using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Windows.Shapes;
using System.Drawing;

namespace e2
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        public void nombre()
        {
            cherry.Visible = false;
            tile.Visible = false;
            picture_pacman.Visible = false;
            Rosado.Visible = false;
            Rojo.Visible = false;
        }
        public void iniciar()
        {
            cherry.Visible = true;
            tile.Visible = true;
            picture_pacman.Visible = true;
            Rosado.Visible = true;
            Rojo.Visible = true;

        }
        public enum Flechas : int
        {
            Up = 1,
            Down = 2,
            Left = 3,
            Right = 4
        }
        Flechas key;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                key = Flechas.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                key = Flechas.Down;
            }
            else if (e.KeyCode == Keys.Left)
            {
                key = Flechas.Left;
            }
            else if (e.KeyCode == Keys.Right)
            {
                key = Flechas.Right;
            }

        }
        public void end()
        {
            Rosado.Location = new Point(-1, -1);
            Rojo.Location = new Point(-1, -1);

            MessageBox.Show("TU PUNTAJE FUE DE: " ,puntaje.ToString());
            timer_aparecer1.Stop();
            timer_desaparecer.Stop();
            timer_pacman.Stop();

        }
        private void timer_pacman_Tick(object sender, EventArgs e)
        {
            if (cherry.Bounds.IntersectsWith(picture_pacman.Bounds))
            {
                puntaje = puntaje + 10;
                cherry.Hide();
                cherry.Location = new Point(0, 0);
                label_puntaje.Text = " " + puntaje;
            }
            if (tile.Bounds.IntersectsWith(picture_pacman.Bounds))
            {
                tile.Location = new Point(0, 0);

                puntaje = puntaje + 15;
                tile.Hide();
                label_puntaje.Text = " " + puntaje;

            }
            if (picture_pacman.Bounds.IntersectsWith(Rosado.Bounds))
            {
                end();
            }
            if (picture_pacman.Bounds.IntersectsWith(Rojo.Bounds))
            {
                end();
                 
            }
            switch (key)
            {
                case Flechas.Up:
                    if (picture_pacman.Location.Y > -picture_pacman.Height)
                    {
                        picture_pacman.Location = new Point(picture_pacman.Location.X, picture_pacman.Location.Y - 10);
                        //picture_pacman.Image = Image.FromFile(@"\sprites\pacman-up.png");

                    }
                    else
                    {
                        picture_pacman.Location = new Point(picture_pacman.Location.X, 0);
                    }
                    break;
                case Flechas.Down:
                    if (picture_pacman.Location.Y < this.Height - 150)
                    {
                        picture_pacman.Location = new Point(picture_pacman.Location.X, picture_pacman.Location.Y + 10);
                        //picture_pacman.Image = Image.FromFile("pacman-down.png");

                    }
                    else
                    {
                        picture_pacman.Location = new Point(picture_pacman.Location.X, this.Height);
                    }
                    break;
                case Flechas.Left:
                    if (picture_pacman.Location.X > -picture_pacman.Width)
                    {
                        picture_pacman.Location = new Point(picture_pacman.Location.X - 10, picture_pacman.Location.Y);
                        //picture_pacman.Image = Image.FromFile("pacman-down.png");
                    }
                    else
                    {
                        picture_pacman.Location = new Point(0, picture_pacman.Location.Y);
                    }
                    break;
                case Flechas.Right:
                    if (picture_pacman.Location.X < this.Width)
                    {
                        picture_pacman.Location = new Point(picture_pacman.Location.X + 10, picture_pacman.Location.Y);
                        //picture_pacman.Image = Image.FromFile("pacman-down.png");
                    }
                    else
                    {
                        picture_pacman.Location = new Point(picture_pacman.Location.X, picture_pacman.Location.Y);
                    }
                    break;
            }
        }

        private void timer_rosado_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int rand = random.Next(0, 3);
            if(rand == 1)
            {
                Rosado.Location = new Point(Rosado.Location.X, Rosado.Location.Y - 7 );
            }
            if (rand == 2)
            {
                Rosado.Location = new Point(Rosado.Location.X, Rosado.Location.Y + 7);
            }
            else if (rand == 0)
            {
                Rosado.Location = new Point(Rosado.Location.X - 7, Rosado.Location.Y);
            }
            else if (rand == 3)
            {
                Rosado.Location = new Point(Rosado.Location.X + 7, Rosado.Location.Y);
            }
        }

        private void timer_rojo_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int rand = random.Next(0, 3);
            if (rand == 1)
            {
                Rojo.Location = new Point(Rojo.Location.X, Rojo.Location.Y - 7);
            }
            if (rand == 2)
            {
                Rojo.Location = new Point(Rojo.Location.X, Rojo.Location.Y + 7);
            }
            else if (rand == 0)
            {
                Rojo.Location = new Point(Rojo.Location.X - 7, Rojo.Location.Y);
            }
            else if (rand == 3)
            {
                Rojo.Location = new Point(Rojo.Location.X + 7, Rojo.Location.Y);
            }
        }
        //723; 789
        private void timer_aparecer_Tick(object sender, EventArgs e)
        {
            cherry.Show();
            tile.Show();
            Random random = new Random();
            int _y1 = random.Next(0, 789);
            int _x1 = random.Next(0, 723);
            int _y2 = random.Next(0, 789);
            int _x2 = random.Next(0, 723);
            cherry.Location = new Point(_x1, _y1);
            tile.Location = new Point(_x2, _y2);
            cherry.Visible = false;
            tile.Visible = false;
            timer_aparecer1.Interval += (Convert.ToInt32(timer_aparecer1.Interval) + 10000); 
        }
        public int puntaje = 0;

        private void timer_desaparecer_Tick(object sender, EventArgs e)
        {

            cherry.Visible = true;
            tile.Visible = true;

            timer_desaparecer.Interval += Convert.ToInt32(timer_aparecer1.Interval) + 10000;

            if (cherry.Bounds.IntersectsWith(picture_pacman.Bounds))  
            {
                puntaje = puntaje + 10;

                cherry.Visible = false;
                label_puntaje.Text = " " + puntaje;
            }
            if(tile.Bounds.IntersectsWith(picture_pacman.Bounds))
            {
                puntaje = puntaje + 15;
                tile.Visible = false;
                label_puntaje.Text = " " + puntaje;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
