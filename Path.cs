using System;
using System.Windows.Forms;
using tonysound;
using System.Drawing;
namespace Packman
{
	/// <summary>
	/// Summary description for Path.
	/// </summary>
	public class Path
	{
		public Path()
		{
			//
			// TODO: Add constructor logic here
			//
		}
		public int SinirAsmismi(double x,double y,double xEn,double yBoy,int sinirX1,int sinirY1,int sinirX2,int sinirY2)
		{
			double xOrta=(x+xEn/2);
			double yOrta=(y+yBoy/2);
			if(xOrta>sinirX1 && xOrta<sinirX2 && yOrta>sinirY1 && yOrta<sinirY2)//aþmamýþ sýnýrý
				return 0;
			else if(xOrta<sinirX1 && yOrta<sinirY1)//artýracan.
				return 1;
			else if(xOrta<sinirX1 && yOrta>sinirY2)//x artýracan,y azaltacan
				return 11;
			else if(xOrta<sinirX1 && yOrta>sinirY1 && yOrta<sinirY2)//sadece x artýracan
				return 12;
			else if(xOrta>sinirX2 && yOrta>sinirY1 && yOrta<sinirY2)//sadece x azaltacan
				return 13;
			else if(xOrta>sinirX2 && yOrta>sinirY2)//azaltacan.
				return 2;
			else if(xOrta>sinirX2 && yOrta<sinirY1)//x azaltacan,y arttýracan
				return 21;
			else if(xOrta>sinirX1 && xOrta<sinirX2 && yOrta<sinirY1)//sadece y arttýracan
				return 22;
			else if(xOrta>sinirX1 && xOrta<sinirX2 && yOrta>sinirY2)//sadece y azaltacan
				return 23;
			else
				return 3;
		}

