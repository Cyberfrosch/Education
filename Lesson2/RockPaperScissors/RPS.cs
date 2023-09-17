using Microsoft.VisualBasic.Devices;
using RockPaperScissors.Properties;
using System.Windows.Forms;
using static RockPaperScissors.RPS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace RockPaperScissors
{
    public partial class RPS : Form
    {
        public Figure.FigureList figureList;

        public Figure? userFigure;
        public Figure? compFigure;

        public int userScore;
        public int compScore;

        public int gameCount;

        private static readonly string _imagePath = GetParentDirectory(Environment.CurrentDirectory, 3) + "\\Resources";
        private static readonly string[] _imageFiles = Directory.GetFiles(_imagePath, "*.ico");

        public RPS()
        {
            InitializeComponent();

            // Set default values
            foreach (var image in _imageFiles)
            {
                ImLsFigure.Images.Add(Image.FromFile(image));
            }

            figureList = new Figure.FigureList(ImLsFigure);

            BtRock.Text = figureList[0].ToString();
            BtRock.Image = figureList[0].FigureImage;

            BtPaper.Text = figureList[1].ToString();
            BtPaper.Image = figureList[1].FigureImage;

            BtScissors.Text = figureList[2].ToString();
            BtScissors.Image = figureList[2].FigureImage;

            userFigure = null;
            compFigure = null;

            userScore = 0;
            compScore = 0;
        }

        private void BtRock_Click(object sender, EventArgs e)
        {
            userFigure = figureList[0];

            BtPlay.Enabled = true;
            BtRock.FlatStyle = FlatStyle.Flat;

            BtPaper.FlatStyle = FlatStyle.Standard;
            BtScissors.FlatStyle = FlatStyle.Standard;
        }

        private void BtPaper_Click(object sender, EventArgs e)
        {
            userFigure = figureList[1];

            BtPlay.Enabled = true;
            BtPaper.FlatStyle = FlatStyle.Flat;

            BtRock.FlatStyle = FlatStyle.Standard;
            BtScissors.FlatStyle = FlatStyle.Standard;
        }

        private void BtScissors_Click(object sender, EventArgs e)
        {
            userFigure = figureList[2];

            BtPlay.Enabled = true;
            BtScissors.FlatStyle = FlatStyle.Flat;

            BtRock.FlatStyle = FlatStyle.Standard;
            BtPaper.FlatStyle = FlatStyle.Standard;
        }

        private async void BtPlay_Click(object sender, EventArgs e)
        {
            PnGameMenu.Enabled = false;
            PnGameField.Enabled = true;

            Random random = new Random();

            compFigure = figureList[random.Next(figureList.Count)];

            //"Loading" game
            await Task.Run(() =>
            {
                for (int i = 0; i < 20; ++i)
                {
                    Invoke(new Action(() =>
                    {
                        if (i != 19)
                        {
                            PbUserFigure.Image = ImLsFigure.Images[random.Next(ImLsFigure.Images.Count)];
                            PbCompFigure.Image = ImLsFigure.Images[random.Next(ImLsFigure.Images.Count)];
                        }
                        else
                        {
                            LbUserFigure.Text = userFigure.ToString();
                            PbUserFigure.Image = userFigure.FigureImage;

                            LbCompFigure.Text = compFigure.ToString();
                            PbCompFigure.Image = compFigure.FigureImage;
                        }
                    }));
                    Thread.Sleep(100);
                }
            });

            if (userFigure > compFigure)
            {
                MessageBox.Show("You've won!");
                userScore++;
            }
            else if (userFigure < compFigure)
            {
                MessageBox.Show("You've lost...");
                compScore++;
            }
            else
            {
                MessageBox.Show("Draw.");
            }

            gameCount++;

            LbUserScore.Text = $"Your score: {userScore}";
            LbCompScore.Text = $"Comp score: {compScore}";

            LbGameNumber.Text = $"Game: {gameCount}";

            PnGameField.Enabled = false;
            PnGameMenu.Enabled = true;
        }

        private void BtReset_Click(object sender, EventArgs e)
        {
            BtRock.FlatStyle = FlatStyle.Standard;
            BtPaper.FlatStyle = FlatStyle.Standard;
            BtScissors.FlatStyle = FlatStyle.Standard;

            LbUserFigure.Text = string.Empty;
            PbUserFigure.Image = null;

            LbCompFigure.Text = string.Empty;
            PbCompFigure.Image = null;

            userFigure = null;
            userScore = 0;

            compFigure = null;
            compScore = 0;

            gameCount = 0;

            LbUserScore.Text = $"Your score: {userScore}";
            LbCompScore.Text = $"Comp score: {compScore}";

            LbGameNumber.Text = $"Game: {gameCount}";

            BtPlay.Enabled = false;
        }

        public static string GetParentDirectory(string path, int levels)
        {
            string? parent;

            for (int i = 0; i < levels; ++i)
            {
                parent = Path.GetDirectoryName(path);

                if (parent == null)
                    break;

                path = parent;
            }

            return path;
        }
    }

    public enum FigureTypes { Rock, Paper, Scissors };

    public class Figure
    {
        private FigureTypes FigureType { get; set; }
        public Image? FigureImage { get; set; }

        public Figure(FigureTypes figureType)
        {
            FigureType = figureType;
            FigureImage = null;
        }

        public Figure(FigureTypes figureType, Image? figureImage)
        {
            FigureType = figureType;
            FigureImage = figureImage;
        }

        private int CompareTo(Figure f)
        {
            int result = 0;

            if (FigureType == f.FigureType)
            {
                result = 0;
            }
            else
            {
                switch (FigureType)
                {
                    case FigureTypes.Rock:
                        result = (f.FigureType == FigureTypes.Scissors) ? 1 : -1;
                        break;
                    case FigureTypes.Paper:
                        result = (f.FigureType == FigureTypes.Rock) ? 1 : -1;
                        break;
                    case FigureTypes.Scissors:
                        result = (f.FigureType == FigureTypes.Paper) ? 1 : -1;
                        break;
                }
            }

            return result;
        }

        public override string ToString()
        {
            string result = string.Empty;

            switch (FigureType)
            {
                case FigureTypes.Rock:
                    result = "Rock";
                    break;
                case FigureTypes.Paper:
                    result = "Paper";
                    break;
                case FigureTypes.Scissors:
                    result = "Scissors";
                    break;
            }

            return result;
        }

        public static bool operator >(Figure leftFigure, Figure rightFigure)
        {
            return leftFigure.CompareTo(rightFigure) > 0;
        }

        public static bool operator <(Figure leftFigure, Figure rightFigure)
        {
            return leftFigure.CompareTo(rightFigure) < 0;
        }

        public class FigureList : List<Figure>
        {
            public FigureList()
            {
                Add(new Figure(FigureTypes.Rock));
                Add(new Figure(FigureTypes.Paper));
                Add(new Figure(FigureTypes.Scissors));
            }

            public FigureList(ImageList imageList)
            {
                Add(new Figure(FigureTypes.Rock, imageList.Images[0]));
                Add(new Figure(FigureTypes.Paper, imageList.Images[1]));
                Add(new Figure(FigureTypes.Scissors, imageList.Images[2]));
            }
        }
    };
}