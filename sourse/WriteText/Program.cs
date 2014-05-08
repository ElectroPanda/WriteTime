/*
 * Сделано в SharpDevelop.
 * Пользователь: admin
 * Дата: 07.05.2014
 * Время: 13:04
 * 
 * Для изменения этого шаблона используйте Сервис | Настройка | Кодирование | Правка стандартных заголовков.
 */
using System;

namespace WriteText
{
	class Program
	{
		public static void Main(string[] args)
		{
            //Boolean mark=false;	
            string[] lines=new string[0];
           
			string fullpath=@"C:\testfiles\speedtest\1\et.txt";
		    if (args.Length>0) {	fullpath=@""+args[0];  }
		    
		    if (System.IO.File.Exists(fullpath)==false)
		    {
		    	   
		       	System.IO.Stream gf=System.IO.File.Create(fullpath);
		    	gf.Close();
		    	
		    }
		    
		    
		    	string[] filelines= System.IO.File.ReadAllLines(fullpath);
		    	Array.Resize(ref lines,filelines.Length);
		    	filelines.CopyTo(lines,0);
		    	
		    
		    
		    if (lines.Length==0)
		    {
		    	
		    DateTime staaart = DateTime.Now;
		    System.IO.StreamWriter sr=System.IO.File.CreateText(fullpath);
		    sr.WriteLine(staaart.ToString("hh:mm:ss.ffff"));
		    sr.Close();
		    }	
		    	
		    if ((lines.Length==1))
		    {
		    	DateTime laaast=new DateTime();
		    	DateTime.TryParse(lines[0],out laaast);
		    	DateTime Looot =DateTime.Now;
		    	TimeSpan difff=laaast-Looot;
				System.IO.StreamWriter fg=System.IO.File.CreateText(fullpath);
				fg.WriteLine(lines[0]);
		    	fg.WriteLine(Looot.ToString("hh:mm:ss.ffff")+"----->"+difff);
		    	fg.Close();
		    
		    
		    }
		    
		    
		    
		    
		    if (lines.Length==2)
		    {
		    System.IO.Stream gf=System.IO.File.Create(fullpath);
		    gf.Close();	
		    DateTime staaart = DateTime.Now;
		    System.IO.StreamWriter sr=System.IO.File.CreateText(fullpath);
		    sr.WriteLine(staaart.ToString("hh:mm:ss.ffff"));
		    sr.Close();
		    }
		    /*System.IO.StreamWriter sr=System.IO.File.CreateText(fullpath);
		    if (lines.Length==1) {sr.WriteLine(lines[0]);}
            sr.WriteLine(DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString()+":"+DateTime.Now.Second.ToString()+","+DateTime.Now.Millisecond.ToString());
            sr.Close();
		    
		    
		    
		    
		    
			DateTime staaart = DateTime.Now;
			DateTime Eeend = DateTime.Now;
			TimeSpan difff;
			
			Console.WriteLine("WriteTime");
			
	
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
			Eeend=DateTime.Now;
			//Console.WriteLine(Eeend);
			difff=staaart-Eeend;
			Console.Write(difff);
			Console.ReadKey(true);*/
			
		}
	}
}