		public int TakipVarmi(double x,double y,double xEn,double yBoy,Form frm,ref string isim,string sender)
		{
			foreach(object ob in frm.Controls)
			{
				if(ob is PictureBox && ((PictureBox)ob).Visible==true)//hayalete çarpmasýn.
				{
					//-----
					PictureBox	btn=(PictureBox)ob;
					int obX=btn.Location.X;
					int obY=btn.Location.Y;												
					

					if(sender=="Boman" && btn.Name.Trim()!="Boman" && btn.Name.Trim()!="Exit")
					{
						int yorta=(obY+btn.Height/2);
						int xorta=(obX+btn.Width/2);

						double bmanxOrta=(x+xEn/2);
						double bmanyOrta=(y+yBoy/2);

						if(Math.Abs(yorta -bmanyOrta)<=100 && Math.Abs(xorta -bmanxOrta)<=100 )
						{
							isim=btn.Name;
							return 1;							
						}
					}
					else if(sender!="Boman" && btn.Name.Trim()=="Boman")
					{
						int yorta=(obY+btn.Height/2);
						int xorta=(obX+btn.Width/2);

						double bmanxOrta=(x+xEn/2);
						double bmanyOrta=(y+yBoy/2);

						if(Math.Abs(yorta -bmanyOrta)<=100 && Math.Abs(xorta -bmanxOrta)<=100 )
						{
							isim=sender;
							return 1;							
						}
					}
				}
			}
			return 0;
		}
		int pay=0;//resimlerin arasýndaki boþluktan dolayý.
		public int Varmi(double x,double y,Yon hareket,double en,double boy,Form frm,ref double Money,ref int yemlikHak,ref int bombHak,string sender,PictureBox Exit)
		{
			foreach(object ob in frm.Controls)
			{
				if(ob is Button && ((Button)ob).Visible==true)
				{
					Button btn=(Button)ob;
					int obX=btn.Location.X;
					int obY=btn.Location.Y;
			
					if(hareket==Yon.Yatay)
					{
						if((y>=obY && y<obY+btn.Height) && x>obX && x<obX+btn.Width)
						{
							if(btn.Width==10 && btn.Height==10 && sender!="Monster")
							{
								string str=Application.StartupPath.ToString()+"\\sound\\newemail.wav";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);

								btn.Visible=false;

								Money+=10;

								//Kapý acýlacak mý//----
								bool kapi=false;
								foreach(object ob2 in frm.Controls)
								{
									if(ob2 is Button && ((Button)ob2).Visible==true)
									{
										Button btn2=(Button)ob2;
										if(btn2.Width==10 && btn2.Height==10 && sender!="Monster")
										{
											kapi=true;//küçük button var açýlmaz demek
										}
									}
								}
								if(kapi==false)//yoksa açýlýr hepsini yersen.
								{
									string str2=Application.StartupPath.ToString()+"\\sound\\yehaw.wav";
									Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

									Exit.Visible=true;
								}
								//-----------------------------
								return 0;
							}
							else if(btn.Width==10 && btn.Height==10 && sender=="Monster")
							{
								return 0;
							}
							else if(sender!="Monster" && btn.BackColor==Color.Transparent && en==41)//kýralacak duvar kýrýlýr
							{
								btn.Visible=false;
								string str2=Application.StartupPath.ToString()+"\\sound\\SOUND12.WAV";
								Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
								return 0;
							}
							else	
								return 1;
						}
						if((y<=obY && y+boy>obY)&& x>obX && x<obX+btn.Width)
						{
							if(btn.Width==10 && btn.Height==10 && sender!="Monster")
							{

								string str=Application.StartupPath.ToString()+"\\sound\\newemail.wav";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);

								btn.Visible=false;
								
								Money+=10;

								//Kapý acýlacak mý//----
								bool kapi=false;
								foreach(object ob2 in frm.Controls)
								{
									if(ob2 is Button && ((Button)ob2).Visible==true)
									{
										Button btn2=(Button)ob2;
										if(btn2.Width==10 && btn2.Height==10 && sender!="Monster")
										{
											kapi=true;
										}
									}
								}
								if(kapi==false)
								{
									string str2=Application.StartupPath.ToString()+"\\sound\\yehaw.wav";
									Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

									Exit.Visible=true;
								}
								//-----------------------------
								return 0;
							}
							else if(btn.Width==10 && btn.Height==10 && sender=="Monster")
							{
								return 0;
							}
							else	
								return 1;
						}
					}
					else 
					{
						if((x>=obX && x<obX+btn.Width) && y>obY && y<obY+btn.Height)
						{
							if(btn.Width==10 && btn.Height==10 && sender!="Monster")
							{
								string str=Application.StartupPath.ToString()+"\\sound\\newemail.wav";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);

								btn.Visible=false;

								Money+=10;
								//Kapý acýlacak mý//----
								bool kapi=false;
								foreach(object ob2 in frm.Controls)
								{
									if(ob2 is Button && ((Button)ob2).Visible==true)
									{
										Button btn2=(Button)ob2;
										if(btn2.Width==10 && btn2.Height==10 && sender!="Monster")
										{
											kapi=true;
										}
									}
								}
								if(kapi==false)
								{
									string str2=Application.StartupPath.ToString()+"\\sound\\yehaw.wav";
									Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

									Exit.Visible=true;
								}
								//-----------------------------
								return 0;
							}
							else if(btn.Width==10 && btn.Height==10 && sender=="Monster")
							{
								return 0;
							}
							else if(sender!="Monster" && btn.BackColor==Color.Transparent && en==41)//kýralacak duvar kýrýlýr
							{
								btn.Visible=false;
								string str2=Application.StartupPath.ToString()+"\\sound\\SOUND12.WAV";
								Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
								return 0;
							}
							else
								return 1;
						}
						if((x<=obX && x+en>=obX+btn.Width) && y>obY && y<obY+btn.Height)
						{
							if(btn.Width==10 && btn.Height==10 && sender!="Monster")
							{
								string str=Application.StartupPath.ToString()+"\\sound\\newemail.wav";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);

								btn.Visible=false;

								Money+=10;
								//Kapý acýlacak mý//----
								bool kapi=false;
								foreach(object ob2 in frm.Controls)
								{
									if(ob2 is Button && ((Button)ob2).Visible==true)
									{
										Button btn2=(Button)ob2;
										if(btn2.Width==10 && btn2.Height==10 && sender!="Monster")
										{
											kapi=true;
										}
									}
								}
								if(kapi==false)
								{
									string str2=Application.StartupPath.ToString()+"\\sound\\yehaw.wav";
									Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

									Exit.Visible=true;
								}
								//-----------------------------
								return 0;
							}
							else if(btn.Width==10 && btn.Height==10 && sender=="Monster")
							{
								return 0;
							}
							else if(sender!="Monster" && btn.BackColor==Color.Transparent && en==41)//kýralacak duvar kýrýlýr
							{
								btn.Visible=false;
								string str2=Application.StartupPath.ToString()+"\\sound\\SOUND12.WAV";
								Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
								return 0;
							}
							else
								return 1;
						}
						if((x<=obX && (x+en<=obX+btn.Width && x+en>obX)) && y>obY && y<obY+btn.Height)
						{
							if(btn.Width==10 && btn.Height==10 && sender!="Monster")
							{
								string str=Application.StartupPath.ToString()+"\\sound\\newemail.wav";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);

								btn.Visible=false;

								Money+=10;
								//Kapý acýlacak mý//----
								bool kapi=false;
								foreach(object ob2 in frm.Controls)
								{
									if(ob2 is Button && ((Button)ob2).Visible==true)
									{
										Button btn2=(Button)ob2;
										if(btn2.Width==10 && btn2.Height==10 && sender!="Monster")
										{
											kapi=true;
										}
									}
								}
								if(kapi==false)
								{
									string str2=Application.StartupPath.ToString()+"\\sound\\yehaw.wav";
									Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

									Exit.Visible=true;
								}
								//-----------------------------
								return 0;
							}
							else if(btn.Width==10 && btn.Height==10 && sender=="Monster")
							{
								return 0;
							}
							else if(sender!="Monster" && btn.BackColor==Color.Transparent && en==41)//kýralacak duvar kýrýlýr
							{
								btn.Visible=false;
								string str2=Application.StartupPath.ToString()+"\\sound\\SOUND12.WAV";
								Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
								return 0;
							}
							else
								return 1;
						}
					}
				}
				if(ob is PictureBox && ((PictureBox)ob).Visible==true)//hayalete çarpmasýn.
				{
					//-----
					PictureBox	btn=(PictureBox)ob;
					int obX=btn.Location.X;//yeni(Level1 569 zart)
					int obY=btn.Location.Y;//yeni

					if(btn.Name.IndexOf("yemlik")==-1 && btn.Name.IndexOf("bomb")==-1)//yeni yeni resim yemlik resmi özel
					{
						//-------Gost mu,Boman mi---
						bool check=false;
						if(sender=="Booman" && btn.Name.Trim()!="Boman" && btn.Name.Trim()!="Exit")
						{
							check=true;
						}
						else if(sender=="Monster" && btn.Name.Trim()=="Boman")
						{
							check=true;
						}
						//-------bitti-------------------------------
						//if(sender=="Booman" && btn.Name.Trim()!="Boman")
						if(check)
						{
							//int obX=btn.Location.X;
							//int obY=btn.Location.Y;
							/*if(y>385)
							{
								return 1;
							}*/
							if(hareket==Yon.Yatay)
							{
								if((y>=obY+pay && y<obY+btn.Height-pay) && x>obX+pay && x<obX+btn.Width-pay)
								{
									return 2;
								}
								if((y<=obY-pay && y+boy>obY+pay)&& x>obX+pay && x<obX+btn.Width-pay)
								{
									return 2;
								}
							}
							else 
							{
								if((x>=obX+pay && x<obX+btn.Width-pay) && y>obY+pay && y<obY+btn.Height-pay)
								{
									return 2;
								}
								if((x<=obX-pay && x+en>obX+btn.Width+pay) && y>obY+pay && y<obY+btn.Height-pay)
								{
									return 2;
								}
								if((x<=obX-pay && (x+en<obX+btn.Width-pay && x+en>obX+pay)) && y>obY+pay && y<obY+btn.Height-pay)
								{
									return 2;
								}
							}
						}
						//-----
					}
						//Yemlik içi----------------
					else if(btn.Name.IndexOf("yemlik")!=-1 && sender=="Booman")//taamen yeni
					{
						if(hareket==Yon.Yatay)
						{
							if((y>=obY && y<obY+btn.Height) && x>obX && x<obX+btn.Width)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND528.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("1");
								btn.Visible=false;
								Money+=10;	
								yemlikHak+=1;
								return 0;
							}
							if((y<=obY && y+boy>obY)&& x>obX && x<obX+btn.Width)
							{	
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND528.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("2");
								btn.Visible=false;
								Money+=10;
								yemlikHak+=1;
								return 0;
							}
						}
						else
						{
							if((x>=obX && x<=obX+btn.Width) && y>=obY && y<=obY+btn.Height)
							{
							
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND528.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("3");
								btn.Visible=false;
								Money+=10;
								yemlikHak+=1;
								return 0;
							}
							if((x<=obX && x+en>=obX+btn.Width) && y>=obY && y<=obY+btn.Height)
							{
								
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND528.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("4");
								btn.Visible=false;
								Money+=10;
								yemlikHak+=1;
								return 0;
							}
							if((x<=obX && (x+en<obX+btn.Width && x+en>obX)) && y>obY && y<obY+btn.Height)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND528.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("5");
								btn.Visible=false;
								Money+=10;
								yemlikHak+=1;
								return 0;
							}
							
						}
					}
						//Bomb içi----------------
					else if(btn.Name.IndexOf("bomb")!=-1 && sender=="Booman")//taamen yeni
					{
						if(hareket==Yon.Yatay)
						{
							if((y>=obY && y<obY+btn.Height) && x>obX && x<obX+btn.Width)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND45.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("1");
								btn.Visible=false;	
								bombHak+=1;
								return 0;
							}
							if((y<=obY && y+boy>obY)&& x>obX && x<obX+btn.Width)
							{	
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND45.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("2");
								btn.Visible=false;
								bombHak+=1;
								return 0;
							}
						}
						else
						{
							if((x>=obX && x<=obX+btn.Width) && y>=obY && y<=obY+btn.Height)
							{
							
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND45.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("3");
								btn.Visible=false;
								bombHak+=1;
								return 0;
							}
							if((x<=obX && x+en>=obX+btn.Width) && y>=obY && y<=obY+btn.Height)
							{
								
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND45.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("4");
								btn.Visible=false;
								bombHak+=1;
								return 0;
							}
							if((x<=obX && (x+en<obX+btn.Width && x+en>obX)) && y>obY && y<obY+btn.Height)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND45.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								//MessageBox.Show("5");
								btn.Visible=false;
								bombHak+=1;
								return 0;
							}
							
						}
					
					}
				}
			}
			return 0;
		}
	}
}
