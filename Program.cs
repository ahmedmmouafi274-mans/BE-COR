using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> myNums = new List<int>();
        char choice;

        do
        {
            // print menu
            Console.WriteLine("\nP - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean");
            Console.WriteLine("S - Display smallest");
            Console.WriteLine("L - Display largest");
            Console.WriteLine("F - Find a number");
            Console.WriteLine("C - Clear list");
            Console.WriteLine("Q - Quit");
            Console.Write("Enter your choice: ");

            // get choice and convert to uppercase
            choice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (choice)
            {
                case 'P':
                    if (myNums.Count == 0)
                    {
                        Console.WriteLine("[] - the list is empty");
                    }
                    else
                    {
                        Console.Write("[ ");
                        for (int i = 0; i < myNums.Count; i++)
                        {
                            Console.Write(myNums[i] + " ");
                        }
                        Console.WriteLine("]");
                    }
                    break;

                case 'A':
                    Console.Write("Enter an integer: ");
                    int val = Convert.ToInt32(Console.ReadLine());

                    // check if number already in list (no duplicates)
                    bool isDup = false;
                    for (int i = 0; i < myNums.Count; i++)
                    {
                        if (myNums[i] == val)
                        {
                            isDup = true;
                            break;
                        }
                    }

                    if (isDup)
                    {
                        Console.WriteLine(val + " already exists - duplicate entries not allowed");
                    }
                    else
                    {
                        myNums.Add(val);
                        Console.WriteLine(val + " added");
                    }
                    break;

                case 'M':
                    if (myNums.Count == 0)
                    {
                        Console.WriteLine("Unable to calculate the mean - no data");
                    }
                    else
                    {
                        int total = 0;
                        for (int i = 0; i < myNums.Count; i++)
                        {
                            total += myNums[i];
                        }

                        // casting to double for accurate division
                        double avg = (double)total / myNums.Count;
                        Console.WriteLine("The mean is " + avg);
                    }
                    break;

                case 'S':
                    if (myNums.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the smallest number - list is empty");
                    }
                    else
                    {
                        int minVal = myNums[0];
                        for (int i = 1; i < myNums.Count; i++)
                        {
                            if (myNums[i] < minVal)
                            {
                                minVal = myNums[i];
                            }
                        }
                        Console.WriteLine("The smallest number is " + minVal);
                    }
                    break;

                case 'L':
                    if (myNums.Count == 0)
                    {
                        Console.WriteLine("Unable to determine the largest number - list is empty");
                    }
                    else
                    {
                        int maxVal = myNums[0];
                        for (int i = 1; i < myNums.Count; i++)
                        {
                            if (myNums[i] > maxVal)
                            {
                                maxVal = myNums[i];
                            }
                        }
                        Console.WriteLine("The largest number is " + maxVal);
                    }
                    break;

                case 'F':
                    if (myNums.Count == 0)
                    {
                        Console.WriteLine("List is empty - cannot search");
                    }
                    else
                    {
                        Console.Write("Enter number to search: ");
                        int target = Convert.ToInt32(Console.ReadLine());
                        int foundIdx = -1;

                        for (int i = 0; i < myNums.Count; i++)
                        {
                            if (myNums[i] == target)
                            {
                                foundIdx = i;
                                break;
                            }
                        }

                        if (foundIdx != -1)
                        {
                            Console.WriteLine(target + " found at index " + foundIdx);
                        }
                        else
                        {
                            Console.WriteLine(target + " not found in the list");
                        }
                    }
                    break;

                case 'C':
                    myNums.Clear();
                    Console.WriteLine("List cleared");
                    break;

                case 'Q':
                    Console.WriteLine("Goodbye");
                    break;

                default:
                    Console.WriteLine("Unknown selection, please try again");
                    break;
            }

        } while (choice != 'Q');
    }
}