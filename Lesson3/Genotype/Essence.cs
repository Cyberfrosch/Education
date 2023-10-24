using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Faker;
using Utils;

namespace Genotype
{
    public enum Sex { Male, Female };
    public enum Shapes { Circle, Triangle };
    public enum Allele { Dominant, Recessive };

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
    public class Gene
    {
        public Allele allele1;
        public Allele allele2;

        private string _name;

        public bool Dominant
        {
            get { return allele1 == Allele.Dominant || allele2 == Allele.Dominant; }
        }

        public Gene(Allele allele1, Allele allele2, string name)
        {
            this.allele1 = allele1;
            this.allele2 = allele2;
            _name = name;
        }

        public string ToString(Allele allele)
        {
            return allele == Allele.Dominant ? "Dominant" : "Recessive";
        }

        public static Gene operator +(Gene gen1, Gene gen2)
        {
            Random random = new();
            Thread.Sleep(1);

            Allele allele1 = random.Next(2) == 0 ? gen1.allele1 : gen2.allele1;
            Allele allele2 = random.Next(2) == 0 ? gen1.allele2 : gen2.allele2;

            return new Gene(allele1, allele2, gen1._name);
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
            LineColor = Color.Purple;
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

        public static int size = 60;
        public Bitmap EssenceIcon;
        public string Name
        {
            get { return _name; }
            set { _name = (value != string.Empty) ? value : "Barsick"; }
        }
        public Sex sex { get; set; }
        public Phenotype EssencePhenotype { get; set; }

        public Essence(string name, Sex pSex)
        {
            Name = name;
            sex = pSex;
            EssencePhenotype = new Phenotype((sex == Sex.Male) ? Shapes.Triangle : Shapes.Circle);
        }

        public void Draw(Control control, Point point, int size)
        {
            Graphics graphic = control.CreateGraphics();

            Label nameLabel = new();
            nameLabel.Text = Name;
            nameLabel.Location = new Point(point.X, point.Y + (size + (10 * size / 100)));
            nameLabel.AutoSize = true;

            control.Controls.Add(nameLabel);

            EssencePhenotype.Draw(graphic, point, size);

            EssenceIcon = new Bitmap(control.Width, control.Height);

            Graphics bitmapGraphics = Graphics.FromImage(EssenceIcon);
            EssencePhenotype.Draw(bitmapGraphics, new Point(4, 4), size);
        }

        public List<Essence> Breed(Essence partner, int count)
        {
            List<Essence> Children = new List<Essence>();
            Random random = new();
            string name;
            Sex sex;

            for (int i = 0; i < count; i++)
            {
                sex = EnumUtilities.GetRandomValue<Sex>();

                if (sex == Sex.Male)
                {
                    name = Main.maleNamesList[random.Next(Main.maleNamesList.Count)]; 
                }
                else
                {
                    name = Main.femaleNamesList[random.Next(Main.femaleNamesList.Count)];
                }

                Essence child = Child(partner, name, sex);
                Children.Add(child);
            }

            return Children;
        }

        public string ToStringSex()
        {
            return sex == Sex.Male ? "Male" : "Female";
        }

        protected abstract Essence Child(Essence partner, string name, Sex pSex);
    }

    public class Animal : Essence
    {
        public Gene Gene1 { get; set; }

        public Animal(string name, Sex sex) : base(name, sex)
        {
            Gene1 = new Gene(EnumUtilities.GetRandomValue<Allele>(), EnumUtilities.GetRandomValue<Allele>(), name);
            EssencePhenotype.LineWidth = Gene1.Dominant ? 4 : 1;
        }

        public Animal(string name, Sex sex, Gene genotype) : base(name, sex)
        {
            Gene1 = genotype;
            EssencePhenotype.LineWidth = Gene1.Dominant ? 4 : 1;
        }

        protected override Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen = Gene1 + (partner as Animal).Gene1;

            Essence child = new Animal(name, sex, childGen);

            return child;
        }
    }

    public class Animal_secondary : Animal
    {
        public Gene Gene2 { get; set; }

        public Animal_secondary(string name, Sex sex) : base(name, sex)
        {
            Gene2 = new Gene(EnumUtilities.GetRandomValue<Allele>(), EnumUtilities.GetRandomValue<Allele>(), name);
            EssencePhenotype.FillColor = Gene2.Dominant ? Color.DarkOrchid : Color.Tomato;
        }
        public Animal_secondary(string name, Sex sex, Gene genotype) : base(name, sex, genotype)
        {
            Gene2 = genotype;
            EssencePhenotype.FillColor = Gene2.Dominant ? Color.DarkOrchid : Color.Tomato;
        }

        public Animal_secondary(string name, Sex sex, Gene gene1, Gene gene2) : base(name, sex, gene1)
        {
            Gene2 = gene2;
            EssencePhenotype.FillColor = Gene2.Dominant ? Color.DarkOrchid : Color.Tomato;
        }

        protected override Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen1 = Gene1 + (partner as Animal).Gene1;
            Gene childGen2 = Gene2 + (partner as Animal_secondary).Gene2;

            Essence child = new Animal_secondary(name, sex, childGen1, childGen2);

            return child;
        }
    }

    public class Animal_tertiary : Animal_secondary
    {
        public Gene Gene3 { get; set; }

        public Animal_tertiary(string name, Sex sex) : base(name, sex)
        {
            Gene3 = new Gene(EnumUtilities.GetRandomValue<Allele>(), EnumUtilities.GetRandomValue<Allele>(), name);
            EssencePhenotype.LineColor = Gene3.Dominant ? Color.SpringGreen : Color.Black;
        }

        public Animal_tertiary(string name, Sex sex, Gene genotype) : base(name, sex, genotype)
        {
            Gene3 = genotype;
            EssencePhenotype.LineColor = Gene3.Dominant ? Color.SpringGreen : Color.Black;
        }

        public Animal_tertiary(string name, Sex sex, Gene gene1, Gene gene2, Gene gene3) : base(name, sex, gene1, gene2)
        {
            Gene3 = gene3;
            EssencePhenotype.LineColor = Gene3.Dominant ? Color.SpringGreen : Color.Black;
        }

        protected override Essence Child(Essence partner, string name, Sex sex)
        {
            Gene childGen1 = Gene1 + (partner as Animal).Gene1;
            Gene childGen2 = Gene2 + (partner as Animal_secondary).Gene2;
            Gene childGen3 = Gene3 + (partner as Animal_tertiary).Gene3;

            Essence child = new Animal_tertiary(name, sex, childGen1, childGen2, childGen3);

            return child;
        }
    }
}
