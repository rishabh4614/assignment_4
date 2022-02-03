using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace assignment_1
{
   /* Collections
-----------
1. Write a program to find the Sum and the Average points scored by the teams in the IPL.Create a Class called Cricket that has a function
   called Pointscalculation(int no_of_matches) that takes no.of matches as input and accepts that many scores from the user.The function should 
   then display the Average and Sum of the scores
 2.. Create a Class called Products with Productid, Product Name, Price.Accept 10 Products, sort them based on the price, and display the 
   sorted Products
 3. Create a simple Stationery application to add items and display added items using Generic collections
*/
    class Cricket
    {
        
        public void Pointscalculation(int no_of_matches)
        {
            int sum = 0;
            int[] Score = new int[no_of_matches];
            for (int i = 0; i < no_of_matches; ++i)
            {
                Console.Write($"Enter Score in {i + 1}st match: ");
                Score[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + Score[i];
            }
            Console.WriteLine("Sum of the Score is :" + sum);
            int avg = 0;
            avg = sum / no_of_matches;
            Console.WriteLine("Average of the Score is: " + avg);
        }
    }

    class Products
    {
        int Productid { get; set; }
        string Product_name { get; set; }
        double Price { get; set; }
        public int pid
        {
            get { return Productid; }
            set { Productid = value; }
        }
        public string pname
        {
            get { return Product_name; }
            set { Product_name = value; }
        }
        public double price
        {
            get { return Price; }
            set { Price = value; }
        }

       
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------Program 1------------------------------");
            Console.Write("Enter no of matches: ");
            int no = Convert.ToInt32(Console.ReadLine());
            Cricket c = new Cricket();
            c.Pointscalculation(no);
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("-----------------------------Program 2------------------------------");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            Console.WriteLine("Enter data's in Dictionary");
            for( int i =0; i<2; ++i)
            {
                string str =  Console.ReadLine();
                int itr = Convert.ToInt32(Console.ReadLine());

                dict.Add(itr,str);
                Console.WriteLine("Added!!!");
            }
            
            Console.WriteLine("Products in Dictionay are: ");

            foreach (KeyValuePair<int, string> i in dict)
            {
                Console.WriteLine($"Product Name is: {i.Value} with Price : {i.Key}");
            }
            Console.WriteLine();
            Console.WriteLine("Price in Sorted Order");

            foreach (KeyValuePair<int, string> i in dict.OrderBy(key => key.Value))
            {
                Console.WriteLine($"Product Name is: {i.Value} with Price : {i.Key}");
            }
            Console.WriteLine("-----------------------------Program 3------------------------------");

            List<string> lst = new List<string>();                      // Genric Collection of same data type

            Console.Write("Enter how many data wants to enter: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i< num; ++i)
            {
                Console.Write($"Enter item: {i+1} ");
                string str = Console.ReadLine();
                lst.Add(str);
            }
            Console.WriteLine("Display items in list !!");
            foreach(string v in lst)
            {
                Console.WriteLine(v);
            }
        }
    }
}
