using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace evaluation_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter file name");
            string name = Console.ReadLine();
            string fileName = @"C:\\Users\\mohith.bellamkonda\\OneDrive - Entain Group\\" + name + ".txt";
            try
            {
                StreamWriter sw = File.AppendText(fileName);



                sw.WriteLine("hi how are you");
                sw.WriteLine("how was working in ivy");
                sw.WriteLine("training going good");
                sw.WriteLine("learn the concepts deeply");
                sw.WriteLine("Now are our brows bound with victorious wreaths");
             
                
                
                sw.Close();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    sr.Close();
                }
            }



            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text you wanna replaced");
            string OldText = Console.ReadLine();




            Console.WriteLine("Enter the text you want in the file");
            string NewText = Console.ReadLine();




            string text = File.ReadAllText(fileName);
            text = text.Replace(OldText, NewText);
            File.WriteAllText(fileName, text);



            Console.ReadLine();



        }
    }
}