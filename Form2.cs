using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using tonysound;
namespace Packman
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lblPara;
		private System.Windows.Forms.Label lblYemlik;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label lblCani;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.ComponentModel.IContainer components;

		public Form2()
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
		public Form2(double dblMoney,int intyemlik,int intHak)
		{
			InitializeComponent();
			Money=dblMoney;
			Yemlik=intyemlik;
			Hak=intHak;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.lblPara = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.lblYemlik = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.lblCani = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.SuspendLayout();
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(160, 32);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(320, 208);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 2;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Visible = false;
			// 
			// timer1
			// 
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox
			// 
			this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
			this.pictureBox.Location = new System.Drawing.Point(160, 32);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(320, 208);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox.TabIndex = 3;
			this.pictureBox.TabStop = false;
			// 
			// lblPara
			// 
			this.lblPara.Enabled = false;
			this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblPara.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblPara.Location = new System.Drawing.Point(16, 96);
			this.lblPara.Name = "lblPara";
			this.lblPara.Size = new System.Drawing.Size(144, 32);
			this.lblPara.TabIndex = 66;
			this.lblPara.Text = "0 YTL";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(16, 136);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(110, 44);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 65;
			this.pictureBox3.TabStop = false;
			// 
			// lblYemlik
			// 
			this.lblYemlik.Enabled = false;
			this.lblYemlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblYemlik.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblYemlik.Location = new System.Drawing.Point(56, 192);
			this.lblYemlik.Name = "lblYemlik";
			this.lblYemlik.Size = new System.Drawing.Size(88, 32);
			this.lblYemlik.TabIndex = 64;
			this.lblYemlik.Text = "X 0";
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(64, 232);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(32, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox5.TabIndex = 63;
			this.pictureBox5.TabStop = false;
			// 
			// lblCani
			// 
			this.lblCani.Enabled = false;
			this.lblCani.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(162)));
			this.lblCani.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lblCani.Location = new System.Drawing.Point(56, 8);
			this.lblCani.Name = "lblCani";
			this.lblCani.Size = new System.Drawing.Size(64, 32);
			this.lblCani.TabIndex = 68;
			this.lblCani.Text = "X 0";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(56, 40);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(60, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 67;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(160, 32);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(320, 208);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 69;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(488, 278);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblCani);
			this.Controls.Add(this.lblPara);
			this.Controls.Add(this.lblYemlik);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.pictureBox4);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Son Durum";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);

		}
		#endregion

		int i=0;
		int s=0;
		int intMoney=0;
		int intHak=0;
		int intYemlik=0;
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			i++;
			
			
			if(intHak<Hak)
			{
				intHak+=1;
				lblCani.Text="X "+intHak.ToString();
			}
			else if(intMoney<Money)
			{
				intMoney+=10;
				lblPara.Text= intMoney.ToString()+" YTL";
			}
			else if(intYemlik<Yemlik)
			{
				intYemlik+=1;
				lblYemlik.Text="X "+ intYemlik.ToString();
				s=1;
			}
			if(s>0)
				s++;
			if(s==3)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\glassbrk.wav";
				Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
				s++;
				pictureBox.Visible=false;
				pictureBox2.Visible=true;
			}
			else if(s==10)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\wmpaud5.wav";
				Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC);
				pictureBox2.Visible=false;
				pictureBox4.Visible=true;
			}
			else if(s>15)
			{
				Level2 frm2=new Level2(Money,Yemlik,Hak,this);
				frm2.Show();
				timer1.Stop();
				this.Visible=false;
				this.Dispose();
				this.Close();
			}
			/*if(i==5)
			{
				this.Visible=false;
				this.Dispose();
				this.Close();
				Level2 frm2=new Level2(Money,Yemlik,Hak,this);
				frm2.Show();
			}*/
			/*if(pictureBox1.Width<96 ||pictureBox1.Height<64)
			{
				if(pictureBox1.Width<96)
					pictureBox1.Width++;
				if(pictureBox1.Height<64)
					pictureBox1.Height++;
			}
			else if(pictureBox3.Width>74 ||pictureBox3.Height>42)
			{
				pictureBox3.Visible=true;
				pictureBox3.BringToFront();
				if(pictureBox3.Width>74)
					pictureBox3.Width--;
				if(pictureBox3.Height>42)
					pictureBox3.Height--;
			}
			else
			{
				pictureBox5.Visible=true;
				pictureBox5.BringToFront();
				if(pictureBox5.Width>74)
					pictureBox5.Width--;
				if(pictureBox5.Height>42)
					pictureBox5.Height--;
			}
			if(i==500)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\glassbrk.wav";
				Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
			}
			if(i==600)
			{
				pictureBox4.Visible=true;
			}
			if(i==820)
			{
				this.Visible=false;
				Level2 frm2=new Level2(Money,Yemlik,Hak,this);
				frm2.Show();
			}		*/
		}
		private void Form2_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode==Keys.Space)
			{
				string str=Application.StartupPath.ToString()+"\\sound\\sus.wav";
				Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
				Level2 frm2=new Level2(Money,Yemlik,Hak,this);
				frm2.Show();
				timer1.Stop();
				this.Visible=false;
				this.Dispose();
				this.Close();
			}
		}

		private void Form2_Load(object sender, System.EventArgs e)
		{
			this.Focus();
			string str=Application.StartupPath.ToString()+"\\sound\\meow.wav";
			Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC);
			timer1.Start();
		}

	}
}
