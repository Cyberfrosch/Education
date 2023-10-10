using System.Drawing;

namespace Genotype
{
    public enum Sexes { Female, Male };
    public enum Shapes { Circle, Triangle };
    public enum Allele { Recessive, Dominant };

    public partial class Main : Form
    {
        private Settings settings;

        public EssenseAttribute1 father;
        public EssenseAttribute1 mother;

        List<EssenseAttribute1> offspring;

        public int OffspringNumber { get; set; }

        public Main()
        {
            InitializeComponent();

            // Default params of parents
            mother = new EssenseAttribute1("Bagira", Sexes.Female);
            father = new EssenseAttribute1("Balu", Sexes.Male);
            OffspringNumber = 50;

            SetLabelValues();
        }

        private void SettingsForm_SettingsChanged(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void BtGenerate_Click(object sender, EventArgs e)
        {
            offspring = father.Breed(mother, OffspringNumber);

            foreach (var child in offspring)
            {
                child.Draw(pictureBox1, new Point(4, 4), 48);
            }

            //father.Draw(pictureBox1, new Point(4, 4), 48);
        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new Settings(this);
                settings.SettingsChanged += SettingsForm_SettingsChanged;
            }

            settings.Show();
        }

        private void SetLabelValues()
        {
            LbMotherName.Text = $"Name: {mother.Name}";
            LbMotherGen.Text = "Genotype: ";
            LbMotherGen.Text += $"A1: {mother.Genotype.ToString(mother.Genotype.allele1)}; ";
            LbMotherGen.Text += $"A2: {mother.Genotype.ToString(mother.Genotype.allele2)}";

            LbFatherName.Text = $"Name: {father.Name}";
            LbFatherGen.Text = "Genotype: ";
            LbFatherGen.Text += $"A1: {father.Genotype.ToString(father.Genotype.allele1)}; ";
            LbFatherGen.Text += $"A2: {father.Genotype.ToString(father.Genotype.allele2)}";
        }
    }

    public class Gene
    {
        // enum Allele можно заменить на bool, но стоит ли? менее гибко и читаемо
        public Allele allele1;
        public Allele allele2;

        // в C# оказывается нет макросов и глобальных переменных (всё внутри класса), т.ч. ничего лучше не придумал:
        public static readonly int alleleSize = Utils.EnumGetSize<Allele>();

        public string name;

        public bool Dominant
        {
            get { return allele1 == Allele.Dominant || allele2 == Allele.Dominant; }
        }

        public Gene(Allele allele1, Allele allele2, string name)
        {
            this.allele1 = allele1;
            this.allele2 = allele2;
            this.name = name;
        }

        public string ToString(Allele allele)
        {
            return allele == Allele.Dominant ? "Dominant" : "Recessive";
        }

        public static Gene operator +(Gene gen1, Gene gen2)
        {
            Random random = new();
            Thread.Sleep(1);

            Allele allele1 = random.Next(alleleSize) == 0 ? gen1.allele1 : gen2.allele1;
            Allele allele2 = random.Next(alleleSize) == 0 ? gen1.allele2 : gen2.allele2;

            return new Gene(allele1, allele2, "Pepe");
        }
    }

    public class Phenotype
    {
        public Shapes Shape { get; set; }
        public Color LineColor { get; set; }
        public Color FillColor { get; set; }
        public float LineWidth { get; set; }

        public Phenotype()
        {
            Shape = Shapes.Circle;
            LineColor = Color.Black;
            FillColor = Color.Empty;
            LineWidth = 1;
        }

        public Phenotype(Shapes shape) : this()
        {
            Shape = shape;
        }

        public Phenotype(Shapes shape, Color lineColor) : this(shape)
        {
            LineColor = lineColor;
        }

        public Phenotype(Shapes shape, Color lineColor, Color fillColor) : this(shape, lineColor)
        {
            FillColor = fillColor;
        }

        public Phenotype(Shapes shape, Color lineColor, Color fillColor, float lineWidth) : this(shape, lineColor, fillColor)
        {
            LineWidth = lineWidth;
        }

        public void Draw(Graphics graphics, Point point, int size)
        {
            Pen pen = new(LineColor, LineWidth);
            Brush brush = new SolidBrush(FillColor);

            Rectangle rectangle = new(point, new Size(size, size));

            switch (Shape)
            {
                case Shapes.Circle:
                    graphics.FillEllipse(brush, rectangle);
                    graphics.DrawEllipse(pen, rectangle);
                    break;
                case Shapes.Triangle:
                    graphics.FillTriangle(brush, rectangle);
                    graphics.DrawTriangle(pen, rectangle);
                    break;
            }
        }
    }

    public abstract class Essence
    {
        private string _name;

        public static int sexSize = 2;

        public string Name
        {
            get { return _name; }
            set { _name = (value != string.Empty) ? value : "Barsick"; }
        }
        public Sexes Sex { get; set; }
        public Phenotype EssensePhenotype { get; set; }

        public Essence(string name, Sexes sex)
        {
            Name = name;
            Sex = sex;
            EssensePhenotype = new Phenotype((Sex == Sexes.Male) ? Shapes.Triangle : Shapes.Circle);
        }

        protected virtual Essence Child(Essence partner, string name, Sexes sex)
        {
            return null;
        }

        public List<Essence> Breed(Essence partner, int count)
        {
            List<Essence> children = new List<Essence>();

            for (int i = 1; i <= count; ++i)
            {
                Essence child = Child(partner, "Child" + i.ToString(), Utils.EnumGetRandomValue<Sexes>(sexSize));
                children.Add(child);
            }

            return children;
        }

        public void Draw(Control control, Point point, int size)
        {
            Graphics graphics = control.CreateGraphics();

            EssensePhenotype.Draw(graphics, point, size);
        }
    }

    public class EssenseAttribute1 : Essence
    {
        public Gene Genotype { get; set; }

        public EssenseAttribute1(string name, Sexes sex) : base(name, sex)
        {
            Genotype = new(Utils.EnumGetRandomValue<Allele>(), Utils.EnumGetRandomValue<Allele>(), name);

            EssensePhenotype.LineWidth = Genotype.Dominant ? 4 : 1;
        }

        public EssenseAttribute1(string name, Sexes sex, Gene gene1) : base(name, sex)
        {
            Genotype = gene1;

            EssensePhenotype.LineWidth = Genotype.Dominant ? 4 : 1;
        }

        protected virtual Essence Child(Essence partner, string name, Sexes sex)
        {
            Gene childGen = Genotype + (partner as EssenseAttribute1).Genotype;
            Essence child = new EssenseAttribute1(name, sex, childGen);

            return child;
        }
    }

    public static class Extensions
    {
        public static void FillTriangle(this Graphics graphics, Brush brush, Rectangle rectangle)
        {
            Point[] points = new Point[3];

            points[0] = new Point(rectangle.Left, rectangle.Top);
            points[1] = new Point(rectangle.Right, rectangle.Top);
            points[2] = new Point(rectangle.Left + rectangle.Width / 2, rectangle.Bottom);

            graphics.FillPolygon(brush, points);
        }

        public static void DrawTriangle(this Graphics graphics, Pen pen, Rectangle rectangle)
        {
            Point[] points = new Point[3];

            points[0] = new Point(rectangle.Left, rectangle.Top);
            points[1] = new Point(rectangle.Right, rectangle.Top);
            points[2] = new Point(rectangle.Left + rectangle.Width / 2, rectangle.Bottom);

            graphics.DrawPolygon(pen, points);
        }
    }
}