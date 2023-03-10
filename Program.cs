using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmirOmidvarTamrin
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            Console.WriteLine("Are you married?");
            answer = Console.ReadLine();
            switch (answer)
            {
                case ("yes"):
                    Console.WriteLine("Do you love Your Wife?");
                    answer = Console.ReadLine();
                    switch (answer)
                    {
                        case("yes"):
                            Console.WriteLine("Do you have any child?");
                            answer = Console.ReadLine();
                            switch (answer)
                            {
                                case ("yes"):
                                    Console.WriteLine("do you love them?");
                                    answer = Console.ReadLine();
                                    switch (answer)
                                    {
                                        case ("yes"):
                                            Console.WriteLine("do they love you?");
                                            answer = Console.ReadLine();
                                            switch (answer)
                                            {
                                                case ("yes"):
                                                    Console.WriteLine("Great!");
                                                    break;
                                                case ("no"):
                                                    Console.WriteLine("You SHould be a better father");
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid");
                                                    break;


                                            }
                                            break;
                                        case ("no"):
                                            Console.WriteLine("You have to love them so that they love you");
                                            break;
                                        default:
                                            Console.WriteLine("Invalid");
                                            break;

                                    }
                                    break;
                                case ("no"):
                                    Console.WriteLine("Please have a baby");
                                    break;
                                default:
                                    Console.WriteLine("Invalid");
                                    break;
                            }
                            break;
                        case ("no"):
                            Console.WriteLine("You should love her to have a better life.");
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;

                    }
                    break;
                case ("no"):
                    Console.WriteLine("Lets get married");
                    break;
                default: Console.WriteLine("Invalid");
                    break;

            }
            Console.ReadKey();
        }
    }
}
