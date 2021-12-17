using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ipr1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Notify += DisplayMessage;

            Console.WriteLine("Add elements to Stack and press Enter to finish" +
                              "\npress 1 to add" +
                              "\npress 2 to remove");

            bool temp = true;
            int k;
            while (temp == true)
            {
                try
                {
                    switch (Console.ReadKey(true).Key)
                    {

                        case ConsoleKey.D1:
                            {
                                Console.Write("member:");
                                st.Add(int.Parse(Console.ReadLine()));
                                break;
                            }

                        case ConsoleKey.D2:
                            {
                                st.Remove(out k);
                                Console.WriteLine($"     Removed member: {k}");
                                break;
                            }

                        case ConsoleKey.Enter:
                            {
                                temp = false;
                                break;
                            }

                        default:
                            {
                                Console.WriteLine("Please, choose what you want to do");
                                break;
                            }
                    }
                }

                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("try again");
                    Console.ResetColor();
                    continue;
                }
            }
                
            k = st.Peek();
            Console.WriteLine($"the first memeber {k}");

            st.Clear();
            Console.WriteLine($"number of objects in stack {st.Count}");

            

            Console.ReadKey();
        }

        private static void DisplayMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
    
}
