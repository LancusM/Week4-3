using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Same setup as 4-2, decision isn't 0, loops the program
            int decision = 1;

            while (decision != 0)
            {
                int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };
                //initialize the matrix and prompt user for an action
                Console.WriteLine("Choose which action you want to perform:");
                Console.WriteLine("Print the matrix(1), Sum the matrix(2), Swap rows and columns(3), or Quit(0).");
                decision = Convert.ToInt32(Console.ReadLine());

                if (decision == 1)
                {
                    //I simply displayed the matrix/array as it should be, but I don't know the way so that it does this automatically. I looked to no avail.
                    Console.WriteLine("{ " + matrix[0, 0] + " " + matrix[0, 1] + " " + matrix[0, 2] + " }");
                    Console.WriteLine("{ " + matrix[1, 0] + " " + matrix[1, 1] + " " + matrix[1, 2] + " }");
                    Console.ReadLine();
                }
                if (decision == 2)
                {
                    //Literally identical to Week 4-2, sums all integers in the matrix and dispalys it.
                    int sum = 0;
                    foreach (int i in matrix)
                    {
                        sum += i;
                    }
                    Console.WriteLine("The sum is " + sum);
                    Console.ReadLine();
                }
                if (decision == 3) {
                    //Took me some time to figure it out, got most of my answers from here: https://stackoverflow.com/questions/18368611/how-do-i-transpose-a-multi-dimensional-array
                    //The r and j confuse me, but I understand it is moving the original array items into a transposed state, where it is 'longer' vertically, instead of horizontally. If that makes sense.
                    //It makes sense to me.
                    for (int j = 0; j < 3; j++)
                    {
                        for (int r = 0; r < 2; r++)
                            Console.Write("{0} ", matrix[r, j]);

                        Console.WriteLine();
                    }
                    //Then the code creates a new array with the items in the correct direction so that it displays correctly, instead of giving an error once it goes beyond the original boundaries.
                    var newArray = new int[3, 2];
                    for (int j = 0; j < 3; j++)
                        for (int r = 0; r < 2; r++)
                            newArray[j, r] = matrix[r, j];
                    //Admittedly, most of decision 3's code was from the site, but I do understand it.
                    Console.ReadLine();
                }
            }

        }
    }
}
