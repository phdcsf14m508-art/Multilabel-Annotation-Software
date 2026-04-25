using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilabel_Annotation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int x ;
        public static int y ;
        public static int height ;
        public static int width;

        public static int NumberPlate_x;
        public static int NumberPlate_y;
        public static int NumberPlate_height;
        public static int NumberPlate_width;

        public static string FileName;

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Select image file for annotation";
            //fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            //fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                var imagePath = fdlg.FileName;
                FileName = imagePath;
                pictureBox1.Image = new Bitmap(imagePath);
            }
        }


        public Point RectStartPoint;
        public Rectangle Rect = new Rectangle();
        public Brush selectionBrush = new SolidBrush(Color.FromArgb(128, 72, 145, 220));

        // Start Rectangle
        //
        private void pictureBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Determine the initial rectangle coordinates...
            RectStartPoint = e.Location;
            Invalidate();
        }

        // Draw Rectangle
        //
        private void pictureBox1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            Point tempEndPoint = e.Location;
            Rect.Location = new Point(
                Math.Min(RectStartPoint.X, tempEndPoint.X),
                Math.Min(RectStartPoint.Y, tempEndPoint.Y));
            Rect.Size = new Size(
                Math.Abs(RectStartPoint.X - tempEndPoint.X),
                Math.Abs(RectStartPoint.Y - tempEndPoint.Y));
            pictureBox1.Invalidate();
        }

        // Draw Area
        //
        private void pictureBox1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Draw the rectangle...
            if (pictureBox1.Image != null)
            {
                if (Rect != null && Rect.Width > 0 && Rect.Height > 0)
                {
                    e.Graphics.FillRectangle(selectionBrush, Rect);
                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (Rect.Contains(e.Location))
                {
                    Debug.WriteLine("Right click");
                }
            }

            if(frmSetLabels.FirstPhaseAnnotationDone == false)
            {
                x = Rect.X;
                y = Rect.Y;
                height = Rect.Height;
                width = Rect.Width;
            }
            if (frmSetLabels.FirstPhaseAnnotationDone == true && frmSetLabels.SecondPhaseAnnotationDone == false)
            {
                NumberPlate_x = Rect.X;
                NumberPlate_y = Rect.Y;
                NumberPlate_height = Rect.Height;
                NumberPlate_width = Rect.Width;
            }

            frmSetLabels setlabelForm = new frmSetLabels();
            setlabelForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            x = Rect.X;
            y = Rect.Y;
            height = Rect.Height;
            width = Rect.Width;
            NumberPlate_x = Rect.X;
            NumberPlate_y = Rect.Y;
            NumberPlate_height = Rect.Height;
            NumberPlate_width = Rect.Width;
            frmSetLabels.FirstPhaseAnnotationDone = false;
            frmSetLabels.SecondPhaseAnnotationDone = false;
            FileName = "";
            pictureBox1.Image = null;
        }

        private void btnDataDetails_Click(object sender, EventArgs e)
        {
            ViewDataDetails viewData = new ViewDataDetails();
                viewData.Show();
        }

       








        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Bitmap bitmap1 = Bitmap.FromHicon(SystemIcons.Hand.Handle);
        //    Graphics formGraphics = this.CreateGraphics();
        //    GraphicsUnit units = GraphicsUnit.Point;

        //    RectangleF bmpRectangleF = bitmap1.GetBounds(ref units);
        //    Rectangle bmpRectangle = Rectangle.Round(bmpRectangleF);
        //    formGraphics.DrawRectangle(Pens.Blue, bmpRectangle);
        //    formGraphics.Dispose();
        //}
    }
}
