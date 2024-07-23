using System;

namespace Which_Number_Missing_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // creat input 
            Console.Write("How many elements (numbers) you want in the collection? ");
            int size = int.Parse(Console.ReadLine());
            // creat array
            int[] collection = new int[size];
            // insert datas in array
            for (int i = 0; i < size; i++)
            {
                Console.Write("Which number do you want to insert in the collection? ");
                collection[i] = int.Parse(Console.ReadLine());
            }
            // ask if you want find a someone number
            Console.WriteLine("Ok, you made your collection. Do you want to find a number? [y/n]: ");
            string answer = Console.ReadLine();
            // if yes 
            if (answer == "y")
            {   //ask which number
                Console.Write("Which number do you want to find? ");
                //convert string in int
                if (int.TryParse(Console.ReadLine(), out int numberToFind))
                {
                    bool found = false;

                    foreach (int number in collection)
                    {//verification if this number in collection
                        if (number == numberToFind)
                        {
                            Console.WriteLine($"{numberToFind} is in the collection.");
                            found = true;
                            break; // Exit the loop if the number is found
                        }
                    }
                    // if not in the collection
                    if (!found)
                    {
                        Console.WriteLine($"{numberToFind} is not in the collection.");
                    }
                }// if insert data in not number 
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            // show collection
            Console.WriteLine("Your collection: ");
            foreach (int number in collection)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //ask if make again
            Console.Write("You want a new collection? [y/n]: ");
            string whileAnswer = Console.ReadLine();
            // if yes
            while (whileAnswer == "y")
            {
                Console.Write("How many elements (numbers) you want in the collection? ");
                int Size = int.Parse(Console.ReadLine());

                int[] newCollection = new int[Size];

                for (int i = 0; i < Size; i++)
                {
                    Console.Write("Which number do you want to insert in the collection? ");
                    newCollection[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Ok, you made your collection. Do you want to find a number? [y/n]:");
                string findAnswer = Console.ReadLine();

                if (findAnswer == "y")
                {
                    Console.Write("Which number will you find? ");

                    if (int.TryParse(Console.ReadLine(), out int numberToFind))
                    {
                        bool isPresent = false;

                        foreach (var item in newCollection)
                        {
                            if (item == numberToFind)
                            {
                                Console.WriteLine($"{item} is in the collection.");
                                isPresent = true;
                                break;
                            }
                        }

                        if (!isPresent)
                        {
                            Console.WriteLine($"{numberToFind} is not in the collection.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }

                Console.WriteLine("Your collection is:");
                foreach (var item in newCollection)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
                //make again? 
                //if not will exit
                Console.Write("Do you want to exit? [y/n]: ");
                string haveExit = Console.ReadLine();
                if (haveExit == "y")
                {
                    Console.WriteLine("Ok, bye");
                    break;
                }

                Console.Write("You want a new collection? [y/n]: ");
                whileAnswer = Console.ReadLine();
            }
        }
    }
}
