using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Collections;

namespace PaintXs_mini
{
    public partial class PaintXs : Form
    {
        public PaintXs()
        {
            InitializeComponent();
            ///подключение графики и размер
            this.Width = 1000;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            pic.Image = bm;         
        }
        
        ///глобальные переменные
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            p.Width = size_scroll.Value;
            erase.Width = size_scroll.Value;
        }

        bool isDown; 
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

            isDown = true;
        }
        ///рисование
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;
            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if (index == 8)
            {
                PointF point1 = new PointF(x, y);
                PointF point2 = new PointF(cX, cY);
                PointF point3 = new PointF(sX, sY);
                PointF[] curvePoints = { point1, point2, point3 };
                g.DrawPolygon(p, curvePoints);
            }

            isDown = false;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
                if (index == 8)
                {
                    PointF point1 = new PointF(x, y);
                    PointF point2 = new PointF(cX, cY);
                    PointF point3 = new PointF(sX, sY);
                    PointF[] curvePoints = { point1, point2, point3 };
                    g.DrawPolygon(p, curvePoints);
                }
            }        
        }    

        private void bth_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void bth_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void bth_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
            this.Cursor = Cursors.Hand;
        }

        private void bth_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
            this.Cursor = Cursors.Hand;
        }

        private void bth_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
            this.Cursor = Cursors.Cross;
        }

        private void bth_rect_Click(object sender, EventArgs e)
        {
            index = 4;
            this.Cursor = Cursors.Cross;
        }

        private void bth_line_Click(object sender, EventArgs e)
        {
            index = 5;
            this.Cursor = Cursors.Cross;
        }
      
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {                   
                for (int i = 0; i < 49; i++)
                {
                    g.DrawLine(p, new Point((pic.Width / 50 * (i + 1)), 0), new Point((pic.Width / 50 * (i + 1)), pic.Height));
                    g.DrawLine(p, new Point(0, (pic.Height / 50 * (i + 1))), new Point(pic.Width, (pic.Height / 50 * (i + 1))));
                }

                int X = pic.Width / 50;
                int Y = pic.Height / 50;

                for (int i = 1; i < 50; i++)
                {
                    if (X <= (X * i))
                    {
                        for (int i1 = 1; i1 < 50; i1++)
                        {
                            if (Y <= (Y * i1))
                            {
                                Graphics a = Graphics.FromImage(pic.Image);
                                a.FillRectangle(Brushes.Black, (X * (i - 1)), (Y * (i1 - 1)), X, Y);
                                this.Refresh();
                                break;
                            }
                        }
                        break;
                    }
                }                                       
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                pic.BackgroundImage = Image.FromFile(ofd.FileName);               
            }             
        }
       
        private void создатьПараболуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                pic.CreateGraphics();
                int y = Convert.ToInt32(toolStripTextBox1.Text);
                Point[] points = new Point[y];
                for (int i = 0; i < points.Length; i++)
                {
                    points[i] = new Point(i, (int)(Math.Sin((double)i / 10) * 100 + 200));
                }
                g.DrawLines(p, points);
            }
            catch
            {
                MessageBox.Show("Заданы некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
        }

        private void bth_fill_Click(object sender, EventArgs e)
        { 
            index = 7;
            this.Cursor = Cursors.Hand;
        }

        private void bth_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Рисунок сохранен", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bth_text_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown)
            {
                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void снеговикToolStripMenuItem_Click(object sender, EventArgs e)
        {                     
            g.FillEllipse(Brushes.LightSkyBlue, 291, 170, 60, 60);
            g.FillEllipse(Brushes.LightSkyBlue, 273, 220, 100, 100);
            g.FillEllipse(Brushes.LightSkyBlue, 250, 300, 150, 150);
            g.FillRectangle(Brushes.Brown, 296, 125, 50, 50);
            g.FillEllipse(Brushes.Black, 307, 183, 5, 5);
            g.FillEllipse(Brushes.Black, 326, 183, 5, 5);
            g.DrawLine(new Pen(Color.Brown, 5), 170, 240, 290, 250);
            g.DrawLine(new Pen(Color.Brown, 5), 350, 250, 460, 240);
           
            Pen orangePen = new Pen(Color.Orange, 3);
            PointF point1 = new PointF(320, 190);
            PointF point2 = new PointF(320, 200);
            PointF point3 = new PointF(280, 200);
            PointF[] curvePoints = { point1, point2, point3 };
            g.FillPolygon(Brushes.Orange, curvePoints);
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            index = 8;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void параболаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
