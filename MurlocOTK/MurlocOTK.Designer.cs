namespace MurlocOTK
{
    partial class MurlocOTK
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudBluegillAlive = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudBluegillDead = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxBluegill = new System.Windows.Forms.PictureBox();
            this.pictureBoxWarleader = new System.Windows.Forms.PictureBox();
            this.pictureBoxMurkEye = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.nudWarleaderAlive = new System.Windows.Forms.NumericUpDown();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.nudWarleaderDead = new System.Windows.Forms.NumericUpDown();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.nudMurkEyeAlive = new System.Windows.Forms.NumericUpDown();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.nudMurkEyeDead = new System.Windows.Forms.NumericUpDown();
            this.labelOneTurnDamage = new System.Windows.Forms.Label();
            this.buttonRecalc = new System.Windows.Forms.Button();
            this.labelBluegillAttack = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelBluegillLife = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelWarleaderAttack = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelMurkEyeAttack = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.labelWarleaderLife = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelMurkEyeLife = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.labelOracleLife = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.labelOracleAttack = new System.Windows.Forms.Label();
            this.pictureBoxOracle = new System.Windows.Forms.PictureBox();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.nudOracleAlive = new System.Windows.Forms.NumericUpDown();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.nudOracleDead = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBluegillAlive)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBluegillDead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBluegill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarleader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMurkEye)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarleaderAlive)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWarleaderDead)).BeginInit();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMurkEyeAlive)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMurkEyeDead)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOracle)).BeginInit();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOracleAlive)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOracleDead)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(13, 13);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(95, 23);
            this.buttonReset.TabIndex = 0;
            this.buttonReset.Text = "초기화(Reset)";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudBluegillAlive);
            this.groupBox2.Location = new System.Drawing.Point(90, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(70, 55);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "생존 수";
            // 
            // nudBluegillAlive
            // 
            this.nudBluegillAlive.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudBluegillAlive.Location = new System.Drawing.Point(6, 20);
            this.nudBluegillAlive.Name = "nudBluegillAlive";
            this.nudBluegillAlive.Size = new System.Drawing.Size(58, 29);
            this.nudBluegillAlive.TabIndex = 1;
            this.nudBluegillAlive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBluegillAlive.ValueChanged += new System.EventHandler(this.nudBluegillAlive_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudBluegillDead);
            this.groupBox1.Location = new System.Drawing.Point(13, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(71, 55);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "죽은 수";
            // 
            // nudBluegillDead
            // 
            this.nudBluegillDead.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudBluegillDead.Location = new System.Drawing.Point(9, 20);
            this.nudBluegillDead.Name = "nudBluegillDead";
            this.nudBluegillDead.Size = new System.Drawing.Size(56, 29);
            this.nudBluegillDead.TabIndex = 1;
            this.nudBluegillDead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBluegillDead.ValueChanged += new System.EventHandler(this.nudBluegillDead_ValueChanged);
            // 
            // pictureBoxBluegill
            // 
            this.pictureBoxBluegill.Image = global::MurlocOTK.Properties.Resources.Bluegill_Warrior;
            this.pictureBoxBluegill.Location = new System.Drawing.Point(12, 42);
            this.pictureBoxBluegill.Name = "pictureBoxBluegill";
            this.pictureBoxBluegill.Size = new System.Drawing.Size(148, 202);
            this.pictureBoxBluegill.TabIndex = 6;
            this.pictureBoxBluegill.TabStop = false;
            this.pictureBoxBluegill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBluegill_MouseClick);
            this.pictureBoxBluegill.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBluegill_MouseDoubleClick);
            // 
            // pictureBoxWarleader
            // 
            this.pictureBoxWarleader.Image = global::MurlocOTK.Properties.Resources.Murloc_Warleader;
            this.pictureBoxWarleader.Location = new System.Drawing.Point(169, 42);
            this.pictureBoxWarleader.Name = "pictureBoxWarleader";
            this.pictureBoxWarleader.Size = new System.Drawing.Size(148, 202);
            this.pictureBoxWarleader.TabIndex = 6;
            this.pictureBoxWarleader.TabStop = false;
            this.pictureBoxWarleader.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWarleader_MouseClick);
            this.pictureBoxWarleader.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxWarleader_MouseDoubleClick);
            // 
            // pictureBoxMurkEye
            // 
            this.pictureBoxMurkEye.Image = global::MurlocOTK.Properties.Resources.Old_Murk_Eye;
            this.pictureBoxMurkEye.Location = new System.Drawing.Point(323, 42);
            this.pictureBoxMurkEye.Name = "pictureBoxMurkEye";
            this.pictureBoxMurkEye.Size = new System.Drawing.Size(148, 202);
            this.pictureBoxMurkEye.TabIndex = 6;
            this.pictureBoxMurkEye.TabStop = false;
            this.pictureBoxMurkEye.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMurkEye_MouseClick);
            this.pictureBoxMurkEye.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxMurkEye_MouseDoubleClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.nudWarleaderAlive);
            this.groupBox7.Location = new System.Drawing.Point(246, 250);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(71, 55);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "생존 수";
            // 
            // nudWarleaderAlive
            // 
            this.nudWarleaderAlive.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudWarleaderAlive.Location = new System.Drawing.Point(6, 20);
            this.nudWarleaderAlive.Name = "nudWarleaderAlive";
            this.nudWarleaderAlive.Size = new System.Drawing.Size(59, 29);
            this.nudWarleaderAlive.TabIndex = 1;
            this.nudWarleaderAlive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWarleaderAlive.ValueChanged += new System.EventHandler(this.nudWarleaderAlive_ValueChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.nudWarleaderDead);
            this.groupBox8.Location = new System.Drawing.Point(169, 250);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(71, 55);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "죽은 수";
            // 
            // nudWarleaderDead
            // 
            this.nudWarleaderDead.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudWarleaderDead.Location = new System.Drawing.Point(9, 20);
            this.nudWarleaderDead.Name = "nudWarleaderDead";
            this.nudWarleaderDead.Size = new System.Drawing.Size(56, 29);
            this.nudWarleaderDead.TabIndex = 1;
            this.nudWarleaderDead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudWarleaderDead.ValueChanged += new System.EventHandler(this.nudWarleaderDead_ValueChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.nudMurkEyeAlive);
            this.groupBox11.Location = new System.Drawing.Point(400, 250);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(71, 55);
            this.groupBox11.TabIndex = 13;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "생존 수";
            // 
            // nudMurkEyeAlive
            // 
            this.nudMurkEyeAlive.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudMurkEyeAlive.Location = new System.Drawing.Point(6, 20);
            this.nudMurkEyeAlive.Name = "nudMurkEyeAlive";
            this.nudMurkEyeAlive.Size = new System.Drawing.Size(59, 29);
            this.nudMurkEyeAlive.TabIndex = 1;
            this.nudMurkEyeAlive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMurkEyeAlive.ValueChanged += new System.EventHandler(this.nudMurkEyeAlive_ValueChanged);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.nudMurkEyeDead);
            this.groupBox12.Location = new System.Drawing.Point(323, 250);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(71, 55);
            this.groupBox12.TabIndex = 11;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "죽은 수";
            // 
            // nudMurkEyeDead
            // 
            this.nudMurkEyeDead.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudMurkEyeDead.Location = new System.Drawing.Point(9, 20);
            this.nudMurkEyeDead.Name = "nudMurkEyeDead";
            this.nudMurkEyeDead.Size = new System.Drawing.Size(62, 29);
            this.nudMurkEyeDead.TabIndex = 1;
            this.nudMurkEyeDead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMurkEyeDead.ValueChanged += new System.EventHandler(this.nudMurkEyeDead_ValueChanged);
            // 
            // labelOneTurnDamage
            // 
            this.labelOneTurnDamage.AutoSize = true;
            this.labelOneTurnDamage.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOneTurnDamage.Location = new System.Drawing.Point(114, 13);
            this.labelOneTurnDamage.Name = "labelOneTurnDamage";
            this.labelOneTurnDamage.Size = new System.Drawing.Size(99, 21);
            this.labelOneTurnDamage.TabIndex = 15;
            this.labelOneTurnDamage.Text = "총 공격력: 0";
            // 
            // buttonRecalc
            // 
            this.buttonRecalc.Location = new System.Drawing.Point(536, 13);
            this.buttonRecalc.Name = "buttonRecalc";
            this.buttonRecalc.Size = new System.Drawing.Size(89, 23);
            this.buttonRecalc.TabIndex = 16;
            this.buttonRecalc.Text = "재계산(랜덤)";
            this.buttonRecalc.UseVisualStyleBackColor = true;
            this.buttonRecalc.Visible = false;
            this.buttonRecalc.Click += new System.EventHandler(this.buttonRecalc_Click);
            // 
            // labelBluegillAttack
            // 
            this.labelBluegillAttack.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBluegillAttack.Location = new System.Drawing.Point(7, 17);
            this.labelBluegillAttack.Name = "labelBluegillAttack";
            this.labelBluegillAttack.Size = new System.Drawing.Size(133, 35);
            this.labelBluegillAttack.TabIndex = 0;
            this.labelBluegillAttack.Text = "2(+0)=2";
            this.labelBluegillAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelBluegillAttack);
            this.groupBox3.Location = new System.Drawing.Point(13, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 55);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "공격력(버프)";
            // 
            // labelBluegillLife
            // 
            this.labelBluegillLife.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBluegillLife.Location = new System.Drawing.Point(6, 17);
            this.labelBluegillLife.Name = "labelBluegillLife";
            this.labelBluegillLife.Size = new System.Drawing.Size(135, 35);
            this.labelBluegillLife.TabIndex = 0;
            this.labelBluegillLife.Text = "1(+0)=1";
            this.labelBluegillLife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelBluegillLife);
            this.groupBox4.Location = new System.Drawing.Point(13, 372);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(147, 55);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "체력(버프)";
            // 
            // labelWarleaderAttack
            // 
            this.labelWarleaderAttack.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelWarleaderAttack.Location = new System.Drawing.Point(7, 17);
            this.labelWarleaderAttack.Name = "labelWarleaderAttack";
            this.labelWarleaderAttack.Size = new System.Drawing.Size(135, 35);
            this.labelWarleaderAttack.TabIndex = 0;
            this.labelWarleaderAttack.Text = "2(+0)=2";
            this.labelWarleaderAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.labelWarleaderAttack);
            this.groupBox6.Location = new System.Drawing.Point(169, 311);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(148, 55);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "공격력(버프)";
            // 
            // labelMurkEyeAttack
            // 
            this.labelMurkEyeAttack.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMurkEyeAttack.Location = new System.Drawing.Point(7, 17);
            this.labelMurkEyeAttack.Name = "labelMurkEyeAttack";
            this.labelMurkEyeAttack.Size = new System.Drawing.Size(135, 35);
            this.labelMurkEyeAttack.TabIndex = 0;
            this.labelMurkEyeAttack.Text = "2(+0)=2";
            this.labelMurkEyeAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.labelMurkEyeAttack);
            this.groupBox10.Location = new System.Drawing.Point(323, 311);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(148, 55);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "공격력(버프)";
            // 
            // labelWarleaderLife
            // 
            this.labelWarleaderLife.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelWarleaderLife.Location = new System.Drawing.Point(6, 17);
            this.labelWarleaderLife.Name = "labelWarleaderLife";
            this.labelWarleaderLife.Size = new System.Drawing.Size(136, 35);
            this.labelWarleaderLife.TabIndex = 0;
            this.labelWarleaderLife.Text = "1(+0)=1";
            this.labelWarleaderLife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelWarleaderLife);
            this.groupBox5.Location = new System.Drawing.Point(169, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 55);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "체력(버프)";
            // 
            // labelMurkEyeLife
            // 
            this.labelMurkEyeLife.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMurkEyeLife.Location = new System.Drawing.Point(6, 17);
            this.labelMurkEyeLife.Name = "labelMurkEyeLife";
            this.labelMurkEyeLife.Size = new System.Drawing.Size(136, 35);
            this.labelMurkEyeLife.TabIndex = 0;
            this.labelMurkEyeLife.Text = "1(+0)=1";
            this.labelMurkEyeLife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.labelMurkEyeLife);
            this.groupBox9.Location = new System.Drawing.Point(323, 372);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(148, 55);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "체력(버프)";
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.labelOracleLife);
            this.groupBox13.Location = new System.Drawing.Point(477, 372);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(148, 55);
            this.groupBox13.TabIndex = 17;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "체력(버프)";
            // 
            // labelOracleLife
            // 
            this.labelOracleLife.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOracleLife.Location = new System.Drawing.Point(6, 17);
            this.labelOracleLife.Name = "labelOracleLife";
            this.labelOracleLife.Size = new System.Drawing.Size(136, 35);
            this.labelOracleLife.TabIndex = 0;
            this.labelOracleLife.Text = "1(+0)=1";
            this.labelOracleLife.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.labelOracleAttack);
            this.groupBox14.Location = new System.Drawing.Point(477, 311);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(148, 55);
            this.groupBox14.TabIndex = 15;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "공격력(버프)";
            // 
            // labelOracleAttack
            // 
            this.labelOracleAttack.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelOracleAttack.Location = new System.Drawing.Point(7, 17);
            this.labelOracleAttack.Name = "labelOracleAttack";
            this.labelOracleAttack.Size = new System.Drawing.Size(135, 35);
            this.labelOracleAttack.TabIndex = 0;
            this.labelOracleAttack.Text = "2(+0)=2";
            this.labelOracleAttack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxOracle
            // 
            this.pictureBoxOracle.Image = global::MurlocOTK.Properties.Resources.Grimscale_Oracle;
            this.pictureBoxOracle.Location = new System.Drawing.Point(477, 42);
            this.pictureBoxOracle.Name = "pictureBoxOracle";
            this.pictureBoxOracle.Size = new System.Drawing.Size(148, 202);
            this.pictureBoxOracle.TabIndex = 14;
            this.pictureBoxOracle.TabStop = false;
            this.pictureBoxOracle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOracle_MouseClick);
            this.pictureBoxOracle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxOracle_MouseDoubleClick);
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.nudOracleAlive);
            this.groupBox15.Location = new System.Drawing.Point(554, 250);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(71, 55);
            this.groupBox15.TabIndex = 18;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "생존 수";
            // 
            // nudOracleAlive
            // 
            this.nudOracleAlive.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudOracleAlive.Location = new System.Drawing.Point(6, 20);
            this.nudOracleAlive.Name = "nudOracleAlive";
            this.nudOracleAlive.Size = new System.Drawing.Size(59, 29);
            this.nudOracleAlive.TabIndex = 1;
            this.nudOracleAlive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOracleAlive.ValueChanged += new System.EventHandler(this.nudOracleAlive_ValueChanged);
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.nudOracleDead);
            this.groupBox16.Location = new System.Drawing.Point(477, 250);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(71, 55);
            this.groupBox16.TabIndex = 16;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "죽은 수";
            // 
            // nudOracleDead
            // 
            this.nudOracleDead.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nudOracleDead.Location = new System.Drawing.Point(9, 20);
            this.nudOracleDead.Name = "nudOracleDead";
            this.nudOracleDead.Size = new System.Drawing.Size(62, 29);
            this.nudOracleDead.TabIndex = 1;
            this.nudOracleDead.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudOracleDead.ValueChanged += new System.EventHandler(this.nudOracleDead_ValueChanged);
            // 
            // MurlocOTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 437);
            this.Controls.Add(this.groupBox13);
            this.Controls.Add(this.buttonRecalc);
            this.Controls.Add(this.groupBox14);
            this.Controls.Add(this.pictureBoxOracle);
            this.Controls.Add(this.labelOneTurnDamage);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox16);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.pictureBoxMurkEye);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pictureBoxWarleader);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.pictureBoxBluegill);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReset);
            this.Name = "MurlocOTK";
            this.Text = "Murloc OTK Calculator by mkkim (e-mail: mkkim@outlook.kr)";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBluegillAlive)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBluegillDead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBluegill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWarleader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMurkEye)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWarleaderAlive)).EndInit();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWarleaderDead)).EndInit();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMurkEyeAlive)).EndInit();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMurkEyeDead)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOracle)).EndInit();
            this.groupBox15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOracleAlive)).EndInit();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudOracleDead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxBluegill;
        private System.Windows.Forms.PictureBox pictureBoxWarleader;
        private System.Windows.Forms.PictureBox pictureBoxMurkEye;
        private System.Windows.Forms.NumericUpDown nudBluegillAlive;
        private System.Windows.Forms.NumericUpDown nudBluegillDead;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown nudWarleaderAlive;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown nudWarleaderDead;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.NumericUpDown nudMurkEyeAlive;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.NumericUpDown nudMurkEyeDead;
        private System.Windows.Forms.Label labelOneTurnDamage;
        private System.Windows.Forms.Button buttonRecalc;
        private System.Windows.Forms.Label labelBluegillAttack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelBluegillLife;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelWarleaderAttack;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelMurkEyeAttack;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label labelWarleaderLife;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelMurkEyeLife;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Label labelOracleLife;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Label labelOracleAttack;
        private System.Windows.Forms.PictureBox pictureBoxOracle;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.NumericUpDown nudOracleAlive;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.NumericUpDown nudOracleDead;
    }
}

