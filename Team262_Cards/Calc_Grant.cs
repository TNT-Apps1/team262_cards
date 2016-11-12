using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team262_Cards
{
    class Calc_Grant
    {
        static string[] cards = new string[52];// declare 52 cards
        static int[] holder = new int[5] { 99, 99, 99, 99, 99 };// 5 card holder
        static string controllLoop = "y";


        public Calc_Grant()
        {




            /* test sample of how it should be ran
             do
            {
                cardsToString();
                Console.WriteLine("Would you like to try again? Y:N");
                controllLoop = Console.ReadKey().KeyChar.ToString().ToLower();
                Console.Clear();
            } while (controllLoop == "y" || controllLoop == " ");
            */


        }// end constructor


        public string cardsToString()//run this method to get 5 random cards as a sting
        {
            clearHolder();
            buildCards();
            generateFiveRandomCards();


            string fiveCardString = "";
            for (int i = 0; i < holder.Length; i++)
            {
                fiveCardString = fiveCardString + cards[holder[i]] + "\n";
            }
            //Console.WriteLine(fiveCardString); //testing
            //Console.ReadLine();  //testing
            return fiveCardString;
        }

        private void clearHolder()//reset holder
        {
            int[] holder = { 99, 99, 99, 99, 99 };
        }

        public void generateFiveRandomCards() // generates 5 random cards from buildCards() method
        {
            int randomNumber = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                do
                {
                    randomNumber = rnd.Next(0, 52);
                } while (randomNumber == holder[0] || randomNumber == holder[1] || randomNumber == holder[2] || randomNumber == holder[3] || randomNumber == holder[4]);// looks for duplicates
                //end do loop


                holder[i] = randomNumber;// place a random non repeating number between 1-52 in one of the 5 positions of holder array

            }//end for loop



        }



        public void buildCards() //build 52 cards
        {
            for (int i = 0; i < 52; i++)
            {
                if (i >= 0 && i < 13)// build diamond
                {
                    cards[i] = System.String.Format(" {0} D", (i + 1));
                }
                else if (i >= 13 && i < 26)// build hearts
                {
                    cards[i] = System.String.Format(" {0} H", (i - 12));
                }
                else if (i >= 26 && i < 39)// build clubs
                {
                    cards[i] = System.String.Format(" {0} C", (i - 25));
                }
                else if (i >= 39 && i < 52)// build spaids
                {
                    cards[i] = System.String.Format(" {0} S", (i - 38));
                }
            }// end for loop

            /* testing
           foreach (string i in cards)
           {
               Console.WriteLine(i);
           }
           */

        }//end buildCards()




    }//end class
}//end namespace
