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
            int iteration = 0;
            foreach (char c in str)
            {
                int unicode = c;
                if (unicode >= this.min_ASCII[0] && unicode <= this.min_ASCII[1])
                {
                    unicode = (unicode - 97) + this.maj_ASCII[0];

                    Console.WriteLine(unicode);
                }
                result[iteration++] = (char)unicode;  
            }
            str = new string(result);
            return str;
        }
    }
    public class View
    {
        public string[] unit { get; set; }
        public void execute()
        {
            Console.WriteLine("Merci d'entrer une chaine de charactère");
            string? str  = Console.ReadLine();
            var VM = new View_Modele();
            str = VM.scaleUP(str);
            Console.WriteLine("Votre nouvelle chaîne de charactère");
            Console.WriteLine(str);
        }
        public void test_unit()
        {
            var VM = new View_Modele();
            Console.WriteLine("Liste des tests : ");
            foreach (string item in unit)
            {
                Console.Write("Test : ");
                Console.WriteLine(item);
                Console.Write("Resultat : ");
                Console.Write(VM.scaleUP(item));
                Console.WriteLine();
            }
        }
        public View()
        {
            unit = new string[4] { "maison", "Corse123", "%&ciel", "!*port" };
        }
    }
}
