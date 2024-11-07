using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace CalculFleche
{
    public partial class Form3 : Form
    {
        System.Media.SoundPlayer player;

        private bool visibility = false;
        private int numImage = 0;
        private int end = 0;
        private int sens = 0;
        public Form3()
        {
            InitializeComponent();
            this.Opacity = 0;
            player = new System.Media.SoundPlayer();
        }

        private void timerChangePicture_Tick(object sender, EventArgs e)
        {
            if (pictureBoxFlamme.Image != null)
            {
                pictureBoxFlamme.Image.Dispose();
            }

            pictureBoxFlamme.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme1.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme2.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme3.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme4.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme5.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme6.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme7.Image = imageListFlamme.Images[numImage];
            pictureBoxFlamme8.Image = imageListFlamme.Images[numImage];

            if (numImage == imageListFlamme.Images.Count - 1)
            {
                numImage = 0;
            }

            else
            {
                numImage++;
            }

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
            }

            pictureBox1.Image = imageList1.Images[sens];

            if (sens == imageList1.Images.Count - 1)
            {
                sens = 0;
            }

            else
            {
                sens++;
            }
        }

        private void timerEnd_Tick(object sender, EventArgs e)
        {
            if(end < 57)
            {
                if(end % 4 == 0)
                {
                    this.BackColor = Color.Fuchsia;
                }

                else if(end % 4 == 1)
                {
                    this.BackColor = Color.Lime;
                }

                else if (end % 4 == 2)
                {
                    this.BackColor = Color.Yellow;
                }

                else
                {
                    this.BackColor = Color.Tomato;
                }

                end++;
            }

            else
            {
                this.Close();
            }
        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
            if (visibility == false)
            {
                player.SoundLocation = @"..\..\Ressources\WTF\rusted-root-send-me-on-my-way.wav";
                player.Play();
                Thread.Sleep(8900);
                this.Opacity = 0.5;
                visibility = !visibility;
            }

            else
            {
                visibility = !visibility;
                this.Opacity = 0;
                end = 0;
            }
                
        }
    }
}
