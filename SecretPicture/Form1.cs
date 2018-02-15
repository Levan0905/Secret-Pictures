using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretPicture
{
    public partial class Form1 : Form
    {
        int secret_nr = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonshowPicture1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.picture1;
        }

        private void buttonshowpicture4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.picture4;
        }

        private void buttonshowpicture3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.picture2;
        }

        private void buttonshowpicture3_Click_1(object sender, EventArgs e)
        {
            if (secret_nr == 2)
                this.BackgroundImage = Properties.Resources.secret;
            else

                this.BackgroundImage = Properties.Resources.picture3;
            secret_nr = 0;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                secret_nr = 1;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (secret_nr == 1)
                if (e.X < buttonshowPicture1.Location.X &&
                    e.Y < buttonshowPicture1.Location.Y)
                {
                    secret_nr = 2;
                }

        }
    }
}

