using System;

namespace MethodenA1
{
    class Program
    {
        public static void Main()
            

        {

            Console.WriteLine("Bitte geben sie ein Wort ein");
            string n = Convert.ToString(Console.ReadLine());
            int m=0;

            bool flag;
            do
            {
                flag = false;
                Console.WriteLine("Bitte Anzhahl geben");
                try
                {
                     m = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception )
                {
                    Console.WriteLine("Falsche Eingabe");
                    flag = true;
                }

            } while (flag);
            
            int anzahl = 0;
            anzahl = ausgabeTextMalX(n,m);
            Console.WriteLine("/nAnzahl der Buchstaben:{0}", anzahl);


        }
        static int ausgabeTextMalX(string text, int zahl)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine(text);

                zahl = text.Length * i;
     
            }

            return zahl;

          




        }
        
    }
}
