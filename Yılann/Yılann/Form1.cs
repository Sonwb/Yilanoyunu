using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yılann
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PictureBox[] yilan_parcalar;
        yilan yilan_olustur = new yilan();
        yilan_yonu ilerleyis = new yilan_yonu(0,-10);

        private PictureBox pb_ekle()
        {
            PictureBox pb = new PictureBox();
            pb.Size = new Size(10, 10);
            pb.BackColor = Color.LightGray;
            pb.Tag = "Yılannn";
            pb.Location = yilan_olustur.yer_al(yilan_parcalar.Length - 1); 
            panel1.Controls.Add(pb);

            return pb;
        }

        private void pb_guncelle()
        {
            for (int i = 0; i < yilan_parcalar.Length; i++)
            {
                yilan_parcalar[i].Location = yilan_olustur.yer_al(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yilan_parcalar = new PictureBox[0];

            for(int i = 0; i < 4; i++)
            {
                Array.Resize(ref yilan_parcalar,yilan_parcalar.Length+1);
                yilan_parcalar[i] = pb_ekle();
            }

            yilan_parcalar[0].BackColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            yilan_olustur.ilerle(ilerleyis);
            pb_guncelle();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode== Keys.Up)
            {
                if(ilerleyis.yYon!=10)
                {
                    ilerleyis = new yilan_yonu(0, -10);
                }
            }
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                if(ilerleyis.xYon!=10)
                {
                    ilerleyis = new yilan_yonu(-10, 0);
                }
            }
            if(e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                if (ilerleyis.yYon!=-10)
                {
                    ilerleyis = new yilan_yonu(0, 10);
                }

            }
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (ilerleyis.xYon!=-10)
                {
                    ilerleyis = new yilan_yonu(10, 0);
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
