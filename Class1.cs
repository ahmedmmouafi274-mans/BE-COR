using System;
using System.Collections.Generic;

class Program
{
    static List<int> sId = new List<int>();
    static List<string> sName = new List<string>();
    static List<List<int>> sCourses = new List<List<int>>();

    static List<int> iId = new List<int>();
    static List<string> iName = new List<string>();

    static List<int> cId = new List<int>();
    static List<string> cTitle = new List<string>();
    static List<int> cInst = new List<int>();

    static void Main()
    {
        int choice = -1;

        while (choice != 0)
        {
            Console.WriteLine("\n1-Add Student 2-Add Instructor 3-Add Course 4-Enroll 5-Show Students 6-Show Courses 0-Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("ID: "); sId.Add(int.Parse(Console.ReadLine()));
                Console.Write("Name: "); sName.Add(Console.ReadLine());
                sCourses.Add(new List<int>());
            }
            else if (choice == 2)
            {
                Console.Write("ID: "); iId.Add(int.Parse(Console.ReadLine()));
                Console.Write("Name: "); iName.Add(Console.ReadLine());
            }
            else if (choice == 3)
            {
                Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
                Console.Write("Title: "); string title = Console.ReadLine();
                Console.Write("Instructor ID: "); int inst = int.Parse(Console.ReadLine());

                if (!iId.Contains(inst))
                {
                    Console.WriteLine("Instructor not found.");
                    continue;
                }

                cId.Add(id); cTitle.Add(title); cInst.Add(inst);
            }
            else if (choice == 4)
            {
                Console.Write("Student ID: "); int s = int.Parse(Console.ReadLine());
                Console.Write("Course ID: "); int c = int.Parse(Console.ReadLine());

                int si = sId.IndexOf(s);
                if (si == -1 || !cId.Contains(c))
                {
                    Console.WriteLine("Not found.");
                    continue;
                }

                sCourses[si].Add(c);
                Console.WriteLine("Enrolled.");
            }
            else if (choice == 5)
            {
                for (int i = 0; i < sId.Count; i++)
                {
                    string courses = "";
                    foreach (int c in sCourses[i])
                        courses += cTitle[cId.IndexOf(c)] + " ";

                    Console.WriteLine(sId[i] + " " + sName[i] + " -> " + courses);
                }
            }
            else if (choice == 6)
            {
                for (int i = 0; i < cId.Count; i++)
                {
                    string inst = iName[iId.IndexOf(cInst[i])];
                    Console.WriteLine(cId[i] + " " + cTitle[i] + " - " + inst);
                }
            }
        }
    }
}