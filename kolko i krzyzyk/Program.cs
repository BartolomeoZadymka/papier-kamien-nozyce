using System;

namespace kolko_i_krzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam w grze papier kamien nozyce");
            Console.WriteLine("Do ilu chcesz zagrać ?");
            int ilosc = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj swój wybór: \n 1.Kamień \n 2.Papier \n 3.Nożyce");

            int wb = 0, wg = 0, r=0;
            Random los;
            los = new Random();
            for (int i = 0; i < ilosc; i++)
            {


                int b = los.Next(1, 4);
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    if (x < 1 || x > 3)
                        throw new ArgumentOutOfRangeException();

                    if (x == 1 && b == 2)
                    {
                        Console.WriteLine("Przegrałeś");
                        wb++;

                    }
                    if (x == 2 && b == 3)
                    {
                        Console.WriteLine("Przegrałeś");
                        wb++;

                    }
                    if (x == 3 && b == 1)
                    {
                        Console.WriteLine("Przegrałeś");
                        wb++;

                    }
                    if (x == 1 && b == 3)
                    {
                        Console.WriteLine("Wygrałeś");
                        wg++;
                    }
                    if (x == 2 && b == 1)
                    {
                        Console.WriteLine("Wygrałeś");
                        wg++;
                    }
                    if (x == 3 && b == 2)
                    {
                        Console.WriteLine("Wygrałeś");
                        wg++;
                    }
                    if (x == b)
                    {
                        Console.WriteLine("Remis");
                        r++;
                    }


                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
             
            }
            Console.WriteLine("wynik bot " + wb + " gracz " + wg + " remisy " + r);
        }
    }
}
