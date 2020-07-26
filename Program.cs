using System;

namespace CSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            // maak een variable aan die stuckKey heet
            ConsoleKeyInfo struckKey;
            
            /*Ga de volgende block code doen:

            de variable stuckKey pakt wat je in typt, zet " || You pressed " er achter.
            zet daarna wat je daadwerkelijk hebt ingedrukt er achter 
            Doe dit tot er escape wordt ingeklikt*/

            do
            {
                struckKey = Console.ReadKey();
                Console.Write(" || You pressed: ");
                Console.WriteLine(struckKey.Key.ToString());
            } while (struckKey.Key != ConsoleKey.Escape);
        }
    }
}
