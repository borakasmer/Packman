using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using tonysound;

namespace Packman
{
	/// <summary>
	/// Summary description for Level4.
	/// </summary>
	public class Level4 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox Boman;
		private System.Windows.Forms.PictureBox Exit;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button cikisDuvari;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button12;
		public System.Windows.Forms.TextBox Cikis;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblPara;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lblCani;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblYemlik;
		private System.Windows.Forms.PictureBox imgSiren;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button nitro;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.PictureBox yemlik1;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.PictureBox yemlik2;
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button42;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.Button button45;
		private System.Windows.Forms.Button button48;
		private System.Windows.Forms.PictureBox yemlik3;
		private System.Windows.Forms.Button button49;
		private System.Windows.Forms.Button button50;
		private System.Windows.Forms.Button button51;
		private System.Windows.Forms.Button button52;
		private System.Windows.Forms.Button button53;
		private System.Windows.Forms.Button button55;
		private System.Windows.Forms.Button button56;
		private System.Windows.Forms.Button button57;
		private System.Windows.Forms.Button button58;
		private System.Windows.Forms.Button button59;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button54;
		private System.Windows.Forms.Button button60;
		private System.Windows.Forms.Button button61;
		private System.Windows.Forms.Button button62;
		private System.Windows.Forms.Button button63;
		private System.Windows.Forms.Button button64;
		private System.Windows.Forms.Button button65;
		private System.Windows.Forms.Button breakTime;
		private System.Windows.Forms.PictureBox gin;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.Timer timer5;
		private System.Windows.Forms.Timer timer6;
		private System.Windows.Forms.Timer timer7;
		private System.Windows.Forms.PictureBox monster;
		private System.Windows.Forms.PictureBox monster2;
		private System.Windows.Forms.PictureBox monster3;
		private System.Windows.Forms.PictureBox monster4;
		private System.Windows.Forms.PictureBox yemlik4;
		private System.Windows.Forms.Label lblCin;
		private System.Windows.Forms.Timer timer8;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label lblCin2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button button66;
		private System.Windows.Forms.Button button67;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button68;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button69;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Button button70;
		private System.Windows.Forms.PictureBox monster5;
		private System.Windows.Forms.Timer timer9;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Button ostime;
		private System.Windows.Forms.PictureBox osuruk;
		private System.Windows.Forms.Label lblOs;
		private System.Windows.Forms.Timer timer10;
		private System.Windows.Forms.Label lblOs2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.ComponentModel.IContainer components;

