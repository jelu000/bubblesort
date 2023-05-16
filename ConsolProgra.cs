/*Namn: Jens Lundeqvist 6601108217    
* Kurs: L0002B
* Uppgift: 1
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L0002B_Inl_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tal1 = "";//inmatade tal i strängform - och lagrar inmatat Pris i variabeln
            string tal2 = "";// - lagar inmatat Betalning
            int int_tal1 = 0;//De inmatade talen i sträng form konverteras till int och lagras i dessa variabler för att kunna utföra matematiska beräkningar
            int int_tal2 = 0;

            bool goapp = true;//används för att repetera programmet

            Exchanger t_exchanger = new Exchanger();//skapar ett objekt som jag kallat t_exchanger av klassen Exchanger
            
            
            //Kör om programmet så länge användaren trycker j
            do
            {
                Console.Clear();//tömmer consol skärm

                try // Använder try - cach sats för att sköta felhantering, ex inmatning av bokstäver istället för siffror
                {
                    Console.Write("\nAnge pris: ");
                    tal1 = Console.ReadLine();
                    int_tal1 = int.Parse(tal1);


                    Console.Write("Betalt: ");
                    tal2 = Console.ReadLine();
                    int_tal2 = int.Parse(tal2);

                }
                catch (Exception e)//Fel hantering om användaren inte matar in siffror 
                {
                    Console.WriteLine("Inmatnings fel, endast helta är giltigt!");
                    Console.Write(e);
                }

                //FelHantering - Om betalt belopp är mer än 2kr och betalt belopp är mer än vad priset är ska beräkning göras
                if (int_tal2 > int_tal1 && int_tal2 > 1)
                {
                    int tillbaka = int_tal2 - int_tal1;

                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Växel tillbaka: " + tillbaka);
                    Console.WriteLine("-------------------------\n");

                    
                    //Skapar ett List object och tilldelar listan jag får från metoden getChangeStringList som anropas från t_echanger objektet
                    List<string> t_pengartillbaka_list = t_exchanger.getChangeStringList(tillbaka);

                    //Loopar ut alla strängar i List objectet t_pengartillbaka_list
                    foreach (string t_pengartillbaka in t_pengartillbaka_list)
                    {
                        Console.WriteLine(t_pengartillbaka);
                    }                   
                }

                else //Felhantering om beloppet är för litet
                {
                    Console.WriteLine("Beräkningen kunde inte göras eller belopp för litet!");
                }

                Console.WriteLine("\nVill du göra en beräkning till? j/n");
                if (Console.ReadLine() == "j")//om användaren vill köra programmet en gång till
                    goapp = true;
                else
                    goapp = false;//avsluta pogrammet
            }

            while (goapp);//Kör pogrammet så länge användaren trycker j
           
        }
    }
}
