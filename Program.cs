using System;

namespace Part_5___Hurricane_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int hur_cat;
            Console.WriteLine("Please enter a category of the hurricane you would like to examine between 1 and 5.");
            hur_cat = Convert.ToInt32(Console.ReadLine());

            if (hur_cat == 1)
            {
                Console.WriteLine("Category 1: 74-95mph or 64-82kt or 119-153km/hr");
                Console.ReadLine();
            }

            else if (hur_cat == 2)
            {
                Console.WriteLine("Category 2: 96-110mph or 83-95kt or 154-177km/hr");
                Console.ReadLine();
            }

            else if (hur_cat == 3)
            {
                Console.WriteLine("Category 3: 111-130mph or 96-113kt or 178-209km/hr");
                Console.ReadLine();
            }

            else if (hur_cat == 4)
            {
                Console.WriteLine("Category 4: 131-155mph or 114-135kt or 210-249km/hr");
                Console.ReadLine();
            }

            else if (hur_cat == 5)
            {
                Console.WriteLine("Category 5: Greather than 155mph or 135kt or 249km/hr");
                Console.ReadLine();
            }
            else
                Console.WriteLine("Invalid entry.");
        }
    }
}