		public Level4()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
		public Level4(double dblMoney,int intyemlik,int intHak,Form frm,int intCin,int intOsuruk)
		{
			InitializeComponent();
			Money=dblMoney;
			yemlik=intyemlik;
			Hak=intHak;
			Cin=intCin;
			Osuruk=intOsuruk;
			//over=false;
			frm.Close();
			frm.Dispose();
			lblPara.Text=Money.ToString()+" YTL";
			lblCani.Text="X"+ Hak.ToString();
			lblYemlik.Text="X"+yemlik.ToString();
			lblCin.Text=intCin.ToString() +"X";
			lblCin2.Text="X"+intCin.ToString();
			lblOs.Text=intOsuruk.ToString() +"X";
			lblOs2.Text="X"+intOsuruk.ToString();
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
			this.label2 = new System.Windows.Forms.Label();
			this.Boman = new System.Windows.Forms.PictureBox();
			this.Exit = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.cikisDuvari = new System.Windows.Forms.Button();
			this.button27 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.Cikis = new System.Windows.Forms.TextBox();
			this.button19 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblPara = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblCani = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblYemlik = new System.Windows.Forms.Label();
			this.imgSiren = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nitro = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.button29 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button34 = new System.Windows.Forms.Button();
			this.yemlik1 = new System.Windows.Forms.PictureBox();
			this.button35 = new System.Windows.Forms.Button();
			this.button36 = new System.Windows.Forms.Button();
			this.button37 = new System.Windows.Forms.Button();
			this.button38 = new System.Windows.Forms.Button();
			this.yemlik2 = new System.Windows.Forms.PictureBox();
			this.button40 = new System.Windows.Forms.Button();
			this.button41 = new System.Windows.Forms.Button();
			this.button42 = new System.Windows.Forms.Button();
			this.button43 = new System.Windows.Forms.Button();
			this.button44 = new System.Windows.Forms.Button();
			this.button45 = new System.Windows.Forms.Button();
			this.button48 = new System.Windows.Forms.Button();
			this.yemlik3 = new System.Windows.Forms.PictureBox();
			this.button49 = new System.Windows.Forms.Button();
			this.button50 = new System.Windows.Forms.Button();
			this.button51 = new System.Windows.Forms.Button();
			this.button52 = new System.Windows.Forms.Button();
			this.button53 = new System.Windows.Forms.Button();
			this.button55 = new System.Windows.Forms.Button();
			this.button56 = new System.Windows.Forms.Button();
			this.button57 = new System.Windows.Forms.Button();
			this.button58 = new System.Windows.Forms.Button();
			this.button59 = new System.Windows.Forms.Button();
			this.button46 = new System.Windows.Forms.Button();
			this.button54 = new System.Windows.Forms.Button();
			this.button60 = new System.Windows.Forms.Button();
			this.button61 = new System.Windows.Forms.Button();
			this.yemlik4 = new System.Windows.Forms.PictureBox();
			this.button62 = new System.Windows.Forms.Button();
			this.button63 = new System.Windows.Forms.Button();
			this.button64 = new System.Windows.Forms.Button();
			this.button65 = new System.Windows.Forms.Button();
			this.gin = new System.Windows.Forms.PictureBox();
			this.breakTime = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.timer6 = new System.Windows.Forms.Timer(this.components);
			this.timer7 = new System.Windows.Forms.Timer(this.components);
			this.monster = new System.Windows.Forms.PictureBox();
			this.monster2 = new System.Windows.Forms.PictureBox();
			this.monster4 = new System.Windows.Forms.PictureBox();
			this.monster3 = new System.Windows.Forms.PictureBox();
			this.lblCin = new System.Windows.Forms.Label();
			this.timer8 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.lblCin2 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.button66 = new System.Windows.Forms.Button();
			this.button67 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button68 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.button28 = new System.Windows.Forms.Button();
			this.button30 = new System.Windows.Forms.Button();
			this.button69 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button33 = new System.Windows.Forms.Button();
			this.button70 = new System.Windows.Forms.Button();
			this.monster5 = new System.Windows.Forms.PictureBox();
			this.timer9 = new System.Windows.Forms.Timer(this.components);
			this.lblOs2 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.lblOs = new System.Windows.Forms.Label();
			this.ostime = new System.Windows.Forms.Button();
			this.osuruk = new System.Windows.Forms.PictureBox();
			this.timer10 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.DarkViolet;
			this.label2.Location = new System.Drawing.Point(416, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 128);
			this.label2.TabIndex = 155;
			this.label2.Text = "3";
			// 
			// Boman
			// 
			this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));
			this.Boman.Location = new System.Drawing.Point(912, 56);
			this.Boman.Name = "Boman";
			this.Boman.Size = new System.Drawing.Size(40, 40);
			this.Boman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Boman.TabIndex = 156;
			this.Boman.TabStop = false;
			// 
			// Exit
			// 
			this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
			this.Exit.Location = new System.Drawing.Point(16, 632);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(88, 24);
			this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Exit.TabIndex = 158;
			this.Exit.TabStop = false;
			this.Exit.Visible = false;
			this.Exit.VisibleChanged += new System.EventHandler(this.Exit_VisibleChanged);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.textBox1.ForeColor = System.Drawing.Color.SteelBlue;
			this.textBox1.Location = new System.Drawing.Point(896, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(64, 15);
			this.textBox1.TabIndex = 157;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "   =>Giriþ";
			// 
			// cikisDuvari
			// 
			this.cikisDuvari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.BackgroundImage")));
			this.cikisDuvari.Enabled = false;
			this.cikisDuvari.Image = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.Image")));
			this.cikisDuvari.Location = new System.Drawing.Point(16, 616);
			this.cikisDuvari.Name = "cikisDuvari";
			this.cikisDuvari.Size = new System.Drawing.Size(88, 16);
			this.cikisDuvari.TabIndex = 160;
			// 
			// button27
			// 
			this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
			this.button27.Enabled = false;
			this.button27.Location = new System.Drawing.Point(104, 640);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(408, 16);
			this.button27.TabIndex = 161;
			// 
			// button32
			// 
			this.button32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button32.BackgroundImage")));
			this.button32.Enabled = false;
			this.button32.Image = ((System.Drawing.Image)(resources.GetObject("button32.Image")));
			this.button32.Location = new System.Drawing.Point(872, 0);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(120, 16);
			this.button32.TabIndex = 163;
			// 
			// button12
			// 
			this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
			this.button12.Enabled = false;
			this.button12.Location = new System.Drawing.Point(440, 400);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(16, 240);
			this.button12.TabIndex = 162;
			// 
			// Cikis
			// 
			this.Cikis.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Cikis.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Cikis.Enabled = false;
			this.Cikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.Cikis.ForeColor = System.Drawing.Color.SteelBlue;
			this.Cikis.Location = new System.Drawing.Point(8, 638);
			this.Cikis.Name = "Cikis";
			this.Cikis.Size = new System.Drawing.Size(64, 15);
			this.Cikis.TabIndex = 164;
			this.Cikis.TabStop = false;
			this.Cikis.Text = "   =>Çýkýþ";
			// 
			// button19
			// 
			this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
			this.button19.Enabled = false;
			this.button19.Location = new System.Drawing.Point(728, 488);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(16, 40);
			this.button19.TabIndex = 166;
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(576, 472);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(168, 16);
			this.button2.TabIndex = 167;
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(104, 568);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(16, 48);
			this.button5.TabIndex = 170;
			// 
			// button8
			// 
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.Enabled = false;
			this.button8.Location = new System.Drawing.Point(512, 640);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(248, 16);
			this.button8.TabIndex = 173;
			// 
			// button9
			// 
			this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
			this.button9.Enabled = false;
			this.button9.Location = new System.Drawing.Point(856, 328);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(16, 200);
			this.button9.TabIndex = 174;
			// 
			// button10
			// 
			this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
			this.button10.Enabled = false;
			this.button10.Location = new System.Drawing.Point(752, 640);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(256, 16);
			this.button10.TabIndex = 175;
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
			this.button11.Enabled = false;
			this.button11.Location = new System.Drawing.Point(992, 0);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(16, 640);
			this.button11.TabIndex = 176;
			// 
			// button13
			// 
			this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
			this.button13.Enabled = false;
			this.button13.Location = new System.Drawing.Point(248, 0);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(624, 16);
			this.button13.TabIndex = 177;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(456, 400);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(32, 16);
			this.button4.TabIndex = 169;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(168, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 189;
			this.pictureBox1.TabStop = false;
			// 
			// lblPara
			// 
			this.lblPara.Enabled = false;
			this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblPara.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblPara.Location = new System.Drawing.Point(96, 43);
			this.lblPara.Name = "lblPara";
			this.lblPara.Size = new System.Drawing.Size(72, 14);
			this.lblPara.TabIndex = 188;
			this.lblPara.Text = "0 YTL";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(72, 45);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 11);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 187;
			this.pictureBox3.TabStop = false;
			// 
			// lblCani
			// 
			this.lblCani.Enabled = false;
			this.lblCani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCani.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCani.Location = new System.Drawing.Point(32, 43);
			this.lblCani.Name = "lblCani";
			this.lblCani.Size = new System.Drawing.Size(40, 14);
			this.lblCani.TabIndex = 186;
			this.lblCani.Text = "X3";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 40);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 185;
			this.pictureBox2.TabStop = false;
			// 
			// lblYemlik
			// 
			this.lblYemlik.Enabled = false;
			this.lblYemlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblYemlik.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblYemlik.Location = new System.Drawing.Point(184, 43);
			this.lblYemlik.Name = "lblYemlik";
			this.lblYemlik.Size = new System.Drawing.Size(40, 14);
			this.lblYemlik.TabIndex = 184;
			this.lblYemlik.Text = "X0";
			// 
			// imgSiren
			// 
			this.imgSiren.Image = ((System.Drawing.Image)(resources.GetObject("imgSiren.Image")));
			this.imgSiren.Location = new System.Drawing.Point(8, 56);
			this.imgSiren.Name = "imgSiren";
			this.imgSiren.Size = new System.Drawing.Size(32, 32);
			this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgSiren.TabIndex = 183;
			this.imgSiren.TabStop = false;
			this.imgSiren.Visible = false;
			// 
			// label3
			// 
			this.label3.Enabled = false;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.Crimson;
			this.label3.Location = new System.Drawing.Point(40, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 182;
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 24);
			this.label1.TabIndex = 181;
			this.label1.Text = "Pilav Üstü Kuru";
			// 
			// nitro
			// 
			this.nitro.BackColor = System.Drawing.Color.DeepPink;
			this.nitro.Enabled = false;
			this.nitro.Location = new System.Drawing.Point(56, 16);
			this.nitro.Name = "nitro";
			this.nitro.Size = new System.Drawing.Size(75, 8);
			this.nitro.TabIndex = 180;
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.Transparent;
			this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
			this.button17.Enabled = false;
			this.button17.Location = new System.Drawing.Point(856, 80);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(16, 72);
			this.button17.TabIndex = 191;
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button22.BackgroundImage")));
			this.button22.Enabled = false;
			this.button22.Location = new System.Drawing.Point(584, 176);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(120, 16);
			this.button22.TabIndex = 195;
			// 
			// button23
			// 
			this.button23.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
			this.button23.Enabled = false;
			this.button23.Location = new System.Drawing.Point(328, 192);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(168, 16);
			this.button23.TabIndex = 196;
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
			this.button25.Enabled = false;
			this.button25.Location = new System.Drawing.Point(0, 88);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(232, 16);
			this.button25.TabIndex = 198;
			// 
			// button26
			// 
			this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
			this.button26.Enabled = false;
			this.button26.Location = new System.Drawing.Point(232, 0);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(16, 104);
			this.button26.TabIndex = 199;
			// 
			// button29
			// 
			this.button29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button29.BackgroundImage")));
			this.button29.Enabled = false;
			this.button29.Location = new System.Drawing.Point(104, 616);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(16, 24);
			this.button29.TabIndex = 201;
			// 
			// button16
			// 
			this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
			this.button16.Enabled = false;
			this.button16.Location = new System.Drawing.Point(328, 16);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(16, 176);
			this.button16.TabIndex = 203;
			// 
			// button14
			// 
			this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
			this.button14.Enabled = false;
			this.button14.Location = new System.Drawing.Point(0, 104);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(16, 552);
			this.button14.TabIndex = 208;
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.Transparent;
			this.button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button21.BackgroundImage")));
			this.button21.Enabled = false;
			this.button21.Location = new System.Drawing.Point(488, 400);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(64, 16);
			this.button21.TabIndex = 211;
			// 
			// button31
			// 
			this.button31.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button31.BackgroundImage")));
			this.button31.Enabled = false;
			this.button31.Location = new System.Drawing.Point(704, 328);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(152, 16);
			this.button31.TabIndex = 212;
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.DodgerBlue;
			this.button34.Enabled = false;
			this.button34.Location = new System.Drawing.Point(592, 504);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(10, 10);
			this.button34.TabIndex = 214;
			this.button34.TabStop = false;
			// 
			// yemlik1
			// 
			this.yemlik1.Image = ((System.Drawing.Image)(resources.GetObject("yemlik1.Image")));
			this.yemlik1.Location = new System.Drawing.Point(200, 560);
			this.yemlik1.Name = "yemlik1";
			this.yemlik1.Size = new System.Drawing.Size(16, 16);
			this.yemlik1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik1.TabIndex = 213;
			this.yemlik1.TabStop = false;
			// 
			// button35
			// 
			this.button35.BackColor = System.Drawing.Color.DodgerBlue;
			this.button35.Enabled = false;
			this.button35.Location = new System.Drawing.Point(96, 128);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(10, 10);
			this.button35.TabIndex = 215;
			this.button35.TabStop = false;
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.DodgerBlue;
			this.button36.Enabled = false;
			this.button36.Location = new System.Drawing.Point(808, 456);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(10, 10);
			this.button36.TabIndex = 217;
			this.button36.TabStop = false;
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.DodgerBlue;
			this.button37.Enabled = false;
			this.button37.Location = new System.Drawing.Point(688, 384);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(10, 10);
			this.button37.TabIndex = 216;
			this.button37.TabStop = false;
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.DodgerBlue;
			this.button38.Enabled = false;
			this.button38.Location = new System.Drawing.Point(912, 560);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(10, 10);
			this.button38.TabIndex = 218;
			this.button38.TabStop = false;
			// 
			// yemlik2
			// 
			this.yemlik2.Image = ((System.Drawing.Image)(resources.GetObject("yemlik2.Image")));
			this.yemlik2.Location = new System.Drawing.Point(768, 248);
			this.yemlik2.Name = "yemlik2";
			this.yemlik2.Size = new System.Drawing.Size(16, 16);
			this.yemlik2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik2.TabIndex = 220;
			this.yemlik2.TabStop = false;
			// 
			// button40
			// 
			this.button40.BackColor = System.Drawing.Color.DodgerBlue;
			this.button40.Enabled = false;
			this.button40.Location = new System.Drawing.Point(912, 376);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(10, 10);
			this.button40.TabIndex = 221;
			this.button40.TabStop = false;
			// 
			// button41
			// 
			this.button41.BackColor = System.Drawing.Color.DodgerBlue;
			this.button41.Enabled = false;
			this.button41.Location = new System.Drawing.Point(952, 264);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(10, 10);
			this.button41.TabIndex = 223;
			this.button41.TabStop = false;
			// 
			// button42
			// 
			this.button42.BackColor = System.Drawing.Color.DodgerBlue;
			this.button42.Enabled = false;
			this.button42.Location = new System.Drawing.Point(664, 232);
			this.button42.Name = "button42";
			this.button42.Size = new System.Drawing.Size(10, 10);
			this.button42.TabIndex = 222;
			this.button42.TabStop = false;
			// 
			// button43
			// 
			this.button43.BackColor = System.Drawing.Color.DodgerBlue;
			this.button43.Enabled = false;
			this.button43.Location = new System.Drawing.Point(904, 160);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(10, 10);
			this.button43.TabIndex = 224;
			this.button43.TabStop = false;
			// 
			// button44
			// 
			this.button44.BackColor = System.Drawing.Color.DodgerBlue;
			this.button44.Enabled = false;
			this.button44.Location = new System.Drawing.Point(40, 232);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(10, 10);
			this.button44.TabIndex = 225;
			this.button44.TabStop = false;
			// 
			// button45
			// 
			this.button45.BackColor = System.Drawing.Color.DodgerBlue;
			this.button45.Enabled = false;
			this.button45.Location = new System.Drawing.Point(544, 272);
			this.button45.Name = "button45";
			this.button45.Size = new System.Drawing.Size(10, 10);
			this.button45.TabIndex = 226;
			this.button45.TabStop = false;
			// 
			// button48
			// 
			this.button48.BackColor = System.Drawing.Color.DodgerBlue;
			this.button48.Enabled = false;
			this.button48.Location = new System.Drawing.Point(576, 80);
			this.button48.Name = "button48";
			this.button48.Size = new System.Drawing.Size(10, 10);
			this.button48.TabIndex = 229;
			this.button48.TabStop = false;
			// 
			// yemlik3
			// 
			this.yemlik3.Image = ((System.Drawing.Image)(resources.GetObject("yemlik3.Image")));
			this.yemlik3.Location = new System.Drawing.Point(40, 136);
			this.yemlik3.Name = "yemlik3";
			this.yemlik3.Size = new System.Drawing.Size(16, 16);
			this.yemlik3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik3.TabIndex = 230;
			this.yemlik3.TabStop = false;
			// 
			// button49
			// 
			this.button49.BackColor = System.Drawing.Color.DodgerBlue;
			this.button49.Enabled = false;
			this.button49.Location = new System.Drawing.Point(56, 480);
			this.button49.Name = "button49";
			this.button49.Size = new System.Drawing.Size(10, 10);
			this.button49.TabIndex = 231;
			this.button49.TabStop = false;
			// 
			// button50
			// 
			this.button50.BackColor = System.Drawing.Color.DodgerBlue;
			this.button50.Enabled = false;
			this.button50.Location = new System.Drawing.Point(72, 344);
			this.button50.Name = "button50";
			this.button50.Size = new System.Drawing.Size(10, 10);
			this.button50.TabIndex = 232;
			this.button50.TabStop = false;
			// 
			// button51
			// 
			this.button51.BackColor = System.Drawing.Color.DodgerBlue;
			this.button51.Enabled = false;
			this.button51.Location = new System.Drawing.Point(136, 616);
			this.button51.Name = "button51";
			this.button51.Size = new System.Drawing.Size(10, 10);
			this.button51.TabIndex = 233;
			this.button51.TabStop = false;
			// 
			// button52
			// 
			this.button52.BackColor = System.Drawing.Color.DodgerBlue;
			this.button52.Enabled = false;
			this.button52.Location = new System.Drawing.Point(464, 368);
			this.button52.Name = "button52";
			this.button52.Size = new System.Drawing.Size(10, 10);
			this.button52.TabIndex = 234;
			this.button52.TabStop = false;
			// 
			// button53
			// 
			this.button53.BackColor = System.Drawing.Color.DodgerBlue;
			this.button53.Enabled = false;
			this.button53.Location = new System.Drawing.Point(496, 464);
			this.button53.Name = "button53";
			this.button53.Size = new System.Drawing.Size(10, 10);
			this.button53.TabIndex = 237;
			this.button53.TabStop = false;
			// 
			// button55
			// 
			this.button55.BackColor = System.Drawing.Color.DodgerBlue;
			this.button55.Enabled = false;
			this.button55.Location = new System.Drawing.Point(528, 592);
			this.button55.Name = "button55";
			this.button55.Size = new System.Drawing.Size(10, 10);
			this.button55.TabIndex = 235;
			this.button55.TabStop = false;
			// 
			// button56
			// 
			this.button56.BackColor = System.Drawing.Color.DodgerBlue;
			this.button56.Enabled = false;
			this.button56.Location = new System.Drawing.Point(160, 376);
			this.button56.Name = "button56";
			this.button56.Size = new System.Drawing.Size(10, 10);
			this.button56.TabIndex = 240;
			this.button56.TabStop = false;
			// 
			// button57
			// 
			this.button57.BackColor = System.Drawing.Color.DodgerBlue;
			this.button57.Enabled = false;
			this.button57.Location = new System.Drawing.Point(272, 432);
			this.button57.Name = "button57";
			this.button57.Size = new System.Drawing.Size(10, 10);
			this.button57.TabIndex = 239;
			this.button57.TabStop = false;
			// 
			// button58
			// 
			this.button58.BackColor = System.Drawing.Color.DodgerBlue;
			this.button58.Enabled = false;
			this.button58.Location = new System.Drawing.Point(312, 336);
			this.button58.Name = "button58";
			this.button58.Size = new System.Drawing.Size(10, 10);
			this.button58.TabIndex = 238;
			this.button58.TabStop = false;
			// 
			// button59
			// 
			this.button59.BackColor = System.Drawing.Color.DodgerBlue;
			this.button59.Enabled = false;
			this.button59.Location = new System.Drawing.Point(192, 152);
			this.button59.Name = "button59";
			this.button59.Size = new System.Drawing.Size(10, 10);
			this.button59.TabIndex = 241;
			this.button59.TabStop = false;
			// 
			// button46
			// 
			this.button46.BackColor = System.Drawing.Color.DodgerBlue;
			this.button46.Enabled = false;
			this.button46.Location = new System.Drawing.Point(656, 40);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(10, 10);
			this.button46.TabIndex = 244;
			this.button46.TabStop = false;
			// 
			// button54
			// 
			this.button54.BackColor = System.Drawing.Color.DodgerBlue;
			this.button54.Enabled = false;
			this.button54.Location = new System.Drawing.Point(392, 120);
			this.button54.Name = "button54";
			this.button54.Size = new System.Drawing.Size(10, 10);
			this.button54.TabIndex = 243;
			this.button54.TabStop = false;
			// 
			// button60
			// 
			this.button60.BackColor = System.Drawing.Color.DodgerBlue;
			this.button60.Enabled = false;
			this.button60.Location = new System.Drawing.Point(800, 80);
			this.button60.Name = "button60";
			this.button60.Size = new System.Drawing.Size(10, 10);
			this.button60.TabIndex = 242;
			this.button60.TabStop = false;
			// 
			// button61
			// 
			this.button61.BackColor = System.Drawing.Color.DodgerBlue;
			this.button61.Enabled = false;
			this.button61.Location = new System.Drawing.Point(304, 96);
			this.button61.Name = "button61";
			this.button61.Size = new System.Drawing.Size(10, 10);
			this.button61.TabIndex = 245;
			this.button61.TabStop = false;
			// 
			// yemlik4
			// 
			this.yemlik4.Image = ((System.Drawing.Image)(resources.GetObject("yemlik4.Image")));
			this.yemlik4.Location = new System.Drawing.Point(712, 120);
			this.yemlik4.Name = "yemlik4";
			this.yemlik4.Size = new System.Drawing.Size(16, 16);
			this.yemlik4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik4.TabIndex = 246;
			this.yemlik4.TabStop = false;
			// 
			// button62
			// 
			this.button62.BackColor = System.Drawing.Color.DodgerBlue;
			this.button62.Enabled = false;
			this.button62.Location = new System.Drawing.Point(640, 160);
			this.button62.Name = "button62";
			this.button62.Size = new System.Drawing.Size(10, 10);
			this.button62.TabIndex = 247;
			this.button62.TabStop = false;
			// 
			// button63
			// 
			this.button63.BackColor = System.Drawing.Color.DodgerBlue;
			this.button63.Enabled = false;
			this.button63.Location = new System.Drawing.Point(952, 480);
			this.button63.Name = "button63";
			this.button63.Size = new System.Drawing.Size(10, 10);
			this.button63.TabIndex = 248;
			this.button63.TabStop = false;
			// 
			// button64
			// 
			this.button64.BackColor = System.Drawing.Color.DodgerBlue;
			this.button64.Enabled = false;
			this.button64.Location = new System.Drawing.Point(680, 592);
			this.button64.Name = "button64";
			this.button64.Size = new System.Drawing.Size(10, 10);
			this.button64.TabIndex = 249;
			this.button64.TabStop = false;
			// 
			// button65
			// 
			this.button65.BackColor = System.Drawing.Color.DodgerBlue;
			this.button65.Enabled = false;
			this.button65.Location = new System.Drawing.Point(384, 232);
			this.button65.Name = "button65";
			this.button65.Size = new System.Drawing.Size(10, 10);
			this.button65.TabIndex = 250;
			this.button65.TabStop = false;
			// 
			// gin
			// 
			this.gin.Image = ((System.Drawing.Image)(resources.GetObject("gin.Image")));
			this.gin.Location = new System.Drawing.Point(24, 5);
			this.gin.Name = "gin";
			this.gin.Size = new System.Drawing.Size(30, 30);
			this.gin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.gin.TabIndex = 251;
			this.gin.TabStop = false;
			this.gin.Visible = false;
			// 
			// breakTime
			// 
			this.breakTime.BackColor = System.Drawing.Color.DarkViolet;
			this.breakTime.Enabled = false;
			this.breakTime.Location = new System.Drawing.Point(64, 16);
			this.breakTime.Name = "breakTime";
			this.breakTime.Size = new System.Drawing.Size(100, 8);
			this.breakTime.TabIndex = 252;
			this.breakTime.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 500;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Interval = 800;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// timer4
			// 
			this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
			// 
			// timer5
			// 
			this.timer5.Interval = 150;
			this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
			// 
			// timer6
			// 
			this.timer6.Interval = 130;
			this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
			// 
			// timer7
			// 
			this.timer7.Interval = 80;
			this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
			// 
			// monster
			// 
			this.monster.Image = ((System.Drawing.Image)(resources.GetObject("monster.Image")));
			this.monster.Location = new System.Drawing.Point(872, 240);
			this.monster.Name = "monster";
			this.monster.Size = new System.Drawing.Size(40, 40);
			this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster.TabIndex = 253;
			this.monster.TabStop = false;
			// 
			// monster2
			// 
			this.monster2.Image = ((System.Drawing.Image)(resources.GetObject("monster2.Image")));
			this.monster2.Location = new System.Drawing.Point(536, 312);
			this.monster2.Name = "monster2";
			this.monster2.Size = new System.Drawing.Size(40, 40);
			this.monster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster2.TabIndex = 254;
			this.monster2.TabStop = false;
			// 
			// monster4
			// 
			this.monster4.Image = ((System.Drawing.Image)(resources.GetObject("monster4.Image")));
			this.monster4.Location = new System.Drawing.Point(648, 80);
			this.monster4.Name = "monster4";
			this.monster4.Size = new System.Drawing.Size(40, 40);
			this.monster4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster4.TabIndex = 255;
			this.monster4.TabStop = false;
			// 
			// monster3
			// 
			this.monster3.Image = ((System.Drawing.Image)(resources.GetObject("monster3.Image")));
			this.monster3.Location = new System.Drawing.Point(136, 128);
			this.monster3.Name = "monster3";
			this.monster3.Size = new System.Drawing.Size(30, 30);
			this.monster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster3.TabIndex = 257;
			this.monster3.TabStop = false;
			// 
			// lblCin
			// 
			this.lblCin.Enabled = false;
			this.lblCin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCin.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCin.Location = new System.Drawing.Point(6, 13);
			this.lblCin.Name = "lblCin";
			this.lblCin.Size = new System.Drawing.Size(20, 14);
			this.lblCin.TabIndex = 258;
			this.lblCin.Text = "0X";
			this.lblCin.Visible = false;
			// 
			// timer8
			// 
			this.timer8.Interval = 200;
			this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(24, 112);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(8, 16);
			this.pictureBox4.TabIndex = 259;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			// 
			// lblCin2
			// 
			this.lblCin2.Enabled = false;
			this.lblCin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCin2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCin2.Location = new System.Drawing.Point(185, 13);
			this.lblCin2.Name = "lblCin2";
			this.lblCin2.Size = new System.Drawing.Size(20, 14);
			this.lblCin2.TabIndex = 261;
			this.lblCin2.Text = "X0";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(165, 10);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(20, 20);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 260;
			this.pictureBox5.TabStop = false;
			// 
			// button66
			// 
			this.button66.BackColor = System.Drawing.Color.DodgerBlue;
			this.button66.Enabled = false;
			this.button66.Location = new System.Drawing.Point(288, 520);
			this.button66.Name = "button66";
			this.button66.Size = new System.Drawing.Size(10, 10);
			this.button66.TabIndex = 264;
			this.button66.TabStop = false;
			// 
			// button67
			// 
			this.button67.BackColor = System.Drawing.Color.DodgerBlue;
			this.button67.Enabled = false;
			this.button67.Location = new System.Drawing.Point(376, 600);
			this.button67.Name = "button67";
			this.button67.Size = new System.Drawing.Size(10, 10);
			this.button67.TabIndex = 263;
			this.button67.TabStop = false;
			// 
			// button15
			// 
			this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
			this.button15.Enabled = false;
			this.button15.Location = new System.Drawing.Point(856, 16);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(16, 64);
			this.button15.TabIndex = 265;
			// 
			// button18
			// 
			this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
			this.button18.Enabled = false;
			this.button18.Location = new System.Drawing.Point(704, 176);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(168, 16);
			this.button18.TabIndex = 266;
			// 
			// button68
			// 
			this.button68.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button68.BackgroundImage")));
			this.button68.Enabled = false;
			this.button68.Location = new System.Drawing.Point(704, 192);
			this.button68.Name = "button68";
			this.button68.Size = new System.Drawing.Size(16, 136);
			this.button68.TabIndex = 269;
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(856, 152);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(16, 24);
			this.button3.TabIndex = 270;
			// 
			// button6
			// 
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(576, 400);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(16, 72);
			this.button6.TabIndex = 271;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(552, 400);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(24, 16);
			this.button7.TabIndex = 272;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(264, 40);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(24, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 273;
			this.pictureBox6.TabStop = false;
			// 
			// button28
			// 
			this.button28.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button28.BackgroundImage")));
			this.button28.Enabled = false;
			this.button28.Location = new System.Drawing.Point(200, 376);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(84, 16);
			this.button28.TabIndex = 275;
			// 
			// button30
			// 
			this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
			this.button30.Enabled = false;
			this.button30.Location = new System.Drawing.Point(200, 280);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(16, 96);
			this.button30.TabIndex = 276;
			// 
			// button69
			// 
			this.button69.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button69.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button69.BackgroundImage")));
			this.button69.Enabled = false;
			this.button69.Location = new System.Drawing.Point(216, 280);
			this.button69.Name = "button69";
			this.button69.Size = new System.Drawing.Size(136, 16);
			this.button69.TabIndex = 277;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(352, 280);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(16, 184);
			this.button1.TabIndex = 278;
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
			this.button20.Enabled = false;
			this.button20.Location = new System.Drawing.Point(120, 464);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(248, 16);
			this.button20.TabIndex = 279;
			// 
			// button24
			// 
			this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
			this.button24.Enabled = false;
			this.button24.Location = new System.Drawing.Point(104, 208);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(16, 272);
			this.button24.TabIndex = 280;
			// 
			// button33
			// 
			this.button33.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button33.BackgroundImage")));
			this.button33.Enabled = false;
			this.button33.Location = new System.Drawing.Point(104, 192);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(160, 16);
			this.button33.TabIndex = 281;
			// 
			// button70
			// 
			this.button70.BackColor = System.Drawing.Color.Transparent;
			this.button70.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button70.BackgroundImage")));
			this.button70.Enabled = false;
			this.button70.Location = new System.Drawing.Point(264, 192);
			this.button70.Name = "button70";
			this.button70.Size = new System.Drawing.Size(64, 16);
			this.button70.TabIndex = 282;
			// 
			// monster5
			// 
			this.monster5.Image = ((System.Drawing.Image)(resources.GetObject("monster5.Image")));
			this.monster5.Location = new System.Drawing.Point(536, 528);
			this.monster5.Name = "monster5";
			this.monster5.Size = new System.Drawing.Size(40, 40);
			this.monster5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster5.TabIndex = 283;
			this.monster5.TabStop = false;
			// 
			// timer9
			// 
			this.timer9.Interval = 200;
			this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
			// 
			// lblOs2
			// 
			this.lblOs2.Enabled = false;
			this.lblOs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblOs2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblOs2.Location = new System.Drawing.Point(185, 71);
			this.lblOs2.Name = "lblOs2";
			this.lblOs2.Size = new System.Drawing.Size(20, 14);
			this.lblOs2.TabIndex = 285;
			this.lblOs2.Text = "X0";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(165, 68);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(20, 20);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 284;
			this.pictureBox7.TabStop = false;
			// 
			// lblOs
			// 
			this.lblOs.Enabled = false;
			this.lblOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblOs.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblOs.Location = new System.Drawing.Point(6, 13);
			this.lblOs.Name = "lblOs";
			this.lblOs.Size = new System.Drawing.Size(20, 14);
			this.lblOs.TabIndex = 288;
			this.lblOs.Text = "0X";
			this.lblOs.Visible = false;
			// 
			// ostime
			// 
			this.ostime.BackColor = System.Drawing.Color.Chocolate;
			this.ostime.Enabled = false;
			this.ostime.Location = new System.Drawing.Point(64, 16);
			this.ostime.Name = "ostime";
			this.ostime.Size = new System.Drawing.Size(100, 8);
			this.ostime.TabIndex = 287;
			this.ostime.Visible = false;
			// 
			// osuruk
			// 
			this.osuruk.Image = ((System.Drawing.Image)(resources.GetObject("osuruk.Image")));
			this.osuruk.Location = new System.Drawing.Point(24, 5);
			this.osuruk.Name = "osuruk";
			this.osuruk.Size = new System.Drawing.Size(30, 30);
			this.osuruk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.osuruk.TabIndex = 286;
			this.osuruk.TabStop = false;
			this.osuruk.Visible = false;
			// 
			// timer10
			// 
			this.timer10.Interval = 200;
			this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(40, 112);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(8, 16);
			this.pictureBox8.TabIndex = 289;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Visible = false;
			// 
			// Level4
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1008, 654);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.lblOs);
			this.Controls.Add(this.ostime);
			this.Controls.Add(this.osuruk);
			this.Controls.Add(this.lblOs2);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.monster5);
			this.Controls.Add(this.button70);
			this.Controls.Add(this.button33);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button69);
			this.Controls.Add(this.button30);
			this.Controls.Add(this.button28);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button68);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button66);
			this.Controls.Add(this.button67);
			this.Controls.Add(this.lblCin2);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.lblCin);
			this.Controls.Add(this.monster4);
			this.Controls.Add(this.monster3);
			this.Controls.Add(this.monster2);
			this.Controls.Add(this.monster);
			this.Controls.Add(this.breakTime);
			this.Controls.Add(this.gin);
			this.Controls.Add(this.button65);
			this.Controls.Add(this.button64);
			this.Controls.Add(this.button63);
			this.Controls.Add(this.button62);
			this.Controls.Add(this.yemlik4);
			this.Controls.Add(this.button61);
			this.Controls.Add(this.button46);
			this.Controls.Add(this.button54);
			this.Controls.Add(this.button60);
			this.Controls.Add(this.button59);
			this.Controls.Add(this.button56);
			this.Controls.Add(this.button57);
			this.Controls.Add(this.button58);
			this.Controls.Add(this.button53);
			this.Controls.Add(this.button55);
			this.Controls.Add(this.button52);
			this.Controls.Add(this.button51);
			this.Controls.Add(this.button50);
			this.Controls.Add(this.button49);
			this.Controls.Add(this.yemlik3);
			this.Controls.Add(this.button48);
			this.Controls.Add(this.button45);
			this.Controls.Add(this.button44);
			this.Controls.Add(this.button43);
			this.Controls.Add(this.button41);
			this.Controls.Add(this.button42);
			this.Controls.Add(this.button40);
			this.Controls.Add(this.yemlik2);
			this.Controls.Add(this.button38);
			this.Controls.Add(this.button36);
			this.Controls.Add(this.button37);
			this.Controls.Add(this.button35);
			this.Controls.Add(this.button34);
			this.Controls.Add(this.yemlik1);
			this.Controls.Add(this.button31);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button29);
			this.Controls.Add(this.button26);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPara);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lblCani);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblYemlik);
			this.Controls.Add(this.imgSiren);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nitro);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button32);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button27);
			this.Controls.Add(this.cikisDuvari);
			this.Controls.Add(this.Boman);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Cikis);
			this.Name = "Level4";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Level4";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level4_KeyDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Level4_Closing);
			this.Load += new System.EventHandler(this.Level4_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level4_KeyUp);
			this.ResumeLayout(false);

		}
		#endregion

		public  Hashtable htable;
		Over frmOver;

		int Cin;
		int Osuruk;
		double Money;
		int yemlik;
		int intbomb;
		int Hak;
		private void Level4_Load(object sender, System.EventArgs e)
		{
			htable=new Hashtable();
			htable["monster"]="";
			htable["monster2"]="";
			htable["monster3"]="";
			htable["monster4"]="";
			htable["monster5"]="";
			htable["smonster"]="";
			htable["smonster2"]="";
			htable["smonster3"]="";
			htable["smonster4"]="";
			htable["smonster5"]="";
			timer3.Start();
		}

		Path rotate;
		Direction go;
		
		Keys dir,dir2,dir3,dir4,dir5;
		//monster
		int xkBak=0;
		int xbBak=0;
		int ykBak=0;
		int ybBak=0;
		int xkilk=0;
		int xbilk=0;
		int ykilk=0;
		int ybilk=0;
		int intKere=0;
		//-----------------
		//monster2
		int xkBak2=0;
		int xbBak2=0;
		int ykBak2=0;
		int ybBak2=0;
		int xkilk2=0;
		int xbilk2=0;
		int ykilk2=0;
		int ybilk2=0;
		int intKere2=0;
		//-----------------
		//monster2
		int xkBak3=0;
		int xbBak3=0;
		int ykBak3=0;
		int ybBak3=0;
		int xkilk3=0;
		int xbilk3=0;
		int ykilk3=0;
		int ybilk3=0;
		int intKere3=0;
		//-----------------
		//monster4
		int xkBak4=0;
		int xbBak4=0;
		int ykBak4=0;
		int ybBak4=0;
		int xkilk4=0;
		int xbilk4=0;
		int ykilk4=0;
		int ybilk4=0;
		int intKere4=0;
		//-----------------
		//monster5
		int xkBak5=0;
		int xbBak5=0;
		int ykBak5=0;
		int ybBak5=0;
		int xkilk5=0;
		int xbilk5=0;
		int ykilk5=0;
		int ybilk5=0;
		int intKere5=0;
		//-----------------

		int kere=0,kere2=0,kere3,kere4=0,kere5=0;
		public void kapat()
		{
			/*if(over==true)
			{
				over=false;
			}
			else
			{
				over=true;
			}*/
			timer1.Stop();
			timer3.Stop();
			timer5.Stop();
			timer4.Stop();
			timer6.Stop();
			timer7.Stop();
			timer9.Stop();
			timer2.Stop();
			//if(over==true)
			//{
			if(frmOver==null)
			{
				this.Dispose();
				this.Close();
				frmOver=new Over(this);
				frmOver.Show();
			}
			//}
		}
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(nitro.Width>=2)
			{
				nitro.Width-=2;
			}
		}

		private void timer2_Tick(object sender, System.EventArgs e)
		{
			if((nitro.Width+2)<=75)
			{
				nitro.Width +=2;
			}
		}

		int i=4;
		private void timer3_Tick(object sender, System.EventArgs e)
		{
			if(i==4)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\aoogah.wav";
				Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOSTOP);
			}

			i-=1;
			if(i==0)
			{
				label2.Text="Git";
			}
			if(i<0)
			{
				timer3.Stop();
				label2.Visible=false;

				rotate=new Path();
				go=new Direction();
				this.Focus();
				timer4.Start();
				timer5.Start();
				timer6.Start();
				timer7.Start();
				timer9.Start();
			}
			if(i>0)
				label2.Text =i.ToString();
		}

		private void Level4_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}

		private void Level4_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(label2.Visible!=true)
			{
				if(e.KeyCode==Keys.D1 && Cin>0 && (nitro.Visible==true || ostime.Visible==true))//cin için
				{
					string str=Application.StartupPath.ToString()+"\\sound\\evil_laf.wav";
					Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
					
					if(nitro.Visible==true)
					{
						label1.Visible=false;
						nitro.Visible=false;
					}
					
					if(ostime.Visible==true)
					{
						if(Osuruk>0)
						{
							ostime.Width=100;
						}
						ostime.Visible=false;
						lblOs.Visible=false;
						osuruk.Visible=false;
						lblOs.Text=Osuruk.ToString()+"X";
						lblOs2.Text="X"+Osuruk.ToString();
						timer10.Stop();
					}

					breakTime.Visible=true;
					lblCin.Visible=true;
					gin.Visible=true;
					Cin--;
					lblCin.Text=Cin.ToString()+"X";
					lblCin2.Text="X"+Cin.ToString();
					System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
					this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));	
					this.Boman.Size = new System.Drawing.Size(41, 41);
					this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
     		
					timer8.Start();
				}
				else if(e.KeyCode==Keys.D1 && Boman.Width==41)
				{
					if(Cin>0)
					{
						breakTime.Width=100;
					}
					string str=Application.StartupPath.ToString()+"\\sound\\SOUND53.wav";
					Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
					label1.Visible=true;
					nitro.Visible=true;
					breakTime.Visible=false;
					lblCin.Visible=false;
					gin.Visible=false;
					lblCin.Text=Cin.ToString()+"X";
					lblCin2.Text="X"+Cin.ToString();
					System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
					this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));	
					this.Boman.Size = new System.Drawing.Size(40, 40);
					this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
     		
					timer8.Stop();
				}
				if(e.KeyCode==Keys.D2 && Osuruk>0 && (nitro.Visible==true || breakTime.Visible==true))//osuruk için
				{
					string str=Application.StartupPath.ToString()+"\\sound\\SOUND54.wav";
					Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
					
					if(nitro.Visible==true)
					{
						label1.Visible=false;
						nitro.Visible=false;
					}
					if(breakTime.Visible==true)
					{
						if(Cin>0)
						{
							breakTime.Width=100;
						}
						breakTime.Visible=false;
						lblCin.Visible=false;
						gin.Visible=false;
						lblCin.Text=Cin.ToString()+"X";
						lblCin2.Text="X"+Cin.ToString();
						timer8.Stop();
					}
					ostime.Visible=true;
					lblOs.Visible=true;
					osuruk.Visible=true;
					Osuruk--;
					lblOs.Text=Osuruk.ToString()+"X";
					lblOs2.Text="X"+Osuruk.ToString();
					System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
					this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));	
					this.Boman.Size = new System.Drawing.Size(39, 39);
					this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
     		
					timer10.Start();
				}
				else if(e.KeyCode==Keys.D2 && Boman.Width==39)
				{
					if(Osuruk>0)
					{
						ostime.Width=100;
					}
					string str=Application.StartupPath.ToString()+"\\sound\\SOUND53.wav";
					Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
					label1.Visible=true;
					nitro.Visible=true;
					ostime.Visible=false;
					lblOs.Visible=false;
					osuruk.Visible=false;
					lblOs.Text=Osuruk.ToString()+"X";
					lblOs2.Text="X"+Osuruk.ToString();
					System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
					this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));	
					this.Boman.Size = new System.Drawing.Size(40, 40);
					this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
     		
					timer10.Stop();
				}

				Nitro nityol=Nitro.Yok;
				if(nitro.Width<=1)
				{
					nityol=Nitro.Yok;
				}
				if(e.Shift==true && Boman.Width==40)
				{
					timer2.Stop();
					timer1.Start();
					if(nitro.Width>1)
					{
						string str=Application.StartupPath.ToString()+"\\sound\\zart.wav";
						Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOSTOP);
						nityol=Nitro.Var;
					}
				}
				else
				{
					timer1.Stop();
					timer2.Start();
					nityol=Nitro.Yok;
				}
				//heal ý almak için arka fonu deðiþiyo
				if(Boman.Location.X<=288 && Boman.Location.Y>=40)
				{
					if((Math.Abs(Boman.Location.X-278)<=40 && Math.Abs(Boman.Location.Y-56)<=40))
					{
						if(pictureBox6.Visible==true)
						{
							string str=Application.StartupPath.ToString()+"\\sound\\SOUND240.wav";
							Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
							nitro.Width=80;
						}
						pictureBox6.Visible=false;
					}
				}
				//bitti------------
				
				int oncekiHak=Hak;
				go.Move(e,Boman,this,ref Money,nityol,new int[]{16,576,72,576}, new int[]{912, 56},ref Hak,ref yemlik,ref intbomb,"FormBoss",Exit,htable,"down");
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				//label4.Text=Boman.Location.X+"-"+Boman.Location.Y;
				if(Hak==0)
				{	
					kapat();
				
				}
				else if(oncekiHak>Hak)
				{
					if(breakTime.Visible==true)
					{
						if(Cin>0)
						{
							breakTime.Width=100;
						}
						breakTime.Visible=false;
						lblCin.Visible=false;
						gin.Visible=false;
						lblCin.Text=Cin.ToString()+"X";
						lblCin2.Text="X"+Cin.ToString();
						timer8.Stop();
					}
					if(ostime.Visible==true)
					{
						if(Osuruk>0)
						{
							ostime.Width=100;
						}
						ostime.Visible=false;
						lblOs.Visible=false;
						osuruk.Visible=false;
						lblOs.Text=Osuruk.ToString()+"X";
						lblOs2.Text="X"+Osuruk.ToString();
						timer10.Stop();
					}
					label1.Visible=true;
					nitro.Visible=true;
					System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
					this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));	
					this.Boman.Size = new System.Drawing.Size(40, 40);
					this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
     		
				
				}
				if(e.KeyCode==Keys.Escape)
				{
					timer1.Stop();
					timer2.Stop();
					timer3.Stop();
					timer4.Stop();
					timer5.Stop();
					timer6.Stop();
					timer7.Stop();
					timer9.Stop();
					if(MessageBox.Show("Çýkmak istediðinize eminmisiniz","Çýkýþ",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK)
					{
						this.Dispose();
						this.Close();
						Giris frm=new Giris();
						frm.Show();
					}
					else
					{
						timer1.Start();
						timer2.Start();
						timer3.Start();
						timer4.Start();
						timer5.Start();
						timer6.Start();
						timer7.Start();
						timer9.Start();
					
					}
				}
				if(e.KeyCode==Keys.D)
				{
					timer1.Stop();
					timer2.Stop();
					timer3.Stop();
					timer4.Stop();
					timer5.Stop();
					timer6.Stop();
					timer7.Stop();
					timer9.Stop();
					
					if(MessageBox.Show("Duraklat","Due",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
					{	
						timer1.Start();
						timer2.Start();
						timer3.Start();
						timer4.Start();
						timer5.Start();
						timer6.Start();
						timer7.Start();
						timer9.Start();
					}
				}
			}
		}

		private void timer4_Tick(object sender, System.EventArgs e)
		{
			if(htable["monster"].ToString()!="")
			{
				label3.Text=htable["monster"].ToString();
				imgSiren.Visible=true;
			}
			else if(htable["monster2"].ToString()!="")
			{
				label3.Text=htable["monster2"].ToString();
				imgSiren.Visible=true;
			}
			else if(htable["monster3"].ToString()!="")
			{
				label3.Text=htable["monster3"].ToString();
				imgSiren.Visible=true;
			}
			else if(htable["monster4"].ToString()!="")
			{
				label3.Text=htable["monster4"].ToString();
				imgSiren.Visible=true;
			}
			else if(htable["monster5"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster5"].ToString();
			}
			else
			{
				imgSiren.Visible=false;
				label3.Text="";
			}
			

			//label3.Text=yMonster;
			//if(yMonster=="")
			if(htable["monster"].ToString().Trim()=="")
			{
				if(htable["smonster"].ToString().Trim()=="")//sýnýrý aþmamýþsa
				{
					//
					intKere=0;
					xkBak=0;
					xbBak=0;
					ykBak=0;
					ybBak=0;
					//
					Random rnd=new Random();
					int i=rnd.Next(1,5);
					if(i==1)
						dir=Keys.Up;
			
					if(i==2)
						dir=Keys.Down;
			
					if(i==3)
						dir=Keys.Left;
			
					if(i==4)
						dir=Keys.Right;
		
					Nitro nit=Nitro.Yok;
					go.Move(dir,monster,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,872,16,992,528);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
				
					}
				}
				else//sýnýrý aþmýþsa
				{
					go.Boundery(monster,htable,ref dir,xbilk,ybilk,872,240,ref xbBak,ref ybBak,ref xkBak,ref ykBak,ref intKere,872,16,992,528,ref kere);
					Nitro nit=Nitro.Var;
					xbilk=monster.Location.X;
					ybilk=monster.Location.Y;
					go.Move(dir,monster,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,872,16,992,528);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
			}
				//else if(yMonster=="monster")
			else if(htable["monster"].ToString().Trim()=="monster")//takip varsa
			{
				//
				intKere=0;
				xkBak=0;
				xbBak=0;
				ykBak=0;
				ybBak=0;
				//
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					if(monster.Location.X>Boman.Location.X)
					{
						dir=Keys.Left;
					}
					else
					{
						dir=Keys.Right;
					}
				}
				else
				{
					if(monster.Location.Y>Boman.Location.Y)
					{
						dir=Keys.Up;
					}
					else
					{
						dir=Keys.Down;
					}
				}
				Nitro nit=Nitro.Yok;
				go.Move(dir,monster,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,872,16,992,528);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{	
					kapat();
				}
			}
		}

		private void timer5_Tick(object sender, System.EventArgs e)
		{
			if(htable["monster"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster"].ToString();
			}
			else if(htable["monster2"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster2"].ToString();
			}
			else if(htable["monster3"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster3"].ToString();
			}

			else if(htable["monster4"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster4"].ToString();
			}
			else if(htable["monster5"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster5"].ToString();
			}
			else
			{
				imgSiren.Visible=false;
				label3.Text="";
			}
			if(htable["monster2"].ToString().Trim()=="")//takip yoksa
			{
				if(htable["smonster2"].ToString().Trim()=="")//sýnýrý aþmamýþsa
				{

					//
					intKere2=0;
					xkBak2=0;
					xbBak2=0;
					ykBak2=0;
					ybBak2=0;
					//
					Random rnd=new Random();
					int i=rnd.Next(1,5);
					if(i==1)
						dir=Keys.Up;
			
					if(i==2)
						dir=Keys.Down;
			
					if(i==3)
						dir=Keys.Left;
			
					if(i==4)
						dir=Keys.Right;
		
					Nitro nit=Nitro.Yok;
					go.Move(dir,monster2,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,368,174,856,528);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
				else//sýnýrý aþmýþsa
				{
					go.Boundery(monster2,htable,ref dir2,xbilk2,ybilk2,536,312,ref xbBak2,ref ybBak2,ref xkBak2,ref ykBak2,ref intKere2,368,174,856,528,ref kere2);
					Nitro nit=Nitro.Var;
					xbilk2=monster2.Location.X;
					ybilk2=monster2.Location.Y;
					go.Move(dir2,monster2,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,368,174,856,528);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
			}
				//else if(yMonster=="monster2")
			else if(htable["monster2"].ToString().Trim()=="monster2")//takip varsa
			{
				//
				intKere2=0;
				xkBak2=0;
				xbBak2=0;
				ykBak2=0;
				ybBak2=0;
				//
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					if(monster2.Location.X>Boman.Location.X)
					{
						dir=Keys.Left;
					}
					else
					{
						dir=Keys.Right;
					}
				}
				else
				{
					if(monster2.Location.Y>Boman.Location.Y)
					{
						dir=Keys.Up;
					}
					else
					{
						dir=Keys.Down;
					}
				}
				Nitro nit=Nitro.Yok;
				go.Move(dir,monster2,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,368,174,856,528);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{
					kapat();
				}
			}
		}

		private void timer6_Tick(object sender, System.EventArgs e)
		{
			if(htable["monster"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster"].ToString();
			}
			else if(htable["monster2"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster2"].ToString();
			}
			else if(htable["monster3"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster3"].ToString();
			}

			else if(htable["monster4"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster4"].ToString();
			}
			else if(htable["monster5"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster5"].ToString();
			}
			else
			{
				imgSiren.Visible=false;
				label3.Text="";
			}
			if(htable["monster3"].ToString().Trim()=="")
			{
				if(htable["smonster3"].ToString().Trim()=="")//sýnýrý aþmamýþsa
				{

					//
					intKere3=0;
					xkBak3=0;
					xbBak3=0;
					ykBak3=0;
					ybBak3=0;
					//
					Random rnd=new Random();
					int i=rnd.Next(1,5);
					if(i==1)
						dir=Keys.Up;
			
					if(i==2)
						dir=Keys.Down;
			
					if(i==3)
						dir=Keys.Left;
			
					if(i==4)
						dir=Keys.Right;
		
					Nitro nit=Nitro.Yok;
					go.Move(dir,monster3,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,16,328,192);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
				else
				{
					go.Boundery(monster3,htable,ref dir3,xbilk3,ybilk3,136,128,ref xbBak3,ref ybBak3,ref xkBak3,ref ykBak3,ref intKere3,16,16,328,192,ref kere3);//sýnýrý aþmýþsa
					Nitro nit=Nitro.Var;
					xbilk3=monster3.Location.X;
					ybilk3=monster3.Location.Y;
					go.Move(dir3,monster3,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,16,328,192);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
			}
				//else if(yMonster=="monster3")
			else if(htable["monster3"].ToString().Trim()=="monster3")//takip varsa
			{
				//
				intKere3=0;
				xkBak3=0;
				xbBak3=0;
				ykBak3=0;
				ybBak3=0;
				//
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					if(monster3.Location.X>Boman.Location.X)
					{
						dir=Keys.Left;
					}
					else
					{
						dir=Keys.Right;
					}
				}
				else
				{
					if(monster3.Location.Y>Boman.Location.Y)
					{
						dir=Keys.Up;
					}
					else
					{
						dir=Keys.Down;
					}
				}
				Nitro nit=Nitro.Yok;
				go.Move(dir,monster3,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,16,328,192);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{
					kapat();
				}
			}
		}

		private void timer7_Tick(object sender, System.EventArgs e)
		{
			if(htable["monster"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster"].ToString();
			}
			else if(htable["monster2"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster2"].ToString();
			}
			else if(htable["monster3"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster3"].ToString();
			}

			else if(htable["monster4"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster4"].ToString();
			}
			else if(htable["monster5"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster5"].ToString();
			}
			else
			{
				imgSiren.Visible=false;
				label3.Text="";
			}
			if(htable["monster4"].ToString().Trim()=="")
			{
				if(htable["smonster4"].ToString().Trim()=="")//sýnýrý aþmamýþsa
				{

					//
					intKere4=0;
					xkBak4=0;
					xbBak4=0;
					ykBak4=0;
					ybBak4=0;
					//
					Random rnd=new Random();
					int i=rnd.Next(1,5);
					if(i==1)
						dir=Keys.Up;
			
					if(i==2)
						dir=Keys.Down;
			
					if(i==3)
						dir=Keys.Left;
			
					if(i==4)
						dir=Keys.Right;
		
					Nitro nit=Nitro.Yok;
					go.Move(dir,monster4,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,344,16,856,192);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
				else
				{
					go.Boundery(monster4,htable,ref dir4,xbilk4,ybilk4,648,80,ref xbBak4,ref ybBak4,ref xkBak4,ref ykBak4,ref intKere4,344,16,856,192,ref kere4);//sýnýrý aþmýþsa
					Nitro nit=Nitro.Var;
					xbilk4=monster4.Location.X;
					ybilk4=monster4.Location.Y;
					go.Move(dir4,monster4,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,344,16,856,192);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
			}
				//else if(yMonster=="monster4")
			else if(htable["monster4"].ToString().Trim()=="monster4")//takip varsa
			{
				//
				intKere4=0;
				xkBak4=0;
				xbBak4=0;
				ykBak4=0;
				ybBak4=0;
				//
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					if(monster4.Location.X>Boman.Location.X)
					{
						dir=Keys.Left;
					}
					else
					{
						dir=Keys.Right;
					}
				}
				else
				{
					if(monster4.Location.Y>Boman.Location.Y)
					{
						dir=Keys.Up;
					}
					else
					{
						dir=Keys.Down;
					}
				}
				Nitro nit=Nitro.Yok;
				go.Move(dir,monster4,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,344,16,856,192);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{
					kapat();
				}
			}
		}

		private void Level4_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Shift==false && Hak>0)
			{
				timer1.Stop();
				timer2.Start();
			}
		}

		private void Exit_VisibleChanged(object sender, System.EventArgs e)
		{
			if(Exit.Visible==true)
			{
				cikisDuvari.Visible=false;
			}
			else
			{
				cikisDuvari.Visible=true;
			}
		}

		private void timer8_Tick(object sender, System.EventArgs e)
		{
			if(breakTime.Width>=2)
			{
				breakTime.Width-=2;
			}
			else
			{
				timer8.Stop();
				if(Cin>0)
				{
					breakTime.Width=100;
				}
				string str=Application.StartupPath.ToString()+"\\sound\\SOUND53.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				label1.Visible=true;
				nitro.Visible=true;
				breakTime.Visible=false;
				lblCin.Visible=false;
				gin.Visible=false;
				lblCin.Text=Cin.ToString()+"X";
				lblCin2.Text="X"+Cin.ToString();
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
				this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));	
				this.Boman.Size = new System.Drawing.Size(40, 40);
				this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;   
			}
		}

		private void timer9_Tick(object sender, System.EventArgs e)
		{
			if(htable["monster"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster"].ToString();
			}
			else if(htable["monster2"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster2"].ToString();
			}
			else if(htable["monster3"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster3"].ToString();
			}

			else if(htable["monster4"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster4"].ToString();
			}
			else if(htable["monster5"].ToString()!="")
			{
				imgSiren.Visible=true;
				label3.Text=htable["monster5"].ToString();
			}
			else
			{
				imgSiren.Visible=false;
				label3.Text="";
			}
			if(htable["monster5"].ToString().Trim()=="")
			{
				if(htable["smonster5"].ToString().Trim()=="")//sýnýrý aþmamýþsa
				{

					//
					intKere5=0;
					xkBak5=0;
					xbBak5=0;
					ykBak5=0;
					ybBak5=0;
					//
					Random rnd=new Random();
					int i=rnd.Next(1,5);
					if(i==1)
						dir=Keys.Up;
			
					if(i==2)
						dir=Keys.Down;
			
					if(i==3)
						dir=Keys.Left;
			
					if(i==4)
						dir=Keys.Right;
		
					Nitro nit=Nitro.Yok;
					go.Move(dir,monster5,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,456,416,744,640);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
				else
				{
					go.Boundery(monster5,htable,ref dir5,xbilk5,ybilk5,536,528,ref xbBak5,ref ybBak5,ref xkBak5,ref ykBak5,ref intKere5,456,416,744,640,ref kere5);//sýnýrý aþmýþsa
					Nitro nit=Nitro.Var;
					xbilk5=monster5.Location.X;
					ybilk5=monster5.Location.Y;
					go.Move(dir5,monster5,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,456,416,744,640);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
			}
				//else if(yMonster=="monster5")
			else if(htable["monster5"].ToString().Trim()=="monster5")//takip varsa
			{
				//
				intKere5=0;
				xkBak5=0;
				xbBak5=0;
				ykBak5=0;
				ybBak5=0;
				//
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					if(monster5.Location.X>Boman.Location.X)
					{
						dir=Keys.Left;
					}
					else
					{
						dir=Keys.Right;
					}
				}
				else
				{
					if(monster5.Location.Y>Boman.Location.Y)
					{
						dir=Keys.Up;
					}
					else
					{
						dir=Keys.Down;
					}
				}
				Nitro nit=Nitro.Yok;
				go.Move(dir,monster5,this,ref Money,nit,new int[]{912,56},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,456,416,744,640);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{
					kapat();
				}
			}
		}

		private void timer10_Tick(object sender, System.EventArgs e)
		{
			if(ostime.Width>=2)
			{
				ostime.Width-=2;
			}
			else
			{
				if(Osuruk>0)
				{
					ostime.Width=100;
				}
				timer10.Stop();
				string str=Application.StartupPath.ToString()+"\\sound\\SOUND53.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				label1.Visible=true;
				nitro.Visible=true;
				ostime.Visible=false;
				lblOs.Visible=false;
				osuruk.Visible=false;
				lblOs.Text=Cin.ToString()+"X";
				lblOs2.Text="X"+Cin.ToString();
				System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level4));
				this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));	
				this.Boman.Size = new System.Drawing.Size(40, 40);
				this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			}
		}
	}
}
