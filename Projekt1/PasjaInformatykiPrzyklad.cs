using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt1
{
    class PasjaInformatykiPrzyklad
    {
        static public string Login;
        static public string PIN;
        static public char wybor;

        public static int exitCode = 0;

        static public void Start()
        {
            for (; ; )
            {
                Console.WriteLine("Witaj w aplikacji mobilnej naszego banku! \nPodaj Login:");
                Login = Console.ReadLine();
                Console.WriteLine("Podaj PIN:");
                PIN = Console.ReadLine();
                if ((Login == "J") && (PIN == "2"))
                {
                    int stanKonta = 10000;

                    char wybor_jezyka;
                    int wplata;
                    int wyplata;
                    Console.WriteLine("Menu Głowne");
                    Console.WriteLine("---------------");
                    Console.WriteLine("1.Sprawdz stan konta");
                    Console.WriteLine("2.Wpłata gotówki");
                    Console.WriteLine("3.Wypłata gotówki");
                    Console.WriteLine("4.Zmień język");
                    Console.WriteLine("5.Koniec programu");

                    Console.WriteLine("Wybierz:");
                    wybor = Console.ReadKey(true).KeyChar;

                    switch (wybor)
                    {
                        case '1':
                            {
                                Console.WriteLine(stanKonta);
                            }
                            break;

                        case '2':
                            {   //Wpłata
                                Console.WriteLine("Wprowadź kwotę, którą wpłacasz");
                                wplata = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("Potwierdzenie wpłaty");
                                Console.WriteLine(wplata);
                                Console.WriteLine("PLN");
                                stanKonta += wplata;
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("Aktualny stan twojego konta wynosi:");
                                Console.WriteLine(stanKonta);
                            }
                            break;
                        case '3':
                            {   //Wypłata
                                Console.WriteLine("Wprowadź kwotę, którą wypłacasz");
                                wyplata = Int32.Parse(Console.ReadLine());

                                Console.WriteLine("Potwierdzenie wypłaty");
                                Console.WriteLine(wyplata);
                                Console.WriteLine("PLN");
                                stanKonta -= wyplata;
                                System.Threading.Thread.Sleep(1000);
                                Console.WriteLine("Aktualny stan twojego konta to:");
                                Console.WriteLine(stanKonta);
                            }
                            break;
                        case '4':
                            {
                                Console.WriteLine("1.Polski \n2.Angielski");
                                wybor_jezyka = Console.ReadKey(true).KeyChar;
                                if (wybor_jezyka == '2')
                                {
                                    Console.WriteLine("Main Menu");
                                    Console.WriteLine("---------------");
                                    Console.WriteLine("1.Check the account balance");
                                    Console.WriteLine("2.Cash deposite");
                                    Console.WriteLine("3.Cash handout");
                                    Console.WriteLine("4.Set language");
                                    Console.WriteLine("5.Close app");


                                    Console.WriteLine("Select:");
                                    wybor = Char.Parse(Console.ReadLine());
                                }
                                else
                                {
                                    Console.WriteLine("Język polski jest aktualnie używany");
                                }
                            }
                            break;

                        case '5':
                            {
                                Environment.Exit(exitCode);
                            }
                            break;
                        default:
                            Console.WriteLine("Niepoprawny znak. Wybierz opcje z menu");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Niepoprawny Login lub PIN!");
                }

                Console.ReadKey();
            }
        }
    }
}
