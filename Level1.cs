using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using tonysound;
using System.IO;

namespace Packman
{
	public enum Nitro
	{
		Var,
		Yok
	}
	public enum Yon
	{
		Yatay,
		Dikey
	}
	/// <summary>
	/// Summary description for Level1.
	/// </summary>
	public class Level1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox Boman;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button nitro;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Timer timer5;

		double Money;
		int yemlik;
		int intbomb;
		public System.Windows.Forms.TextBox Cikis;
		private System.Windows.Forms.PictureBox Exit;
		int Hak;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button cikisDuvari;
		private System.Windows.Forms.PictureBox yemlik2;
		private System.Windows.Forms.PictureBox yemlik1;
		private System.Windows.Forms.PictureBox imgSiren;
		private System.Windows.Forms.PictureBox monster;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.PictureBox monster2;
		private System.Windows.Forms.Button button27;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.PictureBox yemlik3;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblYemlik;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lblCani;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label lblPara;
		public  Hashtable htable;
		Over frmOver;
		private System.Windows.Forms.PictureBox monster3;
		private System.Windows.Forms.Timer timer6;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		//bool over;
		//public static string yMonster="";//takip etmek için
		//public static string y2Monster="";//takip etmek için
		public Level1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			Money=0;
			yemlik=0;
			Hak=3;
			//over=false;
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Level1));
			this.Boman = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.nitro = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.button12 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.button17 = new System.Windows.Forms.Button();
			this.Cikis = new System.Windows.Forms.TextBox();
			this.button18 = new System.Windows.Forms.Button();
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.Exit = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cikisDuvari = new System.Windows.Forms.Button();
			this.yemlik2 = new System.Windows.Forms.PictureBox();
			this.yemlik1 = new System.Windows.Forms.PictureBox();
			this.imgSiren = new System.Windows.Forms.PictureBox();
			this.monster = new System.Windows.Forms.PictureBox();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.yemlik3 = new System.Windows.Forms.PictureBox();
			this.button26 = new System.Windows.Forms.Button();
			this.monster2 = new System.Windows.Forms.PictureBox();
			this.button27 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.button29 = new System.Windows.Forms.Button();
			this.button30 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lblYemlik = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lblCani = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblPara = new System.Windows.Forms.Label();
			this.monster3 = new System.Windows.Forms.PictureBox();
			this.timer6 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// Boman
			// 
			this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));
			this.Boman.Location = new System.Drawing.Point(48, 432);
			this.Boman.Name = "Boman";
			this.Boman.Size = new System.Drawing.Size(40, 40);
			this.Boman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Boman.TabIndex = 0;
			this.Boman.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(128, 296);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(16, 232);
			this.button1.TabIndex = 1;
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(144, 296);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 16);
			this.button2.TabIndex = 6;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.DodgerBlue;
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(288, 472);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(10, 10);
			this.button3.TabIndex = 8;
			this.button3.TabStop = false;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.DodgerBlue;
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(32, 360);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(10, 10);
			this.button4.TabIndex = 9;
			this.button4.TabStop = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.DodgerBlue;
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(64, 288);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(10, 10);
			this.button5.TabIndex = 10;
			this.button5.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.textBox1.ForeColor = System.Drawing.Color.SteelBlue;
			this.textBox1.Location = new System.Drawing.Point(32, 496);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(64, 15);
			this.textBox1.TabIndex = 11;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "   =>Giriþ";
			// 
			// button6
			// 
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(272, 296);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(16, 136);
			this.button6.TabIndex = 12;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.DodgerBlue;
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(328, 264);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(10, 10);
			this.button7.TabIndex = 15;
			this.button7.TabStop = false;
			// 
			// button8
			// 
			this.button8.BackColor = System.Drawing.Color.DodgerBlue;
			this.button8.Enabled = false;
			this.button8.Location = new System.Drawing.Point(208, 232);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(10, 10);
			this.button8.TabIndex = 14;
			this.button8.TabStop = false;
			// 
			// button9
			// 
			this.button9.BackColor = System.Drawing.Color.DodgerBlue;
			this.button9.Enabled = false;
			this.button9.Location = new System.Drawing.Point(168, 208);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(10, 10);
			this.button9.TabIndex = 13;
			this.button9.TabStop = false;
			// 
			// button10
			// 
			this.button10.BackColor = System.Drawing.Color.DodgerBlue;
			this.button10.Enabled = false;
			this.button10.Location = new System.Drawing.Point(256, 352);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(10, 10);
			this.button10.TabIndex = 16;
			this.button10.TabStop = false;
			// 
			// button11
			// 
			this.button11.BackColor = System.Drawing.Color.DodgerBlue;
			this.button11.Enabled = false;
			this.button11.Location = new System.Drawing.Point(688, 320);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(10, 10);
			this.button11.TabIndex = 17;
			this.button11.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// nitro
			// 
			this.nitro.BackColor = System.Drawing.Color.DeepPink;
			this.nitro.Enabled = false;
			this.nitro.Location = new System.Drawing.Point(48, 16);
			this.nitro.Name = "nitro";
			this.nitro.Size = new System.Drawing.Size(75, 8);
			this.nitro.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 24);
			this.label1.TabIndex = 19;
			this.label1.Text = "Pilav Üstü Kuru";
			// 
			// timer2
			// 
			this.timer2.Interval = 500;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.DarkViolet;
			this.label2.Location = new System.Drawing.Point(320, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 128);
			this.label2.TabIndex = 20;
			this.label2.Text = "3";
			// 
			// timer3
			// 
			this.timer3.Interval = 800;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// button12
			// 
			this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
			this.button12.Enabled = false;
			this.button12.Location = new System.Drawing.Point(0, 248);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(16, 280);
			this.button12.TabIndex = 21;
			// 
			// button13
			// 
			this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
			this.button13.Enabled = false;
			this.button13.Location = new System.Drawing.Point(0, 168);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(16, 80);
			this.button13.TabIndex = 22;
			// 
			// button14
			// 
			this.button14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button14.BackgroundImage")));
			this.button14.Enabled = false;
			this.button14.Location = new System.Drawing.Point(16, 168);
			this.button14.Name = "button14";
			this.button14.Size = new System.Drawing.Size(172, 16);
			this.button14.TabIndex = 23;
			// 
			// button15
			// 
			this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
			this.button15.Enabled = false;
			this.button15.Location = new System.Drawing.Point(184, 168);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(232, 16);
			this.button15.TabIndex = 24;
			// 
			// button16
			// 
			this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
			this.button16.Enabled = false;
			this.button16.Location = new System.Drawing.Point(400, 184);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(16, 216);
			this.button16.TabIndex = 25;
			// 
			// timer4
			// 
			this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
			// 
			// button17
			// 
			this.button17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button17.BackgroundImage")));
			this.button17.Enabled = false;
			this.button17.Location = new System.Drawing.Point(480, 384);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(184, 16);
			this.button17.TabIndex = 27;
			// 
			// Cikis
			// 
			this.Cikis.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Cikis.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Cikis.Enabled = false;
			this.Cikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.Cikis.ForeColor = System.Drawing.Color.SteelBlue;
			this.Cikis.Location = new System.Drawing.Point(688, 152);
			this.Cikis.Name = "Cikis";
			this.Cikis.Size = new System.Drawing.Size(64, 15);
			this.Cikis.TabIndex = 28;
			this.Cikis.TabStop = false;
			this.Cikis.Text = "   =>Çýkýþ";
			// 
			// button18
			// 
			this.button18.BackColor = System.Drawing.Color.DodgerBlue;
			this.button18.Enabled = false;
			this.button18.Location = new System.Drawing.Point(168, 360);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(10, 10);
			this.button18.TabIndex = 29;
			this.button18.TabStop = false;
			// 
			// timer5
			// 
			this.timer5.Interval = 200;
			this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
			// 
			// Exit
			// 
			this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
			this.Exit.Location = new System.Drawing.Point(696, 144);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(56, 24);
			this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Exit.TabIndex = 33;
			this.Exit.TabStop = false;
			this.Exit.Visible = false;
			this.Exit.VisibleChanged += new System.EventHandler(this.Exit_VisibleChanged);
			// 
			// label3
			// 
			this.label3.Enabled = false;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label3.ForeColor = System.Drawing.Color.Crimson;
			this.label3.Location = new System.Drawing.Point(32, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(80, 16);
			this.label3.TabIndex = 34;
			// 
			// cikisDuvari
			// 
			this.cikisDuvari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.BackgroundImage")));
			this.cikisDuvari.Enabled = false;
			this.cikisDuvari.Image = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.Image")));
			this.cikisDuvari.Location = new System.Drawing.Point(696, 168);
			this.cikisDuvari.Name = "cikisDuvari";
			this.cikisDuvari.Size = new System.Drawing.Size(56, 16);
			this.cikisDuvari.TabIndex = 35;
			// 
			// yemlik2
			// 
			this.yemlik2.Image = ((System.Drawing.Image)(resources.GetObject("yemlik2.Image")));
			this.yemlik2.Location = new System.Drawing.Point(200, 320);
			this.yemlik2.Name = "yemlik2";
			this.yemlik2.Size = new System.Drawing.Size(16, 16);
			this.yemlik2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik2.TabIndex = 36;
			this.yemlik2.TabStop = false;
			// 
			// yemlik1
			// 
			this.yemlik1.Image = ((System.Drawing.Image)(resources.GetObject("yemlik1.Image")));
			this.yemlik1.Location = new System.Drawing.Point(264, 200);
			this.yemlik1.Name = "yemlik1";
			this.yemlik1.Size = new System.Drawing.Size(16, 16);
			this.yemlik1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik1.TabIndex = 37;
			this.yemlik1.TabStop = false;
			// 
			// imgSiren
			// 
			this.imgSiren.Image = ((System.Drawing.Image)(resources.GetObject("imgSiren.Image")));
			this.imgSiren.Location = new System.Drawing.Point(0, 56);
			this.imgSiren.Name = "imgSiren";
			this.imgSiren.Size = new System.Drawing.Size(32, 32);
			this.imgSiren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgSiren.TabIndex = 38;
			this.imgSiren.TabStop = false;
			this.imgSiren.Visible = false;
			// 
			// monster
			// 
			this.monster.Image = ((System.Drawing.Image)(resources.GetObject("monster.Image")));
			this.monster.Location = new System.Drawing.Point(352, 272);
			this.monster.Name = "monster";
			this.monster.Size = new System.Drawing.Size(30, 30);
			this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster.TabIndex = 39;
			this.monster.TabStop = false;
			// 
			// button20
			// 
			this.button20.BackColor = System.Drawing.Color.DodgerBlue;
			this.button20.Enabled = false;
			this.button20.Location = new System.Drawing.Point(344, 368);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(10, 10);
			this.button20.TabIndex = 41;
			this.button20.TabStop = false;
			// 
			// button21
			// 
			this.button21.BackColor = System.Drawing.Color.DodgerBlue;
			this.button21.Enabled = false;
			this.button21.Location = new System.Drawing.Point(488, 448);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(10, 10);
			this.button21.TabIndex = 42;
			this.button21.TabStop = false;
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.DodgerBlue;
			this.button22.Enabled = false;
			this.button22.Location = new System.Drawing.Point(584, 472);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(10, 10);
			this.button22.TabIndex = 43;
			this.button22.TabStop = false;
			// 
			// button23
			// 
			this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
			this.button23.Enabled = false;
			this.button23.Location = new System.Drawing.Point(528, 168);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(16, 216);
			this.button23.TabIndex = 45;
			// 
			// button24
			// 
			this.button24.BackColor = System.Drawing.Color.DodgerBlue;
			this.button24.Enabled = false;
			this.button24.Location = new System.Drawing.Point(440, 280);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(10, 10);
			this.button24.TabIndex = 46;
			this.button24.TabStop = false;
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.DodgerBlue;
			this.button25.Enabled = false;
			this.button25.Location = new System.Drawing.Point(488, 312);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(10, 10);
			this.button25.TabIndex = 47;
			this.button25.TabStop = false;
			// 
			// yemlik3
			// 
			this.yemlik3.Image = ((System.Drawing.Image)(resources.GetObject("yemlik3.Image")));
			this.yemlik3.Location = new System.Drawing.Point(584, 344);
			this.yemlik3.Name = "yemlik3";
			this.yemlik3.Size = new System.Drawing.Size(16, 16);
			this.yemlik3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik3.TabIndex = 48;
			this.yemlik3.TabStop = false;
			// 
			// button26
			// 
			this.button26.BackColor = System.Drawing.Color.DodgerBlue;
			this.button26.Enabled = false;
			this.button26.Location = new System.Drawing.Point(488, 240);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(10, 10);
			this.button26.TabIndex = 49;
			this.button26.TabStop = false;
			// 
			// monster2
			// 
			this.monster2.Image = ((System.Drawing.Image)(resources.GetObject("monster2.Image")));
			this.monster2.Location = new System.Drawing.Point(192, 392);
			this.monster2.Name = "monster2";
			this.monster2.Size = new System.Drawing.Size(30, 30);
			this.monster2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster2.TabIndex = 50;
			this.monster2.TabStop = false;
			// 
			// button27
			// 
			this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
			this.button27.Enabled = false;
			this.button27.Location = new System.Drawing.Point(544, 168);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(152, 16);
			this.button27.TabIndex = 51;
			// 
			// button28
			// 
			this.button28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button28.BackgroundImage")));
			this.button28.Enabled = false;
			this.button28.Location = new System.Drawing.Point(416, 168);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(112, 16);
			this.button28.TabIndex = 52;
			// 
			// button29
			// 
			this.button29.BackColor = System.Drawing.Color.DodgerBlue;
			this.button29.Enabled = false;
			this.button29.Location = new System.Drawing.Point(568, 264);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(10, 10);
			this.button29.TabIndex = 53;
			this.button29.TabStop = false;
			// 
			// button30
			// 
			this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
			this.button30.Enabled = false;
			this.button30.Location = new System.Drawing.Point(128, 512);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(640, 16);
			this.button30.TabIndex = 54;
			// 
			// button31
			// 
			this.button31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button31.BackgroundImage")));
			this.button31.Enabled = false;
			this.button31.Location = new System.Drawing.Point(752, 168);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(16, 344);
			this.button31.TabIndex = 55;
			// 
			// button32
			// 
			this.button32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button32.BackgroundImage")));
			this.button32.Enabled = false;
			this.button32.Image = ((System.Drawing.Image)(resources.GetObject("button32.Image")));
			this.button32.Location = new System.Drawing.Point(16, 512);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(112, 16);
			this.button32.TabIndex = 56;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(160, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(16, 16);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 57;
			this.pictureBox1.TabStop = false;
			// 
			// lblYemlik
			// 
			this.lblYemlik.Enabled = false;
			this.lblYemlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblYemlik.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblYemlik.Location = new System.Drawing.Point(176, 42);
			this.lblYemlik.Name = "lblYemlik";
			this.lblYemlik.Size = new System.Drawing.Size(40, 14);
			this.lblYemlik.TabIndex = 58;
			this.lblYemlik.Text = "X0";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 38);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(20, 20);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 59;
			this.pictureBox2.TabStop = false;
			// 
			// lblCani
			// 
			this.lblCani.Enabled = false;
			this.lblCani.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCani.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCani.Location = new System.Drawing.Point(19, 41);
			this.lblCani.Name = "lblCani";
			this.lblCani.Size = new System.Drawing.Size(40, 14);
			this.lblCani.TabIndex = 60;
			this.lblCani.Text = "X3";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(64, 43);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(23, 11);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 61;
			this.pictureBox3.TabStop = false;
			// 
			// lblPara
			// 
			this.lblPara.Enabled = false;
			this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblPara.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblPara.Location = new System.Drawing.Point(88, 41);
			this.lblPara.Name = "lblPara";
			this.lblPara.Size = new System.Drawing.Size(72, 14);
			this.lblPara.TabIndex = 62;
			this.lblPara.Text = "0 YTL";
			// 
			// monster3
			// 
			this.monster3.Image = ((System.Drawing.Image)(resources.GetObject("monster3.Image")));
			this.monster3.Location = new System.Drawing.Point(600, 296);
			this.monster3.Name = "monster3";
			this.monster3.Size = new System.Drawing.Size(30, 30);
			this.monster3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monster3.TabIndex = 63;
			this.monster3.TabStop = false;
			// 
			// timer6
			// 
			this.timer6.Interval = 250;
			this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(248, 96);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 72);
			this.pictureBox4.TabIndex = 64;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(32, 96);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 72);
			this.pictureBox5.TabIndex = 65;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(576, 72);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(100, 72);
			this.pictureBox6.TabIndex = 66;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(648, 16);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(100, 72);
			this.pictureBox7.TabIndex = 67;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(208, 16);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(100, 72);
			this.pictureBox8.TabIndex = 68;
			this.pictureBox8.TabStop = false;
			// 
			// Level1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(768, 526);
			this.Controls.Add(this.Boman);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.lblPara);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lblCani);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblYemlik);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button32);
			this.Controls.Add(this.button31);
			this.Controls.Add(this.button30);
			this.Controls.Add(this.button29);
			this.Controls.Add(this.button28);
			this.Controls.Add(this.button27);
			this.Controls.Add(this.button26);
			this.Controls.Add(this.yemlik3);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.imgSiren);
			this.Controls.Add(this.yemlik1);
			this.Controls.Add(this.yemlik2);
			this.Controls.Add(this.cikisDuvari);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.Cikis);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button13);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nitro);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button8);
			this.Controls.Add(this.button9);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.monster3);
			this.Controls.Add(this.monster);
			this.Controls.Add(this.monster2);
			this.Controls.Add(this.label2);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Level1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bölüm1";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Level1_Closing);
			this.Load += new System.EventHandler(this.Level1_Load);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
			this.ResumeLayout(false);

		}
		#endregion

		Path rotate;
		Direction go;
		
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
		private void Level1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(label2.Visible!=true)
			{
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
				go.Move(e,Boman,this,ref Money,nityol,new int[]{694,184,752,184},new int[]{48,440},ref Hak,ref yemlik,ref intbomb,"Form2",Exit,htable,"up");
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
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
					
					if(MessageBox.Show("Duraklat","Due",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
					{	
						timer1.Start();
						timer2.Start();
						timer3.Start();
						timer4.Start();
						timer5.Start();
						timer6.Start();
					}
				}
			}
		}

		private void Level1_Load(object sender, System.EventArgs e)
		{
			htable=new Hashtable();
			htable["monster"]="";
			htable["monster2"]="";
			htable["monster3"]="";
			htable["smonster"]="";
			htable["smonster2"]="";
			htable["smonster3"]="";
			timer3.Start();
		}

		private void timer1_Tick(object sender, System.EventArgs e)//nitro azalýyo
		{
			if(nitro.Width>=2)
			{
				nitro.Width-=2;
			}
		}

		private void timer2_Tick(object sender, System.EventArgs e)//nitro artýyo
		{
			if((nitro.Width+2)<=75)
			{
				nitro.Width +=2;
			}
		}

		int i=4;
		private void timer3_Tick(object sender, System.EventArgs e)//baþlarken ki geri sayým
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
			}
			if(i>0)
				label2.Text =i.ToString();
		}

		private void Level1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)//kurufasulye
		{
			if(e.Shift==false && Hak>0)
			{
				timer1.Stop();
				timer2.Start();
			}
		}
		Keys dir,dir2,dir3;
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

		int kere=0,kere2=0,kere3=0;
		private void timer4_Tick(object sender, System.EventArgs e)//hayalet1
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
				imgSiren.Visible=true;
				label3.Text=htable["monster3"].ToString();
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
					go.Move(dir,monster,this,ref Money,nit,new int[]{56,440},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,14,132,416,432);
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
					go.Boundery(monster,htable,ref dir,xbilk,ybilk,352,272,ref xbBak,ref ybBak,ref xkBak,ref ykBak,ref intKere,14,132,416,432,ref kere);
					Nitro nit=Nitro.Var;
					xbilk=monster.Location.X;
					ybilk=monster.Location.Y;
					go.Move(dir,monster,this,ref Money,nit,new int[]{56,440},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,14,132,416,432);
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
			else if(htable["monster"].ToString().Trim()=="monster")//takip var demek
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
				go.Move(dir,monster,this,ref Money,nit,new int[]{56,456},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,14,132,416,432);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{	
					kapat();
				}
			}	
		}
		private void timer5_Tick(object sender, System.EventArgs e)//hayalet2
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
					go.Move(dir,monster2,this,ref Money,nit,new int[]{56,456},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,144,312,392,496);
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
					go.Boundery(monster2,htable,ref dir2,xbilk2,ybilk2,192,392,ref xbBak2,ref ybBak2,ref xkBak2,ref ykBak2,ref intKere2,144,312,392,496,ref kere2);
					Nitro nit=Nitro.Var;
					xbilk2=monster2.Location.X;
					ybilk2=monster2.Location.Y;
					go.Move(dir2,monster2,this,ref Money,nit,new int[]{56,440},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,144,312,392,496);
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
			else if(htable["monster2"].ToString().Trim()=="monster2")//takip var demek
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
				go.Move(dir,monster2,this,ref Money,nit,new int[]{56,456},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,144,312,392,496);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{
					kapat();
				}
			}	
		}
		private void Level1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
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
					go.Move(dir,monster3,this,ref Money,nit,new int[]{56,456},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,544,184,752,400);
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
					go.Boundery(monster3,htable,ref dir3,xbilk3,ybilk3,600,296,ref xbBak3,ref ybBak3,ref xkBak3,ref ykBak3,ref intKere3,544,184,752,400,ref kere3);//sýnýrý aþmýþsa
					Nitro nit=Nitro.Var;
					xbilk3=monster3.Location.X;
					ybilk3=monster3.Location.Y;
					go.Move(dir3,monster3,this,ref Money,nit,new int[]{56,440},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,544,184,752,400);
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
			else if(htable["monster3"].ToString().Trim()=="monster3")//takip var
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
				go.Move(dir,monster3,this,ref Money,nit,new int[]{56,456},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,544,184,752,400);
				lblPara.Text=Money.ToString()+" YTL";
				lblCani.Text="X"+ Hak.ToString();
				lblYemlik.Text="X"+yemlik.ToString();
				if(Hak==0)
				{
					kapat();
				}
			}	
		}
	}
}
