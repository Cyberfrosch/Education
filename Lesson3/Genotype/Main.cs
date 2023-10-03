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

        const int sexSize = 2;

        List<Animal> offspring;
        public int OffspringNumber { get; set; }

        public Main()
        {
            InitializeComponent();

            // Default params of parents
            mother = new Animal("Bagira", Sexes.Female);
            father = new Animal("Balu", Sexes.Male);
            OffspringNumber = 50;

            SetLabelValues();
        }

        private void SettingsForm_SettingsChanged(object sender, EventArgs e)
        {
            SetLabelValues();
        }

        private void BtGenerate_Click(object sender, EventArgs e)
        {
            GenerateOffspring(mother, father);

            pictureBox1.Image = null;
            DrawOffspring();
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

        private List<Animal> GenerateOffspring(Animal mother, Animal father)
        {
            offspring = new List<Animal>();

            for (int i = 1; i <= OffspringNumber; ++i)
            {
                Gene childGen = mother.Genotype + father.Genotype;
                Animal child = new(childGen.name, Utils.EnumGetRandomValue<Sexes>(sexSize), childGen.allele1, childGen.allele2);
                offspring.Add(child);
            }

            return offspring;
        }

        private void DrawOffspring()
        {
            pictureBox1.Controls.Clear();

            int x = 20;
            int y = 20;

            foreach (Animal child in offspring)
            {
                child.EssensePhenotype.Draw(pictureBox1.CreateGraphics(), new Point(x, y), 30);

                Label nameLabel = new();
                nameLabel.Text = child.Name;
                nameLabel.Location = new Point(x, y + 35);
                nameLabel.AutoSize = true;

                pictureBox1.Controls.Add(nameLabel);

                // Обновляем координаты для следующего потомка
                x += 60;
                if (x > pictureBox1.Width - 40)
                {
                    x = 20;
                    y += 70;
                }
            }
        }

        //private Color GetColorForGenotype(Gene genotype)
        //{
        //    return genotype.Dominant ? Color.Red : Color.Blue;
        //}

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
            Name = name;
            Sex = sex;
            EssensePhenotype = new Phenotype((Sex == Sexes.Male) ? Shapes.Triangle : Shapes.Circle);
        }
    }

    public class Animal : Essense
    {
        public Gene Genotype { get; set; }

        // Случайная генерация аллелей
        public Animal(string name, Sexes sex) : base(name, sex)
        {
            Random random = new();

            // Здесь приводится случайное int значение из диапазона размера enum'a к соответствующему элементу в виде индекса
            Allele allele1 = Utils.EnumGetRandomValue<Allele>(Gene.alleleSize);
            Allele allele2 = Utils.EnumGetRandomValue<Allele>(Gene.alleleSize);

            Genotype = new Gene(allele1, allele2, name);
        }

        public Animal(string name, Sexes sex, Allele allele1) : base(name, sex)
        {
            Genotype = new Gene(allele1, allele1, name);
        }

        // Основной конструктор, остальные сделал для большей гибкости
        public Animal(string name, Sexes sex, Allele allele1, Allele allele2) : base(name, sex)
        {
            Genotype = new Gene(allele1, allele2, name);
        }
    }
}