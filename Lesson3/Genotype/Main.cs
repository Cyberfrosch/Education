using System.Drawing;

namespace Genotype
{
    public enum Sexes { Female, Male };
    public enum Shapes { Circle, Triangle };
    public enum Allele { Recessive, Dominant };

    public partial class Main : Form
    {
        private Settings settings;

        public Animal father;
        public Animal mother;

        public int OffspringNumber { get; set; }

        public Main()
        {
            InitializeComponent();

            // Default params of parents
            father = new Animal("Balu", Sexes.Male);
            mother = new Animal("Bagira", Sexes.Female);
            OffspringNumber = 50;

            settings = new Settings(this);
            settings.SettingsChanged += SettingsForm_SettingsChanged;

            SetLabelValues();
        }

        private List<Animal> GenerateOffspring(//mother //father )
            )
        {
            List<Animal> offspring = new List<Animal>();

            Random random = new();
            const int SexSize = 2;

            for (int i = 1; i <= OffspringNumber; ++i)
            {
                Animal animal = new("Pepe", Utils.EnumGetRandomValue<Sexes>(SexSize));
                offspring.Add(animal);
            }

            return offspring;
        }

        private void DrawOffspring(Graphics g)
        {

        }

        private void BtSettings_Click(object sender, EventArgs e)
        {
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

        private void SettingsForm_SettingsChanged(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenerateOffspring();

            DrawOffspring();
        }
    }

    public class Gen
    {
        // enum Allele можно заменить на bool, но стоит ли? менее гибко и читаемо
        public Allele allele1;
        public Allele allele2;

        // в C# оказывается нет макросов и глобальных переменных (всё внутри класса), т.ч. ничего лучше не придумал:
        public static readonly int alleleSize = Utils.EnumGetSize<Allele>();

        private string _name;

        bool Dominant
        {
            get { return allele1 == Allele.Dominant || allele2 == Allele.Dominant; }
        }

        public Gen(Allele allele1, Allele allele2, string name)
        {
            this.allele1 = allele1;
            this.allele2 = allele2;
            _name = name;
        }

        public string ToString(Allele allele)
        {
            return allele == Allele.Dominant ? "Dominant" : "Recessive";
        }

        public static Gen operator +(Gen gen1, Gen gen2)
        {
            Random random = new();
            Thread.Sleep(1);

            Allele allele1 = random.Next(2) == 0 ? gen1.allele1 : gen2.allele1;
            Allele allele2 = random.Next(2) == 0 ? gen1.allele2 : gen2.allele2;

            return new Gen(allele1, allele2, gen1._name);
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

    public abstract class Essense
    {
        private string _name;

        public static int SexSize = 2;

        public string Name
        {
            get { return _name; }
            set { _name = (value != string.Empty) ? value : "Barsick"; }
        }
        public Sexes Sex { get; set; }
        public Phenotype EssensePhenotype { get; set; }

        public Essense(string name, Sexes sex)
        {
            _name = name;
            Sex = sex;
            EssensePhenotype = new Phenotype((Sex == Sexes.Male) ? Shapes.Triangle : Shapes.Circle);
        }
    }

    public class Animal : Essense
    {
        public Gen Genotype { get; set; }

        // Случайная генерация аллелей
        public Animal(string name, Sexes sex) : base(name, sex)
        {
            Random random = new();

            // Здесь приводится случайное int значение из диапазона размера enum'a к соответствующему элементу в виде индекса
            Allele allele1 = Utils.EnumGetRandomValue<Allele>(Gen.alleleSize);
            Allele allele2 = Utils.EnumGetRandomValue<Allele>(Gen.alleleSize);

            Genotype = new Gen(allele1, allele2, name);
        }

        public Animal(string name, Sexes sex, Allele allele1) : base(name, sex)
        {
            Genotype = new Gen(allele1, allele1, name);
        }

        // Основной конструктор, остальные сделал для большей гибкости
        public Animal(string name, Sexes sex, Allele allele1, Allele allele2) : base(name, sex)
        {
            Genotype = new Gen(allele1, allele2, name);
        }
    }
}