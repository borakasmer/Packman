using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using tonysound;
using System.Data;

namespace Packman
{
	/// <summary>
	/// Summary description for Giris.
	/// </summary>
	public class Giris : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox pictureBox12;
		private System.Windows.Forms.PictureBox pictureBox13;
		private System.Windows.Forms.PictureBox pictureBox14;
		private System.Windows.Forms.PictureBox pictureBox15;
		private System.Windows.Forms.PictureBox pictureBox16;
		private System.Windows.Forms.PictureBox pictureBox18;
		private System.Windows.Forms.PictureBox pictureBox19;
		private System.Windows.Forms.PictureBox pictureBox20;
		private System.Windows.Forms.PictureBox pictureBox21;
		private System.Windows.Forms.PictureBox pictureBox22;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.PictureBox pictureBox11;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label lblDevam;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox17;
		private System.Windows.Forms.PictureBox pictureBox23;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.PictureBox pictureBox24;
		private System.Windows.Forms.PictureBox pictureBox25;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.PictureBox pictureBox26;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.PictureBox pictureBox27;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.PictureBox imgSec;
		private System.ComponentModel.IContainer components;

		public static string KodAdi;
		public Giris()
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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Giris));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.pictureBox12 = new System.Windows.Forms.PictureBox();
			this.pictureBox13 = new System.Windows.Forms.PictureBox();
			this.pictureBox14 = new System.Windows.Forms.PictureBox();
			this.pictureBox15 = new System.Windows.Forms.PictureBox();
			this.pictureBox16 = new System.Windows.Forms.PictureBox();
			this.pictureBox18 = new System.Windows.Forms.PictureBox();
			this.pictureBox19 = new System.Windows.Forms.PictureBox();
			this.pictureBox20 = new System.Windows.Forms.PictureBox();
			this.pictureBox21 = new System.Windows.Forms.PictureBox();
			this.pictureBox22 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.label25 = new System.Windows.Forms.Label();
			this.lblDevam = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.imgSec = new System.Windows.Forms.PictureBox();
			this.label28 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.pictureBox23 = new System.Windows.Forms.PictureBox();
			this.pictureBox17 = new System.Windows.Forms.PictureBox();
			this.pictureBox27 = new System.Windows.Forms.PictureBox();
			this.pictureBox26 = new System.Windows.Forms.PictureBox();
			this.pictureBox25 = new System.Windows.Forms.PictureBox();
			this.pictureBox24 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label29 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(48, 64);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(160, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "BORSOFT CEZAEVÝ";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(184, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "KÝMLÝK KARTI";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 136);
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 136);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(24, 136);
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(0, 408);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(24, 136);
			this.pictureBox4.TabIndex = 6;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(0, 272);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(24, 136);
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(0, 680);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(144, 24);
			this.pictureBox6.TabIndex = 8;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(0, 544);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(24, 136);
			this.pictureBox7.TabIndex = 7;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(144, 680);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(144, 24);
			this.pictureBox8.TabIndex = 9;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(432, 680);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(112, 24);
			this.pictureBox9.TabIndex = 11;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(288, 680);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(144, 24);
			this.pictureBox10.TabIndex = 10;
			this.pictureBox10.TabStop = false;
			// 
			// pictureBox12
			// 
			this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
			this.pictureBox12.Location = new System.Drawing.Point(520, 568);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(24, 136);
			this.pictureBox12.TabIndex = 15;
			this.pictureBox12.TabStop = false;
			// 
			// pictureBox13
			// 
			this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
			this.pictureBox13.Location = new System.Drawing.Point(520, 432);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(24, 136);
			this.pictureBox13.TabIndex = 14;
			this.pictureBox13.TabStop = false;
			// 
			// pictureBox14
			// 
			this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
			this.pictureBox14.Location = new System.Drawing.Point(520, 296);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(24, 136);
			this.pictureBox14.TabIndex = 13;
			this.pictureBox14.TabStop = false;
			// 
			// pictureBox15
			// 
			this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
			this.pictureBox15.Location = new System.Drawing.Point(520, 160);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(24, 136);
			this.pictureBox15.TabIndex = 17;
			this.pictureBox15.TabStop = false;
			// 
			// pictureBox16
			// 
			this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
			this.pictureBox16.Location = new System.Drawing.Point(520, 24);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(24, 136);
			this.pictureBox16.TabIndex = 16;
			this.pictureBox16.TabStop = false;
			// 
			// pictureBox18
			// 
			this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
			this.pictureBox18.Location = new System.Drawing.Point(456, 0);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(88, 24);
			this.pictureBox18.TabIndex = 19;
			this.pictureBox18.TabStop = false;
			// 
			// pictureBox19
			// 
			this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
			this.pictureBox19.Location = new System.Drawing.Point(312, 0);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(144, 24);
			this.pictureBox19.TabIndex = 18;
			this.pictureBox19.TabStop = false;
			// 
			// pictureBox20
			// 
			this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
			this.pictureBox20.Location = new System.Drawing.Point(168, 0);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(144, 24);
			this.pictureBox20.TabIndex = 21;
			this.pictureBox20.TabStop = false;
			// 
			// pictureBox21
			// 
			this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
			this.pictureBox21.Location = new System.Drawing.Point(24, 0);
			this.pictureBox21.Name = "pictureBox21";
			this.pictureBox21.Size = new System.Drawing.Size(144, 24);
			this.pictureBox21.TabIndex = 22;
			this.pictureBox21.TabStop = false;
			// 
			// pictureBox22
			// 
			this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
			this.pictureBox22.Location = new System.Drawing.Point(400, 80);
			this.pictureBox22.Name = "pictureBox22";
			this.pictureBox22.Size = new System.Drawing.Size(84, 84);
			this.pictureBox22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox22.TabIndex = 23;
			this.pictureBox22.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Jokerman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(400, 165);
			this.label3.Name = "label3";
			this.label3.TabIndex = 24;
			this.label3.Text = "No:578046";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(64, 164);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(144, 24);
			this.label4.TabIndex = 25;
			this.label4.Text = "SERÝ           A07";
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(24, 192);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(496, 8);
			this.groupBox1.TabIndex = 26;
			this.groupBox1.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(64, 200);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(112, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "T.C.KÝMLÝK NO";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(64, 216);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(224, 24);
			this.label6.TabIndex = 28;
			this.label6.Text = "2 6 0 3 3 0 4 6 6 0 0";
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(24, 248);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(496, 8);
			this.groupBox2.TabIndex = 29;
			this.groupBox2.TabStop = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(64, 272);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 24);
			this.label7.TabIndex = 31;
			this.label7.Text = "MAN";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(64, 256);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 16);
			this.label8.TabIndex = 30;
			this.label8.Text = "SOYADI";
			// 
			// groupBox3
			// 
			this.groupBox3.Location = new System.Drawing.Point(24, 296);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(496, 8);
			this.groupBox3.TabIndex = 32;
			this.groupBox3.TabStop = false;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(64, 320);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(168, 24);
			this.label9.TabIndex = 34;
			this.label9.Text = "BO";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(64, 304);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 16);
			this.label10.TabIndex = 33;
			this.label10.Text = "ADI";
			// 
			// groupBox4
			// 
			this.groupBox4.Location = new System.Drawing.Point(24, 344);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(496, 8);
			this.groupBox4.TabIndex = 35;
			this.groupBox4.TabStop = false;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(64, 368);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(168, 32);
			this.label11.TabIndex = 37;
			this.label11.Text = "ERDÝNÇ";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(64, 352);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(104, 16);
			this.label12.TabIndex = 36;
			this.label12.Text = "BABA ADI";
			// 
			// groupBox5
			// 
			this.groupBox5.Location = new System.Drawing.Point(24, 394);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(496, 8);
			this.groupBox5.TabIndex = 38;
			this.groupBox5.TabStop = false;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(64, 418);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(168, 32);
			this.label13.TabIndex = 40;
			this.label13.Text = "BÝRSEN";
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(64, 402);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 16);
			this.label14.TabIndex = 39;
			this.label14.Text = "ANA ADI";
			// 
			// groupBox6
			// 
			this.groupBox6.Location = new System.Drawing.Point(24, 443);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(496, 8);
			this.groupBox6.TabIndex = 41;
			this.groupBox6.TabStop = false;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(64, 468);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(112, 32);
			this.label15.TabIndex = 43;
			this.label15.Text = "Ýstanbul";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(64, 452);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(104, 16);
			this.label16.TabIndex = 42;
			this.label16.Text = "DOÐUM YERÝ";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.ForeColor = System.Drawing.Color.Black;
			this.label17.Location = new System.Drawing.Point(184, 468);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(136, 32);
			this.label17.TabIndex = 46;
			this.label17.Text = "03.06.1978";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.ForeColor = System.Drawing.Color.Black;
			this.label18.Location = new System.Drawing.Point(184, 452);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(112, 16);
			this.label18.TabIndex = 45;
			this.label18.Text = "DOÐUM TARÝHÝ";
			// 
			// groupBox8
			// 
			this.groupBox8.Location = new System.Drawing.Point(24, 495);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(496, 8);
			this.groupBox8.TabIndex = 47;
			this.groupBox8.TabStop = false;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.ForeColor = System.Drawing.Color.Black;
			this.label19.Location = new System.Drawing.Point(64, 520);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(112, 32);
			this.label19.TabIndex = 49;
			this.label19.Text = "Bekar";
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.ForeColor = System.Drawing.Color.Black;
			this.label20.Location = new System.Drawing.Point(64, 504);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(96, 16);
			this.label20.TabIndex = 48;
			this.label20.Text = "MEDENÝ HALÝ";
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.ForeColor = System.Drawing.Color.Black;
			this.label21.Location = new System.Drawing.Point(192, 520);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(112, 32);
			this.label21.TabIndex = 51;
			this.label21.Text = "Ýslam";
			// 
			// label22
			// 
			this.label22.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.Black;
			this.label22.Location = new System.Drawing.Point(192, 504);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(96, 16);
			this.label22.TabIndex = 50;
			this.label22.Text = "DÝNÝ";
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.ForeColor = System.Drawing.Color.Black;
			this.label23.Location = new System.Drawing.Point(320, 520);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(112, 32);
			this.label23.TabIndex = 53;
			this.label23.Text = "A Rh+";
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.ForeColor = System.Drawing.Color.Black;
			this.label24.Location = new System.Drawing.Point(320, 504);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(104, 16);
			this.label24.TabIndex = 52;
			this.label24.Text = "KAN GURUBU";
			// 
			// groupBox7
			// 
			this.groupBox7.Location = new System.Drawing.Point(24, 552);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(496, 8);
			this.groupBox7.TabIndex = 54;
			this.groupBox7.TabStop = false;
			// 
			// pictureBox11
			// 
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(344, 600);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(110, 26);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox11.TabIndex = 55;
			this.pictureBox11.TabStop = false;
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("Jokerman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(336, 576);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(136, 16);
			this.label25.TabIndex = 56;
			this.label25.Text = "Hapishane Müdürü:";
			// 
			// lblDevam
			// 
			this.lblDevam.BackColor = System.Drawing.Color.Gainsboro;
			this.lblDevam.Font = new System.Drawing.Font("Jokerman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblDevam.Location = new System.Drawing.Point(152, 648);
			this.lblDevam.Name = "lblDevam";
			this.lblDevam.Size = new System.Drawing.Size(256, 25);
			this.lblDevam.TabIndex = 57;
			this.lblDevam.Text = "Devam Ýçin Bir Butona Basýnýz";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(328, 560);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(0, 23);
			this.button1.TabIndex = 0;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.imgSec);
			this.panel1.Controls.Add(this.label28);
			this.panel1.Controls.Add(this.listBox1);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.pictureBox23);
			this.panel1.Controls.Add(this.pictureBox17);
			this.panel1.Controls.Add(this.pictureBox27);
			this.panel1.Controls.Add(this.pictureBox26);
			this.panel1.Controls.Add(this.pictureBox25);
			this.panel1.Controls.Add(this.pictureBox24);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(552, 8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 688);
			this.panel1.TabIndex = 59;
			// 
			// imgSec
			// 
			this.imgSec.Image = ((System.Drawing.Image)(resources.GetObject("imgSec.Image")));
			this.imgSec.Location = new System.Drawing.Point(8, 368);
			this.imgSec.Name = "imgSec";
			this.imgSec.Size = new System.Drawing.Size(24, 32);
			this.imgSec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgSec.TabIndex = 60;
			this.imgSec.TabStop = false;
			this.imgSec.DoubleClick += new System.EventHandler(this.imgSec_DoubleClick);
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.ForeColor = System.Drawing.Color.Red;
			this.label28.Location = new System.Drawing.Point(16, 592);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(112, 23);
			this.label28.TabIndex = 8;
			this.label28.Text = "Ýlk 10 BoMan";
			// 
			// listBox1
			// 
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.ForeColor = System.Drawing.Color.Teal;
			this.listBox1.ItemHeight = 31;
			this.listBox1.Location = new System.Drawing.Point(34, 368);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(88, 186);
			this.listBox1.TabIndex = 6;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.ForeColor = System.Drawing.Color.Red;
			this.label27.Location = new System.Drawing.Point(32, 272);
			this.label27.Name = "label27";
			this.label27.TabIndex = 5;
			this.label27.Text = "Eski Oyuncu ";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.ForeColor = System.Drawing.Color.Red;
			this.label26.Location = new System.Drawing.Point(32, 0);
			this.label26.Name = "label26";
			this.label26.TabIndex = 2;
			this.label26.Text = "Yeni Oyuncu ";
			// 
			// pictureBox23
			// 
			this.pictureBox23.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
			this.pictureBox23.Location = new System.Drawing.Point(16, 24);
			this.pictureBox23.Name = "pictureBox23";
			this.pictureBox23.Size = new System.Drawing.Size(100, 144);
			this.pictureBox23.TabIndex = 1;
			this.pictureBox23.TabStop = false;
			this.pictureBox23.MouseEnter += new System.EventHandler(this.pictureBox23_MouseEnter);
			// 
			// pictureBox17
			// 
			this.pictureBox17.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
			this.pictureBox17.Location = new System.Drawing.Point(16, 24);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(100, 144);
			this.pictureBox17.TabIndex = 0;
			this.pictureBox17.TabStop = false;
			this.pictureBox17.Click += new System.EventHandler(this.pictureBox17_Click);
			this.pictureBox17.MouseLeave += new System.EventHandler(this.pictureBox17_MouseLeave);
			// 
			// pictureBox27
			// 
			this.pictureBox27.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
			this.pictureBox27.Location = new System.Drawing.Point(12, 624);
			this.pictureBox27.Name = "pictureBox27";
			this.pictureBox27.Size = new System.Drawing.Size(112, 52);
			this.pictureBox27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox27.TabIndex = 9;
			this.pictureBox27.TabStop = false;
			this.pictureBox27.MouseEnter += new System.EventHandler(this.pictureBox27_MouseEnter);
			// 
			// pictureBox26
			// 
			this.pictureBox26.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
			this.pictureBox26.Location = new System.Drawing.Point(12, 624);
			this.pictureBox26.Name = "pictureBox26";
			this.pictureBox26.Size = new System.Drawing.Size(112, 52);
			this.pictureBox26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox26.TabIndex = 7;
			this.pictureBox26.TabStop = false;
			this.pictureBox26.Click += new System.EventHandler(this.pictureBox26_Click);
			this.pictureBox26.MouseLeave += new System.EventHandler(this.pictureBox26_MouseLeave);
			// 
			// pictureBox25
			// 
			this.pictureBox25.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
			this.pictureBox25.Location = new System.Drawing.Point(18, 304);
			this.pictureBox25.Name = "pictureBox25";
			this.pictureBox25.Size = new System.Drawing.Size(100, 72);
			this.pictureBox25.TabIndex = 4;
			this.pictureBox25.TabStop = false;
			this.pictureBox25.MouseEnter += new System.EventHandler(this.pictureBox25_MouseEnter);
			// 
			// pictureBox24
			// 
			this.pictureBox24.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
			this.pictureBox24.Location = new System.Drawing.Point(18, 304);
			this.pictureBox24.Name = "pictureBox24";
			this.pictureBox24.Size = new System.Drawing.Size(100, 72);
			this.pictureBox24.TabIndex = 3;
			this.pictureBox24.TabStop = false;
			this.pictureBox24.Click += new System.EventHandler(this.pictureBox24_Click);
			this.pictureBox24.MouseLeave += new System.EventHandler(this.pictureBox24_MouseLeave);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label29);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Location = new System.Drawing.Point(8, 72);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(120, 88);
			this.panel2.TabIndex = 10;
			this.panel2.Visible = false;
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label29.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label29.Location = new System.Drawing.Point(8, 8);
			this.label29.Name = "label29";
			this.label29.TabIndex = 1;
			this.label29.Text = "Kod Adý";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(8, 32);
			this.textBox1.MaxLength = 6;
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 1;
			this.textBox1.TabStop = false;
			this.textBox1.Text = "";
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button2.Location = new System.Drawing.Point(8, 60);
			this.button2.Name = "button2";
			this.button2.TabIndex = 60;
			this.button2.TabStop = false;
			this.button2.Text = "Tamam";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// timer2
			// 
			this.timer2.Interval = 1;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// Giris
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(696, 702);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblDevam);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.pictureBox11);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.label23);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.label21);
			this.Controls.Add(this.label22);
			this.Controls.Add(this.label19);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox22);
			this.Controls.Add(this.pictureBox21);
			this.Controls.Add(this.pictureBox20);
			this.Controls.Add(this.pictureBox18);
			this.Controls.Add(this.pictureBox19);
			this.Controls.Add(this.pictureBox15);
			this.Controls.Add(this.pictureBox16);
			this.Controls.Add(this.pictureBox12);
			this.Controls.Add(this.pictureBox13);
			this.Controls.Add(this.pictureBox14);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.MaximizeBox = false;
			this.Name = "Giris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giris";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Giris_Closing);
			this.Load += new System.EventHandler(this.Giris_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(lblDevam.ForeColor==Color.Black)
			{
				lblDevam.ForeColor=Color.Red;
				
			}
			else
			{
				lblDevam.ForeColor=Color.Black;
			}
		}

		public DataSet MakeXml()
		{
			//Playerlar için xml
			DataSet ds=new DataSet();
			DataTable dt=new DataTable("PlayerName");
			DataColumn dc=new DataColumn("Adý",typeof(string));
			DataColumn dc2=new DataColumn("Sonmu",typeof(int));

			dt.Columns.Add(dc);
			dt.Columns.Add(dc2);
			
			DataRow drow3=dt.NewRow();
			drow3["Adý"]="  ";
			drow3["Sonmu"]=0;
			dt.Rows.Add(drow3);
			DataSet ds2=new DataSet();
			ds2.Tables.Add(dt);
			ds2.WriteXml("player.xml");
			ds.ReadXml("player.xml");
			return ds;
			//---------------bitti-----------------------------------------
		}
		private void Giris_Load(object sender, System.EventArgs e)
		{
			lblDevam.Text="Bir Oyuncu Seçiniz!";
			KodAdi="";
			timer1.Start();
			string str=Application.StartupPath.ToString()+"\\sound\\22040_mr_rolfi_jam2.wav";
			Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_LOOP);

			DataSet ds=new DataSet();
			try
			{
				ds.ReadXml("player.xml");
			}
			catch
			{
				ds=MakeXml();
			}
			if(ds.Tables.Count==0)
			{
				ds=MakeXml();
			}
			listBox1.Items.Clear();
			foreach(DataRow drow in  ds.Tables["PlayerName"].Rows)
			{
				if(drow[0].ToString().Trim()!="" && int.Parse(drow[1].ToString())==1)
				{
					lblDevam.Text="Devam Ýçin Bir Butona Basýnýz";
					KodAdi=drow[0].ToString();
					listBox1.Items.Add(drow[0].ToString());
					break;
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(KodAdi!=null && KodAdi.Trim()!="")
			{
				timer1.Stop();
				string str=Application.StartupPath.ToString()+"\\sound\\sus.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				Introl frm=new Introl();
				this.Visible=false;
				frm.Show();
			}

		}

		private void pictureBox23_MouseEnter(object sender, System.EventArgs e)
		{
			if(pictureBox23.Visible==true)
			{
				pictureBox23.Visible=false;
			}
		}

		private void pictureBox17_MouseLeave(object sender, System.EventArgs e)
		{
			if(pictureBox23.Visible==false)
			{
				pictureBox23.Visible=true;
			}
		}

		private void pictureBox25_MouseEnter(object sender, System.EventArgs e)
		{
			if(pictureBox25.Visible==true)
			{
				pictureBox25.Visible=false;
			}
		}

		private void pictureBox24_MouseLeave(object sender, System.EventArgs e)
		{
			if(pictureBox25.Visible==false)
			{
				pictureBox25.Visible=true;
			}
		}

		private void Giris_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			timer1.Stop();
			Application.Exit();
		}

		private void pictureBox27_MouseEnter(object sender, System.EventArgs e)
		{
			if(pictureBox27.Visible==true)
			{
				pictureBox27.Visible=false;
			}
		}

		private void pictureBox26_MouseLeave(object sender, System.EventArgs e)
		{
			if(pictureBox27.Visible==false)
			{
				pictureBox27.Visible=true;
			}
		}

		private void pictureBox26_Click(object sender, System.EventArgs e)
		{
			this.Visible=false;
			info frm=new info(this);
			frm.Show();
			panel2.Visible=false;
			panel2.Location=new Point(panel2.Location.X,72);
			ilk=0;
		}

		private void pictureBox17_Click(object sender, System.EventArgs e)
		{
			panel2.Visible=true;
			textBox1.Focus();
			textBox1.Text="";
			timer2.Start();
		}

		int ilk=0;
		private void timer2_Tick(object sender, System.EventArgs e)
		{
			if(ilk==2)
			{
				if(panel2.Location.Y-2>72)
				{
					panel2.Location=new Point(panel2.Location.X,panel2.Location.Y-2);
				}
				else
				{
					ilk=0;
					button1.Focus();
					timer2.Stop();
				}
			}
			else
			{
				if(panel2.Location.Y+2<168)
				{
					panel2.Location=new Point(panel2.Location.X,panel2.Location.Y+2);
				}
				else
				{
					if(ilk!=2)
					{
						ilk=2;
					}
					timer2.Stop();	
				}
			}
		}

		private void pictureBox24_Click(object sender, System.EventArgs e)
		{
			if(listBox1.Items.Count==1 || listBox1.Items.Count==0)
			{
				DataSet ds=new DataSet();
				ds.ReadXml("player.xml");
				listBox1.Items.Clear();
				if(ds.Tables.Count==0)
				{
					ds=MakeXml();
				}
				foreach(DataRow drow in  ds.Tables["PlayerName"].Rows)
				{
					if(drow[0].ToString().Trim()!="")
					{
						listBox1.Items.Add(drow[0].ToString());
						if(int.Parse(drow[1].ToString())==1)
						{
							KodAdi=drow[0].ToString();
							lblDevam.Text="Devam Ýçin Bir Butona Basýnýz";
							listBox1.SelectedIndex=listBox1.FindString(drow[0].ToString());
						}
					}
				}
			}
			else
			{
				DataSet ds=new DataSet();
				ds.ReadXml("player.xml");
				listBox1.Items.Clear();
				foreach(DataRow drow in  ds.Tables["PlayerName"].Rows)
				{
					if(drow[0].ToString().Trim()!="")
					{
						if(int.Parse(drow[1].ToString())==1)
						{
							KodAdi=drow[0].ToString();
							lblDevam.Text="Devam Ýçin Bir Butona Basýnýz";
							listBox1.Items.Add(drow[0].ToString());
							listBox1.SelectedIndex=0;
						}
					}
				}
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(textBox1.Text.Trim()!="")
			{
				DataSet ds=new DataSet();
				ds.ReadXml("player.xml");
				listBox1.Items.Clear();
				bool var=false;
				if(ds.Tables.Count==0)
				{
					ds=MakeXml();
				}
				foreach(DataRow drow in  ds.Tables["PlayerName"].Rows)
				{
					if(drow[0].ToString().Trim().ToLower()==textBox1.Text.Trim().ToLower())
					{
						var=true;
					}
					else
					{
						drow[1]=0;
					}
				}
				if(var==false)
				{
					DataRow drow2=ds.Tables[0].NewRow();
					drow2[0]=textBox1.Text;
					drow2[1]=1;
					ds.Tables[0].Rows.Add(drow2);

					for(int i=ds.Tables["PlayerName"].Rows.Count-1;i>=0;i--)
					{
						if(ds.Tables["PlayerName"].Rows[i][0]==null || ds.Tables["PlayerName"].Rows[i][0].ToString().Trim()=="")
						{
							ds.Tables["PlayerName"].Rows.Remove(ds.Tables["PlayerName"].Rows[i]);
						}
					}

					ds.WriteXml("player.xml");
				}

				listBox1.Items.Clear();
				foreach(DataRow drow in  ds.Tables["PlayerName"].Rows)
				{
					if(int.Parse(drow[1].ToString())==1)
					{
						KodAdi=drow[0].ToString();
						lblDevam.Text="Devam Ýçin Bir Butona Basýnýz";
						listBox1.Items.Add(drow[0].ToString());
						imgSec.Location=new Point(8,368); 
						//listBox1.SelectedIndex=listBox1.FindString(drow[0].ToString());
						break;
					}
				}
				textBox1.Text="";
				timer2.Start();
				button1.Focus();
			}
		}
		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if(listBox1.SelectedItem.ToString().Trim()!="")
			{
				imgSec.Location=new Point(imgSec.Location.X,367+(33*(listBox1.SelectedIndex)));
			
				DataSet ds=new DataSet();
				ds.ReadXml("player.xml");
				DataSet ds2=ds.Clone();
				foreach(DataRow drow in  ds.Tables["PlayerName"].Rows)
				{
					DataRow drow2=ds2.Tables[0].NewRow();
					drow2[0]=drow[0].ToString();
					if(drow[0].ToString().Trim().ToLower()==listBox1.SelectedItem.ToString().Trim().ToLower())
					{
						drow2[1]=1;
						KodAdi=drow[0].ToString();
						lblDevam.Text="Devam Ýçin Bir Butona Basýnýz";
					}
					else
					{
						drow2[1]=0;
					}
					ds2.Tables[0].Rows.Add(drow2);
				}
				ds2.WriteXml("player.xml");
				button1.Focus();
			}
		}

		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			textBox1.BackColor=Color.SkyBlue;
		}

		private void textBox1_Leave(object sender, System.EventArgs e)
		{
			textBox1.BackColor=Color.White;
		}

		private void imgSec_DoubleClick(object sender, System.EventArgs e)
		{
			if(listBox1.SelectedIndex==-1 && listBox1.Items.Count==1)
			{
				listBox1.SelectedIndex=0;
			}
			if(listBox1.Items.Count>0 && listBox1.SelectedItem.ToString().Trim()!="")
			{
				if(MessageBox.Show("Silinsin mi?","Uyarý",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
				{
					DataSet ds=new DataSet();
					ds.ReadXml("player.xml");
					for(int i=ds.Tables["PlayerName"].Rows.Count-1;i>=0;i--)
					{
						if(ds.Tables["PlayerName"].Rows[i][0].ToString()== listBox1.SelectedItem.ToString())
						{
							ds.Tables["PlayerName"].Rows.Remove(ds.Tables["PlayerName"].Rows[i]);
						}
					}

					ds.WriteXml("player.xml");
					listBox1.Items.Clear();
					lblDevam.Text="Bir Oyuncu Seçiniz!";
					KodAdi="";
					imgSec.Location=new Point(imgSec.Location.X,340);
					foreach(DataRow drow in  ds.Tables["PlayerName"].Rows)
					{
						listBox1.Items.Add(drow[0].ToString());
					}
				}
			}
		}

		private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Enter)
			{
				button2_Click(null,null);
			}
		}
	}

		/*private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
				string a=textBox1.Text;
				textBox1.Text="";
				textBox1.AppendText(a.ToUpper());
		}*/
}
