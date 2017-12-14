using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        
        public enum WalkingDeadCharacters
        {
            RICK,
            SHANE,
            LORI,
            ANDREA,
            DALE,
            GLENN,
            CARL,
            DARYL,
            CAROL,
            MERLE,
            MORGAN,
            MAGGIE,
            HERSHEL,
            BETH,
            MICHONNE,
            GOVERNOR,
            TYREESE,
            SASHA,
            BOB,
            TARA,
            ABRAHAM,
            EUGENE,
            ROSITA,
            GARETH,
            GABRIEL,
            AARON,
            DEANNA,
            JESSIE,
            SPENCER,
            ENID,
            DWIGHT,
            JESUS,
            GREGORY,
            NEGAN,
            SIMON,
            EZEKIEL,
            JADIS
               

        }
       

        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Please enter the first name of a character on the Walking Dead." + 
                " The Computer will tell you the name of the actor who plays that character: ");

            var answer = Console.ReadLine().Replace(" ", "").ToUpper();
            var firstName = Enum.TryParse<WalkingDeadCharacters>(answer, out WalkingDeadCharacters name);

            

            if (firstName)
            {
                switch (name)
                {
                    
                    case WalkingDeadCharacters.SHANE:
                        {
                            Console.WriteLine("Jon Bernthal");
                            break;
                        }
                    case WalkingDeadCharacters.LORI:
                        {
                            Console.WriteLine("Sarah Wayne Callies");
                            break;
                        }
                    case WalkingDeadCharacters.ANDREA:
                        {
                            Console.WriteLine("Laurie Holden");
                            break;
                        }
                    case WalkingDeadCharacters.DALE:
                        {
                            Console.WriteLine("Jeffrey DeMunn");
                            break;
                        }
                    case WalkingDeadCharacters.GLENN:
                        {
                            Console.WriteLine("Steven Yeun");
                            break;
                        }
                    case WalkingDeadCharacters.CARL:
                        {
                            Console.WriteLine("Chandler Riggs");
                            break;
                        }
                    case WalkingDeadCharacters.DARYL:
                        {
                            Console.WriteLine("Norman Reedus");
                            break;
                        }
                    case WalkingDeadCharacters.CAROL:
                        {
                            Console.WriteLine("Melissa McBride");
                            break;
                        }
                    case WalkingDeadCharacters.MERLE:
                        {
                            Console.WriteLine("Michael Rooker");
                            break;
                        }
                    case WalkingDeadCharacters.MORGAN:
                        {
                            Console.WriteLine("Lennie James");
                            break;
                        }
                    case WalkingDeadCharacters.MAGGIE:
                        {
                            Console.WriteLine("Lauren Cohan");
                            break;
                        }
                    case WalkingDeadCharacters.HERSHEL:
                        {
                            Console.WriteLine("Scott Wilson");
                            break;
                        }

                    case WalkingDeadCharacters.BETH :
                        {
                            Console.WriteLine("Emily Kinney");
                            break;
                        }
                    case WalkingDeadCharacters.MICHONNE :
                        {
                            Console.WriteLine("Danai Gurira");
                            break;
                        }

                    case WalkingDeadCharacters.GOVERNOR :
                        {
                            Console.WriteLine("David Morrissey");
                            break;
                        }

                    case WalkingDeadCharacters.TYREESE :
                        {
                            Console.WriteLine("Chad Coleman");
                            break;
                        }

                    case WalkingDeadCharacters.SASHA :
                        {
                            Console.WriteLine("Sonequa Martin-Green");
                            break;
                        }


                    case WalkingDeadCharacters.BOB :
                        {
                            Console.WriteLine("Lawrence Gilliard Jr.");
                            break;
                        }


                    case WalkingDeadCharacters.TARA :
                        {
                            Console.WriteLine("Alanna Masterson!");
                            break;
                        }


                    case WalkingDeadCharacters.ABRAHAM :
                        {
                            Console.WriteLine("Michael Cudlitz");
                            break;
                        }


                    case WalkingDeadCharacters.EUGENE :
                        {
                            Console.WriteLine("Josh McDermitt");
                            break;
                        }


                    case WalkingDeadCharacters.ROSITA :
                        {
                            Console.WriteLine("Christian Serratos");
                            break;
                        }

                    case WalkingDeadCharacters.GARETH :
                        {
                            Console.WriteLine("Andrew J. West");
                            break;
                        }

                    case WalkingDeadCharacters.GABRIEL :
                        {
                            Console.WriteLine("Seth Gilliam");
                            break;
                        }

                    case WalkingDeadCharacters.AARON :
                        {
                            Console.WriteLine("Ross Marquand");
                            break;
                        }

                    case WalkingDeadCharacters.DEANNA :
                        {
                            Console.WriteLine("Tovah Feldshuh");
                            break;
                        }

                    case WalkingDeadCharacters.JESSIE :
                        {
                            Console.WriteLine("Alexandra Brekenridge");
                            break;
                        }

                    case WalkingDeadCharacters.SPENCER :
                        {
                            Console.WriteLine("Austin Nichols");
                            break;
                        }

                    case WalkingDeadCharacters.ENID :
                        {
                            Console.WriteLine("Katelyn Nacon");
                            break;
                        }

                    case WalkingDeadCharacters.DWIGHT :
                        {
                            Console.WriteLine("Austin Amelio");
                            break;
                        }

                    case WalkingDeadCharacters.JESUS :
                        {
                            Console.WriteLine("Tom Payne");
                            break;
                        }

                    case WalkingDeadCharacters.GREGORY :
                        {
                            Console.WriteLine("Xander Berkely");
                            break;
                        }

                    case WalkingDeadCharacters.NEGAN :
                        {
                            Console.WriteLine("Jeffery Dean Morgan");
                            break;
                        }

                    case WalkingDeadCharacters.SIMON :
                        {
                            Console.WriteLine("Steven Ogg");
                            break;
                        }

                    case WalkingDeadCharacters.EZEKIEL :
                        {
                            Console.WriteLine("Khary Payton");
                            break;
                        }

                    case WalkingDeadCharacters.JADIS :
                        {
                            Console.WriteLine("Pollyanna McIntosh");
                            break;
                        }


                    
                        
                    default:
                        {
                            Console.WriteLine("Andrew Lincoln");
                            break;
                        }
                }

            }
            else
            {
                Console.WriteLine("That is not a recognized character on The Walking Dead.");
            }
            Console.ReadLine();


            

           public class ClassCalculator
    {
     public class Calculator
        {        
            
            public double Square(double num) => num * num;

            public double Add(double num1, double num2) => num1 + num2;
            public double Multiply(double  num1, double num2) => num1 * num2;
            public double Divide(double num1, double num2) => num2 / num1;
            public double Subtract(double num1, double num2)
            {
                if (num1 > num2) 
                {
                    return num1 - num2;
                }
                return num2 - num1;
            }

        }
        }
    } 



             

        

    }

