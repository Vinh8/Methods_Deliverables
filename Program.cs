using System;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    // First method to random populate array when called 
    static int[] random_array(int user_input)
    {
        Random random = new Random();
        int[] array = new int[user_input];
        for (int i = 0; i < user_input; i++)
        {
            array[i] = random.Next(10,50);
        }
         return array;
    }
    // Second method to take the sum of the array when selected
    static int sum(int[] array)
    {
        int sum = 0;
        foreach (int i in array)
        {
            sum = sum + i;

        }
        return sum; 
    }
    // Main body to call the methods and display it
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer number between 5 and 15");
        try
        {
            int user_input = int.Parse(Console.ReadLine());

            int[] array = random_array(user_input);
            Console.WriteLine("Input: " + user_input.ToString());

            Console.WriteLine("Output: ");

            Console.Write("The elements of the arrays are: ");

            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(" ");
            Console.WriteLine("The sum is: " + sum(array));

        }
        catch
        {
            Console.WriteLine("Please enter an integer between 5 and 15");
            Console.ReadKey(true);
        }
    }
}