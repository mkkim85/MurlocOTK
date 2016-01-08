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
        int MIN = int.MaxValue, MAX = 0;
        int CSUM = 0, CNUM = 0;

        public MurlocOTK()
        {
            InitializeComponent();

            nudBluegillDead.Value = 0;
            nudBluegillAlive.Value = 0;
            nudWarleaderDead.Value = 0;
            nudWarleaderAlive.Value = 0;
            nudMurkEyeDead.Value = 0;
            nudMurkEyeAlive.Value = 0;
            nudOracleDead.Value = 0;
            nudOracleAlive.Value = 0;
            labelBluegillAttack.Text = "2(0)=2";
            labelBluegillLife.Text = "1(0)=1";
            labelWarleaderAttack.Text = "3(0)=3";
            labelWarleaderLife.Text = "3(0)=3";
            labelMurkEyeAttack.Text = "2(0)=2";
            labelMurkEyeLife.Text = "4(0)=4";
            labelOracleAttack.Text = "1(0)=1";
            labelOracleLife.Text = "1(0)=1";
            labelOneTurnDamage.Text = "딜: 0";
        }

        public int getDamage(int[] data)
        {
            int bluegillAttack = 2, bluegillLife = 1;
            int warleaderAttack = 3, warleaderLife = 3;
            int murkeyeAttack = 2, murkeyeLife = 4;
            int oracleAttack = 1, oracleLife = 1;
            int murlocNum = 0;
            int[] mNum = { 0, 0, 0, 0 };
            int damage = 0;
            int numAlive = (int)nudBluegillAlive.Value + (int)nudWarleaderAlive.Value
                + (int)nudMurkEyeAlive.Value + (int)nudOracleAlive.Value;

            murlocNum = data.Length + numAlive;

            for (int i = 0; i < data.Length; i++)
                mNum[data[i]]++;

            mNum[0] = mNum[0] + (int)nudBluegillAlive.Value;
            mNum[1] = mNum[1] + (int)nudWarleaderAlive.Value;
            mNum[2] = mNum[2] + (int)nudMurkEyeAlive.Value;
            mNum[3] = mNum[3] + (int)nudOracleAlive.Value;

            if (mNum[0] > 0)
            {
                bluegillAttack = bluegillAttack + (2 * mNum[1] + 1 * mNum[3]);
                bluegillLife = bluegillLife + (1 * mNum[1]);
            }
            if (mNum[1] > 0)
            {
                warleaderAttack = warleaderAttack + (2 * (mNum[1] - 1) + 1 * mNum[3]);
                warleaderLife = warleaderLife + (1 * (mNum[1] - 1));
            }
            if (mNum[2] > 0)
            {
                murkeyeAttack = murkeyeAttack + (2 * mNum[1]) + (murlocNum - 1) + 1 * mNum[3];
                murkeyeLife = murkeyeLife + (1 * mNum[1]);
            }
            if (mNum[3] > 0)
            {
                oracleAttack = oracleAttack + (2 * mNum[1]) + (1 * (mNum[3] - 1));
                oracleLife = oracleLife + (1 * mNum[1]);
            }

            damage
                = bluegillAttack * mNum[0]
                + warleaderAttack * (int)nudWarleaderAlive.Value
                + murkeyeAttack * mNum[2]
                + oracleAttack * (int)nudOracleAlive.Value;

            return damage;
        }

        public void combinationUtil(int[] arr, int[] data, int start, int end, int index, int r)
        {
            if (index == r)
            {
                // Calculate damage
                int DAMAGE = getDamage(data);

                if (DAMAGE < MIN)
                    MIN = DAMAGE;
                if (DAMAGE > MAX)
                    MAX = DAMAGE;

                CSUM += DAMAGE;
                CNUM++;
                return;
            }

            for (int i = start; i <= end && end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1, end, index + 1, r);
            }
        }

        public void Calculate()
        {
            int bluegillAttack = 2, bluegillLife = 1;
            int warleaderAttack = 3, warleaderLife = 3;
            int murkeyeAttack = 2, murkeyeLife = 4;
            int oracleAttack = 1, oracleLife = 1;
            int murlocNum = 0;
            int bluegilNum = 0, warleaderNum = 0, murkeyeNum = 0, oracleNum = 0;
            int oneTurnDamage = 0;
            int numDead = (int)nudBluegillDead.Value + (int)nudWarleaderDead.Value 
                + (int)nudMurkEyeDead.Value + (int)nudOracleDead.Value;
            int numAlive = (int)nudBluegillAlive.Value + (int)nudWarleaderAlive.Value 
                + (int)nudMurkEyeAlive.Value + (int)nudOracleAlive.Value;

            // For combination
            MIN = int.MaxValue;
            MAX = 0;
            CSUM = 0;
            CNUM = 0;

            if (numDead > MAX_NUM && numAlive != MAX_NUM)
                buttonRecalc.Visible = true;
            else if ((numDead + numAlive) > MAX_NUM && numDead > 1 && numAlive < MAX_NUM)
                buttonRecalc.Visible = true;
            else if (numAlive >= MAX_NUM)
                buttonRecalc.Visible = false;
            else
                buttonRecalc.Visible = false;

            if (numAlive >= MAX_NUM)
            {
                murlocNum = MAX_NUM;
                bluegilNum = (int)nudBluegillAlive.Value;
                warleaderNum = (int)nudWarleaderAlive.Value;
                murkeyeNum = (int)nudMurkEyeAlive.Value;
                oracleNum = (int)nudOracleAlive.Value;
            }
            else if (numDead > MAX_NUM || ((numDead + numAlive) > MAX_NUM && numDead > 1 && numAlive < MAX_NUM))
            {
                // Pick up murloc randomly
                int pickNum = MAX_NUM - numAlive;
                int bluegillPickNum = 0, warleaderPickNum = 0, murkeyePickNum = 0, oraclePickNum = 0;
                int pickCount = 0;
                Random rand = new Random();

                while (pickCount < pickNum)
                {
                    int i = rand.Next(4);
                    if (i == 0 && (bluegillPickNum < (int)nudBluegillDead.Value))
                        ++bluegillPickNum;
                    else if (i == 1 && (warleaderPickNum < (int)nudWarleaderDead.Value))
                        ++warleaderPickNum;
                    else if (i == 2 && (murkeyePickNum < (int)nudMurkEyeDead.Value))
                        ++murkeyePickNum;
                    else if (i == 3 && (oraclePickNum < (int)nudOracleDead.Value))
                        ++oraclePickNum;
                    else
                        continue;
                    ++pickCount;
                }

                murlocNum = MAX_NUM;
                bluegilNum = bluegillPickNum + (int)nudBluegillAlive.Value;
                warleaderNum = warleaderPickNum + (int)nudWarleaderAlive.Value;
                murkeyeNum = murkeyePickNum + (int)nudMurkEyeAlive.Value;
                oracleNum = oraclePickNum + (int)nudOracleAlive.Value;

                int idx = 0;

                int[] arr = new int[numDead];
                int[] data = new int[pickNum];

                for (int i = 0; i < (int)nudBluegillDead.Value; i++)
                    arr[idx++] = 0;
                for (int i = 0; i < (int)nudWarleaderDead.Value; i++)
                    arr[idx++] = 1;
                for (int i = 0; i < (int)nudMurkEyeDead.Value; i++)
                    arr[idx++] = 2;
                for (int i = 0; i < (int)nudOracleDead.Value; i++)
                    arr[idx++] = 3;

                combinationUtil(arr, data, 0, numDead - 1, 0, pickNum);
            }
            else
            {
                murlocNum = numDead + numAlive;
                bluegilNum = (int)nudBluegillAlive.Value + (int)nudBluegillDead.Value;
                warleaderNum = (int)nudWarleaderAlive.Value + (int)nudWarleaderDead.Value;
                murkeyeNum = (int)nudMurkEyeAlive.Value + (int)nudMurkEyeDead.Value;
                oracleNum = (int)nudOracleAlive.Value + (int)nudOracleDead.Value;
            }

            if (bluegilNum > 0)
            {
                bluegillAttack = bluegillAttack + (2 * warleaderNum + 1 * oracleNum);
                bluegillLife = bluegillLife + (1 * warleaderNum);
            }
            if (warleaderNum > 0)
            {
                warleaderAttack = warleaderAttack + (2 * (warleaderNum - 1) + 1 * oracleNum);
                warleaderLife = warleaderLife + (1 * (warleaderNum - 1));
            }
            if (murkeyeNum > 0)
            {
                murkeyeAttack = murkeyeAttack + (2 * warleaderNum) + (murlocNum - 1) + 1 * oracleNum;
                murkeyeLife = murkeyeLife + (1 * warleaderNum);
            }
            if (oracleNum > 0)
            {
                oracleAttack = oracleAttack + (2 * warleaderNum) + (1 * (oracleNum - 1));
                oracleLife = oracleLife + (1 * warleaderNum);
            }

            oneTurnDamage
                = bluegillAttack * bluegilNum
                + warleaderAttack * (int)nudWarleaderAlive.Value
                + murkeyeAttack * murkeyeNum
                + oracleAttack * (int)nudOracleAlive.Value;

            labelBluegillAttack.Text = "2(" + (bluegillAttack - 2) + ")=" + bluegillAttack
                + "*" + bluegilNum + "=" + bluegillAttack * bluegilNum;
            labelBluegillLife.Text = "1(" + (bluegillLife - 1) + ")=" + bluegillLife;
            labelWarleaderAttack.Text = "3(" + (warleaderAttack - 3) + ")=" + warleaderAttack
                + "*" + (int)nudWarleaderAlive.Value + "=" + warleaderAttack * (int)nudWarleaderAlive.Value;
            labelWarleaderLife.Text = "3(" + (warleaderLife - 3) + ")=" + warleaderLife;
            labelMurkEyeAttack.Text = "2(" + (murkeyeAttack - 2) + ")=" + murkeyeAttack
                + "*" + murkeyeNum + "=" + murkeyeAttack * murkeyeNum;
            labelMurkEyeLife.Text = "4(" + (murkeyeLife - 4) + ")=" + murkeyeLife;
            labelOracleAttack.Text = "1(" + (oracleAttack - 1) + ")=" + oracleAttack
                + "*" + (int)nudOracleAlive.Value + "=" + oracleAttack * (int)nudOracleAlive.Value;
            labelOracleLife.Text = "1(" + (oracleLife - 1) + ")=" + oracleLife;

            if (CNUM > 0)
            {
                labelOneTurnDamage.Text = "딜: " + oneTurnDamage
                    + "(" + bluegillAttack * bluegilNum + "+"
                    + warleaderAttack * (int)nudWarleaderAlive.Value + "+"
                    + murkeyeAttack * murkeyeNum + "+"
                    + oracleAttack * (int)nudOracleAlive.Value + ")"
                    + " 최소/최대/평균(" + MIN + "/" + MAX + "/" + ((double)CSUM / CNUM).ToString("0.0") + ")";
            }
            else
            {
                labelOneTurnDamage.Text = "딜: " + oneTurnDamage
                + "(" + bluegillAttack * bluegilNum + "+"
                + warleaderAttack * (int)nudWarleaderAlive.Value + "+"
                + murkeyeAttack * murkeyeNum + "+"
                + oracleAttack * (int)nudOracleAlive.Value + ")";
            }
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
            nudOracleDead.Value = 0;
            nudOracleAlive.Value = 0;
            labelBluegillAttack.Text = "2(0)=2";
            labelBluegillLife.Text = "1(0)=1";
            labelWarleaderAttack.Text = "3(0)=3";
            labelWarleaderLife.Text = "3(0)=3";
            labelMurkEyeAttack.Text = "2(0)=2";
            labelMurkEyeLife.Text = "4(0)=4";
            labelOracleAttack.Text = "1(0)=1";
            labelOracleLife.Text = "1(0)=1";
            labelOneTurnDamage.Text = "딜: 0";
            buttonRecalc.Visible = false;
        }

        private void nudBluegillDead_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudBluegillAlive_ValueChanged(object sender, EventArgs e)
        {
            if (nudBluegillAlive.Value + nudWarleaderAlive.Value + nudMurkEyeAlive.Value + nudOracleAlive.Value > MAX_NUM)
                nudBluegillAlive.Value--;
            Calculate();
        }

        private void nudWarleaderDead_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudWarleaderAlive_ValueChanged(object sender, EventArgs e)
        {
            if (nudBluegillAlive.Value + nudWarleaderAlive.Value + nudMurkEyeAlive.Value + nudOracleAlive.Value > MAX_NUM)
                nudWarleaderAlive.Value--;
            Calculate();
        }

        private void nudMurkEyeDead_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudMurkEyeAlive_ValueChanged(object sender, EventArgs e)
        {
            if (nudBluegillAlive.Value + nudWarleaderAlive.Value + nudMurkEyeAlive.Value + nudOracleAlive.Value > MAX_NUM)
                nudMurkEyeAlive.Value--;
            Calculate();
        }

        private void nudOracleDead_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void nudOracleAlive_ValueChanged(object sender, EventArgs e)
        {
            if (nudBluegillAlive.Value + nudWarleaderAlive.Value + nudMurkEyeAlive.Value + nudOracleAlive.Value > MAX_NUM)
                nudOracleAlive.Value--;
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

        private void pictureBoxOracle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudOracleDead.Value = nudOracleDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudOracleDead.Value > 0)
                nudOracleDead.Value = nudOracleDead.Value - 1;
            Calculate();
        }

        private void pictureBoxBluegill_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudBluegillDead.Value = nudBluegillDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudBluegillDead.Value > 0)
                nudBluegillDead.Value = nudBluegillDead.Value - 1;
            Calculate();
        }

        private void pictureBoxWarleader_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudWarleaderDead.Value = nudWarleaderDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudWarleaderDead.Value > 0)
                nudWarleaderDead.Value = nudWarleaderDead.Value - 1;
            Calculate();
        }

        private void pictureBoxMurkEye_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudMurkEyeDead.Value = nudMurkEyeDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudMurkEyeDead.Value > 0)
                nudMurkEyeDead.Value = nudMurkEyeDead.Value - 1;
            Calculate();
        }

        private void pictureBoxOracle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                nudOracleDead.Value = nudOracleDead.Value + 1;
            else if (e.Button == MouseButtons.Right && nudOracleDead.Value > 0)
                nudOracleDead.Value = nudOracleDead.Value - 1;
            Calculate();
        }
    }
}
