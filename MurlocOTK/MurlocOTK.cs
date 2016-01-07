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
        int MAX_NUM = 7;

        public MurlocOTK()
        {
            InitializeComponent();

            nudBluegillDead.Value = 0;
            nudBluegillAlive.Value = 0;
            nudWarleaderDead.Value = 0;
            nudWarleaderAlive.Value = 0;
            nudMurkEyeDead.Value = 0;
            nudMurkEyeAlive.Value = 0;
            labelBluegillAttack.Text = "2(0)=2";
            labelBluegillLife.Text = "1(0)=1";
            labelWarleaderAttack.Text = "3(0)=3";
            labelWarleaderLife.Text = "3(0)=3";
            labelMurkEyeAttack.Text = "2(0)=2";
            labelMurkEyeLife.Text = "4(0)=4";
            labelOneTurnDamage.Text = "총 공격력: 0";
        }

        public void Calculate()
        {
            int bluegillAttack = 2, bluegillLife = 1;
            int warleaderAttack = 3, warleaderLife = 3;
            int murkeyeAttack = 2, murkeyeLife = 4;
            int murlocNum = 0;
            int bluegilNum = 0, warleaderNum = 0, murkeyeNum = 0;
            int oneTurnDamage = 0;
            int numDead = (int)nudBluegillDead.Value + (int)nudWarleaderDead.Value + (int)nudMurkEyeDead.Value;
            int numAlive = (int)nudBluegillAlive.Value + (int)nudWarleaderAlive.Value + (int)nudMurkEyeAlive.Value;

            if (numDead > MAX_NUM)
                buttonRecalc.Visible = true;
            else if ((numDead + numAlive) > MAX_NUM && numDead > 1 && numAlive < MAX_NUM)
                buttonRecalc.Visible = true;
            else if (numAlive >= MAX_NUM)
                buttonRecalc.Visible = false;
            else
                buttonRecalc.Visible = false;

            if (numDead > MAX_NUM || ((numDead + numAlive) > MAX_NUM && numDead > 1 && numAlive < MAX_NUM))
            {
                // Pick up murloc randomly
                int pickNum = MAX_NUM - numAlive;
                int bluegillPickNum = 0, warleaderPickNum = 0, murkeyePickNum = 0;
                int pickCount = 0;
                Random rand = new Random();

                while (pickCount < pickNum)
                {
                    int i = rand.Next(3);
                    if (i == 0 && (bluegillPickNum < (int)nudBluegillDead.Value))
                        ++bluegillPickNum;
                    else if (i == 1 && (warleaderPickNum < (int)nudWarleaderDead.Value))
                        ++warleaderPickNum;
                    else if (i == 2 && (murkeyePickNum < (int)nudMurkEyeDead.Value))
                        ++murkeyePickNum;
                    else
                        continue;
                    ++pickCount;
                }

                murlocNum = MAX_NUM;
                bluegilNum = bluegillPickNum + (int)nudBluegillAlive.Value;
                warleaderNum = warleaderPickNum + (int)nudWarleaderAlive.Value;
                murkeyeNum = murkeyePickNum + (int)nudMurkEyeAlive.Value;
            }
            else
            {
                murlocNum = numDead + numAlive;
                bluegilNum = (int)nudBluegillAlive.Value + (int)nudBluegillDead.Value;
                warleaderNum = (int)nudWarleaderAlive.Value + (int)nudWarleaderDead.Value;
                murkeyeNum = (int)nudMurkEyeAlive.Value + (int)nudMurkEyeDead.Value;
            }

            if (bluegilNum > 0)
            {
                bluegillAttack = bluegillAttack + (2 * warleaderNum);
                bluegillLife = bluegillLife + (1 * warleaderNum);
            }
            if (warleaderNum > 0)
            {
                warleaderAttack = warleaderAttack + (2 * (warleaderNum - 1));
                warleaderLife = warleaderLife + (1 * (warleaderNum - 1));
            }
            if (murkeyeNum > 0)
            {
                murkeyeAttack = murkeyeAttack + (2 * warleaderNum) + (murlocNum - 1);
                murkeyeLife = murkeyeLife + (1 * warleaderNum);
            }

            oneTurnDamage
                = bluegillAttack * bluegilNum
                + warleaderAttack * (int)nudWarleaderAlive.Value
                + murkeyeAttack * murkeyeNum;

            labelBluegillAttack.Text = "2(" + (bluegillAttack - 2) + ")=" + bluegillAttack
                + "*" + bluegilNum + "=" + bluegillAttack * bluegilNum;
            labelBluegillLife.Text = "1(" + (bluegillLife - 1) + ")=" + bluegillLife;
            labelWarleaderAttack.Text = "3(" + (warleaderAttack - 3) + ")=" + warleaderAttack
                + "*" + (int)nudWarleaderAlive.Value + "=" + warleaderAttack * (int)nudWarleaderAlive.Value;
            labelWarleaderLife.Text = "3(" + (warleaderLife - 3) + ")=" + warleaderLife;
            labelMurkEyeAttack.Text = "2(" + (murkeyeAttack - 2) + ")=" + murkeyeAttack
                + "*" + murkeyeNum + "=" + murkeyeAttack * murkeyeNum;
            labelMurkEyeLife.Text = "4(" + (murkeyeLife - 4) + ")=" + murkeyeLife;
            labelOneTurnDamage.Text = "총 공격력: " + oneTurnDamage
                + " (" + bluegillAttack * bluegilNum + "+" 
                + warleaderAttack * (int)nudWarleaderAlive.Value + "+"
                + murkeyeAttack * murkeyeNum + ")";
        }

        private void buttonRecalc_Click(object sender, EventArgs e)
        {
            Calculate();
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

        private void pictureBoxBluegill_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudBluegillDead.Value = nudBluegillDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudBluegillDead.Value > 0)
                nudBluegillDead.Value = nudBluegillDead.Value - 1;
            Calculate();
        }

        private void pictureBoxWarleader_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudWarleaderDead.Value = nudWarleaderDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudWarleaderDead.Value > 0)
                nudWarleaderDead.Value = nudWarleaderDead.Value - 1;
            Calculate();
        }

        private void pictureBoxMurkEye_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudMurkEyeDead.Value = nudMurkEyeDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudMurkEyeDead.Value > 0)
                nudMurkEyeDead.Value = nudMurkEyeDead.Value - 1;
            Calculate();
        }
    }
}
