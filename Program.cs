using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadanie_sortowanie_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> number_table = new List<string> { };
            try
            {
                Console.Write("Podaj pierwszą liczbę: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj drugą liczbę: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj trzecią liczbę: ");
                int c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Podaj czwartą liczbę: ");
                int d = Convert.ToInt32(Console.ReadLine());

                if(a >= b)
                {
                    if(a >= c)
                    {
                        if(a >= d)
                        {
                            number_table.Add($"{a}(a)");
                            if(b >= c)
                            {
                                if (b >= d)
                                {
                                    number_table.Add($"{b}(b)");
                                    if (c >= d)
                                    {
                                        number_table.Add($"{c}(c)");
                                        number_table.Add($"{d}(d)");
                                    }
                                    else
                                    {
                                        number_table.Add($"{d}(d)");
                                        number_table.Add($"{c}(c)");
                                    }
                                }
                                else
                                {
                                    number_table.Add($"{d}(d)");
                                    number_table.Add($"{b}(b)");
                                    number_table.Add($"{c}(c)");
                                }
                            }
                            else
                            {
                                if(b >= d)
                                {
                                    if(c >= d)
                                    {
                                        number_table.Add($"{c}(c)");
                                        number_table.Add($"{b}(b)");
                                        number_table.Add($"{d}(d)");
                                    }
                                }
                                else
                                {
                                    if(c >= d)
                                    {
                                        number_table.Add($"{c}(c)"); 
                                        number_table.Add($"{d}(d)");
                                        number_table.Add($"{b}(b)");
                                    }
                                    else
                                    {
                                        number_table.Add($"{d}(d)");
                                        number_table.Add($"{c}(c)");
                                        number_table.Add($"{b}(b)");
                                    }
                                }
                            }
                        }
                        else
                        {
                            if(b >= c)
                            {
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{c}(c)");
                            }
                            else
                            {
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{b}(b)");
                            }
                        }
                    }
                    else
                    {
                        if(a >= d)
                        {
                            if(b >= d)
                            {
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{d}(d)");
                            }
                            else
                            {
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{b}(b)");
                            }
                        }
                        else
                        {
                            if(c >= d)
                            {
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{b}(b)");
                            }
                            else
                            {
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{b}(b)");
                            }
                        }
                    }
                }
                else
                {
                    if (a >= c)
                    {
                        if (a >= d)
                        {
                            if (c >= d)
                            {
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{d}(d)");
                            }
                            else
                            {
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{c}(c)");
                            }
                        }
                        else
                        {
                            if (b >= d)
                            {
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{c}(c)");
                            }
                            else
                            {
                                number_table.Add($"{d}(d)");
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{c}(c)");
                            }
                        }
                    }
                    else
                    {
                        if(a >= d)
                        {
                            if(b >= c)
                            {
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{d}(d)");
                            }
                            else
                            {
                                number_table.Add($"{c}(c)");
                                number_table.Add($"{b}(b)");
                                number_table.Add($"{a}(a)");
                                number_table.Add($"{d}(d)");
                            }
                        }
                        else
                        {
                            if(b >= c)
                            {
                                if(b >= d)
                                {
                                    if(c >= d)
                                    {
                                        number_table.Add($"{b}(b)");
                                        number_table.Add($"{c}(c)");
                                        number_table.Add($"{d}(d)");
                                        number_table.Add($"{a}(a)");
                                    }
                                    else
                                    {
                                        number_table.Add($"{b}(b)");
                                        number_table.Add($"{d}(d)");
                                        number_table.Add($"{c}(c)");
                                        number_table.Add($"{a}(a)");
                                    }
                                }
                                else
                                {
                                    number_table.Add($"{d}(d)");
                                    number_table.Add($"{b}(b)");
                                    number_table.Add($"{c}(c)");
                                    number_table.Add($"{a}(a)");
                                }
                            }
                            else
                            {
                                if(b >= d)
                                {
                                    number_table.Add($"{c}(c)");
                                    number_table.Add($"{b}(b)");
                                    number_table.Add($"{d}(d)");
                                    number_table.Add($"{a}(a)");
                                }
                                else
                                {
                                    if(c >= d)
                                    {
                                        number_table.Add($"{c}(c)");
                                        number_table.Add($"{d}(d)");
                                        number_table.Add($"{b}(b)");
                                        number_table.Add($"{a}(a)");
                                    }
                                    else
                                    {
                                        number_table.Add($"{d}(d)");
                                        number_table.Add($"{c}(c)");
                                        number_table.Add($"{b}(b)");
                                        number_table.Add($"{a}(a)");
                                    }
                                }
                            }
                        }
                    }
                }

                /* Wypis liczb */
                foreach (string item in number_table)
                {
                    Console.Write($"{item},");
                }
                Console.WriteLine("\n------------------------------------");
                Console.WriteLine("Chcesz spróbować ponownie?(Y/n)");
                try
                {
                    string choose = Convert.ToString(Console.ReadLine());
                    if(choose == "Y" || choose == "y")
                    {
                        Console.Clear();
                        Main(args);
                    }
                    else if(choose == "N" || choose == "n")
                    {
                        Console.Clear();
                        Console.WriteLine("Trwa zamykanie aplikacji...");
                        Thread.Sleep(1500);
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                   
                    
                }
                catch
                {
                    Console.WriteLine("Nieprawidłowa wartość!");
                }
            }
            catch 
            {
                Console.WriteLine("Nieprawidłowa wartość spróbuj ponownie");
                Main(args);
            }
            Console.ReadKey();
        }
    }
}
