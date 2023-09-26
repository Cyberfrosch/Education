using Microsoft.VisualBasic.Devices;
using RockPaperScissors.Properties;
using System;
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

        public RPS()
        {
            InitializeComponent();

            // Set default values
            figureList = new Figure.FigureList(ImLsFigure);

            BtRock.Text = figureList[0].ToString();
            BtRock.Image = new Bitmap(figureList[0].FigureImage, new Size(32, 32));

            BtPaper.Text = figureList[1].ToString();
            BtPaper.Image = new Bitmap(figureList[1].FigureImage, new Size(32, 32));

            BtScissors.Text = figureList[2].ToString();
            BtScissors.Image = new Bitmap(figureList[2].FigureImage, new Size(32, 32));

            ResetScore();
        }

        private void BtRock_Click(object sender, EventArgs e)
        {
            SelectFigure(BtRock);
        }

        private void BtPaper_Click(object sender, EventArgs e)
        {
            SelectFigure(BtPaper);
        }

        private void BtScissors_Click(object sender, EventArgs e)
        {
            SelectFigure(BtScissors);
        }

        private async void BtPlay_Click(object sender, EventArgs e)
        {
            LbUserFigure.Text = string.Empty;
            LbCompFigure.Text = string.Empty;

            PnGameMenu.Enabled = false;
            PnGameField.Enabled = true;

            Random random = new Random();

            compFigure = figureList[random.Next(figureList.Count)];

            await LoadingGameField(20, 150);

            LbUserFigure.Text = userFigure.ToString();
            PbUserFigure.Image = userFigure.FigureImage;

            LbCompFigure.Text = compFigure.ToString();
            PbCompFigure.Image = compFigure.FigureImage;

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

            SetScore();

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

            ResetScore();

            BtPlay.Enabled = false;
        }

        public void SetScore()
        {
            LbUserScore.Text = $"Your score: {userScore}";
            LbCompScore.Text = $"Comp score: {compScore}";

            LbGameNumber.Text = $"Game: {gameCount}";
        }

        public void ResetScore()
        {
            userFigure = null;
            userScore = 0;

            compFigure = null;
            compScore = 0;

            gameCount = 0;

            SetScore();
        }

        private void SelectFigure(Button button)
        {
            if (button == BtRock)
            {
                BtPaper.FlatStyle = FlatStyle.Standard;
                BtScissors.FlatStyle = FlatStyle.Standard;
            }
            else if (button == BtPaper)
            {
                BtRock.FlatStyle = FlatStyle.Standard;
                BtScissors.FlatStyle = FlatStyle.Standard;
            }
            else if (button == BtScissors)
            {
                BtRock.FlatStyle = FlatStyle.Standard;
                BtPaper.FlatStyle = FlatStyle.Standard;
            }
            else
            {
                return;
            }

            button.FlatStyle = FlatStyle.Flat;

            int index = Convert.ToInt32(button.Tag);
            userFigure = figureList[index];

            BtPlay.Enabled = true;
        }

        private async Task LoadingGameField(int numIteration, int delay)
        {
            Random random = new Random();

            for (int i = 0; i < numIteration; ++i)
            {
                Invoke(new Action(() =>
                {
                    PbUserFigure.Image = ImLsFigure.Images[random.Next(ImLsFigure.Images.Count)];
                    PbCompFigure.Image = ImLsFigure.Images[random.Next(ImLsFigure.Images.Count)];
                }));

                await Task.Delay(delay);
            }
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