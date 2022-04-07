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
            int n = 0;
            int m = 0;
            n = text.Length;
            m = zahl;
            m *= n;
            Console.WriteLine(m);

            for (int i = 0; i < zahl; i++)
            {
                Console.WriteLine(text);

     
            }

            return zahl;

          




        }
        
    }
}
