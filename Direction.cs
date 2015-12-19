using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Collections;
using tonysound;
namespace Packman
{
	/// <summary>
	/// Summary description for Direction.
	/// </summary>
	public class Direction
	{
		Path rotate;
		int miktar=0;
		public Direction()
		{
			rotate=new Path();
		}

		public void Boundery(PictureBox monster,Hashtable htable,ref Keys dir,int xbilk,int ybilk,int yeniX,int yeniY,ref int xbBak,ref int ybBak,ref int xkBak,ref int ykBak,ref int intKere,int minX,int minY,int maxX,int maxY,ref int kere)
		{
			if(Char.IsNumber(htable["s"+monster.Name].ToString(),1)==false && htable["s"+monster.Name].ToString().Substring(0,1)=="1")//sýnýrlardan küçük
			{
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					dir=Keys.Right;
					if(xbilk==monster.Location.X)
					{
						xkBak=1;
						if(xkBak==1 && ykBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX ,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
					else
					{
						xkBak=0;
						ykBak=0;
						intKere=0;
					}
				}
			
				if(i==2)
				{
					dir=Keys.Down;
					if(ybilk==monster.Location.Y)
					{
						ykBak=1;
						if(xkBak==1 && ykBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
				}
			}
			if(htable["s"+monster.Name].ToString().Substring(0,2)=="11")//x arttýr,y küçült
			{
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					dir=Keys.Right;
					if(xbilk==monster.Location.X)
					{
						xkBak=1;
						if(xkBak==1 && ykBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
					else
					{
						xkBak=0;
						ykBak=0;
						intKere=0;
					}
				}
			
				if(i==2)
				{
					dir=Keys.Up;
					if(ybilk==monster.Location.Y)
					{
						ykBak=1;
						if(xkBak==1 && ykBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
				}
			}
			if(htable["s"+monster.Name].ToString().Substring(0,2)=="12")//sadece x artýracan
			{	
				dir=Keys.Right;
				if(xbilk==monster.Location.X)
				{
					xkBak=1;
					if(xkBak==1)
					{
						intKere++;
						if(intKere>10)
						{
							if(intKere<20)
							{
								if(monster.Location.Y>minY)
								{
									if(ybilk!=monster.Location.Y)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Up;
										intKere--;
									} 
									else
									{
										dir=Keys.Right;
									} 
								}
							}
							else if(intKere<30)
							{		
								if(monster.Location.Y<maxY)
								{
									if(ybilk!=monster.Location.Y)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Down;
										intKere--;
									} 
									else
									{
										dir=Keys.Right;
									} 
								}
							}
							else
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
				}
				else
				{
					xkBak=0;
					ykBak=0;
					intKere=0;
				}
			}
			if(htable["s"+monster.Name].ToString().Substring(0,2)=="13")//sadece x azaltacan
			{	
				dir=Keys.Left;
				if(xbilk==monster.Location.X)
				{
					xkBak=1;
					if(xkBak==1)
					{
						intKere++;
						if(intKere>10)
						{
							if(intKere<20)
							{
								if(monster.Location.Y>minY)
								{
									if(ybilk!=monster.Location.Y)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Up;
										intKere--;
									} 
									else
									{
										dir=Keys.Left;
									} 
								}
							}
							else if(intKere<30)
							{		
								if(monster.Location.Y<maxY)
								{
									if(ybilk!=monster.Location.Y)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Down;
										intKere--;
									} 
									else
									{
										dir=Keys.Left;
									} 
								}
							}
							else
							{
								kere=0;
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
				}
				else
				{
					xkBak=0;
					ykBak=0;
					intKere=0;
				}
			}
			if(htable["s"+monster.Name].ToString().Substring(0,2)=="21")//x azaltacan,y arttýracan
			{
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					dir=Keys.Left;
					if(xbilk==monster.Location.X)
					{
						xkBak=1;
						if(xkBak==1 && ykBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
					else
					{
						xkBak=0;
						ykBak=0;
						intKere=0;
					}
				}
				if(i==2)
				{
					dir=Keys.Down;
					if(ybilk==monster.Location.Y)
					{
						ykBak=1;
						if(xkBak==1 && ykBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
					else
					{
						ykBak=0;
						xkBak=0;
						intKere=0;
					}
				}
			}
			if(htable["s"+monster.Name].ToString().Substring(0,2)=="22")//sadece y yi arttýracam
			{
				dir=Keys.Down;
				if(ybilk==monster.Location.Y)
				{
					ykBak=1;
					if(ykBak==1)
					{
						intKere++;
						if(intKere>10)
						{
							if(intKere<20)
							{
								if(monster.Location.X>minX)
								{
									if(xbilk!=monster.Location.X)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Left;
										intKere--;
									} 
									else
									{
										dir=Keys.Down;
									} 
								}
							}
							else if(intKere<30)
							{		
								if(monster.Location.X<maxX)
								{
									if(xbilk!=monster.Location.X)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Right;
										intKere--;
									} 
									else
									{
										dir=Keys.Down;
									} 
								}
							}
							else
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
				}
				else
				{
					xkBak=0;
					ykBak=0;
					intKere=0;
				}	
			}
			if(htable["s"+monster.Name].ToString().Substring(0,2)=="23")//sadece y yi azaltacam
			{
				 dir=Keys.Up;
				if(ybilk==monster.Location.Y)
				{
					ykBak=1;
					if(ykBak==1)
					{
						intKere++;
						if(intKere>10)
						{
							if(intKere<20)
							{
								if(monster.Location.X>minX)
								{
									if(xbilk!=monster.Location.X)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Left;
										intKere--;
									} 
									else
									{
										dir=Keys.Up;
									} 
								}
							}
							else if(intKere<30)
							{		
								if(monster.Location.X<maxX)
								{
									if(xbilk!=monster.Location.X)
										intKere--;

									kere++;
									if((kere%2)!=0)
									{
										dir=Keys.Right;
										intKere--;
									} 
									else
									{
										dir=Keys.Up;
									} 
								}
							}
							else
							{
								kere=0;
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
				}
				else
				{
					kere=0;
					xkBak=0;
					ykBak=0;
					intKere=0;
				}	
			}
			else if(Char.IsNumber(htable["s"+monster.Name].ToString(),1)==false && htable["s"+monster.Name].ToString().Substring(0,1)=="2")//sýnýrlardan büyük
			{
				Random rnd=new Random();
				int i=rnd.Next(1,3);
				if(i==1)
				{
					dir=Keys.Left;
					if(xbilk==monster.Location.X)
					{
						xbBak=1;
						if(xbBak==1 && ybBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
					else
					{
						xbBak=0;
						ybBak=0;
						intKere=0;
					}
				}
				if(i==2)
				{
					if(ybilk==monster.Location.Y)
					{
						ybBak=1;
						if(xbBak==1 && ybBak==1)
						{
							intKere++;
							if(intKere>10)
							{
								string str=Application.StartupPath.ToString()+"\\sound\\SOUND14.WAV";
								Sound.Play(str,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT);
								monster.Location=new Point(yeniX,yeniY);
								intKere=0;
								xkBak=0;
								xbBak=0;
								ykBak=0;
								ybBak=0;
							}
						}
					}
					else
					{
						ybBak=0;
						xbBak=0;
						intKere=0;
					}
					dir=Keys.Up;
				}
			}
		}
		string isim="";
		public void Move(KeyEventArgs e,PictureBox Boman,Form frm,ref double Money,Nitro nit,int[] exit,int[] start,ref int Hak,ref int yemlik,ref int bomb,string form,PictureBox exit1,Hashtable htable,string yon)//boman için
		{
			//string str=Application.StartupPath.ToString()+"\\sound\\F0.wav";//hareket ederkenki sesimiz.
            string str=Application.StartupPath.ToString()+"\\sound\\walk2.wav";//hareket ederkenki sesimiz.            
			
			if(e.KeyCode==Keys.Up || e.KeyCode==Keys.Down || e.KeyCode==Keys.Left || e.KeyCode==Keys.Right)
			//Sound.Play(str,PlaySoundFlags.SND_FILENAME| PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOSTOP);
		    Sound.Play(str,PlaySoundFlags.SND_FILENAME| PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT|PlaySoundFlags.SND_NOSTOP);

			if(yon=="up" && Boman.Location.X>exit[0] && Boman.Location.Y<exit[1] && Boman.Location.X<exit[2] && exit1.Visible==true)//çýkýþa gelmiþsek
			{
				if(form=="Form2")
				{
					frm.Dispose();
					frm.Close();
					Form2 frm2=new Form2(Money,yemlik,Hak);
					frm2.Show();
				}
				if(form=="Form3")
				{
					frm.Dispose();
					frm.Close();
					Form3 frm3=new Form3(Money,yemlik,Hak);
					frm3.Show();
				}
				if(form=="Form4")
				{
					frm.Dispose();
					frm.Close();
					Form4 frm4=new Form4(Money,yemlik,Hak);
					frm4.Show();
				}
				//frm.Visible=false;
			}
			if(yon=="left" && Boman.Location.X<exit[0] && Boman.Location.Y>exit[1] && Boman.Location.Y<exit[3] && exit1.Visible==true)//çýkýþa gelmiþsek
			{
				if(form=="Form2")
				{
					frm.Dispose();
					frm.Close();
					Form2 frm2=new Form2();
					frm2.Show();
				}
				if(form=="Form3")
				{
					frm.Dispose();
					frm.Close();
					Form3 frm3=new Form3(Money,yemlik,Hak);
					frm3.Show();
				}
				if(form=="Form4")
				{
					frm.Dispose();
					frm.Close();
					Form4 frm4=new Form4(Money,yemlik,Hak);
					frm4.Show();
				}
				//frm.Visible=false;
			}
			if(yon=="down" && Boman.Location.X>exit[0] && Boman.Location.Y>exit[1] && Boman.Location.X<exit[2] && exit1.Visible==true)//çýkýþa gelmiþsek
			{
				if(form=="Form2")
				{
					frm.Dispose();
					frm.Close();
					Form2 frm2=new Form2(Money,yemlik,Hak);
					frm2.Show();
				}
				if(form=="Form3")
				{
					frm.Dispose();
					frm.Close();
					Form3 frm3=new Form3(Money,yemlik,Hak);
					frm3.Show();
				}
				if(form=="Form4")
				{
					frm.Dispose();
					frm.Close();
					Form4 frm4=new Form4(Money,yemlik,Hak);
					frm4.Show();
				}
				if(form=="FormBoss")
				{
					frm.Dispose();
					frm.Close();
					FormBoss frmBoss=new FormBoss(Money,yemlik,Hak);
					frmBoss.Show();
				}
				//frm.Visible=false;
			}

			bool yapma=false;
			
			if(yapma==false)
			{
				if(nit==Nitro.Var || Boman.Width==39)
				{
					miktar=8;
				}
				else
				{
					miktar=4;
				}
				switch(e.KeyCode)
				{
					case Keys.Up:
					{
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y-miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==0)//duvar yoksa hareket ve küçükleri yeme
						{
							if(Boman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,"Boman")==1)//yaratýða yakýnlaþtýkmý
							{
								htable[isim]=isim;//dönen yaratýk ismine yaratýða atýyoruz.
							}
							else
							{
								htable[Boman.Name]="";//Boman'e boþ deðer atýyoruz
							}
							Boman.Location=new Point(Boman.Location.X,Boman.Location.Y-miktar);
						}
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y-miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==2)//yaratýða deydik ölüyoruz
						{
							
							string str2=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str2,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
								
							for(int i=0;i<8;i++)
							{
								Boman.Location=new Point(Boman.Location.X-3,Boman.Location.Y-3);
								Thread.Sleep(200);
							}
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
							Boman.Location=new Point(start[0],start[1]);
						}
						break;
					}
					case Keys.Down:
					{
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y+Boman.Height+miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==0)
						{
							if(Boman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,"Boman")==1)
							{
								htable[isim]=isim;//dönen yaratýk ismine yaratýða atýyoruz.
							}
							else
							{
								htable[Boman.Name]="";//Boman'e boþ atýyoruz
							}
							Boman.Location=new Point(Boman.Location.X,Boman.Location.Y+miktar);
						}
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y+Boman.Height+miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==2)
						{
							string str3=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str3,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								Boman.Location=new Point(Boman.Location.X-3,Boman.Location.Y-3);
								Thread.Sleep(200);
							}
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
							Boman.Location=new Point(start[0],start[1]);
						}
						break;
					}
					case Keys.Right:
					{
						if(rotate.Varmi(Boman.Location.X+miktar+Boman.Width,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==0)
						{
							if(Boman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,"Boman")==1)
							{
								htable[isim]=isim;//dönen yaratýk ismine ismi yaratýða atýyoruz.
							}
							else
							{	
								htable[Boman.Name]="";//kendimize boþ atýyoruz Boman'e
							}
							Boman.Location=new Point(Boman.Location.X+miktar,Boman.Location.Y);
						}
						if(rotate.Varmi(Boman.Location.X+miktar+Boman.Width,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==2)
						{
							string str4=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str4,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								Boman.Location=new Point(Boman.Location.X-3,Boman.Location.Y-3);
								Thread.Sleep(200);
							}
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
							Boman.Location=new Point(start[0],start[1]);
						}
						break;
					}
					case Keys.Left:
					{
						if(rotate.Varmi(Boman.Location.X-miktar,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==0)
						{
							if(Boman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,"Boman")==1)
							{
								//Level1.yMonster=isim;
								htable[isim]=isim;//dönen yaratýk ismine ismi yaratýða atýyoruz.
							}
							else
							{
								htable[Boman.Name]="";//Burda Boman biziz.Yani kendimize boþ atýyoruz
							}
							Boman.Location=new Point(Boman.Location.X-miktar,Boman.Location.Y);
						}
						if(rotate.Varmi(Boman.Location.X-miktar,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Booman",exit1)==2)
						{
							string str5=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str5,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
							for(int i=0;i<8;i++)
							{
								Boman.Location=new Point(Boman.Location.X-3,Boman.Location.Y-3);
								Thread.Sleep(200);
							}
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
							Boman.Location=new Point(start[0],start[1]);
						}
						break;
					}
				}
			}
		}
		public void Move(Keys e,PictureBox Boman,Form frm,ref double Money,Nitro nit,int[] start,PictureBox RelBoman,ref int Hak,ref int yemlik,ref int bomb,PictureBox exit1,Hashtable htable,int minX1,int minY1,int maxX1,int maxY1)//hayalet için
		{
			if(nit==Nitro.Var)
			{
				miktar=8;
			}
			else
			{
				miktar=4;
			}
			if(Boman.Name=="monsterBoss1")
			{
				miktar=8;
			}
			if(Boman.Name!="monsterBoss1")
			{
				switch(e)
				{
					case Keys.Up:
					{
						//önce yaratýk gosth harelet edebilirmi diye baktýk duvar var mý?
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y-miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==0)
						{
							//hareket ediyosa bize yaklaþmýþ mý?
							if(RelBoman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,Boman.Name)==1)//yaratýða yakýnlaþtýkmý
							{
								htable[isim]=isim;//hangi yaratýksa(hangisine yaklaþýlmýþsa) ona deðer atýyoruz.
							}
							else
							{
								int sinir=rotate.SinirAsmismi(Boman.Location.X,Boman.Location.Y-miktar,Boman.Width,Boman.Height,minX1,minY1,maxX1,maxY1);
							
								switch (sinir)
								{
									case 0:
									{
										htable["s"+Boman.Name]="";
										break;
									}
									case 1:
									{
										htable["s"+Boman.Name]="1"+Boman.Name;
										break;
									}
									case 11:
									{
										htable["s"+Boman.Name]="11"+Boman.Name;
										break;
									}
									case 12:
									{
										htable["s"+Boman.Name]="12"+Boman.Name;
										break;
									}
									case 13:
									{
										htable["s"+Boman.Name]="13"+Boman.Name;
										break;
									}
									case 21:
									{
										htable["s"+Boman.Name]="21"+Boman.Name;
										break;
									}
									case 22:
									{
										htable["s"+Boman.Name]="22"+Boman.Name;
										break;
									}
									case 23:
									{
										htable["s"+Boman.Name]="23"+Boman.Name;
										break;
									}
									case 2:
									{
										htable["s"+Boman.Name]="2"+Boman.Name;
										break;
									}
								}
								htable[Boman.Name]="";//()Boman burda yaratýðýn ismi ayný zamanda.hangi yaratýktan geliyosa ona boþ deðer atýyoruz.
							}
							Boman.Location=new Point(Boman.Location.X,Boman.Location.Y-miktar);
						}
						//yaklaþýp deðmiþse ölürüz.....
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y-miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{

							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}

							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
					case Keys.Down:
					{
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y+Boman.Height+miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==0)
						{
							if(RelBoman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,Boman.Name)==1)//yaratýða yakýnlaþtýkmý
							{
								//Level1.yMonster=isim;
								htable[isim]=isim;//hangi yaratýksa ona deðer atýyoruz.
							}
							else
							{
								/*if(Boman.Name=="monster2")
								{
									int i=0;
								}*/
								int sinir=rotate.SinirAsmismi(Boman.Location.X,Boman.Location.Y-miktar,Boman.Width,Boman.Height,minX1,minY1,maxX1,maxY1);
								switch (sinir)
								{
									case 0:
									{
										htable["s"+Boman.Name]="";
										break;
									}
									case 1:
									{
										htable["s"+Boman.Name]="1"+Boman.Name;
										break;
									}
									case 11:
									{
										htable["s"+Boman.Name]="11"+Boman.Name;
										break;
									}
									case 12:
									{
										htable["s"+Boman.Name]="12"+Boman.Name;
										break;
									}
									case 13:
									{
										htable["s"+Boman.Name]="13"+Boman.Name;
										break;
									}
									case 21:
									{
										htable["s"+Boman.Name]="21"+Boman.Name;
										break;
									}
									case 22:
									{
										htable["s"+Boman.Name]="22"+Boman.Name;
										break;
									}
									case 23:
									{
										htable["s"+Boman.Name]="23"+Boman.Name;
										break;
									}
									case 2:
									{
										htable["s"+Boman.Name]="2"+Boman.Name;
										break;
									}
								}
								htable[Boman.Name]="";//()Boman yaratýðýn ismi ayný zamanda.hangi yaratýktan geliyosa ona boþ deðer atýyoruz.
							}
							Boman.Location=new Point(Boman.Location.X,Boman.Location.Y+miktar);
						}
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y+Boman.Height+miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{

							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}
							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
					case Keys.Right:
					{
						if(rotate.Varmi(Boman.Location.X+miktar+Boman.Width,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==0)
						{
							if(RelBoman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,Boman.Name)==1)//yaratýða yakýnlaþtýkmý
							{
								htable[isim]=isim;//hangi yaratýksa ona deðer atýyoruz.
							}
							else
							{
								int sinir=rotate.SinirAsmismi(Boman.Location.X,Boman.Location.Y-miktar,Boman.Width,Boman.Height,minX1,minY1,maxX1,maxY1);
								switch (sinir)
								{
									case 0:
									{
										htable["s"+Boman.Name]="";
										break;
									}
									case 1:
									{
										htable["s"+Boman.Name]="1"+Boman.Name;
										break;
									}
									case 11:
									{
										htable["s"+Boman.Name]="11"+Boman.Name;
										break;
									}
									case 12:
									{
										htable["s"+Boman.Name]="12"+Boman.Name;
										break;
									}
									case 13:
									{
										htable["s"+Boman.Name]="13"+Boman.Name;
										break;
									}
									case 21:
									{
										htable["s"+Boman.Name]="21"+Boman.Name;
										break;
									}
									case 22:
									{
										htable["s"+Boman.Name]="22"+Boman.Name;
										break;
									}
									case 23:
									{
										htable["s"+Boman.Name]="23"+Boman.Name;
										break;
									}
									case 2:
									{
										htable["s"+Boman.Name]="2"+Boman.Name;
										break;
									}
								}
								htable[Boman.Name]="";//()Boman yaratýðýn ismi ayný zamanda.hangi yaratýktan geliyosa ona boþ deðer atýyoruz.
							}
							Boman.Location=new Point(Boman.Location.X+miktar,Boman.Location.Y);
						}
						if(rotate.Varmi(Boman.Location.X+miktar+Boman.Width,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{
							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}
							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
					case Keys.Left:
					{
						if(rotate.Varmi(Boman.Location.X-miktar,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==0)
						{
							if(RelBoman.Width!=39 && rotate.TakipVarmi(Boman.Location.X,Boman.Location.Y,Boman.Width,Boman.Height,frm, ref isim,Boman.Name)==1)//yaratýða yakýnlaþtýkmý
							{
								//Level1.yMonster=isim;
								htable[isim]=isim;//hangi yaratýksa ona deðer atýyoruz.
							}
							else
							{
								int sinir=rotate.SinirAsmismi(Boman.Location.X,Boman.Location.Y-miktar,Boman.Width,Boman.Height,minX1,minY1,maxX1,maxY1);
								switch (sinir)
								{
									case 0:
									{
										htable["s"+Boman.Name]="";
										break;
									}
									case 1:
									{
										htable["s"+Boman.Name]="1"+Boman.Name;
										break;
									}
									case 11:
									{
										htable["s"+Boman.Name]="11"+Boman.Name;
										break;
									}
									case 12:
									{
										htable["s"+Boman.Name]="12"+Boman.Name;
										break;
									}
									case 13:
									{
										htable["s"+Boman.Name]="13"+Boman.Name;
										break;
									}
									case 21:
									{
										htable["s"+Boman.Name]="21"+Boman.Name;
										break;
									}
									case 22:
									{
										htable["s"+Boman.Name]="22"+Boman.Name;
										break;
									}
									case 23:
									{
										htable["s"+Boman.Name]="23"+Boman.Name;
										break;
									}
									case 2:
									{
										htable["s"+Boman.Name]="2"+Boman.Name;
										break;
									}
								}
								htable[Boman.Name]="";//eger deðer yoksa hangi yaratýktan dönerse onu boþa atýyoruz.
							}
							Boman.Location=new Point(Boman.Location.X-miktar,Boman.Location.Y);
						}
						if(rotate.Varmi(Boman.Location.X-miktar,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{
							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}
							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
				}
			}
			else//eger Monster Boss ise bu satýrlar çalýþýr(Takip yok;sýnýr yok)
			{
				switch(e)
				{
					case Keys.Up:
					{
						//önce yaratýk gosth harelet edebilirmi diye baktýk duvar var mý?
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y-miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Boss",exit1)==0)
						{
							Boman.Location=new Point(Boman.Location.X,Boman.Location.Y-miktar);
						}
						//yaklaþýp deðmiþse ölürüz.....
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y-miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{

							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);
							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}

							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
					case Keys.Down:
					{
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y+Boman.Height+miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Boss",exit1)==0)
						{
							Boman.Location=new Point(Boman.Location.X,Boman.Location.Y+miktar);
						}
						if(rotate.Varmi(Boman.Location.X,Boman.Location.Y+Boman.Height+miktar,Yon.Dikey,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{

							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}
							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
					case Keys.Left:
					{
						if(rotate.Varmi(Boman.Location.X-miktar,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Boss",exit1)==0)
						{
							Boman.Location=new Point(Boman.Location.X-miktar,Boman.Location.Y);
						}
						if(rotate.Varmi(Boman.Location.X-miktar,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{
							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}
							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
					case Keys.Right:
					{
						if(rotate.Varmi(Boman.Location.X+miktar+Boman.Width,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Boss",exit1)==0)
						{
							Boman.Location=new Point(Boman.Location.X+miktar,Boman.Location.Y);
						}
						if(rotate.Varmi(Boman.Location.X+miktar+Boman.Width,Boman.Location.Y,Yon.Yatay,Boman.Width,Boman.Height,frm,ref Money,ref yemlik,ref bomb,"Monster",exit1)==2)
						{
							string str=Application.StartupPath.ToString()+"\\sound\\toon8.wav";
							Sound.Play(str,PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_NOWAIT);

							for(int i=0;i<8;i++)
							{
								RelBoman.Location=new Point(RelBoman.Location.X-3,RelBoman.Location.Y-3);
								Thread.Sleep(200);
							}
							RelBoman.Location=new Point(start[0],start[1]);
							--Hak;
							string stryol=Application.StartupPath.ToString()+"\\sound\\sus.wav";
							Sound.Play(stryol,PlaySoundFlags.SND_ASYNC|PlaySoundFlags.SND_FILENAME|PlaySoundFlags.SND_NOWAIT); 
						}
						break;
					}
				}
			}
		}
	
	}
}
