using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MurlocOTK
{
    public partial class MurlocOTK : Form
    {
        public MurlocOTK()
        {
            InitializeComponent();

            nudBluegillDead.Value = 0;
            nudBluegillAlive.Value = 0;
            nudWarleaderDead.Value = 0;
            nudWarleaderAlive.Value = 0;
            nudMurkEyeDead.Value = 0;
            nudMurkEyeAlive.Value = 0;
            labelBluegillAttack.Text = "2(+0)=2";
            labelBluegillLife.Text = "1(+0)=1";
            labelWarleaderAttack.Text = "3(+0)=3";
            labelWarleaderLife.Text = "3(+0)=3";
            labelMurkEyeAttack.Text = "2(+0)=2";
            labelMurkEyeLife.Text = "4(+0)=4";
            labelOneTurnDamage.Text = "원턴 데미지: 0";
        }

        public void Calculate()
        {
            int bluegillAttack = 2, bluegillLife = 1;
            int warleaderAttack = 3, warleaderLife = 3;
            int murkeyeAttack = 2, murkeyeLife = 4;
            int oneTurnDamage = 0;
            int numDead = (int)nudBluegillDead.Value + (int)nudWarleaderDead.Value + (int)nudMurkEyeDead.Value;
            int numAlive = (int)nudBluegillAlive.Value + (int)nudWarleaderAlive.Value + (int)nudMurkEyeAlive.Value;

            if (numDead > 7)
                buttonRecalc.Visible = true;
            else if ((numDead + numAlive) > 7 && numDead > 1 && numAlive < 7)
                buttonRecalc.Visible = true;
            else
                buttonRecalc.Visible = false;
        }

        private void buttonRecalc_Click(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            nudBluegillDead.Value = 0;
            nudBluegillAlive.Value = 0;
            nudWarleaderDead.Value = 0;
            nudWarleaderAlive.Value = 0;
            nudMurkEyeDead.Value = 0;
            nudMurkEyeAlive.Value = 0;
            labelBluegillAttack.Text = "2(+0)=2";
            labelBluegillLife.Text = "1(+0)=1";
            labelWarleaderAttack.Text = "3(+0)=3";
            labelWarleaderLife.Text = "3(+0)=3";
            labelMurkEyeAttack.Text = "2(+0)=2";
            labelMurkEyeLife.Text = "4(+0)=4";
            buttonRecalc.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nudBluegillDead.Value = nudBluegillDead.Value + 1;
            Calculate();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            nudWarleaderDead.Value = nudWarleaderDead.Value + 1;
            Calculate();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            nudMurkEyeDead.Value = nudMurkEyeDead.Value + 1;
            Calculate();
        }

        private void nudBluegillDead_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudBluegillAlive_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudWarleaderDead_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudWarleaderAlive_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudMurkEyeDead_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudMurkEyeAlive_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }
    }
}
