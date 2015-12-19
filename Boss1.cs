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
	public class Boss1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button27;
		public System.Windows.Forms.TextBox Cikis;
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button nitro;
		private System.Windows.Forms.Button button17;
		private System.Windows.Forms.Button button25;
		private System.Windows.Forms.Button button26;
		private System.Windows.Forms.Button button14;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button31;
		private System.Windows.Forms.Button button34;
		private System.Windows.Forms.PictureBox yemlik1;
		private System.Windows.Forms.Button button35;
		private System.Windows.Forms.Button button36;
		private System.Windows.Forms.Button button37;
		private System.Windows.Forms.Button button38;
		private System.Windows.Forms.Button button40;
		private System.Windows.Forms.Button button41;
		private System.Windows.Forms.Button button42;
		private System.Windows.Forms.Button button43;
		private System.Windows.Forms.Button button44;
		private System.Windows.Forms.Button button45;
		private System.Windows.Forms.Button button48;
		private System.Windows.Forms.PictureBox yemlik3;
		private System.Windows.Forms.Button button50;
		private System.Windows.Forms.Button button51;
		private System.Windows.Forms.Button button52;
		private System.Windows.Forms.Button button55;
		private System.Windows.Forms.Button button56;
		private System.Windows.Forms.Button button57;
		private System.Windows.Forms.Button button59;
		private System.Windows.Forms.Button button46;
		private System.Windows.Forms.Button button54;
		private System.Windows.Forms.Button button60;
		private System.Windows.Forms.Button button61;
		private System.Windows.Forms.Button button62;
		private System.Windows.Forms.Button button64;
		private System.Windows.Forms.Button button65;
		private System.Windows.Forms.Button breakTime;
		private System.Windows.Forms.PictureBox gin;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Label lblCin;
		private System.Windows.Forms.Timer timer8;
		private System.Windows.Forms.Label lblCin2;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button button66;
		private System.Windows.Forms.Button button67;
		private System.Windows.Forms.Button button18;
		private System.Windows.Forms.Button button68;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button30;
		private System.Windows.Forms.Button button70;
		private System.Windows.Forms.Timer timer9;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Button ostime;
		private System.Windows.Forms.PictureBox osuruk;
		private System.Windows.Forms.Label lblOs;
		private System.Windows.Forms.Timer timer10;
		private System.Windows.Forms.Label lblOs2;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button15;
		private System.Windows.Forms.Button button16;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Button button23;
		private System.Windows.Forms.Button button24;
		private System.Windows.Forms.Button button28;
		private System.Windows.Forms.Button button32;
		private System.Windows.Forms.Button button33;
		private System.Windows.Forms.Button button39;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button47;
		private System.Windows.Forms.Button cikisDuvari;
		private System.Windows.Forms.PictureBox Exit;
		private System.Windows.Forms.Button button29;
		private System.Windows.Forms.Button button71;
		private System.Windows.Forms.Button button72;
		private System.Windows.Forms.Button button69;
		private System.Windows.Forms.Button button73;
		private System.Windows.Forms.Button button74;
		private System.Windows.Forms.Button button75;
		private System.Windows.Forms.Button button76;
		private System.Windows.Forms.Button button77;
		private System.Windows.Forms.Button button78;
		private System.Windows.Forms.Button button79;
		private System.Windows.Forms.Button button80;
		private System.Windows.Forms.Button button81;
		private System.Windows.Forms.Button button82;
		private System.Windows.Forms.Button button83;
		private System.Windows.Forms.Button button84;
		private System.Windows.Forms.Button button85;
		private System.Windows.Forms.Button button86;
		private System.Windows.Forms.Button button87;
		private System.Windows.Forms.Button button88;
		private System.Windows.Forms.Button button89;
		private System.Windows.Forms.Button button90;
		private System.Windows.Forms.Button button92;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Button button93;
		private System.Windows.Forms.Button button94;
		private System.Windows.Forms.Button button95;
		private System.Windows.Forms.Button button96;
		private System.Windows.Forms.Button button97;
		private System.Windows.Forms.Button button98;
		private System.Windows.Forms.Button button99;
		private System.Windows.Forms.Button button100;
		private System.Windows.Forms.Button button101;
		private System.Windows.Forms.Button button102;
		private System.Windows.Forms.Button button103;
		private System.Windows.Forms.Button button104;
		private System.Windows.Forms.Button button105;
		private System.Windows.Forms.Button button106;
		private System.Windows.Forms.Button button107;
		private System.Windows.Forms.Button button108;
		private System.Windows.Forms.Button button109;
		private System.Windows.Forms.Button button110;
		private System.Windows.Forms.Button button111;
		private System.Windows.Forms.Button button112;
		private System.Windows.Forms.Button button113;
		private System.Windows.Forms.Button button114;
		private System.Windows.Forms.Button button115;
		private System.Windows.Forms.Button button116;
		private System.Windows.Forms.Button button117;
		private System.Windows.Forms.Button button118;
		private System.Windows.Forms.Button button119;
		private System.Windows.Forms.Button button53;
		private System.Windows.Forms.Button button58;
		private System.Windows.Forms.Button button91;
		private System.Windows.Forms.Button button120;
		private System.Windows.Forms.Button button121;
		private System.Windows.Forms.Button button122;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Button button49;
		private System.Windows.Forms.Button button63;
		private System.Windows.Forms.Button button123;
		private System.Windows.Forms.Button button124;
		private System.Windows.Forms.Button button125;
		private System.Windows.Forms.PictureBox Boman;
		private System.Windows.Forms.Button button126;
		private System.Windows.Forms.PictureBox monsterBoss1;
		private System.Windows.Forms.Label lblPara2;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Button button127;
		private System.Windows.Forms.Button button128;
		private System.Windows.Forms.Button button129;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Button button130;
		private System.Windows.Forms.Label lblMyMoney;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.Label lblKazan;
		private System.Windows.Forms.Label lblKaybet;
		private System.Windows.Forms.Timer timer5;
		private System.Windows.Forms.Label lblRound;
		private System.Windows.Forms.PictureBox picCmpRound;
		private System.Windows.Forms.PictureBox picBenround;
		private System.ComponentModel.IContainer components;

		public Boss1()
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
		double gelenPara=0;
		int intRound=0;
		int intBen=0;
		int intCmp=0;
		public Boss1(double dblMoney,int intyemlik,int intHak,Form frm,int intCin,int intOsuruk,int round,int ben,int cmp)
		{
			InitializeComponent();
			gelenPara=dblMoney;
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
			intBen=ben;
			intCmp=cmp;
			if(intCmp>0)
				picCmpRound.Visible=true;
			if(intBen>0)
				picBenround.Visible=true;
			intRound=round;
		}
		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Boss1));
			this.label2 = new System.Windows.Forms.Label();
			this.monsterBoss1 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button27 = new System.Windows.Forms.Button();
			this.Cikis = new System.Windows.Forms.TextBox();
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
			this.label1 = new System.Windows.Forms.Label();
			this.nitro = new System.Windows.Forms.Button();
			this.button17 = new System.Windows.Forms.Button();
			this.button25 = new System.Windows.Forms.Button();
			this.button26 = new System.Windows.Forms.Button();
			this.button14 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button31 = new System.Windows.Forms.Button();
			this.button34 = new System.Windows.Forms.Button();
			this.yemlik1 = new System.Windows.Forms.PictureBox();
			this.button35 = new System.Windows.Forms.Button();
			this.button36 = new System.Windows.Forms.Button();
			this.button37 = new System.Windows.Forms.Button();
			this.button38 = new System.Windows.Forms.Button();
			this.button40 = new System.Windows.Forms.Button();
			this.button41 = new System.Windows.Forms.Button();
			this.button42 = new System.Windows.Forms.Button();
			this.button43 = new System.Windows.Forms.Button();
			this.button44 = new System.Windows.Forms.Button();
			this.button45 = new System.Windows.Forms.Button();
			this.button48 = new System.Windows.Forms.Button();
			this.yemlik3 = new System.Windows.Forms.PictureBox();
			this.button50 = new System.Windows.Forms.Button();
			this.button51 = new System.Windows.Forms.Button();
			this.button52 = new System.Windows.Forms.Button();
			this.button55 = new System.Windows.Forms.Button();
			this.button56 = new System.Windows.Forms.Button();
			this.button57 = new System.Windows.Forms.Button();
			this.button59 = new System.Windows.Forms.Button();
			this.button46 = new System.Windows.Forms.Button();
			this.button54 = new System.Windows.Forms.Button();
			this.button60 = new System.Windows.Forms.Button();
			this.button61 = new System.Windows.Forms.Button();
			this.button62 = new System.Windows.Forms.Button();
			this.button64 = new System.Windows.Forms.Button();
			this.button65 = new System.Windows.Forms.Button();
			this.gin = new System.Windows.Forms.PictureBox();
			this.breakTime = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.lblCin = new System.Windows.Forms.Label();
			this.timer8 = new System.Windows.Forms.Timer(this.components);
			this.lblCin2 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.button66 = new System.Windows.Forms.Button();
			this.button67 = new System.Windows.Forms.Button();
			this.button18 = new System.Windows.Forms.Button();
			this.button68 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.button30 = new System.Windows.Forms.Button();
			this.button70 = new System.Windows.Forms.Button();
			this.timer9 = new System.Windows.Forms.Timer(this.components);
			this.lblOs2 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.lblOs = new System.Windows.Forms.Label();
			this.ostime = new System.Windows.Forms.Button();
			this.osuruk = new System.Windows.Forms.PictureBox();
			this.timer10 = new System.Windows.Forms.Timer(this.components);
			this.Boman = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button15 = new System.Windows.Forms.Button();
			this.button16 = new System.Windows.Forms.Button();
			this.button19 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.button23 = new System.Windows.Forms.Button();
			this.button24 = new System.Windows.Forms.Button();
			this.button28 = new System.Windows.Forms.Button();
			this.button32 = new System.Windows.Forms.Button();
			this.button33 = new System.Windows.Forms.Button();
			this.button39 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button47 = new System.Windows.Forms.Button();
			this.cikisDuvari = new System.Windows.Forms.Button();
			this.Exit = new System.Windows.Forms.PictureBox();
			this.button29 = new System.Windows.Forms.Button();
			this.button71 = new System.Windows.Forms.Button();
			this.button72 = new System.Windows.Forms.Button();
			this.button69 = new System.Windows.Forms.Button();
			this.button73 = new System.Windows.Forms.Button();
			this.button74 = new System.Windows.Forms.Button();
			this.button75 = new System.Windows.Forms.Button();
			this.button76 = new System.Windows.Forms.Button();
			this.button77 = new System.Windows.Forms.Button();
			this.button78 = new System.Windows.Forms.Button();
			this.button79 = new System.Windows.Forms.Button();
			this.button80 = new System.Windows.Forms.Button();
			this.button81 = new System.Windows.Forms.Button();
			this.button82 = new System.Windows.Forms.Button();
			this.button83 = new System.Windows.Forms.Button();
			this.button84 = new System.Windows.Forms.Button();
			this.button85 = new System.Windows.Forms.Button();
			this.button86 = new System.Windows.Forms.Button();
			this.button87 = new System.Windows.Forms.Button();
			this.button88 = new System.Windows.Forms.Button();
			this.button89 = new System.Windows.Forms.Button();
			this.button90 = new System.Windows.Forms.Button();
			this.button92 = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.button93 = new System.Windows.Forms.Button();
			this.button94 = new System.Windows.Forms.Button();
			this.button95 = new System.Windows.Forms.Button();
			this.button96 = new System.Windows.Forms.Button();
			this.button97 = new System.Windows.Forms.Button();
			this.button98 = new System.Windows.Forms.Button();
			this.button99 = new System.Windows.Forms.Button();
			this.button100 = new System.Windows.Forms.Button();
			this.button101 = new System.Windows.Forms.Button();
			this.button102 = new System.Windows.Forms.Button();
			this.button103 = new System.Windows.Forms.Button();
			this.button104 = new System.Windows.Forms.Button();
			this.button105 = new System.Windows.Forms.Button();
			this.button106 = new System.Windows.Forms.Button();
			this.button107 = new System.Windows.Forms.Button();
			this.button108 = new System.Windows.Forms.Button();
			this.button109 = new System.Windows.Forms.Button();
			this.button110 = new System.Windows.Forms.Button();
			this.button111 = new System.Windows.Forms.Button();
			this.button112 = new System.Windows.Forms.Button();
			this.button113 = new System.Windows.Forms.Button();
			this.button114 = new System.Windows.Forms.Button();
			this.button115 = new System.Windows.Forms.Button();
			this.button116 = new System.Windows.Forms.Button();
			this.button117 = new System.Windows.Forms.Button();
			this.button118 = new System.Windows.Forms.Button();
			this.button119 = new System.Windows.Forms.Button();
			this.button53 = new System.Windows.Forms.Button();
			this.button58 = new System.Windows.Forms.Button();
			this.button91 = new System.Windows.Forms.Button();
			this.button120 = new System.Windows.Forms.Button();
			this.button121 = new System.Windows.Forms.Button();
			this.button122 = new System.Windows.Forms.Button();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.button49 = new System.Windows.Forms.Button();
			this.button63 = new System.Windows.Forms.Button();
			this.button123 = new System.Windows.Forms.Button();
			this.button124 = new System.Windows.Forms.Button();
			this.button125 = new System.Windows.Forms.Button();
			this.button126 = new System.Windows.Forms.Button();
			this.lblPara2 = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.button127 = new System.Windows.Forms.Button();
			this.button128 = new System.Windows.Forms.Button();
			this.button129 = new System.Windows.Forms.Button();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.button130 = new System.Windows.Forms.Button();
			this.lblMyMoney = new System.Windows.Forms.Label();
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.lblKazan = new System.Windows.Forms.Label();
			this.lblKaybet = new System.Windows.Forms.Label();
			this.timer5 = new System.Windows.Forms.Timer(this.components);
			this.lblRound = new System.Windows.Forms.Label();
			this.picCmpRound = new System.Windows.Forms.PictureBox();
			this.picBenround = new System.Windows.Forms.PictureBox();
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
			// monsterBoss1
			// 
			this.monsterBoss1.Image = ((System.Drawing.Image)(resources.GetObject("monsterBoss1.Image")));
			this.monsterBoss1.Location = new System.Drawing.Point(928, 48);
			this.monsterBoss1.Name = "monsterBoss1";
			this.monsterBoss1.Size = new System.Drawing.Size(40, 40);
			this.monsterBoss1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.monsterBoss1.TabIndex = 156;
			this.monsterBoss1.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Enabled = false;
			this.textBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.textBox1.ForeColor = System.Drawing.Color.SteelBlue;
			this.textBox1.Location = new System.Drawing.Point(936, 32);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(48, 15);
			this.textBox1.TabIndex = 157;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "BOSS";
			// 
			// button27
			// 
			this.button27.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button27.BackgroundImage")));
			this.button27.Enabled = false;
			this.button27.Location = new System.Drawing.Point(16, 640);
			this.button27.Name = "button27";
			this.button27.Size = new System.Drawing.Size(496, 16);
			this.button27.TabIndex = 161;
			// 
			// Cikis
			// 
			this.Cikis.BackColor = System.Drawing.Color.LightSteelBlue;
			this.Cikis.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Cikis.Enabled = false;
			this.Cikis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.Cikis.ForeColor = System.Drawing.Color.SteelBlue;
			this.Cikis.Location = new System.Drawing.Point(20, 638);
			this.Cikis.Name = "Cikis";
			this.Cikis.Size = new System.Drawing.Size(64, 15);
			this.Cikis.TabIndex = 164;
			this.Cikis.TabStop = false;
			this.Cikis.Text = "BOMAN";
			// 
			// button2
			// 
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Enabled = false;
			this.button2.Location = new System.Drawing.Point(640, 408);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(232, 16);
			this.button2.TabIndex = 167;
			// 
			// button5
			// 
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Enabled = false;
			this.button5.Location = new System.Drawing.Point(184, 424);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(16, 120);
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
			this.button9.Location = new System.Drawing.Point(872, 152);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(16, 136);
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
			this.button11.Location = new System.Drawing.Point(992, 112);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(16, 528);
			this.button11.TabIndex = 176;
			// 
			// button13
			// 
			this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
			this.button13.Enabled = false;
			this.button13.Location = new System.Drawing.Point(232, 0);
			this.button13.Name = "button13";
			this.button13.Size = new System.Drawing.Size(760, 16);
			this.button13.TabIndex = 177;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Enabled = false;
			this.button4.Location = new System.Drawing.Point(640, 528);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(96, 16);
			this.button4.TabIndex = 169;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(176, 42);
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
			this.lblYemlik.Location = new System.Drawing.Point(192, 43);
			this.lblYemlik.Name = "lblYemlik";
			this.lblYemlik.Size = new System.Drawing.Size(30, 14);
			this.lblYemlik.TabIndex = 184;
			this.lblYemlik.Text = "X0";
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
			this.button17.Location = new System.Drawing.Point(504, 184);
			this.button17.Name = "button17";
			this.button17.Size = new System.Drawing.Size(16, 80);
			this.button17.TabIndex = 191;
			// 
			// button25
			// 
			this.button25.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button25.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button25.BackgroundImage")));
			this.button25.Enabled = false;
			this.button25.Location = new System.Drawing.Point(0, 88);
			this.button25.Name = "button25";
			this.button25.Size = new System.Drawing.Size(216, 16);
			this.button25.TabIndex = 198;
			// 
			// button26
			// 
			this.button26.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button26.BackgroundImage")));
			this.button26.Enabled = false;
			this.button26.Location = new System.Drawing.Point(216, 0);
			this.button26.Name = "button26";
			this.button26.Size = new System.Drawing.Size(16, 104);
			this.button26.TabIndex = 199;
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
			this.button21.Location = new System.Drawing.Point(736, 528);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(64, 16);
			this.button21.TabIndex = 211;
			// 
			// button31
			// 
			this.button31.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button31.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button31.BackgroundImage")));
			this.button31.Enabled = false;
			this.button31.Location = new System.Drawing.Point(640, 272);
			this.button31.Name = "button31";
			this.button31.Size = new System.Drawing.Size(232, 16);
			this.button31.TabIndex = 212;
			// 
			// button34
			// 
			this.button34.BackColor = System.Drawing.Color.DodgerBlue;
			this.button34.Enabled = false;
			this.button34.Location = new System.Drawing.Point(40, 192);
			this.button34.Name = "button34";
			this.button34.Size = new System.Drawing.Size(10, 10);
			this.button34.TabIndex = 214;
			this.button34.TabStop = false;
			// 
			// yemlik1
			// 
			this.yemlik1.Image = ((System.Drawing.Image)(resources.GetObject("yemlik1.Image")));
			this.yemlik1.Location = new System.Drawing.Point(368, 192);
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
			this.button35.Location = new System.Drawing.Point(216, 136);
			this.button35.Name = "button35";
			this.button35.Size = new System.Drawing.Size(10, 10);
			this.button35.TabIndex = 215;
			this.button35.TabStop = false;
			// 
			// button36
			// 
			this.button36.BackColor = System.Drawing.Color.DodgerBlue;
			this.button36.Enabled = false;
			this.button36.Location = new System.Drawing.Point(856, 344);
			this.button36.Name = "button36";
			this.button36.Size = new System.Drawing.Size(10, 10);
			this.button36.TabIndex = 217;
			this.button36.TabStop = false;
			// 
			// button37
			// 
			this.button37.BackColor = System.Drawing.Color.DodgerBlue;
			this.button37.Enabled = false;
			this.button37.Location = new System.Drawing.Point(944, 488);
			this.button37.Name = "button37";
			this.button37.Size = new System.Drawing.Size(10, 10);
			this.button37.TabIndex = 216;
			this.button37.TabStop = false;
			// 
			// button38
			// 
			this.button38.BackColor = System.Drawing.Color.DodgerBlue;
			this.button38.Enabled = false;
			this.button38.Location = new System.Drawing.Point(904, 584);
			this.button38.Name = "button38";
			this.button38.Size = new System.Drawing.Size(10, 10);
			this.button38.TabIndex = 218;
			this.button38.TabStop = false;
			// 
			// button40
			// 
			this.button40.BackColor = System.Drawing.Color.DodgerBlue;
			this.button40.Enabled = false;
			this.button40.Location = new System.Drawing.Point(944, 536);
			this.button40.Name = "button40";
			this.button40.Size = new System.Drawing.Size(10, 10);
			this.button40.TabIndex = 221;
			this.button40.TabStop = false;
			// 
			// button41
			// 
			this.button41.BackColor = System.Drawing.Color.DodgerBlue;
			this.button41.Enabled = false;
			this.button41.Location = new System.Drawing.Point(840, 72);
			this.button41.Name = "button41";
			this.button41.Size = new System.Drawing.Size(10, 10);
			this.button41.TabIndex = 223;
			this.button41.TabStop = false;
			// 
			// button42
			// 
			this.button42.BackColor = System.Drawing.Color.DodgerBlue;
			this.button42.Enabled = false;
			this.button42.Location = new System.Drawing.Point(600, 72);
			this.button42.Name = "button42";
			this.button42.Size = new System.Drawing.Size(10, 10);
			this.button42.TabIndex = 222;
			this.button42.TabStop = false;
			// 
			// button43
			// 
			this.button43.BackColor = System.Drawing.Color.DodgerBlue;
			this.button43.Enabled = false;
			this.button43.Location = new System.Drawing.Point(696, 72);
			this.button43.Name = "button43";
			this.button43.Size = new System.Drawing.Size(10, 10);
			this.button43.TabIndex = 224;
			this.button43.TabStop = false;
			// 
			// button44
			// 
			this.button44.BackColor = System.Drawing.Color.DodgerBlue;
			this.button44.Enabled = false;
			this.button44.Location = new System.Drawing.Point(168, 136);
			this.button44.Name = "button44";
			this.button44.Size = new System.Drawing.Size(10, 10);
			this.button44.TabIndex = 225;
			this.button44.TabStop = false;
			// 
			// button45
			// 
			this.button45.BackColor = System.Drawing.Color.DodgerBlue;
			this.button45.Enabled = false;
			this.button45.Location = new System.Drawing.Point(400, 72);
			this.button45.Name = "button45";
			this.button45.Size = new System.Drawing.Size(10, 10);
			this.button45.TabIndex = 226;
			this.button45.TabStop = false;
			// 
			// button48
			// 
			this.button48.BackColor = System.Drawing.Color.DodgerBlue;
			this.button48.Enabled = false;
			this.button48.Location = new System.Drawing.Point(744, 72);
			this.button48.Name = "button48";
			this.button48.Size = new System.Drawing.Size(10, 10);
			this.button48.TabIndex = 229;
			this.button48.TabStop = false;
			// 
			// yemlik3
			// 
			this.yemlik3.Image = ((System.Drawing.Image)(resources.GetObject("yemlik3.Image")));
			this.yemlik3.Location = new System.Drawing.Point(680, 456);
			this.yemlik3.Name = "yemlik3";
			this.yemlik3.Size = new System.Drawing.Size(16, 16);
			this.yemlik3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.yemlik3.TabIndex = 230;
			this.yemlik3.TabStop = false;
			// 
			// button50
			// 
			this.button50.BackColor = System.Drawing.Color.DodgerBlue;
			this.button50.Enabled = false;
			this.button50.Location = new System.Drawing.Point(120, 136);
			this.button50.Name = "button50";
			this.button50.Size = new System.Drawing.Size(10, 10);
			this.button50.TabIndex = 232;
			this.button50.TabStop = false;
			// 
			// button51
			// 
			this.button51.BackColor = System.Drawing.Color.DodgerBlue;
			this.button51.Enabled = false;
			this.button51.Location = new System.Drawing.Point(40, 344);
			this.button51.Name = "button51";
			this.button51.Size = new System.Drawing.Size(10, 10);
			this.button51.TabIndex = 233;
			this.button51.TabStop = false;
			// 
			// button52
			// 
			this.button52.BackColor = System.Drawing.Color.DodgerBlue;
			this.button52.Enabled = false;
			this.button52.Location = new System.Drawing.Point(256, 192);
			this.button52.Name = "button52";
			this.button52.Size = new System.Drawing.Size(10, 10);
			this.button52.TabIndex = 234;
			this.button52.TabStop = false;
			// 
			// button55
			// 
			this.button55.BackColor = System.Drawing.Color.DodgerBlue;
			this.button55.Enabled = false;
			this.button55.Location = new System.Drawing.Point(40, 248);
			this.button55.Name = "button55";
			this.button55.Size = new System.Drawing.Size(10, 10);
			this.button55.TabIndex = 235;
			this.button55.TabStop = false;
			// 
			// button56
			// 
			this.button56.BackColor = System.Drawing.Color.DodgerBlue;
			this.button56.Enabled = false;
			this.button56.Location = new System.Drawing.Point(72, 136);
			this.button56.Name = "button56";
			this.button56.Size = new System.Drawing.Size(10, 10);
			this.button56.TabIndex = 240;
			this.button56.TabStop = false;
			// 
			// button57
			// 
			this.button57.BackColor = System.Drawing.Color.DodgerBlue;
			this.button57.Enabled = false;
			this.button57.Location = new System.Drawing.Point(256, 256);
			this.button57.Name = "button57";
			this.button57.Size = new System.Drawing.Size(10, 10);
			this.button57.TabIndex = 239;
			this.button57.TabStop = false;
			// 
			// button59
			// 
			this.button59.BackColor = System.Drawing.Color.DodgerBlue;
			this.button59.Enabled = false;
			this.button59.Location = new System.Drawing.Point(352, 72);
			this.button59.Name = "button59";
			this.button59.Size = new System.Drawing.Size(10, 10);
			this.button59.TabIndex = 241;
			this.button59.TabStop = false;
			// 
			// button46
			// 
			this.button46.BackColor = System.Drawing.Color.DodgerBlue;
			this.button46.Enabled = false;
			this.button46.Location = new System.Drawing.Point(792, 72);
			this.button46.Name = "button46";
			this.button46.Size = new System.Drawing.Size(10, 10);
			this.button46.TabIndex = 244;
			this.button46.TabStop = false;
			// 
			// button54
			// 
			this.button54.BackColor = System.Drawing.Color.DodgerBlue;
			this.button54.Enabled = false;
			this.button54.Location = new System.Drawing.Point(648, 72);
			this.button54.Name = "button54";
			this.button54.Size = new System.Drawing.Size(10, 10);
			this.button54.TabIndex = 243;
			this.button54.TabStop = false;
			// 
			// button60
			// 
			this.button60.BackColor = System.Drawing.Color.DodgerBlue;
			this.button60.Enabled = false;
			this.button60.Location = new System.Drawing.Point(888, 72);
			this.button60.Name = "button60";
			this.button60.Size = new System.Drawing.Size(10, 10);
			this.button60.TabIndex = 242;
			this.button60.TabStop = false;
			// 
			// button61
			// 
			this.button61.BackColor = System.Drawing.Color.DodgerBlue;
			this.button61.Enabled = false;
			this.button61.Location = new System.Drawing.Point(496, 72);
			this.button61.Name = "button61";
			this.button61.Size = new System.Drawing.Size(10, 10);
			this.button61.TabIndex = 245;
			this.button61.TabStop = false;
			// 
			// button62
			// 
			this.button62.BackColor = System.Drawing.Color.DodgerBlue;
			this.button62.Enabled = false;
			this.button62.Location = new System.Drawing.Point(552, 72);
			this.button62.Name = "button62";
			this.button62.Size = new System.Drawing.Size(10, 10);
			this.button62.TabIndex = 247;
			this.button62.TabStop = false;
			// 
			// button64
			// 
			this.button64.BackColor = System.Drawing.Color.DodgerBlue;
			this.button64.Enabled = false;
			this.button64.Location = new System.Drawing.Point(40, 304);
			this.button64.Name = "button64";
			this.button64.Size = new System.Drawing.Size(10, 10);
			this.button64.TabIndex = 249;
			this.button64.TabStop = false;
			// 
			// button65
			// 
			this.button65.BackColor = System.Drawing.Color.DodgerBlue;
			this.button65.Enabled = false;
			this.button65.Location = new System.Drawing.Point(448, 72);
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
			// lblCin2
			// 
			this.lblCin2.Enabled = false;
			this.lblCin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCin2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCin2.Location = new System.Drawing.Point(192, 13);
			this.lblCin2.Name = "lblCin2";
			this.lblCin2.Size = new System.Drawing.Size(20, 14);
			this.lblCin2.TabIndex = 261;
			this.lblCin2.Text = "X0";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(176, 10);
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
			this.button66.Location = new System.Drawing.Point(40, 136);
			this.button66.Name = "button66";
			this.button66.Size = new System.Drawing.Size(10, 10);
			this.button66.TabIndex = 264;
			this.button66.TabStop = false;
			// 
			// button67
			// 
			this.button67.BackColor = System.Drawing.Color.DodgerBlue;
			this.button67.Enabled = false;
			this.button67.Location = new System.Drawing.Point(40, 400);
			this.button67.Name = "button67";
			this.button67.Size = new System.Drawing.Size(10, 10);
			this.button67.TabIndex = 263;
			this.button67.TabStop = false;
			// 
			// button18
			// 
			this.button18.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button18.BackgroundImage")));
			this.button18.Enabled = false;
			this.button18.Location = new System.Drawing.Point(776, 152);
			this.button18.Name = "button18";
			this.button18.Size = new System.Drawing.Size(96, 16);
			this.button18.TabIndex = 266;
			// 
			// button68
			// 
			this.button68.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button68.BackgroundImage")));
			this.button68.Enabled = false;
			this.button68.Location = new System.Drawing.Point(624, 152);
			this.button68.Name = "button68";
			this.button68.Size = new System.Drawing.Size(16, 136);
			this.button68.TabIndex = 269;
			// 
			// button6
			// 
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(624, 408);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(16, 136);
			this.button6.TabIndex = 271;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(424, 208);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(24, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 273;
			this.pictureBox6.TabStop = false;
			// 
			// button30
			// 
			this.button30.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button30.BackgroundImage")));
			this.button30.Enabled = false;
			this.button30.Image = ((System.Drawing.Image)(resources.GetObject("button30.Image")));
			this.button30.Location = new System.Drawing.Point(992, 0);
			this.button30.Name = "button30";
			this.button30.Size = new System.Drawing.Size(16, 112);
			this.button30.TabIndex = 276;
			// 
			// button70
			// 
			this.button70.BackColor = System.Drawing.Color.Transparent;
			this.button70.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button70.BackgroundImage")));
			this.button70.Enabled = false;
			this.button70.Location = new System.Drawing.Point(712, 152);
			this.button70.Name = "button70";
			this.button70.Size = new System.Drawing.Size(64, 16);
			this.button70.TabIndex = 282;
			// 
			// timer9
			// 
			this.timer9.Interval = 50;
			this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
			// 
			// lblOs2
			// 
			this.lblOs2.Enabled = false;
			this.lblOs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblOs2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblOs2.Location = new System.Drawing.Point(192, 71);
			this.lblOs2.Name = "lblOs2";
			this.lblOs2.Size = new System.Drawing.Size(20, 14);
			this.lblOs2.TabIndex = 285;
			this.lblOs2.Text = "X0";
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(176, 68);
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
			// Boman
			// 
			this.Boman.Image = ((System.Drawing.Image)(resources.GetObject("Boman.Image")));
			this.Boman.Location = new System.Drawing.Point(24, 568);
			this.Boman.Name = "Boman";
			this.Boman.Size = new System.Drawing.Size(40, 40);
			this.Boman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Boman.TabIndex = 289;
			this.Boman.TabStop = false;
			// 
			// button3
			// 
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Enabled = false;
			this.button3.Location = new System.Drawing.Point(872, 408);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(16, 120);
			this.button3.TabIndex = 290;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(320, 152);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(16, 120);
			this.button1.TabIndex = 294;
			// 
			// button12
			// 
			this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
			this.button12.Enabled = false;
			this.button12.Location = new System.Drawing.Point(336, 152);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(168, 16);
			this.button12.TabIndex = 293;
			// 
			// button15
			// 
			this.button15.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
			this.button15.Enabled = false;
			this.button15.Location = new System.Drawing.Point(320, 272);
			this.button15.Name = "button15";
			this.button15.Size = new System.Drawing.Size(184, 16);
			this.button15.TabIndex = 292;
			// 
			// button16
			// 
			this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
			this.button16.Enabled = false;
			this.button16.Location = new System.Drawing.Point(504, 264);
			this.button16.Name = "button16";
			this.button16.Size = new System.Drawing.Size(16, 24);
			this.button16.TabIndex = 291;
			// 
			// button19
			// 
			this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
			this.button19.Enabled = false;
			this.button19.Location = new System.Drawing.Point(320, 424);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(16, 104);
			this.button19.TabIndex = 298;
			// 
			// button20
			// 
			this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
			this.button20.Enabled = false;
			this.button20.Location = new System.Drawing.Point(320, 408);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(184, 16);
			this.button20.TabIndex = 297;
			// 
			// button22
			// 
			this.button22.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button22.BackgroundImage")));
			this.button22.Enabled = false;
			this.button22.Location = new System.Drawing.Point(320, 528);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(184, 16);
			this.button22.TabIndex = 296;
			// 
			// button23
			// 
			this.button23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button23.BackgroundImage")));
			this.button23.Enabled = false;
			this.button23.Location = new System.Drawing.Point(504, 408);
			this.button23.Name = "button23";
			this.button23.Size = new System.Drawing.Size(16, 136);
			this.button23.TabIndex = 295;
			// 
			// button24
			// 
			this.button24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button24.BackgroundImage")));
			this.button24.Enabled = false;
			this.button24.Location = new System.Drawing.Point(88, 408);
			this.button24.Name = "button24";
			this.button24.Size = new System.Drawing.Size(112, 16);
			this.button24.TabIndex = 299;
			// 
			// button28
			// 
			this.button28.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button28.BackgroundImage")));
			this.button28.Enabled = false;
			this.button28.Location = new System.Drawing.Point(88, 528);
			this.button28.Name = "button28";
			this.button28.Size = new System.Drawing.Size(96, 16);
			this.button28.TabIndex = 300;
			// 
			// button32
			// 
			this.button32.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button32.BackgroundImage")));
			this.button32.Enabled = false;
			this.button32.Location = new System.Drawing.Point(88, 272);
			this.button32.Name = "button32";
			this.button32.Size = new System.Drawing.Size(96, 16);
			this.button32.TabIndex = 303;
			// 
			// button33
			// 
			this.button33.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button33.BackgroundImage")));
			this.button33.Enabled = false;
			this.button33.Location = new System.Drawing.Point(88, 184);
			this.button33.Name = "button33";
			this.button33.Size = new System.Drawing.Size(112, 16);
			this.button33.TabIndex = 302;
			// 
			// button39
			// 
			this.button39.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button39.BackgroundImage")));
			this.button39.Enabled = false;
			this.button39.Location = new System.Drawing.Point(184, 200);
			this.button39.Name = "button39";
			this.button39.Size = new System.Drawing.Size(16, 88);
			this.button39.TabIndex = 301;
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.DodgerBlue;
			this.button7.Enabled = false;
			this.button7.Location = new System.Drawing.Point(304, 72);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(10, 10);
			this.button7.TabIndex = 304;
			this.button7.TabStop = false;
			// 
			// button47
			// 
			this.button47.BackColor = System.Drawing.Color.DodgerBlue;
			this.button47.Enabled = false;
			this.button47.Location = new System.Drawing.Point(256, 72);
			this.button47.Name = "button47";
			this.button47.Size = new System.Drawing.Size(10, 10);
			this.button47.TabIndex = 305;
			this.button47.TabStop = false;
			// 
			// cikisDuvari
			// 
			this.cikisDuvari.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.BackgroundImage")));
			this.cikisDuvari.Enabled = false;
			this.cikisDuvari.Image = ((System.Drawing.Image)(resources.GetObject("cikisDuvari.Image")));
			this.cikisDuvari.Location = new System.Drawing.Point(16, 616);
			this.cikisDuvari.Name = "cikisDuvari";
			this.cikisDuvari.Size = new System.Drawing.Size(88, 16);
			this.cikisDuvari.TabIndex = 307;
			// 
			// Exit
			// 
			this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
			this.Exit.Location = new System.Drawing.Point(16, 632);
			this.Exit.Name = "Exit";
			this.Exit.Size = new System.Drawing.Size(88, 24);
			this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Exit.TabIndex = 306;
			this.Exit.TabStop = false;
			this.Exit.Visible = false;
			// 
			// button29
			// 
			this.button29.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button29.BackgroundImage")));
			this.button29.Enabled = false;
			this.button29.Location = new System.Drawing.Point(104, 616);
			this.button29.Name = "button29";
			this.button29.Size = new System.Drawing.Size(16, 24);
			this.button29.TabIndex = 308;
			// 
			// button71
			// 
			this.button71.BackColor = System.Drawing.Color.DodgerBlue;
			this.button71.Enabled = false;
			this.button71.Location = new System.Drawing.Point(160, 584);
			this.button71.Name = "button71";
			this.button71.Size = new System.Drawing.Size(10, 10);
			this.button71.TabIndex = 310;
			this.button71.TabStop = false;
			// 
			// button72
			// 
			this.button72.BackColor = System.Drawing.Color.DodgerBlue;
			this.button72.Enabled = false;
			this.button72.Location = new System.Drawing.Point(40, 448);
			this.button72.Name = "button72";
			this.button72.Size = new System.Drawing.Size(10, 10);
			this.button72.TabIndex = 309;
			this.button72.TabStop = false;
			// 
			// button69
			// 
			this.button69.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button69.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button69.BackgroundImage")));
			this.button69.Enabled = false;
			this.button69.Location = new System.Drawing.Point(800, 528);
			this.button69.Name = "button69";
			this.button69.Size = new System.Drawing.Size(88, 16);
			this.button69.TabIndex = 311;
			// 
			// button73
			// 
			this.button73.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button73.BackgroundImage")));
			this.button73.Enabled = false;
			this.button73.Location = new System.Drawing.Point(504, 152);
			this.button73.Name = "button73";
			this.button73.Size = new System.Drawing.Size(16, 32);
			this.button73.TabIndex = 312;
			// 
			// button74
			// 
			this.button74.BackColor = System.Drawing.Color.DodgerBlue;
			this.button74.Enabled = false;
			this.button74.Location = new System.Drawing.Point(208, 584);
			this.button74.Name = "button74";
			this.button74.Size = new System.Drawing.Size(10, 10);
			this.button74.TabIndex = 317;
			this.button74.TabStop = false;
			// 
			// button75
			// 
			this.button75.BackColor = System.Drawing.Color.DodgerBlue;
			this.button75.Enabled = false;
			this.button75.Location = new System.Drawing.Point(384, 584);
			this.button75.Name = "button75";
			this.button75.Size = new System.Drawing.Size(10, 10);
			this.button75.TabIndex = 316;
			this.button75.TabStop = false;
			// 
			// button76
			// 
			this.button76.BackColor = System.Drawing.Color.DodgerBlue;
			this.button76.Enabled = false;
			this.button76.Location = new System.Drawing.Point(256, 584);
			this.button76.Name = "button76";
			this.button76.Size = new System.Drawing.Size(10, 10);
			this.button76.TabIndex = 315;
			this.button76.TabStop = false;
			// 
			// button77
			// 
			this.button77.BackColor = System.Drawing.Color.DodgerBlue;
			this.button77.Enabled = false;
			this.button77.Location = new System.Drawing.Point(296, 584);
			this.button77.Name = "button77";
			this.button77.Size = new System.Drawing.Size(10, 10);
			this.button77.TabIndex = 314;
			this.button77.TabStop = false;
			// 
			// button78
			// 
			this.button78.BackColor = System.Drawing.Color.DodgerBlue;
			this.button78.Enabled = false;
			this.button78.Location = new System.Drawing.Point(336, 584);
			this.button78.Name = "button78";
			this.button78.Size = new System.Drawing.Size(10, 10);
			this.button78.TabIndex = 313;
			this.button78.TabStop = false;
			// 
			// button79
			// 
			this.button79.BackColor = System.Drawing.Color.DodgerBlue;
			this.button79.Enabled = false;
			this.button79.Location = new System.Drawing.Point(432, 584);
			this.button79.Name = "button79";
			this.button79.Size = new System.Drawing.Size(10, 10);
			this.button79.TabIndex = 322;
			this.button79.TabStop = false;
			// 
			// button80
			// 
			this.button80.BackColor = System.Drawing.Color.DodgerBlue;
			this.button80.Enabled = false;
			this.button80.Location = new System.Drawing.Point(624, 584);
			this.button80.Name = "button80";
			this.button80.Size = new System.Drawing.Size(10, 10);
			this.button80.TabIndex = 321;
			this.button80.TabStop = false;
			// 
			// button81
			// 
			this.button81.BackColor = System.Drawing.Color.DodgerBlue;
			this.button81.Enabled = false;
			this.button81.Location = new System.Drawing.Point(480, 584);
			this.button81.Name = "button81";
			this.button81.Size = new System.Drawing.Size(10, 10);
			this.button81.TabIndex = 320;
			this.button81.TabStop = false;
			// 
			// button82
			// 
			this.button82.BackColor = System.Drawing.Color.DodgerBlue;
			this.button82.Enabled = false;
			this.button82.Location = new System.Drawing.Point(528, 584);
			this.button82.Name = "button82";
			this.button82.Size = new System.Drawing.Size(10, 10);
			this.button82.TabIndex = 319;
			this.button82.TabStop = false;
			// 
			// button83
			// 
			this.button83.BackColor = System.Drawing.Color.DodgerBlue;
			this.button83.Enabled = false;
			this.button83.Location = new System.Drawing.Point(576, 584);
			this.button83.Name = "button83";
			this.button83.Size = new System.Drawing.Size(10, 10);
			this.button83.TabIndex = 318;
			this.button83.TabStop = false;
			// 
			// button84
			// 
			this.button84.BackColor = System.Drawing.Color.DodgerBlue;
			this.button84.Enabled = false;
			this.button84.Location = new System.Drawing.Point(672, 584);
			this.button84.Name = "button84";
			this.button84.Size = new System.Drawing.Size(10, 10);
			this.button84.TabIndex = 327;
			this.button84.TabStop = false;
			// 
			// button85
			// 
			this.button85.BackColor = System.Drawing.Color.DodgerBlue;
			this.button85.Enabled = false;
			this.button85.Location = new System.Drawing.Point(864, 584);
			this.button85.Name = "button85";
			this.button85.Size = new System.Drawing.Size(10, 10);
			this.button85.TabIndex = 326;
			this.button85.TabStop = false;
			// 
			// button86
			// 
			this.button86.BackColor = System.Drawing.Color.DodgerBlue;
			this.button86.Enabled = false;
			this.button86.Location = new System.Drawing.Point(720, 584);
			this.button86.Name = "button86";
			this.button86.Size = new System.Drawing.Size(10, 10);
			this.button86.TabIndex = 325;
			this.button86.TabStop = false;
			// 
			// button87
			// 
			this.button87.BackColor = System.Drawing.Color.DodgerBlue;
			this.button87.Enabled = false;
			this.button87.Location = new System.Drawing.Point(768, 584);
			this.button87.Name = "button87";
			this.button87.Size = new System.Drawing.Size(10, 10);
			this.button87.TabIndex = 324;
			this.button87.TabStop = false;
			// 
			// button88
			// 
			this.button88.BackColor = System.Drawing.Color.DodgerBlue;
			this.button88.Enabled = false;
			this.button88.Location = new System.Drawing.Point(816, 584);
			this.button88.Name = "button88";
			this.button88.Size = new System.Drawing.Size(10, 10);
			this.button88.TabIndex = 323;
			this.button88.TabStop = false;
			// 
			// button89
			// 
			this.button89.BackColor = System.Drawing.Color.DodgerBlue;
			this.button89.Enabled = false;
			this.button89.Location = new System.Drawing.Point(256, 416);
			this.button89.Name = "button89";
			this.button89.Size = new System.Drawing.Size(10, 10);
			this.button89.TabIndex = 330;
			this.button89.TabStop = false;
			// 
			// button90
			// 
			this.button90.BackColor = System.Drawing.Color.DodgerBlue;
			this.button90.Enabled = false;
			this.button90.Location = new System.Drawing.Point(256, 472);
			this.button90.Name = "button90";
			this.button90.Size = new System.Drawing.Size(10, 10);
			this.button90.TabIndex = 329;
			this.button90.TabStop = false;
			// 
			// button92
			// 
			this.button92.BackColor = System.Drawing.Color.DodgerBlue;
			this.button92.Enabled = false;
			this.button92.Location = new System.Drawing.Point(256, 528);
			this.button92.Name = "button92";
			this.button92.Size = new System.Drawing.Size(10, 10);
			this.button92.TabIndex = 331;
			this.button92.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(560, 320);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 332;
			this.pictureBox4.TabStop = false;
			// 
			// button93
			// 
			this.button93.BackColor = System.Drawing.Color.DodgerBlue;
			this.button93.Enabled = false;
			this.button93.Location = new System.Drawing.Point(944, 440);
			this.button93.Name = "button93";
			this.button93.Size = new System.Drawing.Size(10, 10);
			this.button93.TabIndex = 334;
			this.button93.TabStop = false;
			// 
			// button94
			// 
			this.button94.BackColor = System.Drawing.Color.DodgerBlue;
			this.button94.Enabled = false;
			this.button94.Location = new System.Drawing.Point(944, 344);
			this.button94.Name = "button94";
			this.button94.Size = new System.Drawing.Size(10, 10);
			this.button94.TabIndex = 333;
			this.button94.TabStop = false;
			// 
			// button95
			// 
			this.button95.BackColor = System.Drawing.Color.DodgerBlue;
			this.button95.Enabled = false;
			this.button95.Location = new System.Drawing.Point(944, 280);
			this.button95.Name = "button95";
			this.button95.Size = new System.Drawing.Size(10, 10);
			this.button95.TabIndex = 336;
			this.button95.TabStop = false;
			// 
			// button96
			// 
			this.button96.BackColor = System.Drawing.Color.DodgerBlue;
			this.button96.Enabled = false;
			this.button96.Location = new System.Drawing.Point(944, 216);
			this.button96.Name = "button96";
			this.button96.Size = new System.Drawing.Size(10, 10);
			this.button96.TabIndex = 335;
			this.button96.TabStop = false;
			// 
			// button97
			// 
			this.button97.BackColor = System.Drawing.Color.DodgerBlue;
			this.button97.Enabled = false;
			this.button97.Location = new System.Drawing.Point(944, 160);
			this.button97.Name = "button97";
			this.button97.Size = new System.Drawing.Size(10, 10);
			this.button97.TabIndex = 339;
			this.button97.TabStop = false;
			// 
			// button98
			// 
			this.button98.BackColor = System.Drawing.Color.DodgerBlue;
			this.button98.Enabled = false;
			this.button98.Location = new System.Drawing.Point(944, 96);
			this.button98.Name = "button98";
			this.button98.Size = new System.Drawing.Size(10, 10);
			this.button98.TabIndex = 338;
			this.button98.TabStop = false;
			// 
			// button99
			// 
			this.button99.BackColor = System.Drawing.Color.DodgerBlue;
			this.button99.Enabled = false;
			this.button99.Location = new System.Drawing.Point(112, 584);
			this.button99.Name = "button99";
			this.button99.Size = new System.Drawing.Size(10, 10);
			this.button99.TabIndex = 340;
			this.button99.TabStop = false;
			// 
			// button100
			// 
			this.button100.BackColor = System.Drawing.Color.DodgerBlue;
			this.button100.Enabled = false;
			this.button100.Location = new System.Drawing.Point(120, 456);
			this.button100.Name = "button100";
			this.button100.Size = new System.Drawing.Size(10, 10);
			this.button100.TabIndex = 341;
			this.button100.TabStop = false;
			// 
			// button101
			// 
			this.button101.BackColor = System.Drawing.Color.DodgerBlue;
			this.button101.Enabled = false;
			this.button101.Location = new System.Drawing.Point(160, 504);
			this.button101.Name = "button101";
			this.button101.Size = new System.Drawing.Size(10, 10);
			this.button101.TabIndex = 342;
			this.button101.TabStop = false;
			// 
			// button102
			// 
			this.button102.BackColor = System.Drawing.Color.DodgerBlue;
			this.button102.Enabled = false;
			this.button102.Location = new System.Drawing.Point(168, 216);
			this.button102.Name = "button102";
			this.button102.Size = new System.Drawing.Size(10, 10);
			this.button102.TabIndex = 344;
			this.button102.TabStop = false;
			// 
			// button103
			// 
			this.button103.BackColor = System.Drawing.Color.DodgerBlue;
			this.button103.Enabled = false;
			this.button103.Location = new System.Drawing.Point(104, 248);
			this.button103.Name = "button103";
			this.button103.Size = new System.Drawing.Size(10, 10);
			this.button103.TabIndex = 343;
			this.button103.TabStop = false;
			// 
			// button104
			// 
			this.button104.BackColor = System.Drawing.Color.DodgerBlue;
			this.button104.Enabled = false;
			this.button104.Location = new System.Drawing.Point(112, 344);
			this.button104.Name = "button104";
			this.button104.Size = new System.Drawing.Size(10, 10);
			this.button104.TabIndex = 349;
			this.button104.TabStop = false;
			// 
			// button105
			// 
			this.button105.BackColor = System.Drawing.Color.DodgerBlue;
			this.button105.Enabled = false;
			this.button105.Location = new System.Drawing.Point(304, 344);
			this.button105.Name = "button105";
			this.button105.Size = new System.Drawing.Size(10, 10);
			this.button105.TabIndex = 348;
			this.button105.TabStop = false;
			// 
			// button106
			// 
			this.button106.BackColor = System.Drawing.Color.DodgerBlue;
			this.button106.Enabled = false;
			this.button106.Location = new System.Drawing.Point(160, 344);
			this.button106.Name = "button106";
			this.button106.Size = new System.Drawing.Size(10, 10);
			this.button106.TabIndex = 347;
			this.button106.TabStop = false;
			// 
			// button107
			// 
			this.button107.BackColor = System.Drawing.Color.DodgerBlue;
			this.button107.Enabled = false;
			this.button107.Location = new System.Drawing.Point(208, 344);
			this.button107.Name = "button107";
			this.button107.Size = new System.Drawing.Size(10, 10);
			this.button107.TabIndex = 346;
			this.button107.TabStop = false;
			// 
			// button108
			// 
			this.button108.BackColor = System.Drawing.Color.DodgerBlue;
			this.button108.Enabled = false;
			this.button108.Location = new System.Drawing.Point(256, 344);
			this.button108.Name = "button108";
			this.button108.Size = new System.Drawing.Size(10, 10);
			this.button108.TabIndex = 345;
			this.button108.TabStop = false;
			// 
			// button109
			// 
			this.button109.BackColor = System.Drawing.Color.DodgerBlue;
			this.button109.Enabled = false;
			this.button109.Location = new System.Drawing.Point(336, 344);
			this.button109.Name = "button109";
			this.button109.Size = new System.Drawing.Size(10, 10);
			this.button109.TabIndex = 354;
			this.button109.TabStop = false;
			// 
			// button110
			// 
			this.button110.BackColor = System.Drawing.Color.DodgerBlue;
			this.button110.Enabled = false;
			this.button110.Location = new System.Drawing.Point(528, 344);
			this.button110.Name = "button110";
			this.button110.Size = new System.Drawing.Size(10, 10);
			this.button110.TabIndex = 353;
			this.button110.TabStop = false;
			// 
			// button111
			// 
			this.button111.BackColor = System.Drawing.Color.DodgerBlue;
			this.button111.Enabled = false;
			this.button111.Location = new System.Drawing.Point(384, 344);
			this.button111.Name = "button111";
			this.button111.Size = new System.Drawing.Size(10, 10);
			this.button111.TabIndex = 352;
			this.button111.TabStop = false;
			// 
			// button112
			// 
			this.button112.BackColor = System.Drawing.Color.DodgerBlue;
			this.button112.Enabled = false;
			this.button112.Location = new System.Drawing.Point(432, 344);
			this.button112.Name = "button112";
			this.button112.Size = new System.Drawing.Size(10, 10);
			this.button112.TabIndex = 351;
			this.button112.TabStop = false;
			// 
			// button113
			// 
			this.button113.BackColor = System.Drawing.Color.DodgerBlue;
			this.button113.Enabled = false;
			this.button113.Location = new System.Drawing.Point(480, 344);
			this.button113.Name = "button113";
			this.button113.Size = new System.Drawing.Size(10, 10);
			this.button113.TabIndex = 350;
			this.button113.TabStop = false;
			// 
			// button114
			// 
			this.button114.BackColor = System.Drawing.Color.DodgerBlue;
			this.button114.Enabled = false;
			this.button114.Location = new System.Drawing.Point(616, 344);
			this.button114.Name = "button114";
			this.button114.Size = new System.Drawing.Size(10, 10);
			this.button114.TabIndex = 359;
			this.button114.TabStop = false;
			// 
			// button115
			// 
			this.button115.BackColor = System.Drawing.Color.DodgerBlue;
			this.button115.Enabled = false;
			this.button115.Location = new System.Drawing.Point(808, 344);
			this.button115.Name = "button115";
			this.button115.Size = new System.Drawing.Size(10, 10);
			this.button115.TabIndex = 358;
			this.button115.TabStop = false;
			// 
			// button116
			// 
			this.button116.BackColor = System.Drawing.Color.DodgerBlue;
			this.button116.Enabled = false;
			this.button116.Location = new System.Drawing.Point(664, 344);
			this.button116.Name = "button116";
			this.button116.Size = new System.Drawing.Size(10, 10);
			this.button116.TabIndex = 357;
			this.button116.TabStop = false;
			// 
			// button117
			// 
			this.button117.BackColor = System.Drawing.Color.DodgerBlue;
			this.button117.Enabled = false;
			this.button117.Location = new System.Drawing.Point(712, 344);
			this.button117.Name = "button117";
			this.button117.Size = new System.Drawing.Size(10, 10);
			this.button117.TabIndex = 356;
			this.button117.TabStop = false;
			// 
			// button118
			// 
			this.button118.BackColor = System.Drawing.Color.DodgerBlue;
			this.button118.Enabled = false;
			this.button118.Location = new System.Drawing.Point(760, 344);
			this.button118.Name = "button118";
			this.button118.Size = new System.Drawing.Size(10, 10);
			this.button118.TabIndex = 355;
			this.button118.TabStop = false;
			// 
			// button119
			// 
			this.button119.BackColor = System.Drawing.Color.DodgerBlue;
			this.button119.Enabled = false;
			this.button119.Location = new System.Drawing.Point(904, 344);
			this.button119.Name = "button119";
			this.button119.Size = new System.Drawing.Size(10, 10);
			this.button119.TabIndex = 360;
			this.button119.TabStop = false;
			// 
			// button53
			// 
			this.button53.BackColor = System.Drawing.Color.DodgerBlue;
			this.button53.Enabled = false;
			this.button53.Location = new System.Drawing.Point(576, 528);
			this.button53.Name = "button53";
			this.button53.Size = new System.Drawing.Size(10, 10);
			this.button53.TabIndex = 363;
			this.button53.TabStop = false;
			// 
			// button58
			// 
			this.button58.BackColor = System.Drawing.Color.DodgerBlue;
			this.button58.Enabled = false;
			this.button58.Location = new System.Drawing.Point(576, 416);
			this.button58.Name = "button58";
			this.button58.Size = new System.Drawing.Size(10, 10);
			this.button58.TabIndex = 362;
			this.button58.TabStop = false;
			// 
			// button91
			// 
			this.button91.BackColor = System.Drawing.Color.DodgerBlue;
			this.button91.Enabled = false;
			this.button91.Location = new System.Drawing.Point(576, 472);
			this.button91.Name = "button91";
			this.button91.Size = new System.Drawing.Size(10, 10);
			this.button91.TabIndex = 361;
			this.button91.TabStop = false;
			// 
			// button120
			// 
			this.button120.BackColor = System.Drawing.Color.DodgerBlue;
			this.button120.Enabled = false;
			this.button120.Location = new System.Drawing.Point(576, 224);
			this.button120.Name = "button120";
			this.button120.Size = new System.Drawing.Size(10, 10);
			this.button120.TabIndex = 365;
			this.button120.TabStop = false;
			// 
			// button121
			// 
			this.button121.BackColor = System.Drawing.Color.DodgerBlue;
			this.button121.Enabled = false;
			this.button121.Location = new System.Drawing.Point(576, 160);
			this.button121.Name = "button121";
			this.button121.Size = new System.Drawing.Size(10, 10);
			this.button121.TabIndex = 364;
			this.button121.TabStop = false;
			// 
			// button122
			// 
			this.button122.BackColor = System.Drawing.Color.DodgerBlue;
			this.button122.Enabled = false;
			this.button122.Location = new System.Drawing.Point(576, 280);
			this.button122.Name = "button122";
			this.button122.Size = new System.Drawing.Size(10, 10);
			this.button122.TabIndex = 366;
			this.button122.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(848, 440);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(16, 16);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 367;
			this.pictureBox8.TabStop = false;
			// 
			// button49
			// 
			this.button49.BackColor = System.Drawing.Color.DodgerBlue;
			this.button49.Enabled = false;
			this.button49.Location = new System.Drawing.Point(40, 544);
			this.button49.Name = "button49";
			this.button49.Size = new System.Drawing.Size(10, 10);
			this.button49.TabIndex = 369;
			this.button49.TabStop = false;
			// 
			// button63
			// 
			this.button63.BackColor = System.Drawing.Color.DodgerBlue;
			this.button63.Enabled = false;
			this.button63.Location = new System.Drawing.Point(40, 496);
			this.button63.Name = "button63";
			this.button63.Size = new System.Drawing.Size(10, 10);
			this.button63.TabIndex = 368;
			this.button63.TabStop = false;
			// 
			// button123
			// 
			this.button123.BackColor = System.Drawing.Color.DodgerBlue;
			this.button123.Enabled = false;
			this.button123.Location = new System.Drawing.Point(256, 136);
			this.button123.Name = "button123";
			this.button123.Size = new System.Drawing.Size(10, 10);
			this.button123.TabIndex = 370;
			this.button123.TabStop = false;
			// 
			// button124
			// 
			this.button124.BackColor = System.Drawing.Color.DodgerBlue;
			this.button124.Enabled = false;
			this.button124.Location = new System.Drawing.Point(944, 584);
			this.button124.Name = "button124";
			this.button124.Size = new System.Drawing.Size(10, 10);
			this.button124.TabIndex = 371;
			this.button124.TabStop = false;
			// 
			// button125
			// 
			this.button125.BackColor = System.Drawing.Color.DodgerBlue;
			this.button125.Enabled = false;
			this.button125.Location = new System.Drawing.Point(944, 392);
			this.button125.Name = "button125";
			this.button125.Size = new System.Drawing.Size(10, 10);
			this.button125.TabIndex = 374;
			this.button125.TabStop = false;
			// 
			// button126
			// 
			this.button126.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button126.BackgroundImage")));
			this.button126.Enabled = false;
			this.button126.Location = new System.Drawing.Point(640, 152);
			this.button126.Name = "button126";
			this.button126.Size = new System.Drawing.Size(72, 16);
			this.button126.TabIndex = 375;
			// 
			// lblPara2
			// 
			this.lblPara2.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.lblPara2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblPara2.ForeColor = System.Drawing.Color.Lime;
			this.lblPara2.Location = new System.Drawing.Point(40, 64);
			this.lblPara2.Name = "lblPara2";
			this.lblPara2.Size = new System.Drawing.Size(40, 24);
			this.lblPara2.TabIndex = 377;
			this.lblPara2.Text = "0 ";
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(0, 64);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(20, 21);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 378;
			this.pictureBox10.TabStop = false;
			// 
			// button127
			// 
			this.button127.BackColor = System.Drawing.Color.DodgerBlue;
			this.button127.Enabled = false;
			this.button127.Location = new System.Drawing.Point(72, 584);
			this.button127.Name = "button127";
			this.button127.Size = new System.Drawing.Size(10, 10);
			this.button127.TabIndex = 379;
			this.button127.TabStop = false;
			// 
			// button128
			// 
			this.button128.BackColor = System.Drawing.Color.DodgerBlue;
			this.button128.Enabled = false;
			this.button128.Location = new System.Drawing.Point(80, 344);
			this.button128.Name = "button128";
			this.button128.Size = new System.Drawing.Size(10, 10);
			this.button128.TabIndex = 380;
			this.button128.TabStop = false;
			// 
			// button129
			// 
			this.button129.BackColor = System.Drawing.Color.DodgerBlue;
			this.button129.Enabled = false;
			this.button129.Location = new System.Drawing.Point(24, 72);
			this.button129.Name = "button129";
			this.button129.Size = new System.Drawing.Size(10, 10);
			this.button129.TabIndex = 381;
			this.button129.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(88, 64);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(20, 21);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 382;
			this.pictureBox9.TabStop = false;
			// 
			// button130
			// 
			this.button130.BackColor = System.Drawing.Color.DodgerBlue;
			this.button130.Enabled = false;
			this.button130.Location = new System.Drawing.Point(112, 72);
			this.button130.Name = "button130";
			this.button130.Size = new System.Drawing.Size(10, 10);
			this.button130.TabIndex = 384;
			this.button130.TabStop = false;
			// 
			// lblMyMoney
			// 
			this.lblMyMoney.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.lblMyMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblMyMoney.ForeColor = System.Drawing.Color.Lime;
			this.lblMyMoney.Location = new System.Drawing.Point(128, 64);
			this.lblMyMoney.Name = "lblMyMoney";
			this.lblMyMoney.Size = new System.Drawing.Size(40, 24);
			this.lblMyMoney.TabIndex = 383;
			this.lblMyMoney.Text = "0 ";
			// 
			// timer4
			// 
			this.timer4.Interval = 1000;
			this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
			// 
			// lblKazan
			// 
			this.lblKazan.BackColor = System.Drawing.Color.Transparent;
			this.lblKazan.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblKazan.ForeColor = System.Drawing.Color.Crimson;
			this.lblKazan.Location = new System.Drawing.Point(328, 304);
			this.lblKazan.Name = "lblKazan";
			this.lblKazan.Size = new System.Drawing.Size(488, 83);
			this.lblKazan.TabIndex = 385;
			this.lblKazan.Text = "Sen Kazandýn!!";
			this.lblKazan.Visible = false;
			// 
			// lblKaybet
			// 
			this.lblKaybet.BackColor = System.Drawing.Color.Transparent;
			this.lblKaybet.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblKaybet.ForeColor = System.Drawing.Color.Crimson;
			this.lblKaybet.Location = new System.Drawing.Point(400, 312);
			this.lblKaybet.Name = "lblKaybet";
			this.lblKaybet.Size = new System.Drawing.Size(344, 80);
			this.lblKaybet.TabIndex = 386;
			this.lblKaybet.Text = "Kaybettin!!";
			this.lblKaybet.Visible = false;
			// 
			// timer5
			// 
			this.timer5.Interval = 200;
			this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
			// 
			// lblRound
			// 
			this.lblRound.BackColor = System.Drawing.Color.Transparent;
			this.lblRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblRound.ForeColor = System.Drawing.Color.Crimson;
			this.lblRound.Location = new System.Drawing.Point(400, 304);
			this.lblRound.Name = "lblRound";
			this.lblRound.Size = new System.Drawing.Size(344, 80);
			this.lblRound.TabIndex = 387;
			this.lblRound.Text = "Kaybettin!!";
			this.lblRound.Visible = false;
			// 
			// picCmpRound
			// 
			this.picCmpRound.Image = ((System.Drawing.Image)(resources.GetObject("picCmpRound.Image")));
			this.picCmpRound.Location = new System.Drawing.Point(16, 56);
			this.picCmpRound.Name = "picCmpRound";
			this.picCmpRound.Size = new System.Drawing.Size(16, 16);
			this.picCmpRound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picCmpRound.TabIndex = 388;
			this.picCmpRound.TabStop = false;
			this.picCmpRound.Visible = false;
			// 
			// picBenround
			// 
			this.picBenround.Image = ((System.Drawing.Image)(resources.GetObject("picBenround.Image")));
			this.picBenround.Location = new System.Drawing.Point(104, 56);
			this.picBenround.Name = "picBenround";
			this.picBenround.Size = new System.Drawing.Size(16, 16);
			this.picBenround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picBenround.TabIndex = 389;
			this.picBenround.TabStop = false;
			this.picBenround.Visible = false;
			// 
			// Boss1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1008, 654);
			this.Controls.Add(this.picBenround);
			this.Controls.Add(this.lblRound);
			this.Controls.Add(this.lblKaybet);
			this.Controls.Add(this.lblKazan);
			this.Controls.Add(this.button130);
			this.Controls.Add(this.lblMyMoney);
			this.Controls.Add(this.button129);
			this.Controls.Add(this.button128);
			this.Controls.Add(this.button127);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.lblPara2);
			this.Controls.Add(this.button126);
			this.Controls.Add(this.button125);
			this.Controls.Add(this.button124);
			this.Controls.Add(this.button123);
			this.Controls.Add(this.button49);
			this.Controls.Add(this.button63);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.button122);
			this.Controls.Add(this.button120);
			this.Controls.Add(this.button121);
			this.Controls.Add(this.button53);
			this.Controls.Add(this.button58);
			this.Controls.Add(this.button91);
			this.Controls.Add(this.button119);
			this.Controls.Add(this.button114);
			this.Controls.Add(this.button115);
			this.Controls.Add(this.button116);
			this.Controls.Add(this.button117);
			this.Controls.Add(this.button118);
			this.Controls.Add(this.button109);
			this.Controls.Add(this.button110);
			this.Controls.Add(this.button111);
			this.Controls.Add(this.button112);
			this.Controls.Add(this.button113);
			this.Controls.Add(this.button104);
			this.Controls.Add(this.button105);
			this.Controls.Add(this.button106);
			this.Controls.Add(this.button107);
			this.Controls.Add(this.button108);
			this.Controls.Add(this.button102);
			this.Controls.Add(this.button103);
			this.Controls.Add(this.button101);
			this.Controls.Add(this.button100);
			this.Controls.Add(this.button99);
			this.Controls.Add(this.button97);
			this.Controls.Add(this.button98);
			this.Controls.Add(this.button95);
			this.Controls.Add(this.button96);
			this.Controls.Add(this.button93);
			this.Controls.Add(this.button94);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.button92);
			this.Controls.Add(this.button89);
			this.Controls.Add(this.button90);
			this.Controls.Add(this.button84);
			this.Controls.Add(this.button85);
			this.Controls.Add(this.button86);
			this.Controls.Add(this.button87);
			this.Controls.Add(this.button88);
			this.Controls.Add(this.button79);
			this.Controls.Add(this.button80);
			this.Controls.Add(this.button81);
			this.Controls.Add(this.button82);
			this.Controls.Add(this.button83);
			this.Controls.Add(this.button74);
			this.Controls.Add(this.button75);
			this.Controls.Add(this.button76);
			this.Controls.Add(this.button77);
			this.Controls.Add(this.button78);
			this.Controls.Add(this.button73);
			this.Controls.Add(this.button69);
			this.Controls.Add(this.button71);
			this.Controls.Add(this.button72);
			this.Controls.Add(this.button29);
			this.Controls.Add(this.cikisDuvari);
			this.Controls.Add(this.Exit);
			this.Controls.Add(this.button47);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button32);
			this.Controls.Add(this.button33);
			this.Controls.Add(this.button39);
			this.Controls.Add(this.button28);
			this.Controls.Add(this.button24);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.button23);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button15);
			this.Controls.Add(this.button16);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.Boman);
			this.Controls.Add(this.lblOs);
			this.Controls.Add(this.ostime);
			this.Controls.Add(this.osuruk);
			this.Controls.Add(this.lblOs2);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.button70);
			this.Controls.Add(this.button30);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button68);
			this.Controls.Add(this.button18);
			this.Controls.Add(this.button66);
			this.Controls.Add(this.button67);
			this.Controls.Add(this.lblCin2);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.lblCin);
			this.Controls.Add(this.breakTime);
			this.Controls.Add(this.gin);
			this.Controls.Add(this.button65);
			this.Controls.Add(this.button64);
			this.Controls.Add(this.button62);
			this.Controls.Add(this.button61);
			this.Controls.Add(this.button46);
			this.Controls.Add(this.button54);
			this.Controls.Add(this.button60);
			this.Controls.Add(this.button59);
			this.Controls.Add(this.button56);
			this.Controls.Add(this.button57);
			this.Controls.Add(this.button55);
			this.Controls.Add(this.button52);
			this.Controls.Add(this.button51);
			this.Controls.Add(this.button50);
			this.Controls.Add(this.yemlik3);
			this.Controls.Add(this.button48);
			this.Controls.Add(this.button45);
			this.Controls.Add(this.button44);
			this.Controls.Add(this.button43);
			this.Controls.Add(this.button41);
			this.Controls.Add(this.button42);
			this.Controls.Add(this.button40);
			this.Controls.Add(this.button38);
			this.Controls.Add(this.button36);
			this.Controls.Add(this.button37);
			this.Controls.Add(this.button35);
			this.Controls.Add(this.button34);
			this.Controls.Add(this.yemlik1);
			this.Controls.Add(this.button31);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button14);
			this.Controls.Add(this.button26);
			this.Controls.Add(this.button25);
			this.Controls.Add(this.button17);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPara);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.lblCani);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.lblYemlik);
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
			this.Controls.Add(this.button27);
			this.Controls.Add(this.monsterBoss1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Cikis);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.picCmpRound);
			this.Name = "Boss1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kalan Zaman:40";
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
		double Money2;
		int yemlik;
		int intbomb;
		int Hak;
		private void Level4_Load(object sender, System.EventArgs e)
		{
			htable=new Hashtable();
			
			htable["monster5"]="";
			htable["smonster5"]="";
			timer3.Start();
		}

		Path rotate;
		Direction go;
		
		Keys dir;
		
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
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
			}

			i-=1;
			if(i==0)
			{
				label2.Text="Git";
			}
			if(i<0)
			{
				label2.Visible=false;
				lblRound.Visible=true;
				lblRound.Text="Round "+(intRound+1).ToString();
				if(i<-2)
				{
					lblRound.Visible=false;
					timer3.Stop();
					rotate=new Path();
					go=new Direction();
					this.Focus();
				
					timer9.Start();
					timer4.Start();
				}
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
			if(label2.Visible!=true && zaman>0 && lblRound.Visible==false)
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
				else if(zaman>0)
				{
					timer1.Stop();
					timer2.Start();
					nityol=Nitro.Yok;
				}
				//Gas Alýyoruz-----------------
				if(Math.Abs((Boman.Location.X+20)-572)<=45 && Math.Abs((Boman.Location.Y+20)-336)<=45)
				{
					if(pictureBox4.Visible==true)
					{
						string str=Application.StartupPath.ToString()+"\\sound\\SOUND240.wav";
						Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
						nitro.Width=80;
					}
					pictureBox4.Visible=false;
				}
				//bitti------------
				//Gas Alýyoruz-----------------
				if(Math.Abs((Boman.Location.X+20)-436)<=43 && Math.Abs((Boman.Location.Y+20)-224)<=40)
				{
					if(pictureBox6.Visible==true)
					{
						string str=Application.StartupPath.ToString()+"\\sound\\SOUND240.wav";
						Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
						nitro.Width=80;
					}
					pictureBox6.Visible=false;
				}
				//bitti------------
				
				int oncekiHak=Hak;
				go.Move(e,Boman,this,ref Money,nityol,new int[]{16,576,72,576},new int[]{24, 568},ref Hak,ref yemlik,ref intbomb,"Form4",Exit,htable,"down");
				//lblPara.Text=Money.ToString()+" YTL";
				lblMyMoney.Text=((Money-gelenPara)/10).ToString();
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
					
     		
				
				}
				if(e.KeyCode==Keys.Escape)
				{
					timer1.Stop();
					timer2.Stop();
					timer3.Stop();
					
					timer9.Stop();
					if(MessageBox.Show("Çýkmak istediðinize eminmisiniz","Çýkýþ",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk)==DialogResult.OK)
					{
						this.Dispose();
						this.Close();
						Giris frm=new Giris();
						frm.Show();
					}
					else if(zaman>0)
					{
						timer1.Start();
						timer2.Start();
						timer3.Start();
					
						timer9.Start();
					
					}
				}
				if(e.KeyCode==Keys.D)
				{
					timer1.Stop();
					timer2.Stop();
					timer3.Stop();
					timer4.Stop();
					timer8.Stop();
					timer9.Stop();
					timer10.Stop();
					if(MessageBox.Show("Duraklat","Dur",MessageBoxButtons.OK,MessageBoxIcon.Information)==DialogResult.OK)
					{	
						timer1.Start();
						timer2.Start();
						timer3.Start();
						timer4.Start();
						timer8.Start();
						timer9.Start();
						timer10.Start();
					}
				}
			}
		}

		private void Level4_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.Shift==false && Hak>0 && zaman>0)
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
				
			}
		}

		int i1=0;
		int hareket=0;
		Random rnd;
		int b24=0;
		int a21=0;
		int b2=0;
		int b22=0;
		private void timer9_Tick(object sender, System.EventArgs e)
		{
			if(i1==0)
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
			}
			if(i1==1 && hareket==0)//a1
			{
				dir=Keys.Left;
				hareket++;
			}
			
			if(i1==2 && hareket==0)//b1
			{
				dir=Keys.Down;
				hareket++;
			}
			if(hareket==1 && i1==1 && monsterBoss1.Location.X<=560)//a2
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(i1==1)
				{
					dir=Keys.Left;
					a21=1;
				}
				if(i1==2)
					dir=Keys.Down;
				hareket++;
			}
			if(hareket==1 && i1==2 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=928)//b2
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(i1==1)
				{
					dir=Keys.Left;
					b2=1;
				}
				if(i1==2)
					dir=Keys.Down;
				hareket++;
			}
			if(hareket==2 && i1==2 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X<=560)//a2.1
			{
				rnd=new Random();
				i1=rnd.Next(1,4);
				if(i1==1)
				{
					a21=1;
					dir=Keys.Left;
				}
				if(i1==2)
					dir=Keys.Down;
				if(i1==3)
					dir=Keys.Right;
				hareket++;
			}
			if(hareket==3 && i1==3 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=928)//a2.1_1
			{
				i1=2;
				dir=Keys.Down;
				hareket++;
			}
			if((hareket==4 || hareket==2) && i1==2 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X>=928)//a2.1_2
			{
				i1=1;
				dir=Keys.Left;
				hareket++;
			}
			if((hareket==5 || hareket==4) && i1==1 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X<=240)//a2.1_3
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(i1==1)
					dir=Keys.Left;
				if(i1==2)
					dir=Keys.Up;
				hareket++;
			}
			if(hareket==3 && i1==2 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X>240 && monsterBoss1.Location.X<=560)//a2.3
			{
				i1=1;
				dir=Keys.Left;
				hareket++;
			}
			if(hareket==3 && i1==1 && monsterBoss1.Location.Y<=568 && monsterBoss1.Location.X>240 && monsterBoss1.Location.X<=560)//b2.2
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(i1==1)
					dir=Keys.Left;
				if(i1==2)
				{
					dir=Keys.Up;
					b22=1;
				}
				hareket++;
			}
			if(hareket==4 && i1==2 && monsterBoss1.Location.Y<=328 && monsterBoss1.Location.X>240 && monsterBoss1.Location.X<=560)//b2.3
			{
				i1=1;
				dir=Keys.Left;
				hareket++;
				b22=0;
			}
			if((hareket==5 || hareket==4 )&& i1==1 && monsterBoss1.Location.Y<=328 && monsterBoss1.Location.X<=240)//b2.4
			{
				if(a21==0)
				{
					b2=0;
					b24=1;
					i1=2;
					dir=Keys.Up;
					hareket++;
				}
				else
				{
					i1=1;
					dir=Keys.Left;
					hareket++;
				}
			}
			if((hareket==6 || hareket==5) && i1==2 && monsterBoss1.Location.Y<=328 && monsterBoss1.Location.X<=240)//a2.1_4
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(b24==1)
					i1=2;
				if(i1==1)
					dir=Keys.Right;
				if(i1==2)
					dir=Keys.Up;
				hareket++;
			}
			if(hareket==7 && i1==1 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=928)//a2.1_5
			{
				i1=2;
				dir=Keys.Up;
				hareket++;
			}
