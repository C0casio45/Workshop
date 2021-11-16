using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop
{
    public class Modele
    {
        protected int[] maj_ASCII = new int[2] { 65, 90 };
        protected int[] min_ASCII = new int[2] { 97, 122 };
    }

    public class View_Modele : Modele
    {
        public string scaleUP(string str)
        {
            char[] result = new char[str.Length];
            int iteration = -1;
            foreach (char c in str)
            {
                int unicode = c;
                if(unicode >= this.min_ASCII[0] && unicode <= this.min_ASCII[1])
                {
                    unicode = (this.min_ASCII[0] - 65) + this.maj_ASCII[0];
                }
                result[iteration++] = unicode;  
            }
            
            return str;
        }
    }
    public class View
    {
        public void execute(string str)
        {
            Console.WriteLine("Merci d'entrer une chaine de charactère");
            Console.ReadLine();
            var VM = new View_Modele();
            str = VM.scaleUP(str);
            Console.WriteLine("Votre nouvelle chaîne de charactère");
            Console.WriteLine(str);
        }
    }
}
