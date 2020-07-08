using System;

namespace TablesOfPowers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            string loopAgain;

            do
            {
                Console.Write("\r\nEnter an integer: ");
                string userString = Console.ReadLine();
                int userInput = Convert.ToInt32(userString);

                //Input limit must be below 1291 to not break the cubed integer limit
                //Input should be greater than Zero
                if (userInput > 0 && userInput < 1291)
                {
                    Console.WriteLine($"\r\nNumber\t\tSquared\t\tCubed");
                    Console.WriteLine($"=======\t\t=======\t\t=======");

                    for (int index = 1; index <= userInput; index++)
                    {
                        int squared = index * index;
                        int cubed = index * index * index;
                        string indexString = index.ToString();
                        string squaredString = squared.ToString();
                        string cubedString = cubed.ToString();
                        //format the output to be right justified
                        var output = String.Format("{0,7}{1,16}{2,16}", indexString, squaredString, cubedString);
                        Console.WriteLine(output);
                        //Console.WriteLine($"{indexString}\t\t{squaredString}\t\t{cubedString}");
                    }
                }
                else
                {   
                    Console.WriteLine("You must enter a positive number less than 1291.");
                }
                Console.Write("\r\nContinue? (y/n): ");
                loopAgain = Console.ReadLine();
            } while (loopAgain == "Y" || loopAgain == "y");
        }
    }
}
