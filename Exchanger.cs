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
    //skapar en klass jag kallar Exchager som ska användas i huvudprogrammet
    class Exchanger
    {
            //konstruktor som körs först och som också används för att kunna skapa ett object av klassen Exchanger
            public Exchanger()
            {
                Console.WriteLine("Testclass - constructor");
            }

            /*exChange500:100:20:1(t_belopp) : används för hur många gånger en mynt/sedelvalör går att få ut från beloppet
             * IN: beloppet
             * UT: antal mynt/sedlar man får ut från beloppet
             */
            public int exChange500(int t_belopp)
            {
                int antal = t_belopp / 500;
                return antal;
            }

            public int exChange100(int t_belopp)
            {
                int antal = t_belopp / 100;
                return antal;
            }

            public int exChange20(int t_belopp)
            {
                int antal = t_belopp / 20;
                return antal;
            }

            public int exChange5(int t_belopp)
            {
                int antal = t_belopp / 5;
                return antal;
            }

            public int exChange1(int t_belopp)
            {
                int antal = t_belopp / 1;
                return antal;
            }
            /*getRest(tal, t_sedel) beräknar rest från  tidigare delat belopp så man vet hur mycket pengar det blir över vid varje växling
             * IN: tal är det belopp som man vill växla : t_sedel är den mynt/sedelavalör man vill få rest ifrån
             * UT: rest som man kan använda för nästa mindre växling.
             */

            public int getRest(int t_tal, int t_sedel)
            {
                return t_tal % t_sedel;
            }

            /*getChangeStringList(tillbaka) metod för att beräkna växling för varje valör lagra dessa i strängformat i Lista 
             * IN: tillbaka är den summa pengar man vill basera sin växling på
             * UT: Lista med strängar för växling i vaje valör, 500, 100, 20, 5, 1
             */
            public List<string> getChangeStringList(int tillbaka = 0)
            {
                int antal_sedlar = 0;
                string pengar_tillbaka_string = "";
                //skapar ett List objekt för att lagra strängar och som den här metoden sen ska retunera 
                List<string> pengar_tillbaka_list = new List<string>();

                //Prövar att växla 500lappar
                antal_sedlar = exChange500(tillbaka);
                if (antal_sedlar > 0)//om det blir mer än 1st 500lapp så gör växling
                {
                    if (antal_sedlar > 1)//om de är fler en 1st 500lapp skriv strängen i plural
                        pengar_tillbaka_string = antal_sedlar + " femhundralappar";
                    else//annar skriv strängen i singular
                        pengar_tillbaka_string = antal_sedlar + " femhundralapp";

                    pengar_tillbaka_list.Add(pengar_tillbaka_string);//lägger till strängen i List objektet
                    tillbaka = getRest(tillbaka, 500);//Kollar vilken rest det blir efter växling och tilldelar det till variabel tillbaka
                }

                antal_sedlar = exChange100(tillbaka);//Lika som ovan OSV fast valör 100Lappar
                if (antal_sedlar > 0)
                {
                    if (antal_sedlar > 1)
                        pengar_tillbaka_string = antal_sedlar + " hundralappar";
                    else
                        pengar_tillbaka_string = antal_sedlar + " hundralapp";

                    pengar_tillbaka_list.Add(pengar_tillbaka_string);
                    tillbaka = getRest(tillbaka, 100);
                }

                antal_sedlar = exChange20(tillbaka);//Lika som ovan OSV fast valör 20Lappar
            if (antal_sedlar > 0)
                {
                    if (antal_sedlar > 1)
                        pengar_tillbaka_string = antal_sedlar + " tjugor";
                    else
                        pengar_tillbaka_string = antal_sedlar + " tjuga";

                    pengar_tillbaka_list.Add(pengar_tillbaka_string);
                    tillbaka = getRest(tillbaka, 20);
                }

                antal_sedlar = exChange5(tillbaka); //Lika som ovan OSV fast valör 5kronor
            if (antal_sedlar > 0)
                {
                    if (antal_sedlar > 1)
                        pengar_tillbaka_string = antal_sedlar + " femkronor";
                    else
                        pengar_tillbaka_string = antal_sedlar + " femkrona";

                    pengar_tillbaka_list.Add(pengar_tillbaka_string);
                    tillbaka = getRest(tillbaka, 5);
                }

                antal_sedlar = exChange1(tillbaka); //Lika som ovan OSV fast valör 1kronor
            if (antal_sedlar > 0)
                {
                    if (antal_sedlar > 1)
                        pengar_tillbaka_string = antal_sedlar + " enkronor";
                    else
                        pengar_tillbaka_string = antal_sedlar + " enkrona";

                    pengar_tillbaka_list.Add(pengar_tillbaka_string);
                    tillbaka = getRest(tillbaka, 1);
                }


                return pengar_tillbaka_list; // returnera Listan

            }


        
    }
}
