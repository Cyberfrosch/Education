using System.Drawing;
using System.Drawing.Imaging;

namespace SerpinskyTriangle
{
    public partial class SerpinskyTriangle : Form
    {
        private Point[] _vertex;
        private Bitmap _bmp;
        private Point _activePoint;
        private Color _color;
        private int _depth;

        public SerpinskyTriangle()
        {
            InitializeComponent();
            Init();

            // Set default values
            _color = Color.Black;
            _depth = Convert.ToInt32(NmUDDepth.Value);

            PbColor.BackColor = _color;
        }

        private void Init()
        {
            _vertex = new[]
            {
                new Point(4, PbImage.ClientSize.Height - 4),
                new Point(PbImage.ClientSize.Width - 4, PbImage.ClientSize.Height - 4),
                new Point((PbImage.ClientSize.Width - 4) / 2, 4)
            };
            _activePoint = _vertex[0];

            _bmp = new Bitmap(PbImage.ClientSize.Width, PbImage.ClientSize.Height);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            Point vertexPoint = _vertex[random.Next(3)];
            _activePoint = MidPoint(vertexPoint, _activePoint);
            _bmp.SetPixel(_activePoint.X, _activePoint.Y, _color);

            PbImage.Image = _bmp;
        }

        private void BtColor_Click(object sender, EventArgs e)
        {
            if (colorDialogPbImage.ShowDialog() == DialogResult.OK)
            {
                _color = colorDialogPbImage.Color;
                PbColor.BackColor = _color;
            }
        }

        private Point MidPoint(Point point1, Point point2)
        {
            int x = (point1.X + point2.X) / 2;
            int y = (point1.Y + point2.Y) / 2;

            return new Point(x, y);
        }

        private void BtDraw_Click(object sender, EventArgs e)
        {
            ///TODO
            Clear();
            ///

            DrawTriangle(_bmp, _color, _vertex[0], _vertex[1], _vertex[2], _depth);
            PbImage.Image = _bmp;

            BtClear.Enabled = true;
            BtSave.Enabled = true;
            BtSaveAs.Enabled = true;
        }

        private void DrawTriangle(Bitmap bmp, Color color, Point p1, Point p2, Point p3, int level)
        {
            if (level == 0)
            {
                using Graphics g = Graphics.FromImage(bmp);

                Brush brush = new SolidBrush(color);
                Point[] triangle = { p1, p2, p3 };
                g.FillPolygon(brush, triangle);

                timer1.Stop();
            }
            else
            {
                Point left_mid = MidPoint(p1, p2);
                Point right_mid = MidPoint(p1, p3);
                Point bottom_mid = MidPoint(p2, p3);

                DrawTriangle(bmp, color, p1, left_mid, right_mid, level - 1);
                DrawTriangle(bmp, color, left_mid, p2, bottom_mid, level - 1);
                DrawTriangle(bmp, color, right_mid, bottom_mid, p3, level - 1);
            }

            timer1.Start();
        }

        private void NmUDDepth_ValueChanged(object sender, EventArgs e)
        {
            _depth = Convert.ToInt32(NmUDDepth.Value);
        }

        private void BtSaveAs_Click(object sender, EventArgs e)
        {
            using SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = "Bitmap Image (*.bmp)|*.bmp|JPEG Image (*.jpg)|*.jpg|PNG Image (*.png)|*.png|All files|*.*";
            saveFileDialog.Title = "Save as";
            saveFileDialog.FileName = "triangle_image";
            saveFileDialog.ShowDialog();

            switch (saveFileDialog.FilterIndex)
            {
                case 1:
                case 4:
                    _bmp.Save(saveFileDialog.FileName, ImageFormat.Bmp);
                    break;
                case 2:
                    _bmp.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                    break;
                case 3:
                    _bmp.Save(saveFileDialog.FileName, ImageFormat.Png);
                    break;
                default:
                    break;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            string filePath = Environment.CurrentDirectory + "\\triangle_image.bmp";

            _bmp.Save(filePath, ImageFormat.Bmp);
        }

        private void BtClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            using Graphics g = Graphics.FromImage(_bmp);
            g.Clear(SystemColors.Control);

            PbImage.Image = _bmp;

            BtSave.Enabled = false;
            BtSaveAs.Enabled = false;
        }
    }
}