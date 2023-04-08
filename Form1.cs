using System;
using System.Data.Odbc;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 1400;
            Height = 800;
            b = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(b);
            g.Clear(Color.White);
            pictureBox1.Image = b;
        }
        Bitmap b;
        Graphics g;
        bool PaintMode = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        int operation;
        int x1,y1,x2,y2,x3,y3;
        ColorDialog dialog = new ColorDialog();
        Color dialcolor;
        bool ColorPick =false;

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (PaintMode)
            {
                if (operation == 3)
                {
                    g.DrawEllipse(p, x3, y3, x2, y2);


                }
                if (operation == 4)
                {

                    g.DrawRectangle(p, x3, y3, x2, y2);

                }
                if (operation == 5)
                {
                    g.DrawLine(p, x3, y3, x1, y1);
                }
            }
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {
            operation = 4;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            operation = 5;
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            dialog.ShowDialog();
            dialcolor = dialog.Color;
            pictureBox1.BackColor= dialcolor;   
            p.Color = dialcolor;
            ColorPick = true;
            ColorDisplay.Focus();
        }

        private void ColorDisplay_Paint(object sender, PaintEventArgs e)
        {
            if(ColorPick)
            {
                ColorDisplay.BackColor = dialcolor;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = b;
            operation = 0;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var saving = new SaveFileDialog();
            saving.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if(saving.ShowDialog() == DialogResult.OK) {
                Bitmap sv = b.Clone(new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height), b.PixelFormat);
                sv.Save(saving.FileName);
            }
        }

        private void TextButton_Click(object sender, EventArgs e)
        {
            operation = 6;
           
        }

        private void UploadButton_Click(object sender, EventArgs e)
        {
            var uploading= new OpenFileDialog();
            uploading.Filter = "Images (*.jpg)|*.jpg|(*.*|*.*";
            if(uploading.ShowDialog() == DialogResult.OK) { 
                Bitmap uv = new Bitmap(uploading.FileName);    
                g= Graphics.FromImage(uv);
               // string SelectedFile=uploading.FileName;
                pictureBox1.Image = uv;
    
            }
            pictureBox1.Refresh();  
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            operation = 1;

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PaintMode = true;
            py = e.Location;
            x3 = e.X;
            y3 = e.Y;
            if (operation == 6)
            {
                string text = Microsoft.VisualBasic.Interaction.InputBox("Proszê podaæ tekst", "Tekst", "Twój tekst");
                string textbold = Microsoft.VisualBasic.Interaction.InputBox("Proszê podaæ gruboœæ tekstu", "Gruboœæ", "24");
                int num = Convert.ToInt32(textbold);
                Brush br = new SolidBrush(Color.Black);
                Font f = new Font("Arial", num, FontStyle.Bold);
                g.DrawString(text, f, br, py);
                operation= 0;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PaintMode = false;
            x2 = x1 - x3;
            y2 = y1 - y3;
            if (operation == 3)
            {

                g.DrawEllipse(p, x3, y3, x2, y2);

            }
            if (operation == 4)
            {

                g.DrawRectangle(p, x3, y3, x2, y2);

            }
            if (operation == 5)
            {
                g.DrawLine(p, x3, y3, x1, y1);
            }

        }

        private void EraserButton_Click(object sender, EventArgs e)
        {
            operation = 2;
        }

        private void ElipseButton_Click(object sender, EventArgs e)
        {
            operation = 3;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (PaintMode)
            {
                if (operation == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                    x3=e.X;
                    y3=e.Y; 
                   
                }
                if (operation == 2)
                {
                    Pen w = new Pen(Color.White, 50);    
                    px = e.Location;
                    g.DrawLine(w, px, py);
                    py = px;
                }
               
                pictureBox1.Refresh();

                x1 = e.X;
                y1 = e.Y;
                x2 = e.X - x3;
                y2 = e.Y - y3;
            }
        }
    }
}
  