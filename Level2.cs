using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using tonysound;
using System.Threading;

namespace Packman
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Level2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblPara;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lblCani;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblYemlik;
		private System.Windows.Forms.PictureBox imgSiren;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button nitro;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.PictureBox Exit;
		private System.Windows.Forms.PictureBox Boman;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.PictureBox monster;
		private System.Windows.Forms.PictureBox yemlik1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.PictureBox yemlik2;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button42;
		private System.Windows.Forms.Button button45;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button47;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button48;
		private System.Windows.Forms.PictureBox yemlik3;
		private System.Windows.Forms.Button button49;
		private System.Windows.Forms.Button button50;
		private System.Windows.Forms.Button button51;
		private System.Windows.Forms.Button button52;
		private System.Windows.Forms.Button button53;
		private System.Windows.Forms.Button button54;
		private System.Windows.Forms.Button button55;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.Timer timer5;
		private System.ComponentModel.IContainer components;

		public  Hashtable htable;
		Over frmOver;
		//bool over;

		double Money;
		int yemlik;
		int intbomb;
		private System.Windows.Forms.PictureBox monster5;
		private System.Windows.Forms.PictureBox monster3;
		private System.Windows.Forms.PictureBox monster2;
		private System.Windows.Forms.PictureBox monster4;
		private System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.TextBox Cikis;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Timer timer6;
		private System.Windows.Forms.Timer timer7;
		private System.Windows.Forms.PictureBox yemlik4;
		private System.Windows.Forms.Button giris;
		private System.Windows.Forms.Button cikisDuvari;
		private System.Windows.Forms.PictureBox bomb;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label lblBomb;
		private System.Windows.Forms.Timer timer8;
		int Hak;
		public Level2()
		{
			InitializeComponent();
			intbomb=0;
			Money=0;
			yemlik=0;
			Hak=3;
			//over=false;
		}
		public Level2(double dblMoney,int intyemlik,int intHak,Form frm)
		{
			InitializeComponent();
			Money=dblMoney;
			yemlik=intyemlik;
			Hak=intHak;
			//over=false;
			frm.Close();
			frm.Dispose();
			lblPara.Text=Money.ToString()+" YTL";
			lblCani.Text="X"+ Hak.ToString();
			lblYemlik.Text="X"+yemlik.ToString();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level2));
			this.lblPara = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblCani = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblYemlik = new System.Windows.Forms.Label();
			this.imgSiren = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nitro = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button27 = new System.Windows.Forms.Button();
			this.giris = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.PictureBox();
			this.Boman = new System.Windows.Forms.PictureBox();
			this.cikisDuvari = new System.Windows.Forms.Button();
			this.button29 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.monster = new System.Windows.Forms.PictureBox();
			this.yemlik1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.yemlik2 = new System.Windows.Forms.PictureBox();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.monster5 = new System.Windows.Forms.PictureBox();
			this.monster3 = new System.Windows.Forms.PictureBox();
			this.button22 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.button30 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.button34 = new System.Windows.Forms.Button();
			this.button35 = new System.Windows.Forms.Button();
			this.button36 = new System.Windows.Forms.Button();
			this.button37 = new System.Windows.Forms.Button();
			this.button38 = new System.Windows.Forms.Button();
			this.button39 = new System.Windows.Forms.Button();
			this.button40 = new System.Windows.Forms.Button();
			this.button41 = new System.Windows.Forms.Button();
			this.button42 = new System.Windows.Forms.Button();
			this.button45 = new System.Windows.Forms.Button();
			this.button44 = new System.Windows.Forms.Button();
			this.button46 = new System.Windows.Forms.Button();
			this.button47 = new System.Windows.Forms.Button();
			this.monster2 = new System.Windows.Forms.PictureBox();
			this.button25 = new System.Windows.Forms.Button();
			this.button33 = new System.Windows.Forms.Button();
			this.button43 = new System.Windows.Forms.Button();
			this.button48 = new System.Windows.Forms.Button();
			this.yemlik3 = new System.Windows.Forms.PictureBox();
			this.button49 = new System.Windows.Forms.Button();
			this.button50 = new System.Windows.Forms.Button();
			this.button51 = new System.Windows.Forms.Button();
			this.button52 = new System.Windows.Forms.Button();
			this.yemlik4 = new System.Windows.Forms.PictureBox();
			this.button53 = new System.Windows.Forms.Button();
			this.monster4 = new System.Windows.Forms.PictureBox();
			this.button54 = new System.Windows.Forms.Button();
			this.button55 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Cikis = new System.Windows.Forms.TextBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.timer6 = new System.Windows.Forms.Timer(this.components);
			this.timer7 = new System.Windows.Forms.Timer(this.components);
			this.bomb = new System.Windows.Forms.PictureBox();
			this.lblBomb = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.timer8 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblPara
			// 
			this.lblPara.Enabled = false;
			this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblPara.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblPara.Location = new System.Drawing.Point(96, 43);
			this.lblPara.Name = "lblPara";
			this.lblPara.Size = new System.Drawing.Size(72, 14);
			this.lblPara.TabIndex = 72;
			this.lblPara.Text = "0 YTL";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(72, 45);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 11);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 71;
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
			this.lblCani.TabIndex = 70;
			this.lblCani.Text = "X3";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(8, 40);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 69;
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
			this.lblYemlik.TabIndex = 68;
			this.lblYemlik.Text = "X0";
			// 
			// imgSiren
			// 
			this.imgSiren.Image = ((System.Drawing.Image)(resources.GetObject("imgSiren.Image")));
			this.imgSiren.Location = new System.Drawing.Point(8, 56);
			this.imgSiren.Name = "imgSiren";
			this.imgSiren.Size = new System.Drawing.Size(32, 32);
			this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgSiren.TabIndex = 67;
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
			this.label3.TabIndex = 66;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.DarkViolet;
			this.label2.Location = new System.Drawing.Point(328, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 128);
			this.label2.TabIndex = 65;
			this.label2.Text = "3";
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 24);
			this.label1.TabIndex = 64;
			this.label1.Text = "Pilav Üstü Kuru";
			// 
			// nitro
			// 
			this.nitro.BackColor = System.Drawing.Color.DeepPink;
			this.nitro.Enabled = false;
			this.nitro.Location = new System.Drawing.Point(56, 16);
			this.nitro.Name = "nitro";
			this.nitro.Size = new System.Drawing.Size(75, 8);
			this.nitro.TabIndex = 63;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(168, 42);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 73;
			this.pictureBox1.TabStop = false;
			// 
			// button27
			// 
			this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
			this.button27.Enabled = false;
			this.button27.Location = new System.Drawing.Point(560, 0);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(208, 16);
			this.button27.TabIndex = 78;
			// 
			// giris
			// 
			this.giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("giris.BackgroundImage")));
			this.giris.Enabled = false;
			this.giris.Image = ((System.Drawing.Image)(resources.GetObject("giris.Image")));
			this.giris.Location = new System.Drawing.Point(752, 16);
			this.giris.Name = "giris";
			this.giris.Size = new System.Drawing.Size(16, 56);
			this.giris.TabIndex = 77;
			// 
			// Exit
			// 
			this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
			this.Exit.Location = new System.Drawing.Point(24, 312);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(24, 56);
			this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Exit.TabIndex = 76;
			this.Exit.TabStop = false;
			this.Exit.Visible = false;
			this.Exit.VisibleChanged += new System.EventHandler(this.Exit_VisibleChanged);
			// 
			// Boman
			// 
			this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));
			this.Boman.Location = new System.Drawing.Point(712, 32);
			this.Boman.Name = "Boman";
			this.Boman.Size = new System.Drawing.Size(40, 40);
			this.Boman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Boman.TabIndex = 74;
			this.Boman.TabStop = false;
			// 
			// cikisDuvari
			// 
			this.cikisDuvari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.BackgroundImage")));
			this.cikisDuvari.Enabled = false;
			this.cikisDuvari.Image = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.Image")));
			this.cikisDuvari.Location = new System.Drawing.Point(48, 312);
			this.cikisDuvari.Name = "cikisDuvari";
			this.cikisDuvari.Size = new System.Drawing.Size(16, 56);
			this.cikisDuvari.TabIndex = 79;
			// 
			// button29
			// 
			this.button29.BackColor = System.Drawing.Color.DodgerBlue;
			this.button29.Enabled = false;
			this.button29.Location = new System.Drawing.Point(608, 176);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(10, 10);
			this.button29.TabIndex = 85;
			this.button29.TabStop = false;
			// 
			// button23
			// 
			this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
			this.button23.Enabled = false;
			this.button23.Location = new System.Drawing.Point(560, 16);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(16, 184);
			this.button23.TabIndex = 84;
			// 
			// monster
			// 
			this.monster.Image = ((System.Drawing.Image)(resources.GetObject("monster.Image")));
			this.monster.Location = new System.Drawing.Point(72, 176);
			this.monster.Name = "monster";
			this.monster.Size = new System.Drawing.Size(40, 40);
			this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster.TabIndex = 83;
			this.monster.TabStop = false;
			// 
			// yemlik1
			// 
			this.yemlik1.Image = ((System.Drawing.Image)(resources.GetObject("yemlik1.Image")));
			this.yemlik1.Location = new System.Drawing.Point(80, 480);
			this.yemlik1.Name = "yemlik1";
			this.yemlik1.Size = new System.Drawing.Size(16, 16);
			this.yemlik1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik1.TabIndex = 82;
			this.yemlik1.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(560, 200);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(16, 16);
			this.button2.TabIndex = 86;
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(584, 224);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(16, 16);
			this.button3.TabIndex = 87;
			// 
			// button4
			// 
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(568, 216);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(16, 16);
			this.button4.TabIndex = 88;
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(616, 240);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(16, 16);
			this.button5.TabIndex = 90;
			// 
			// button7
			// 
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(600, 232);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(16, 16);
			this.button7.TabIndex = 89;
			// 
			// button8
			// 
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.Enabled = false;
			this.button8.Location = new System.Drawing.Point(448, 296);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(168, 16);
			this.button8.TabIndex = 92;
			// 
			// button9
			// 
			this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
			this.button9.Enabled = false;
			this.button9.Location = new System.Drawing.Point(616, 240);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(16, 72);
			this.button9.TabIndex = 93;
			// 
			// button6
			// 
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(432, 256);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(16, 56);
			this.button6.TabIndex = 94;
			// 
			// button10
			// 
			this.button10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button10.BackgroundImage")));
			this.button10.Enabled = false;
			this.button10.Location = new System.Drawing.Point(376, 128);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(184, 16);
			this.button10.TabIndex = 95;
			// 
			// button11
			// 
			this.button11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button11.BackgroundImage")));
			this.button11.Enabled = false;
			this.button11.Location = new System.Drawing.Point(368, 0);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(192, 16);
			this.button11.TabIndex = 96;
			this.button11.Text = "1";
			// 
			// button12
			// 
			this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
			this.button12.Enabled = false;
			this.button12.Location = new System.Drawing.Point(0, 88);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(224, 16);
			this.button12.TabIndex = 97;
			// 
			// button13
			// 
			this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
			this.button13.Enabled = false;
			this.button13.Location = new System.Drawing.Point(224, 0);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(16, 104);
			this.button13.TabIndex = 98;
			// 
			// yemlik2
			// 
			this.yemlik2.Image = ((System.Drawing.Image)(resources.GetObject("yemlik2.Image")));
			this.yemlik2.Location = new System.Drawing.Point(528, 56);
			this.yemlik2.Name = "yemlik2";
			this.yemlik2.Size = new System.Drawing.Size(16, 16);
			this.yemlik2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik2.TabIndex = 99;
			this.yemlik2.TabStop = false;
			// 
			// button14
			// 
			this.button14.BackColor = System.Drawing.Color.DodgerBlue;
			this.button14.Enabled = false;
			this.button14.Location = new System.Drawing.Point(704, 136);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(10, 10);
			this.button14.TabIndex = 100;
			this.button14.TabStop = false;
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.DodgerBlue;
			this.button15.Enabled = false;
			this.button15.Location = new System.Drawing.Point(584, 32);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(10, 10);
			this.button15.TabIndex = 102;
			this.button15.TabStop = false;
			// 
			// button16
			// 
			this.button16.BackColor = System.Drawing.Color.DodgerBlue;
			this.button16.Enabled = false;
			this.button16.Location = new System.Drawing.Point(608, 352);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(10, 10);
			this.button16.TabIndex = 101;
			this.button16.TabStop = false;
			// 
			// button17
			// 
			this.button17.BackColor = System.Drawing.Color.DodgerBlue;
			this.button17.Enabled = false;
			this.button17.Location = new System.Drawing.Point(440, 48);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(10, 10);
			this.button17.TabIndex = 103;
			this.button17.TabStop = false;
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.DodgerBlue;
			this.button18.Enabled = false;
			this.button18.Location = new System.Drawing.Point(368, 224);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(10, 10);
			this.button18.TabIndex = 104;
			this.button18.TabStop = false;
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.DodgerBlue;
			this.button19.Enabled = false;
			this.button19.Location = new System.Drawing.Point(536, 384);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(10, 10);
			this.button19.TabIndex = 105;
			this.button19.TabStop = false;
			// 
			// button20
			// 
			this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
			this.button20.Enabled = false;
			this.button20.Location = new System.Drawing.Point(752, 72);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(16, 352);
			this.button20.TabIndex = 106;
			// 
			// button21
			// 
			this.button21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button21.BackgroundImage")));
			this.button21.Enabled = false;
			this.button21.Location = new System.Drawing.Point(592, 424);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(176, 16);
			this.button21.TabIndex = 107;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.monster5);
			this.panel1.Location = new System.Drawing.Point(600, 440);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(168, 80);
			this.panel1.TabIndex = 111;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.SystemColors.Control;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(88, -8);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(70, 70);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 110;
			this.pictureBox4.TabStop = false;
			// 
			// monster5
			// 
			this.monster5.BackColor = System.Drawing.SystemColors.Control;
			this.monster5.Image = ((System.Drawing.Image)(resources.GetObject("monster5.Image")));
			this.monster5.Location = new System.Drawing.Point(-128, -144);
			this.monster5.Name = "monster5";
			this.monster5.Size = new System.Drawing.Size(320, 370);
			this.monster5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster5.TabIndex = 112;
			this.monster5.TabStop = false;
			// 
			// monster3
			// 
			this.monster3.Image = ((System.Drawing.Image)(resources.GetObject("monster3.Image")));
			this.monster3.Location = new System.Drawing.Point(480, 356);
			this.monster3.Name = "monster3";
			this.monster3.Size = new System.Drawing.Size(40, 40);
			this.monster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster3.TabIndex = 115;
			this.monster3.TabStop = false;
			// 
			// button22
			// 
			this.button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button22.BackgroundImage")));
			this.button22.Enabled = false;
			this.button22.Location = new System.Drawing.Point(0, 520);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(768, 16);
			this.button22.TabIndex = 116;
			// 
			// button24
			// 
			this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
			this.button24.Enabled = false;
			this.button24.Location = new System.Drawing.Point(376, 256);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(56, 16);
			this.button24.TabIndex = 117;
			// 
			// button26
			// 
			this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
			this.button26.Enabled = false;
			this.button26.Location = new System.Drawing.Point(0, 104);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(16, 192);
			this.button26.TabIndex = 118;
			// 
			// button28
			// 
			this.button28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button28.BackgroundImage")));
			this.button28.Enabled = false;
			this.button28.Location = new System.Drawing.Point(0, 296);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(64, 16);
			this.button28.TabIndex = 119;
			// 
			// button30
			// 
			this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
			this.button30.Enabled = false;
			this.button30.Location = new System.Drawing.Point(0, 368);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(40, 16);
			this.button30.TabIndex = 120;
			// 
			// button31
			// 
			this.button31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button31.BackgroundImage")));
			this.button31.Enabled = false;
			this.button31.Location = new System.Drawing.Point(240, 0);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(128, 16);
			this.button31.TabIndex = 121;
			// 
			// button32
			// 
			this.button32.BackColor = System.Drawing.Color.DodgerBlue;
			this.button32.Enabled = false;
			this.button32.Location = new System.Drawing.Point(448, 184);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(10, 10);
			this.button32.TabIndex = 122;
			this.button32.TabStop = false;
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.DodgerBlue;
			this.button34.Enabled = false;
			this.button34.Location = new System.Drawing.Point(480, 264);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(10, 10);
			this.button34.TabIndex = 124;
			this.button34.TabStop = false;
			// 
			// button35
			// 
			this.button35.BackColor = System.Drawing.Color.DodgerBlue;
			this.button35.Enabled = false;
			this.button35.Location = new System.Drawing.Point(288, 120);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(10, 10);
			this.button35.TabIndex = 123;
			this.button35.TabStop = false;
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.DodgerBlue;
			this.button36.Enabled = false;
			this.button36.Location = new System.Drawing.Point(264, 40);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(10, 10);
			this.button36.TabIndex = 126;
			this.button36.TabStop = false;
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.DodgerBlue;
			this.button37.Enabled = false;
			this.button37.Location = new System.Drawing.Point(344, 72);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(10, 10);
			this.button37.TabIndex = 125;
			this.button37.TabStop = false;
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.DodgerBlue;
			this.button38.Enabled = false;
			this.button38.Location = new System.Drawing.Point(520, 456);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(10, 10);
			this.button38.TabIndex = 128;
			this.button38.TabStop = false;
			// 
			// button39
			// 
			this.button39.BackColor = System.Drawing.Color.DodgerBlue;
			this.button39.Enabled = false;
			this.button39.Location = new System.Drawing.Point(712, 296);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(10, 10);
			this.button39.TabIndex = 127;
			this.button39.TabStop = false;
			// 
			// button40
			// 
			this.button40.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button40.BackgroundImage")));
			this.button40.Enabled = false;
			this.button40.Location = new System.Drawing.Point(256, 224);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(16, 48);
			this.button40.TabIndex = 129;
			// 
			// button41
			// 
			this.button41.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button41.BackgroundImage")));
			this.button41.Enabled = false;
			this.button41.Location = new System.Drawing.Point(272, 256);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(104, 16);
			this.button41.TabIndex = 130;
			// 
			// button42
			// 
			this.button42.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button42.BackgroundImage")));
			this.button42.Enabled = false;
			this.button42.Location = new System.Drawing.Point(40, 368);
			this.button42.Name = "button42";
			this.button42.Size = new System.Drawing.Size(80, 16);
			this.button42.TabIndex = 131;
			// 
			// button45
			// 
			this.button45.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button45.BackgroundImage")));
			this.button45.Enabled = false;
			this.button45.Location = new System.Drawing.Point(120, 368);
			this.button45.Name = "button45";
			this.button45.Size = new System.Drawing.Size(64, 16);
			this.button45.TabIndex = 134;
			// 
			// button44
			// 
			this.button44.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button44.BackgroundImage")));
			this.button44.Enabled = false;
			this.button44.Location = new System.Drawing.Point(184, 368);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(48, 16);
			this.button44.TabIndex = 135;
			// 
			// button46
			// 
			this.button46.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button46.BackgroundImage")));
			this.button46.Enabled = false;
			this.button46.Location = new System.Drawing.Point(216, 384);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(16, 24);
			this.button46.TabIndex = 136;
			// 
			// button47
			// 
			this.button47.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button47.BackgroundImage")));
			this.button47.Enabled = false;
			this.button47.Location = new System.Drawing.Point(232, 392);
			this.button47.Name = "button47";
			this.button47.Size = new System.Drawing.Size(184, 16);
			this.button47.TabIndex = 137;
			// 
			// monster2
			// 
			this.monster2.Image = ((System.Drawing.Image)(resources.GetObject("monster2.Image")));
			this.monster2.Location = new System.Drawing.Point(72, 400);
			this.monster2.Name = "monster2";
			this.monster2.Size = new System.Drawing.Size(40, 40);
			this.monster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster2.TabIndex = 138;
			this.monster2.TabStop = false;
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.DodgerBlue;
			this.button25.Enabled = false;
			this.button25.Location = new System.Drawing.Point(176, 488);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(10, 10);
			this.button25.TabIndex = 140;
			this.button25.TabStop = false;
			// 
			// button33
			// 
			this.button33.BackColor = System.Drawing.Color.DodgerBlue;
			this.button33.Enabled = false;
			this.button33.Location = new System.Drawing.Point(192, 416);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(10, 10);
			this.button33.TabIndex = 139;
			this.button33.TabStop = false;
			// 
			// button43
			// 
			this.button43.BackColor = System.Drawing.Color.DodgerBlue;
			this.button43.Enabled = false;
			this.button43.Location = new System.Drawing.Point(272, 464);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(10, 10);
			this.button43.TabIndex = 141;
			this.button43.TabStop = false;
			// 
			// button48
			// 
			this.button48.BackColor = System.Drawing.Color.DodgerBlue;
			this.button48.Enabled = false;
			this.button48.Location = new System.Drawing.Point(384, 448);
			this.button48.Name = "button48";
			this.button48.Size = new System.Drawing.Size(10, 10);
			this.button48.TabIndex = 142;
			this.button48.TabStop = false;
			// 
			// yemlik3
			// 
			this.yemlik3.Image = ((System.Drawing.Image)(resources.GetObject("yemlik3.Image")));
			this.yemlik3.Location = new System.Drawing.Point(528, 248);
			this.yemlik3.Name = "yemlik3";
			this.yemlik3.Size = new System.Drawing.Size(16, 16);
			this.yemlik3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik3.TabIndex = 143;
			this.yemlik3.TabStop = false;
			// 
			// button49
			// 
			this.button49.BackColor = System.Drawing.Color.DodgerBlue;
			this.button49.Enabled = false;
			this.button49.Location = new System.Drawing.Point(336, 320);
			this.button49.Name = "button49";
			this.button49.Size = new System.Drawing.Size(10, 10);
			this.button49.TabIndex = 146;
			this.button49.TabStop = false;
			// 
			// button50
			// 
			this.button50.BackColor = System.Drawing.Color.DodgerBlue;
			this.button50.Enabled = false;
			this.button50.Location = new System.Drawing.Point(208, 280);
			this.button50.Name = "button50";
			this.button50.Size = new System.Drawing.Size(10, 10);
			this.button50.TabIndex = 145;
			this.button50.TabStop = false;
			// 
			// button51
			// 
			this.button51.BackColor = System.Drawing.Color.DodgerBlue;
			this.button51.Enabled = false;
			this.button51.Location = new System.Drawing.Point(152, 328);
			this.button51.Name = "button51";
			this.button51.Size = new System.Drawing.Size(10, 10);
			this.button51.TabIndex = 144;
			this.button51.TabStop = false;
			// 
			// button52
			// 
			this.button52.BackColor = System.Drawing.Color.DodgerBlue;
			this.button52.Enabled = false;
			this.button52.Location = new System.Drawing.Point(264, 344);
			this.button52.Name = "button52";
			this.button52.Size = new System.Drawing.Size(10, 10);
			this.button52.TabIndex = 147;
			this.button52.TabStop = false;
			// 
			// yemlik4
			// 
			this.yemlik4.Image = ((System.Drawing.Image)(resources.GetObject("yemlik4.Image")));
			this.yemlik4.Location = new System.Drawing.Point(200, 160);
			this.yemlik4.Name = "yemlik4";
			this.yemlik4.Size = new System.Drawing.Size(16, 16);
			this.yemlik4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik4.TabIndex = 148;
			this.yemlik4.TabStop = false;
			// 
			// button53
			// 
			this.button53.BackColor = System.Drawing.Color.DodgerBlue;
			this.button53.Enabled = false;
			this.button53.Location = new System.Drawing.Point(696, 216);
			this.button53.Name = "button53";
			this.button53.Size = new System.Drawing.Size(10, 10);
			this.button53.TabIndex = 149;
			this.button53.TabStop = false;
			// 
			// monster4
			// 
			this.monster4.Image = ((System.Drawing.Image)(resources.GetObject("monster4.Image")));
			this.monster4.Location = new System.Drawing.Point(288, 32);
			this.monster4.Name = "monster4";
			this.monster4.Size = new System.Drawing.Size(40, 40);
			this.monster4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster4.TabIndex = 150;
			this.monster4.TabStop = false;
			// 
			// button54
			// 
			this.button54.BackColor = System.Drawing.Color.DodgerBlue;
			this.button54.Enabled = false;
			this.button54.Location = new System.Drawing.Point(472, 88);
			this.button54.Name = "button54";
			this.button54.Size = new System.Drawing.Size(10, 10);
			this.button54.TabIndex = 151;
			this.button54.TabStop = false;
			// 
			// button55
			// 
			this.button55.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button55.BackgroundImage")));
			this.button55.Enabled = false;
			this.button55.Location = new System.Drawing.Point(0, 384);
			this.button55.Name = "button55";
			this.button55.Size = new System.Drawing.Size(16, 136);
			this.button55.TabIndex = 152;
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
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.textBox1.ForeColor = System.Drawing.Color.SteelBlue;
			this.textBox1.Location = new System.Drawing.Point(688, 16);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(64, 15);
			this.textBox1.TabIndex = 153;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "   =>Giriþ";
			// 
			// Cikis
			// 
			this.Cikis.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Cikis.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Cikis.Enabled = false;
			this.Cikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.Cikis.ForeColor = System.Drawing.Color.SteelBlue;
			this.Cikis.Location = new System.Drawing.Point(0, 312);
			this.Cikis.Name = "Cikis";
			this.Cikis.Size = new System.Drawing.Size(64, 15);
			this.Cikis.TabIndex = 154;
			this.Cikis.TabStop = false;
			this.Cikis.Text = "<=Çýkýþ";
			// 
			// pictureBox5
			// 
			this.pictureBox5.BackColor = System.Drawing.Color.White;
			this.pictureBox5.Location = new System.Drawing.Point(592, 440);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(8, 80);
			this.pictureBox5.TabIndex = 155;
			this.pictureBox5.TabStop = false;
			// 
			// timer6
			// 
			this.timer6.Interval = 200;
			this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
			// 
			// timer7
			// 
			this.timer7.Interval = 250;
			this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
			// 
			// bomb
			// 
			this.bomb.Image = ((System.Drawing.Image)(resources.GetObject("bomb.Image")));
			this.bomb.Location = new System.Drawing.Point(528, 144);
			this.bomb.Name = "bomb";
			this.bomb.Size = new System.Drawing.Size(32, 32);
			this.bomb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.bomb.TabIndex = 156;
			this.bomb.TabStop = false;
			// 
			// lblBomb
			// 
			this.lblBomb.Enabled = false;
			this.lblBomb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblBomb.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblBomb.Location = new System.Drawing.Point(184, 16);
			this.lblBomb.Name = "lblBomb";
			this.lblBomb.Size = new System.Drawing.Size(40, 14);
			this.lblBomb.TabIndex = 157;
			this.lblBomb.Text = "X0";
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(152, 8);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(32, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 158;
			this.pictureBox6.TabStop = false;
			// 
			// timer8
			// 
			this.timer8.Interval = 200;
			this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
			// 
			// Level2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(768, 534);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.lblBomb);
			this.Controls.Add(this.bomb);
			this.Controls.Add(this.Boman);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.cikisDuvari);
			this.Controls.Add(this.Cikis);
			this.Controls.Add(this.button55);
			this.Controls.Add(this.button54);
			this.Controls.Add(this.button53);
			this.Controls.Add(this.yemlik4);
			this.Controls.Add(this.button52);
			this.Controls.Add(this.button49);
			this.Controls.Add(this.button50);
			this.Controls.Add(this.button51);
			this.Controls.Add(this.yemlik3);
			this.Controls.Add(this.button48);
			this.Controls.Add(this.button43);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.button33);
			this.Controls.Add(this.button47);
			this.Controls.Add(this.button46);
			this.Controls.Add(this.button44);
			this.Controls.Add(this.button45);
			this.Controls.Add(this.button42);
			this.Controls.Add(this.button41);
			this.Controls.Add(this.button40);
			this.Controls.Add(this.button38);
			this.Controls.Add(this.button39);
			this.Controls.Add(this.button36);
			this.Controls.Add(this.button37);
			this.Controls.Add(this.button34);
			this.Controls.Add(this.button35);
			this.Controls.Add(this.button32);
			this.Controls.Add(this.button31);
			this.Controls.Add(this.button30);
			this.Controls.Add(this.button28);
			this.Controls.Add(this.button26);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.yemlik2);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button29);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.yemlik1);
			this.Controls.Add(this.button27);
			this.Controls.Add(this.giris);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPara);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lblCani);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblYemlik);
			this.Controls.Add(this.imgSiren);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nitro);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.monster4);
			this.Controls.Add(this.monster);
			this.Controls.Add(this.monster3);
			this.Controls.Add(this.monster2);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.MaximizeBox = false;
			this.Name = "Level2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bölüm2";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Level2_Closing);
			this.Load += new System.EventHandler(this.Level2_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level2_KeyUp);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void Level2_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}
		Path rotate;
		Direction go;
		
		Keys dir,dir2,dir3,dir4;
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

		int kere=0,kere2=0,kere3,kere4=0;
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
			}
			if(i>0)
				label2.Text =i.ToString();
		}

		private void Level2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(label2.Visible!=true)
			{
				if(e.KeyCode==Keys.Space && intbomb>0)
				{
					string str=Application.StartupPath.ToString()+"\\sound\\alleluia.wav";
					Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
					
					bomb.Visible=true;
					bomb.Location=new Point(Boman.Location.X+30,Boman.Location.Y);
					timer8.Start();
				}
				Nitro nityol=Nitro.Yok;
				if(nitro.Width<=1)
				{
					nityol=Nitro.Yok;
				}
				if(e.Shift==true)
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
				if(Boman.Location.X>=592-bomb.Width && Boman.Location.Y>=440)
				{
					if(Boman.Location.X>=648)
					{
						if(Hak<3 && pictureBox4.Visible==true)
						{
							string str=Application.StartupPath.ToString()+"\\sound\\femeek2.wav";
							Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
							Hak++;
							lblCani.Text="X"+Hak.ToString();
						}
						pictureBox4.Visible=false;
					}
					Boman.BackColor=Color.White;
				}
				else
				{	
					Boman.BackColor=Color.LightSteelBlue;
				}
				//bitti------------

				go.Move(e,Boman,this,ref Money,nityol,new int[]{48,305,48,368},new int[]{712,32},ref Hak,ref yemlik,ref intbomb,"Form3",Exit,htable,"left");
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				lblBomb.Text="X"+intbomb.ToString();
				//label4.Text=Boman.Location.X+"-"+Boman.Location.Y;
				if(Hak==0)
				{	
					kapat();
				
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
					
					if(MessageBox.Show("Duraklat","Due",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
					{	
						timer1.Start();
						timer2.Start();
						timer3.Start();
						timer4.Start();
						timer5.Start();
						timer6.Start();
						timer7.Start();
					}
				}
			}
		}
		private void Level1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)//kurufasulye
		{
			if(e.Shift==false && Hak>0)
			{
				timer1.Stop();
				timer2.Start();
			}
		}

		private void Level2_Load(object sender, System.EventArgs e)
		{
			htable=new Hashtable();
			htable["monster"]="";
			htable["monster2"]="";
			htable["monster3"]="";
			htable["monster4"]="";
			htable["smonster"]="";
			htable["smonster2"]="";
			htable["smonster3"]="";
			htable["smonster4"]="";
			timer3.Start();
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
					go.Move(dir,monster,this,ref Money,nit,new int[]{72,176},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,104,264,392);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
					if(Hak==0)
					{
						kapat();
				
					}
				}
				else//sýnýrý aþmýþsa
				{
					go.Boundery(monster,htable,ref dir,xbilk,ybilk,72,176,ref xbBak,ref ybBak,ref xkBak,ref ykBak,ref intKere,16,104,264,392,ref kere);
					Nitro nit=Nitro.Var;
					xbilk=monster.Location.X;
					ybilk=monster.Location.Y;
					go.Move(dir,monster,this,ref Money,nit,new int[]{56,440},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,104,264,392);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
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
				go.Move(dir,monster,this,ref Money,nit,new int[]{712,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,104,264,392);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				lblBomb.Text="X"+intbomb.ToString();
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
					go.Move(dir,monster2,this,ref Money,nit,new int[]{713,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,384,440,520);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
				else//sýnýrý aþmýþsa
				{
					go.Boundery(monster2,htable,ref dir2,xbilk2,ybilk2,72,400,ref xbBak2,ref ybBak2,ref xkBak2,ref ykBak2,ref intKere2,16,384,440,520,ref kere2);
					Nitro nit=Nitro.Var;
					xbilk2=monster2.Location.X;
					ybilk2=monster2.Location.Y;
					go.Move(dir2,monster2,this,ref Money,nit,new int[]{713,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,384,440,520);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
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
				go.Move(dir,monster2,this,ref Money,nit,new int[]{712,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,16,384,440,520);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				lblBomb.Text="X"+intbomb.ToString();
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
					go.Move(dir,monster3,this,ref Money,nit,new int[]{712,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,256,272,632,592);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
				else
				{
					go.Boundery(monster3,htable,ref dir3,xbilk3,ybilk3,480,352,ref xbBak3,ref ybBak3,ref xkBak3,ref ykBak3,ref intKere3,256,272,632,592,ref kere3);//sýnýrý aþmýþsa
					Nitro nit=Nitro.Var;
					xbilk3=monster3.Location.X;
					ybilk3=monster3.Location.Y;
					go.Move(dir3,monster3,this,ref Money,nit,new int[]{712,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,256,272,632,592);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
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
				go.Move(dir,monster3,this,ref Money,nit,new int[]{712,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,256,272,632,592);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				lblBomb.Text="X"+intbomb.ToString();
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
					go.Move(dir,monster4,this,ref Money,nit,new int[]{713,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,232,16,552,216);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
					if(Hak==0)
					{
						kapat();
					}
				}
				else
				{
					go.Boundery(monster4,htable,ref dir4,xbilk4,ybilk4,288,32,ref xbBak4,ref ybBak4,ref xkBak4,ref ykBak4,ref intKere4,232,16,552,216,ref kere4);//sýnýrý aþmýþsa
					Nitro nit=Nitro.Var;
					xbilk4=monster4.Location.X;
					ybilk4=monster4.Location.Y;
					go.Move(dir4,monster4,this,ref Money,nit,new int[]{712,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,232,16,552,216);
					lblPara.Text=Money.ToString()+" YTL";
					lblCani.Text="X"+ Hak.ToString();
					lblYemlik.Text="X"+yemlik.ToString();
					lblBomb.Text="X"+intbomb.ToString();
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
				go.Move(dir,monster4,this,ref Money,nit,new int[]{712,32},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,232,16,552,216);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				lblBomb.Text="X"+intbomb.ToString();
				if(Hak==0)
				{
					kapat();
				}
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

		private void Level2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Shift==false && Hak>0)
			{
				timer1.Stop();
				timer2.Start();
			}
		}
		int bombTime=0;
		private void timer8_Tick(object sender, System.EventArgs e)
		{
			bombTime++;
			if(bombTime==10)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\boom.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				bomb.Visible=false;
				intbomb--;
				timer8.Stop();
				bombTime=0;
				if(Math.Abs(pictureBox5.Location.X-bomb.Location.X-bomb.Width)<50 && pictureBox5.Location.Y<=bomb.Location.Y)
				{
					pictureBox5.Visible=false;
					monster5.Visible=false;
				}
				if(Math.Abs((Boman.Location.X+Boman.Width)/2-(bomb.Location.X+bomb.Width)/2)<50 && Math.Abs((Boman.Location.Y+Boman.Height)/2 - (bomb.Location.Y+bomb.Height)/2)<50)
				{
					for(int i=0;i<8;i++)
					{
						Boman.Location=new Point(Boman.Location.X-3,Boman.Location.Y-3);
						Thread.Sleep(200);
					}
					--Hak;
					Boman.Location=new Point(712,32);
				}
			}
		}
	}
}
