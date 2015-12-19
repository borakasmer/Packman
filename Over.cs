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
	/// Summary description for Over.
	/// </summary>
	public class Over : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button19;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label txtSay;
		private System.Windows.Forms.Panel gOver;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

		public Over()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
		Form gelenFrm;
		public Over(Form frm)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			if(frm is Level1)
			{
				frm.Dispose();
			}

			if(frm is Level2)
			{
				frm.Dispose();
			}
			if(frm is Level3)
			{
				frm.Dispose();
			}
			if(frm is Level4)
			{
				frm.Dispose();
			}
			if(frm is Boss1)
			{
				frm.Dispose();
			}

			gelenFrm=frm;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Over));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button19 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.txtSay = new System.Windows.Forms.Label();
			this.gOver = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.gOver.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(672, 472);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// button19
			// 
			this.button19.BackColor = System.Drawing.Color.WhiteSmoke;
			this.button19.Font = new System.Drawing.Font("Ravie", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button19.ForeColor = System.Drawing.Color.Black;
			this.button19.Location = new System.Drawing.Point(280, 424);
			this.button19.Name = "button19";
			this.button19.Size = new System.Drawing.Size(384, 24);
			this.button19.TabIndex = 0;
			this.button19.Text = "Devam için Herhangi bir Tuþa Basýnýz....";
			this.button19.Click += new System.EventHandler(this.button19_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// txtSay
			// 
			this.txtSay.BackColor = System.Drawing.Color.LightGray;
			this.txtSay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.txtSay.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.txtSay.Font = new System.Drawing.Font("Bernard MT Condensed", 72F, System.Drawing.FontStyle.Bold);
			this.txtSay.Location = new System.Drawing.Point(352, 120);
			this.txtSay.Name = "txtSay";
			this.txtSay.Size = new System.Drawing.Size(56, 121);
			this.txtSay.TabIndex = 34;
			this.txtSay.Text = "9";
			// 
			// gOver
			// 
			this.gOver.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gOver.Controls.Add(this.label1);
			this.gOver.Location = new System.Drawing.Point(192, 312);
			this.gOver.Name = "gOver";
			this.gOver.Size = new System.Drawing.Size(384, 64);
			this.gOver.TabIndex = 33;
			this.gOver.Visible = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Crimson;
			this.label1.Location = new System.Drawing.Point(-4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(392, 96);
			this.label1.TabIndex = 33;
			this.label1.Text = "OYUN BÝTTÝ";
			// 
			// Over
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(672, 470);
			this.Controls.Add(this.txtSay);
			this.Controls.Add(this.button19);
			this.Controls.Add(this.gOver);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Over";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Over";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Over_Closing);
			this.Load += new System.EventHandler(this.Over_Load);
			this.gOver.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		int i=9;
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if(i==9)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\wmpaud7.wav";
				Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOSTOP);
			}
			if(i>=0)
			{
				txtSay.Text=i.ToString();
			}
			if(i==0)
			{
				button19.Enabled=false;
				gOver.Visible=true;
 				string str=Application.StartupPath.ToString()+"\\sound\\WS2_Guitar_020.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME);
			}
			if(i==-3)
			{
				this.Dispose();
				this.Close();
				Giris frm=new Giris();
				frm.Show();
				timer1.Stop();
			}
			i--;
		}

		private void Over_Load(object sender, System.EventArgs e)
		{
			string str=Application.StartupPath.ToString()+"\\sound\\sus.wav";
			Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
			button19.Focus();
			timer1.Start();
		}

		private void button19_Click(object sender, System.EventArgs e)
		{
			timer1.Stop();
			this.Dispose();
			this.Close();
			string str=Application.StartupPath.ToString()+"\\sound\\sus.wav";
			Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
			if(gelenFrm is Level1)
			{
				Level1 frm=new Level1();
				frm.Show();
			}
			else if(gelenFrm is Level2)
			{
				Level2 frm=new Level2();
				frm.Show();
			}
			else if(gelenFrm is Level3)
			{
				Level3 frm=new Level3(0,0,3,this,0);
				frm.Show();
			}
			else if(gelenFrm is Level4)
			{
				Level4 frm=new Level4(0,0,3,this,0,0);
				frm.Show();
			}
			else if(gelenFrm is Boss1)
			{
				Boss1 frm=new Boss1(0,0,3,this,0,0,0,0,0);
				frm.Show();
			}
		}
		private void Over_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			Application.Exit();
		}
	}
}
