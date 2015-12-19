using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using tonysound;

namespace Packman
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class FormBoss : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblCani;
		private System.Windows.Forms.Label lblPara;
		private System.Windows.Forms.Label lblYemlik;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label lblYem;
		private System.Windows.Forms.Label lblMoney;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.Label lblYem2;
		private System.Windows.Forms.Label lblCin;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.Label lblGas;
		private System.Windows.Forms.Label lblYem3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.IContainer components;

		public FormBoss()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		double Money=0;
		int Yemlik=0;
		int Hak=0;
		int i=0;
		public FormBoss(double dblMoney,int intyemlik,int intHak)
		{
			InitializeComponent();
			Money=dblMoney;
			Yemlik=intyemlik;
			Hak=intHak;
			lblCani.Text="X "+Hak.ToString();
			lblPara.Text="X "+Money.ToString();
			lblMoney.Text="X "+Money.ToString();
			lblYemlik.Text="X "+Yemlik.ToString();
			lblYem.Text="X "+Yemlik.ToString();
			lblYem3.Text="X "+Yemlik.ToString();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FormBoss));
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblCani = new System.Windows.Forms.Label();
			this.lblPara = new System.Windows.Forms.Label();
			this.lblYemlik = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.lblYem = new System.Windows.Forms.Label();
			this.lblCin = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.lblYem2 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblMoney = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.lblGas = new System.Windows.Forms.Label();
			this.lblYem3 = new System.Windows.Forms.Label();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(104, 48);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(110, 44);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 71;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 73;
			this.pictureBox1.TabStop = false;
			// 
			// lblCani
			// 
			this.lblCani.Enabled = false;
			this.lblCani.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCani.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCani.Location = new System.Drawing.Point(16, 8);
			this.lblCani.Name = "lblCani";
			this.lblCani.Size = new System.Drawing.Size(64, 32);
			this.lblCani.TabIndex = 74;
			this.lblCani.Text = "X 0";
			// 
			// lblPara
			// 
			this.lblPara.Enabled = false;
			this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblPara.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblPara.Location = new System.Drawing.Point(104, 8);
			this.lblPara.Name = "lblPara";
			this.lblPara.Size = new System.Drawing.Size(144, 32);
			this.lblPara.TabIndex = 72;
			this.lblPara.Text = "0 YTL";
			// 
			// lblYemlik
			// 
			this.lblYemlik.Enabled = false;
			this.lblYemlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblYemlik.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblYemlik.Location = new System.Drawing.Point(272, 8);
			this.lblYemlik.Name = "lblYemlik";
			this.lblYemlik.Size = new System.Drawing.Size(88, 32);
			this.lblYemlik.TabIndex = 70;
			this.lblYemlik.Text = "X 0";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(280, 48);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(32, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 69;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(8, 130);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(248, 270);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 75;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 128);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(248, 270);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 76;
			this.pictureBox2.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
			this.groupBox1.Location = new System.Drawing.Point(264, 80);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(8, 328);
			this.groupBox1.TabIndex = 77;
			this.groupBox1.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(384, 208);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(50, 50);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 78;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(296, 232);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(16, 16);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 79;
			this.pictureBox7.TabStop = false;
			// 
			// lblYem
			// 
			this.lblYem.Enabled = false;
			this.lblYem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblYem.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblYem.Location = new System.Drawing.Point(296, 208);
			this.lblYem.Name = "lblYem";
			this.lblYem.Size = new System.Drawing.Size(56, 16);
			this.lblYem.TabIndex = 80;
			this.lblYem.Text = "X 0";
			// 
			// lblCin
			// 
			this.lblCin.Enabled = false;
			this.lblCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCin.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCin.Location = new System.Drawing.Point(384, 192);
			this.lblCin.Name = "lblCin";
			this.lblCin.Size = new System.Drawing.Size(56, 16);
			this.lblCin.TabIndex = 81;
			this.lblCin.Text = "X 0";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Location = new System.Drawing.Point(336, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(32, 32);
			this.button1.TabIndex = 82;
			this.button1.TabStop = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(328, 384);
			this.button2.Name = "button2";
			this.button2.TabIndex = 83;
			this.button2.Text = "Tamam";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Location = new System.Drawing.Point(336, 120);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(32, 32);
			this.button3.TabIndex = 86;
			this.button3.TabStop = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// lblYem2
			// 
			this.lblYem2.Enabled = false;
			this.lblYem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblYem2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblYem2.Location = new System.Drawing.Point(384, 104);
			this.lblYem2.Name = "lblYem2";
			this.lblYem2.Size = new System.Drawing.Size(56, 16);
			this.lblYem2.TabIndex = 85;
			this.lblYem2.Text = "X 0";
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(384, 128);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(16, 16);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 84;
			this.pictureBox8.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.groupBox2.Location = new System.Drawing.Point(272, 168);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(184, 8);
			this.groupBox2.TabIndex = 87;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.RosyBrown;
			this.groupBox3.Location = new System.Drawing.Point(272, 80);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(184, 8);
			this.groupBox3.TabIndex = 88;
			this.groupBox3.TabStop = false;
			// 
			// lblMoney
			// 
			this.lblMoney.Enabled = false;
			this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblMoney.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblMoney.Location = new System.Drawing.Point(288, 104);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(56, 16);
			this.lblMoney.TabIndex = 90;
			this.lblMoney.Text = "X 0";
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(288, 128);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(24, 16);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 91;
			this.pictureBox10.TabStop = false;
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(350, 256);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 16);
			this.label1.TabIndex = 93;
			this.label1.Text = "X 2";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(338, 258);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(9, 9);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 92;
			this.pictureBox9.TabStop = false;
			// 
			// label4
			// 
			this.label4.Enabled = false;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label4.Location = new System.Drawing.Point(344, 152);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 16);
			this.label4.TabIndex = 95;
			this.label4.Text = "X 100";
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(328, 154);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(16, 9);
			this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 96;
			this.pictureBox12.TabStop = false;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.groupBox4.Location = new System.Drawing.Point(272, 280);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(184, 8);
			this.groupBox4.TabIndex = 97;
			this.groupBox4.TabStop = false;
			// 
			// label2
			// 
			this.label2.Enabled = false;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label2.Location = new System.Drawing.Point(352, 360);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 103;
			this.label2.Text = "X 3";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Location = new System.Drawing.Point(336, 328);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(32, 32);
			this.button4.TabIndex = 102;
			this.button4.TabStop = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// lblGas
			// 
			this.lblGas.Enabled = false;
			this.lblGas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblGas.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblGas.Location = new System.Drawing.Point(384, 296);
			this.lblGas.Name = "lblGas";
			this.lblGas.Size = new System.Drawing.Size(56, 16);
			this.lblGas.TabIndex = 101;
			this.lblGas.Text = "X 0";
			// 
			// lblYem3
			// 
			this.lblYem3.Enabled = false;
			this.lblYem3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblYem3.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblYem3.Location = new System.Drawing.Point(296, 312);
			this.lblYem3.Name = "lblYem3";
			this.lblYem3.Size = new System.Drawing.Size(56, 16);
			this.lblYem3.TabIndex = 100;
			this.lblYem3.Text = "X 0";
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(296, 336);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(16, 16);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox11.TabIndex = 99;
			this.pictureBox11.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(384, 312);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(50, 50);
			this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox13.TabIndex = 98;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(338, 364);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(9, 9);
			this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox14.TabIndex = 104;
			this.pictureBox14.TabStop = false;
			// 
			// FormBoss
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(456, 414);
			this.Controls.Add(this.pictureBox14);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.lblGas);
			this.Controls.Add(this.lblYem3);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.pictureBox13);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.lblMoney);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.lblYem2);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblCin);
			this.Controls.Add(this.lblYem);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblCani);
			this.Controls.Add(this.lblPara);
			this.Controls.Add(this.lblYemlik);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox4);
			this.Name = "FormBoss";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form3";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form4_KeyDown);
			this.Load += new System.EventHandler(this.Form3_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(i>100)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\msquito.wav";
				Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
				timer1.Stop();
				pictureBox4.Visible=true;
				pictureBox2.Visible=false;
			}
			i++;
		}

		private void Form3_Load(object sender, System.EventArgs e)
		{
			this.Focus();
			string str=Application.StartupPath.ToString()+"\\sound\\meow.wav";
			Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC);
			timer1.Start();
		}

		int intYemal=0;
		int intCinal=0;
		int intGassal=0;
		private void button3_Click(object sender, System.EventArgs e)
		{
			if(Money>=100)
			{
				intYemal++;
				Money-=100;
				Yemlik+=1;
				lblMoney.Text="X "+Money.ToString();
				lblYem.Text="X "+Yemlik.ToString();
				lblYem2.Text="X "+intYemal.ToString();
				lblYem3.Text="X "+Yemlik.ToString();
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(Yemlik>=2)
			{
				intCinal++;
				Yemlik-=2;
				lblYem.Text="X "+Yemlik.ToString();
				lblYem3.Text="X "+Yemlik.ToString();
				lblCin.Text="X "+intCinal.ToString();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			string str=Application.StartupPath.ToString()+"\\sound\\sus.wav";
			Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
			timer1.Stop();
			Boss1 boss=new Boss1(Money,Yemlik,Hak,this,intCinal,intGassal,0,0,0);
			boss.Show();
			this.Close();
			this.Dispose();
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if(Yemlik>=3)
			{
				intGassal++;
				Yemlik-=3;
				lblYem3.Text="X "+Yemlik.ToString();
				lblYem.Text="X "+Yemlik.ToString();
				lblGas.Text="X "+intGassal.ToString();
			}
		}

		private void Form4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Space)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\sus.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				Level4 frm4=new Level4( Money,Yemlik,Hak,this,intCinal,intGassal);
				frm4.Show();
				timer1.Stop();
				this.Visible=false;
				this.Dispose();
				this.Close();
			}
		}
	}
}
