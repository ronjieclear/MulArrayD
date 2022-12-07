using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulArrayD
{
    internal class Program
    {
        public static void Shuffle(Random random, string[,] arr)
        {
            int height = arr.GetUpperBound(0) + 1; // Y same as getlen
            int width = arr.GetUpperBound(1) + 1; // X
            for (int i = 0; i < height; i++) //loop Y Questions
            {
                int randomRow = random.Next(i, height); //select a random number
                for (int j = 0; j < width; ++j) //retrieve Y and add the to new array
                {
                    string tmp = arr[i, j]; //select rows
                    arr[i, j] = arr[randomRow, j];//add new rows
                    arr[randomRow, j] = tmp; //save to the new array rows
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Array");
            //to create mul array
            string[,] questions = new string[3,2];
            questions[0, 0] = "Q1"; //1
            questions[1, 0] = "Q2"; //2
            questions[2, 0] = "Q3"; //3
            // questions[3, 0] = "Q4"; //4 - index out of bounds
            questions[0, 1] = "Ans1";
            questions[1, 1] = "Ans2";
            questions[2, 1] = "Ans3";
            //TO display the value of a mul array
            Console.WriteLine(questions[1, 0]); // This will display Q2
            Console.WriteLine(questions[1, 1]); //This will display Ans2

            //Create a dynamic multi dimensional array with initial value 
            string[,] QA = new string[,]
            {   // 1   2    3  4   5   6   cols - w
                {"Q1","A","B","C","D","A"},  //1  
                {"Q2","A","B","C","D","B"},  //2
                {"Q3","A","B","C","D","C"},  //3 rows - h
                {"Q4","A","B","C","D","D"},  //4 rows - h
                {"Language used in Prog2","C","Python","C#","HTML","C#" }
            };

            Random rnd = new Random(); //declare a randomizer
            Shuffle(rnd, QA); //function call send array to shuffle class

            //determine the h & w of the array
            int h=QA.GetLength(0);
            int w=QA.GetLength(1);
            Console.WriteLine(h);
            Console.WriteLine(w);

            string ca = "";//this will hold the correct answer
            string sagot = "";//this will holf the answer from the user
            //to show all values of the array, dimaliwat say use nested loop
            for (int i = 0; i < h; i++) //this loop the questions
            {
                Console.WriteLine(QA[i,0]); //this shows the questions
                for (int j = 1; j < w; j++) ///this will show the options
                {
                    if (j==w-1)//get the correct answer
                    {
                        ca = QA[i, j];//this will hold the correct answer
                    }
                    else
                    {
                        Console.Write($" {QA[i, j]} ");//this shows the options
                    }                    
                }//end of loop options
                Console.WriteLine();//To create a new line
                Console.Write("Enter your answer:");  //Ask for the user answer
                sagot = Console.ReadLine();
                if (sagot == ca)//this will check if the answer is correct
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"The correct answer is {ca}");
                }
            }//end of loop questions

            Console.ReadLine();
        }
    }
}
