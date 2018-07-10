using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Плеер
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
            this.BackColor = Color.AliceBlue;//цвет фона  
            this.TransparencyKey = this.BackColor;//он же будет заменен на прозрачный цвет

            pictureBox1.Image = Properties.Resources.Cotel;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp;
            sp = new SoundPlayer(Properties.Resources.Zvuk_dlya_video___Volshebnaya_Palochka);
            sp.Play();
        }
    }
}
