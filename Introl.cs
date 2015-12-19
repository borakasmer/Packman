using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using tonysound;
namespace Packman
{
	/// <summary>
	/// Summary description for Introl.
	/// </summary>
	public class Introl : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components;

		public Introl()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Introl));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(-24, -16);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(640, 578);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(128, 424);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(128, 120);
			this.pictureBox3.TabIndex = 2;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(368, 440);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(120, 72);
			this.pictureBox4.TabIndex = 3;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(240, 464);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 24);
			this.pictureBox5.TabIndex = 4;
			this.pictureBox5.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(64, 152);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(352, 100);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.label1.Location = new System.Drawing.Point(112, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 64);
			this.label1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label2.Font = new System.Drawing.Font("Chiller", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Crimson;
			this.label2.Location = new System.Drawing.Point(104, 264);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(264, 72);
			this.label2.TabIndex = 7;
			this.label2.Text = "K A Ç I S";
			this.label2.Visible = false;
			// 
			// Introl
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(584, 526);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Introl";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Introl";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Introl_KeyDown);
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Introl_Closing);
			this.Load += new System.EventHandler(this.Introl_Load);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			//Application.Run(new	FormBoss(150,3,2));	
			//Application.Run(new	Boss1(150,3,2,new Form5(),2,2,0,0,0));	
			//Application.Run(new	Level3(150,3,2,2));	
			Application.Run(new	Giris());	
		}

		private void Introl_Load(object sender, System.EventArgs e)
		{
			timer1.Start();
			string str=Application.StartupPath.ToString()+"\\sound\\wmpaud8.wav";
			Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC);
		}
		
		int i=-1;
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			i++;
			if(i==-0)
			{
//				string str=Application.StartupPath.ToString()+"\\sound\\wmpaud8.wav";
//				Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC);
			}
			if(i==0)
				label1.Text+="B";
			if(i==1)
				label1.Text+="Ö";
			if(i==2)
				label1.Text+="L";
			if(i==3)
				label1.Text+="Ü";
			if(i==4)
				label1.Text+="M";
			if(i==5)
				label1.Text+="-";
			if(i==6)
			{
				label1.Text+="1";
				label2.Visible=true;
			}
			if(i==7)
			{
				Level1 frm=new Level1();
				this.Visible=false;
				frm.Show();
				timer1.Stop();
			}
		}

		private void Introl_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Space)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\sus.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				Level1 frm=new Level1();
				this.Dispose();
				this.Close();
				this.Visible=false;
				frm.Show();
				timer1.Stop();
			}
		}

		private void Introl_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}
	}
}