//			if((hareket==8 || hareket==11) && i1==2 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=928)//a2.1_son1
			if((hareket==8 || hareket==6 || hareket==11) && i1==2 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=928)//a2.1_son1
			{
				i1=0;
				hareket=0;
			}

			if(hareket==7 && i1==2 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X<=240)//a2.1_6
			{
				i1=1;
				dir=Keys.Right;
				hareket++;
			}
			if(hareket==8 && i1==1 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=928)//a2.1_son2
			{
				i1=0;
				hareket=0;
			}
			
			if((hareket==6 || hareket==4) && i1==1 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X<=24)//a2.1_7
			{
				i1=2;
				dir=Keys.Up;
				hareket++;
			}
			if((hareket==7 || hareket==5) && i1==2 && monsterBoss1.Location.Y<=120 && monsterBoss1.Location.X<=24)//a2.1_8
			{
				i1=1;
				dir=Keys.Right;
				hareket++;
			}
			if(hareket==8 && i1==1 && monsterBoss1.Location.Y<=120 && monsterBoss1.Location.X>=240)//a2.1_9
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(a21==1)
				{
					a21=0;
				}
				if(b24==1)
				{
					b24=0;
				}
				else
				{
					if(i1==1)
						dir=Keys.Down;
					if(i1==2)
						dir=Keys.Up;
				}
				hareket++;
			}
			if(hareket==9 && i1==2 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=240)//a2.1_10
			{
				i1=1;
				dir=Keys.Right;
				hareket++;
			}
			if((hareket==10|| hareket==9) && i1==1 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=928)//a2.1_son3
			{
				i1=0;
				hareket=0;
			}
			//if(hareket==9 && i1==1 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=240)//a2.1_11
			if(b22==0 && b2==0 && (hareket==4 || hareket==9) && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=240 && monsterBoss1.Location.Y<400 && monsterBoss1.Location.X<560)//a2.1_11
			{
				i1=1;
				dir=Keys.Right;
				hareket++;
			}
			//if(hareket==10 && i1==1 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=928)//a2.1_12
			if((hareket==5 || hareket==10)&& i1==1 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=928 && monsterBoss1.Location.Y<540)//a2.1_12
			{
				i1=2;
				dir=Keys.Up;
				hareket++;
			}
			if(a21==1 && hareket==2 && i1==1 && monsterBoss1.Location.X<=240)//a2.2
			{
				i1=2;
				dir=Keys.Down;
				hareket++;
			}
			if(hareket==3 && i1==2 && monsterBoss1.Location.Y>=120 && monsterBoss1.Location.X<=258)//a2.3
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(i1==1)
					dir=Keys.Left;
				if(i1==2)
					dir=Keys.Down;
				hareket++;
			}
			//if(hareket==4 && i1==1 && monsterBoss1.Location.Y>=120 && monsterBoss1.Location.X<=24)//a2.3_1
			if(hareket==6 && i1==1 && monsterBoss1.Location.Y>=120 && monsterBoss1.Location.X<=24)//a2.3_1
			{
				i1=2;
				dir=Keys.Down;
				hareket++;
			}
			if(hareket==5 && i1==2 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X<=24)//a2.3_1_1
			{
				rnd=new Random();
				i1=rnd.Next(1,3);
				if(i1==1)
					dir=Keys.Right;
				if(i1==2)
					dir=Keys.Down;
				hareket++;
			}
			if(hareket==6 && i1==1 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X<=24)//a2.2
			{
				i1=2;
				dir=Keys.Up;
				hareket++;
			}
			if(hareket==6 && i1==1 && monsterBoss1.Location.Y>=328 && monsterBoss1.Location.X>=928)//a2.3_1_2
			{
				i1=2;
				dir=Keys.Up;
				hareket++;
			}
			if(hareket==7 && i1==2 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=928)//a2.3_1_son1
			{
				i1=0;
				hareket=0;
			}
			//if(hareket==6 && i1==2 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X<=24)//a2.3_1_3
			if(hareket==7 && i1==2 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X<=24)//a2.3_1_3
			{
				if(dir==Keys.Down)
				{
					i1=1;
					dir=Keys.Right;
					hareket++;
				}
			}
			//if(hareket==7 && i1==1 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X>=928)//a2.3_1_4
			if(hareket==8 && i1==1 && monsterBoss1.Location.Y>=568 && monsterBoss1.Location.X>=928)//a2.3_1_4
			{
				i1=2;
				dir=Keys.Up;
				hareket++;
			}
			//if(hareket==8 && i1==2 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=928)//a2.3_1_son2
			if(hareket==9 && i1==2 && monsterBoss1.Location.Y<=48 && monsterBoss1.Location.X>=928)//a2.3_1_son2
			{
				i1=0;
				hareket=0;
			}
			if(hareket==2 && i1==1 && monsterBoss1.Location.X<=560 && monsterBoss1.Location.Y>=328)//b2.1
			{	
				rnd=new Random();
				if(i1==1)
				{
					dir=Keys.Left;
				}
				if(i1==2)
					dir=Keys.Down;
				hareket++;
			}
			
			Nitro nit=Nitro.Var;
			go.Move(dir,monsterBoss1,this,ref Money2,nit,new int[]{24,568},Boman,ref Hak,ref yemlik,ref intbomb,Exit,htable,0,0,1000,648);
			if(Money2>0)
				lblPara2.Text=(Money2/10).ToString();
			else
			{
				lblPara2.Text=(Money2).ToString();
			}
			lblCani.Text="X"+ Hak.ToString();
			lblYemlik.Text="X"+yemlik.ToString();
			if(Hak==0)
			{
				kapat();
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
			}
		}

		int zaman=40;
		private void timer4_Tick(object sender, System.EventArgs e)
		{
			zaman--;
			if(zaman>=0)
			this.Text="Kalan zaman:"+(zaman).ToString();;

			if(zaman==0)
			{
				timer2.Stop();
				timer1.Stop();
				timer3.Stop();
			
				timer8.Stop();
				timer10.Stop();
				timer9.Stop();
				if((Money-gelenPara)>Money2)
				{
					intBen++;
					string str=Application.StartupPath.ToString()+"\\sound\\J0214098.wav";
					Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);

					//lblPara.Text=Money.ToString()+" YTL";
					lblKazan.Visible=true;

					if(intBen<2 && zaman<-2)
					{
						timer4.Stop();
						this.Dispose();
						this.Close();
						Boss1 boss=new Boss1(gelenPara,yemlik,Hak,this,Cin,Osuruk,intRound+1,intBen+1 ,intCmp);
						boss.Show();
					}
				}
				else
				{
					lblKaybet.Visible=true;
					intCmp++;
					if(Hak>1)
					{
						Hak--;
						//Boss1 boss=new Boss1(gelenPara,yemlik,Hak/*,this*/,Cin,Osuruk);
						if(intCmp<2)
						{
							if(zaman<-2)
							{
								timer4.Stop();
								this.Dispose();
								this.Close();
								Boss1 boss=new Boss1(gelenPara,yemlik,Hak,this,Cin,Osuruk,intRound+1,intBen ,intCmp+1);
								boss.Show();
							}
						}
						else
						{
							kapat();
						}
					}
					else
					{
						kapat();
					}
				}
			}
			else if(zaman<-2)
			{
				if(intCmp<2 && intBen<2)
				{
					timer4.Stop();
					this.Dispose();
					this.Close();
					Boss1 boss=new Boss1(gelenPara,yemlik,Hak,this,Cin,Osuruk,intRound+1,intBen ,intCmp);
					boss.Show();
				}
				else if(intCmp>=2)
				{
					kapat();
				}
				else if(intBen>=2)
				{
					timer5.Start();
				}
			}
		}

		double miktar=0;
		int i3,ekle=0;
		private void timer5_Tick(object sender, System.EventArgs e)
		{
			if(i3==0)
			{
				miktar=(Money-gelenPara);
				i3++;
			}
			if(miktar>0)
			{
				miktar-=10;
				ekle+=10;				
				lblPara.Text=(gelenPara+ekle).ToString();
				lblMyMoney.Text=(int.Parse(lblMyMoney.Text)-1).ToString();
			}
			else
			{
				timer5.Stop();
				this.Dispose();
				this.Close();
				Form5 frm5=new Form5(Money,yemlik,Hak);
				frm5.Show();
			}
			
		}

		
	}
}
