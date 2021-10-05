/// HomeWork 6 Project 2 (Graded Assignment)    
/// File Name: Homework6_week6_part2
/// Student: Samuel Peppetta
/// Miracosta college fall 2021
/// Professor Mark Akola
/// 
///This is a program that uses methods to accomplish a task.  
///It takes ten random element integers numbers in 
///an array and reverses the contents in the array. 





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6_week6_part2
{
    class Program
    {
static void Main(string[] args)
        {
            //main methods call from 
            int[] OriginalArray = GenerateNumbers();
            int[] ReverseArray = Reverse(OriginalArray);
            PrintNumbers(OriginalArray);
            PrintNumbers(ReverseArray);
            Console.Read();
        }

        static int[] GenerateNumbers() //should return "int"numbers of numbers in ten
                                       //elements. 
        {
            int[] num = new int[10];
            Random rand = new Random();//Random generator from Random class
                                       //for generating the element's ten
                                       //integer numbers
            for (int i = 0; i < num.Length; i++) //first for loop from 0-10
            {
                num[i] = rand.Next(1, 11); //random numbers from 1-10 different
                                            // numbered pics
            }
            return num;
        }

        static int[] Reverse(int[] original)// reverses the elements in an array
        {
            int[] temp = new int[original.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = original[original.Length - i - 1];//"swapping"algorithm of elemnets 
                                                            //in the array
            }
            return temp;
        }

        static void PrintNumbers(int[] printedNumbers)
        {
            Console.Write("Array Info: ");
            for (int i = 0; i < printedNumbers.Length; i++)// uses for loop to go 
                                                          //down the array one element
                                                         //at a time and print out the
                                                        //items. Note!! Do not use foreach
                                                        //loop it will not show numbers!!
            {
                Console.Write(printedNumbers[i] + ",");
            }
            Console.WriteLine();
        }
    }
}
