using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using tonysound;

namespace Packman
{
	/// <summary>
	/// Summary description for info.
	/// </summary>
	public class info : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.PictureBox imgSumo;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

		Form frmEnter;
		public info()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		public info(Form frm)
		{
			InitializeComponent();
			frmEnter=frm;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(info));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.imgSumo = new System.Windows.Forms.PictureBox();
			this.label42 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label38);
			this.panel1.Controls.Add(this.label39);
			this.panel1.Controls.Add(this.label40);
			this.panel1.Controls.Add(this.label41);
			this.panel1.Controls.Add(this.label34);
			this.panel1.Controls.Add(this.label35);
			this.panel1.Controls.Add(this.label36);
			this.panel1.Controls.Add(this.label37);
			this.panel1.Controls.Add(this.label30);
			this.panel1.Controls.Add(this.label31);
			this.panel1.Controls.Add(this.label32);
			this.panel1.Controls.Add(this.label33);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.label28);
			this.panel1.Controls.Add(this.label29);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label23);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
			this.panel1.Location = new System.Drawing.Point(96, 652);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(496, 544);
			this.panel1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Gainsboro;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.button1.Location = new System.Drawing.Point(96, 504);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(312, 23);
			this.button1.TabIndex = 40;
			this.button1.Text = "ANA MENÜYE DÖN";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label38
			// 
			this.label38.BackColor = System.Drawing.Color.Transparent;
			this.label38.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label38.Location = new System.Drawing.Point(416, 440);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(100, 40);
			this.label38.TabIndex = 39;
			this.label38.Text = "label38";
			// 
			// label39
			// 
			this.label39.BackColor = System.Drawing.Color.Transparent;
			this.label39.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label39.Location = new System.Drawing.Point(288, 440);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(100, 40);
			this.label39.TabIndex = 38;
			this.label39.Text = "label39";
			// 
			// label40
			// 
			this.label40.BackColor = System.Drawing.Color.Transparent;
			this.label40.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label40.Location = new System.Drawing.Point(152, 440);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(110, 40);
			this.label40.TabIndex = 37;
			this.label40.Text = "label40";
			// 
			// label41
			// 
			this.label41.BackColor = System.Drawing.Color.Transparent;
			this.label41.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label41.Location = new System.Drawing.Point(32, 440);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(100, 40);
			this.label41.TabIndex = 36;
			this.label41.Text = "label41";
			// 
			// label34
			// 
			this.label34.BackColor = System.Drawing.Color.Transparent;
			this.label34.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label34.ForeColor = System.Drawing.Color.SteelBlue;
			this.label34.Location = new System.Drawing.Point(416, 392);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(100, 40);
			this.label34.TabIndex = 35;
			this.label34.Text = "label34";
			// 
			// label35
			// 
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label35.ForeColor = System.Drawing.Color.SteelBlue;
			this.label35.Location = new System.Drawing.Point(288, 392);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(100, 40);
			this.label35.TabIndex = 34;
			this.label35.Text = "label35";
			// 
			// label36
			// 
			this.label36.BackColor = System.Drawing.Color.Transparent;
			this.label36.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label36.ForeColor = System.Drawing.Color.SteelBlue;
			this.label36.Location = new System.Drawing.Point(152, 392);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(110, 40);
			this.label36.TabIndex = 33;
			this.label36.Text = "label36";
			// 
			// label37
			// 
			this.label37.BackColor = System.Drawing.Color.Transparent;
			this.label37.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label37.ForeColor = System.Drawing.Color.SteelBlue;
			this.label37.Location = new System.Drawing.Point(32, 392);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(100, 40);
			this.label37.TabIndex = 32;
			this.label37.Text = "label37";
			// 
			// label30
			// 
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label30.ForeColor = System.Drawing.Color.SteelBlue;
			this.label30.Location = new System.Drawing.Point(416, 344);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(100, 40);
			this.label30.TabIndex = 31;
			this.label30.Text = "label30";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Transparent;
			this.label31.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label31.ForeColor = System.Drawing.Color.SteelBlue;
			this.label31.Location = new System.Drawing.Point(288, 344);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(100, 40);
			this.label31.TabIndex = 30;
			this.label31.Text = "label31";
			// 
			// label32
			// 
			this.label32.BackColor = System.Drawing.Color.Transparent;
			this.label32.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label32.ForeColor = System.Drawing.Color.SteelBlue;
			this.label32.Location = new System.Drawing.Point(152, 344);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(110, 40);
			this.label32.TabIndex = 29;
			this.label32.Text = "label32";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Transparent;
			this.label33.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label33.ForeColor = System.Drawing.Color.SteelBlue;
			this.label33.Location = new System.Drawing.Point(32, 344);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(100, 40);
			this.label33.TabIndex = 28;
			this.label33.Text = "label33";
			// 
			// label26
			// 
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label26.ForeColor = System.Drawing.Color.SteelBlue;
			this.label26.Location = new System.Drawing.Point(416, 296);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 40);
			this.label26.TabIndex = 27;
			this.label26.Text = "label26";
			// 
			// label27
			// 
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label27.ForeColor = System.Drawing.Color.SteelBlue;
			this.label27.Location = new System.Drawing.Point(288, 296);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(100, 40);
			this.label27.TabIndex = 26;
			this.label27.Text = "label27";
			// 
			// label28
			// 
			this.label28.BackColor = System.Drawing.Color.Transparent;
			this.label28.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label28.ForeColor = System.Drawing.Color.SteelBlue;
			this.label28.Location = new System.Drawing.Point(152, 296);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(110, 40);
			this.label28.TabIndex = 25;
			this.label28.Text = "label28";
			// 
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.Transparent;
			this.label29.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label29.ForeColor = System.Drawing.Color.SteelBlue;
			this.label29.Location = new System.Drawing.Point(32, 296);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(100, 40);
			this.label29.TabIndex = 24;
			this.label29.Text = "label29";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label22.ForeColor = System.Drawing.Color.SteelBlue;
			this.label22.Location = new System.Drawing.Point(32, 248);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(100, 40);
			this.label22.TabIndex = 23;
			this.label22.Text = "label22";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Transparent;
			this.label23.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label23.ForeColor = System.Drawing.Color.SteelBlue;
			this.label23.Location = new System.Drawing.Point(152, 248);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(110, 40);
			this.label23.TabIndex = 22;
			this.label23.Text = "label23";
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Transparent;
			this.label24.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label24.ForeColor = System.Drawing.Color.SteelBlue;
			this.label24.Location = new System.Drawing.Point(288, 248);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(100, 40);
			this.label24.TabIndex = 21;
			this.label24.Text = "label24";
			// 
			// label25
			// 
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label25.ForeColor = System.Drawing.Color.SteelBlue;
			this.label25.Location = new System.Drawing.Point(416, 248);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(100, 40);
			this.label25.TabIndex = 20;
			this.label25.Text = "label25";
			// 
			// label18
			// 
			this.label18.BackColor = System.Drawing.Color.Transparent;
			this.label18.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label18.ForeColor = System.Drawing.Color.SteelBlue;
			this.label18.Location = new System.Drawing.Point(32, 200);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 40);
			this.label18.TabIndex = 19;
			this.label18.Text = "label18";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label19.ForeColor = System.Drawing.Color.SteelBlue;
			this.label19.Location = new System.Drawing.Point(152, 200);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(110, 40);
			this.label19.TabIndex = 18;
			this.label19.Text = "label19";
			// 
			// label20
			// 
			this.label20.BackColor = System.Drawing.Color.Transparent;
			this.label20.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label20.ForeColor = System.Drawing.Color.SteelBlue;
			this.label20.Location = new System.Drawing.Point(288, 200);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 40);
			this.label20.TabIndex = 17;
			this.label20.Text = "label20";
			// 
			// label21
			// 
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label21.ForeColor = System.Drawing.Color.SteelBlue;
			this.label21.Location = new System.Drawing.Point(416, 200);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(100, 40);
			this.label21.TabIndex = 16;
			this.label21.Text = "label21";
			// 
			// label14
			// 
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label14.ForeColor = System.Drawing.Color.SteelBlue;
			this.label14.Location = new System.Drawing.Point(32, 152);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 40);
			this.label14.TabIndex = 15;
			this.label14.Text = "label14";
			// 
			// label15
			// 
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label15.ForeColor = System.Drawing.Color.SteelBlue;
			this.label15.Location = new System.Drawing.Point(152, 152);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110, 40);
			this.label15.TabIndex = 14;
			this.label15.Text = "label15";
			// 
			// label16
			// 
			this.label16.BackColor = System.Drawing.Color.Transparent;
			this.label16.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label16.ForeColor = System.Drawing.Color.SteelBlue;
			this.label16.Location = new System.Drawing.Point(288, 152);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 40);
			this.label16.TabIndex = 13;
			this.label16.Text = "label16";
			// 
			// label17
			// 
			this.label17.BackColor = System.Drawing.Color.Transparent;
			this.label17.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label17.ForeColor = System.Drawing.Color.SteelBlue;
			this.label17.Location = new System.Drawing.Point(416, 152);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 40);
			this.label17.TabIndex = 12;
			this.label17.Text = "label17";
			// 
			// label10
			// 
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label10.ForeColor = System.Drawing.Color.SteelBlue;
			this.label10.Location = new System.Drawing.Point(32, 104);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 40);
			this.label10.TabIndex = 11;
			this.label10.Text = "label10";
			// 
			// label11
			// 
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label11.ForeColor = System.Drawing.Color.SteelBlue;
			this.label11.Location = new System.Drawing.Point(152, 104);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(110, 40);
			this.label11.TabIndex = 10;
			this.label11.Text = "label11";
			// 
			// label12
			// 
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label12.ForeColor = System.Drawing.Color.SteelBlue;
			this.label12.Location = new System.Drawing.Point(288, 104);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 40);
			this.label12.TabIndex = 9;
			this.label12.Text = "label12";
			// 
			// label13
			// 
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold);
			this.label13.ForeColor = System.Drawing.Color.SteelBlue;
			this.label13.Location = new System.Drawing.Point(416, 104);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 40);
			this.label13.TabIndex = 8;
			this.label13.Text = "label13";
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.SteelBlue;
			this.label6.Location = new System.Drawing.Point(32, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 40);
			this.label6.TabIndex = 7;
			this.label6.Text = "label6";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.SteelBlue;
			this.label7.Location = new System.Drawing.Point(152, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 40);
			this.label7.TabIndex = 6;
			this.label7.Text = "label7";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.SteelBlue;
			this.label8.Location = new System.Drawing.Point(288, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 40);
			this.label8.TabIndex = 5;
			this.label8.Text = "label8";
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.SteelBlue;
			this.label9.Location = new System.Drawing.Point(416, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 40);
			this.label9.TabIndex = 4;
			this.label9.Text = "label9";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.SteelBlue;
			this.label5.Location = new System.Drawing.Point(416, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 40);
			this.label5.TabIndex = 3;
			this.label5.Text = "label5";
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.SteelBlue;
			this.label4.Location = new System.Drawing.Point(288, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 40);
			this.label4.TabIndex = 2;
			this.label4.Text = "label4";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SteelBlue;
			this.label3.Location = new System.Drawing.Point(152, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 40);
			this.label3.TabIndex = 1;
			this.label3.Text = "label3";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Jokerman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SteelBlue;
			this.label2.Location = new System.Drawing.Point(32, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 40);
			this.label2.TabIndex = 0;
			this.label2.Text = "label2";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(8, 160);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(65, 125);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(592, 296);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 130);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(128, 16);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(400, 50);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(248, 0);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(40, 88);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 5;
			this.pictureBox6.TabStop = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 1;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(-8, 632);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(112, 64);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 6;
			this.pictureBox7.TabStop = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(584, 632);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(104, 64);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 7;
			this.pictureBox8.TabStop = false;
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(16, 584);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(80, 50);
			this.pictureBox9.TabIndex = 8;
			this.pictureBox9.TabStop = false;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(592, 584);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(80, 50);
			this.pictureBox10.TabIndex = 9;
			this.pictureBox10.TabStop = false;
			// 
			// imgSumo
			// 
			this.imgSumo.Image = ((System.Drawing.Image)(resources.GetObject("imgSumo.Image")));
			this.imgSumo.Location = new System.Drawing.Point(272, 592);
			this.imgSumo.Name = "imgSumo";
			this.imgSumo.Size = new System.Drawing.Size(135, 75);
			this.imgSumo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.imgSumo.TabIndex = 12;
			this.imgSumo.TabStop = false;
			// 
			// label42
			// 
			this.label42.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label42.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label42.Location = new System.Drawing.Point(408, 104);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(248, 48);
			this.label42.TabIndex = 15;
			this.label42.Text = "OYUNCULAR";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(104, 112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(36, 36);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(72, 104);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 48);
			this.label1.TabIndex = 13;
			this.label1.Text = "T    P  ON ";
			// 
			// info
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(680, 702);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.label42);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.imgSumo);
			this.Name = "info";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "info";
			this.Load += new System.EventHandler(this.info_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void info_Load(object sender, System.EventArgs e)
		{
			string str=Application.StartupPath.ToString()+"\\sound\\panther1.wav";
			Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC);
			timer1.Start();
			/*DataTable dt=new DataTable("Oyuncular");
			DataColumn dc=new DataColumn("Derece",typeof(int));
			DataColumn dc1=new DataColumn("Adý",typeof(string));
			DataColumn dc2=new DataColumn("Score",typeof(int));
			DataColumn dc3=new DataColumn("Level",typeof(string));
			dt.Columns.Add(dc);
			dt.Columns.Add(dc1);
			dt.Columns.Add(dc2);
			dt.Columns.Add(dc3);
			DataRow drow3=dt.NewRow();
			drow3["Derece"]=1;
			drow3["Ad"]="BORA";
			drow3["Score"]="3000";
			drow3["Level"]="3-1";
			dt.Rows.Add(drow3);

			DataRow drow2=dt.NewRow();
			drow2["Derece"]=2;
			drow2["Adý"]="JACK";
			drow2["Score"]="2000";
			drow2["Level"]="2-1";
			dt.Rows.Add(drow2);

			DataSet ds=new DataSet();
			ds.Tables.Add(dt);
			ds.WriteXml("score.xml");
			Application.Exit();*/
			//---------------bitti-------------------------

			//Playerlar için xml
			/*DataTable dt=new DataTable("PlayerName");
			DataColumn dc=new DataColumn("Adý",typeof(string));
			DataColumn dc2=new DataColumn("Sonmu",typeof(int));

			dt.Columns.Add(dc);
			dt.Columns.Add(dc2);
			
			DataRow drow3=dt.NewRow();
			drow3["Adý"]="Bora";
			drow3["Sonmu"]=1;
			dt.Rows.Add(drow3);
			DataSet ds2=new DataSet();
			ds2.Tables.Add(dt);
			ds2.WriteXml("player.xml");*/
			//---------------bitti-----------------------------------------
			DataSet ds=new DataSet();
			ds.ReadXml("score.xml");
			int i=0;
			foreach(DataRow drow in  ds.Tables["Oyuncular"].Rows)
			{
				i++;
				switch (i)
				{
					case 1:
					{
						label2.Text=drow[0].ToString();
						label3.Text=drow[1].ToString();
						label4.Text=drow[2].ToString();
						label5.Text=drow[3].ToString();
						break;
					}
					case 2:
					{
						label6.Text=drow[0].ToString();
						label7.Text=drow[1].ToString();
						label8.Text=drow[2].ToString();
						label9.Text=drow[3].ToString();
						break;
					}
					case 3:
					{
						label10.Text=drow[0].ToString();
						label11.Text=drow[1].ToString();
						label12.Text=drow[2].ToString();
						label13.Text=drow[3].ToString();
						break;
					}
					case 4:
					{
						label14.Text=drow[0].ToString();
						label15.Text=drow[1].ToString();
						label16.Text=drow[2].ToString();
						label17.Text=drow[3].ToString();
						break;
					}
					case 5:
					{
						label18.Text=drow[0].ToString();
						label19.Text=drow[1].ToString();
						label20.Text=drow[2].ToString();
						label21.Text=drow[3].ToString();
						break;
					}
					case 6:
					{
						label22.Text=drow[0].ToString();
						label23.Text=drow[1].ToString();
						label24.Text=drow[2].ToString();
						label25.Text=drow[3].ToString();
						break;
					}
					case 7:
					{
						label29.Text=drow[0].ToString();
						label28.Text=drow[1].ToString();
						label27.Text=drow[2].ToString();
						label26.Text=drow[3].ToString();
						break;
					}
					case 8:
					{
						label33.Text=drow[0].ToString();
						label32.Text=drow[1].ToString();
						label31.Text=drow[2].ToString();
						label30.Text=drow[3].ToString();
						break;
					}
					case 9:
					{
						label37.Text=drow[0].ToString();
						label36.Text=drow[1].ToString();
						label35.Text=drow[2].ToString();
						label34.Text=drow[3].ToString();
						break;
					}
					case 10:
					{
						label41.Text=drow[0].ToString();
						label40.Text=drow[1].ToString();
						label39.Text=drow[2].ToString();
						label38.Text=drow[3].ToString();
						break;
					}
				}

			}
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			
			if(panel1.Location.Y>152)
			{
				panel1.Location=new Point(panel1.Location.X,panel1.Location.Y-2);
				imgSumo.Location=new Point(imgSumo.Location.X,imgSumo.Location.Y-2);
			}
			else
			{
				timer1.Stop();
			}
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if(panel1.Location.Y==152)
			{
				frmEnter.Visible=true;
				string str=Application.StartupPath.ToString()+"\\sound\\22040_mr_rolfi_jam2.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				frmEnter.Visible=true;
				this.Close();
				this.Dispose();
			}
			else
			{
				panel1.Location=new Point(panel1.Location.X,152);
				timer1.Stop();
			}
			
		}
	}
}
