using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterOdev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnTank_Click(object sender, EventArgs e)
        {
            DusmanTank Tank = new DusmanTank();
            Oyun Oyun1 = new Oyun();
            MessageBox.Show(Oyun1.Oyna(Tank));
        }

        private void btnRobot_Click(object sender, EventArgs e)
        {
            DusmanRobotu Robot = new DusmanRobotu();
            Adapter Adaptor = new Adapter(Robot);
            Oyun Oyun2 = new Oyun();
            MessageBox.Show(Oyun2.Oyna(Adaptor));
        
        }
    }
}
