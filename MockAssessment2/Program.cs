using System;
using System.Collections.Generic;

namespace MockAssessment2
{
    class Program
    {
        static int AddStarWarsCharacters(string[] chars)
		{
            for (int i = 0; i < chars.Length; i++)
			{
                if (chars[i] == "Yoda")
				{
                    return i;
				}
			}
            return -1;
		}

        static string DeathStarCombat(Dictionary<string, int> attacks)
		{
            int highest = 0;
            string jedi = "";

            foreach (var pair in attacks)
			{
                if (pair.Value > highest)
				{
                    highest = pair.Value;
                    jedi = pair.Key;
				}
			}

            return jedi;
		}

        static int AverageDroidsWRONG(List<int> droids)
		{
            int sum = 0;
            int count = 0;
            foreach (int droid in droids)
			{
                if (droid % 2 == 0)
				{
                    sum += droid;
                    count++;
				}
			}
            return sum / count;
		}

        static int AverageDroids(List<int> droids)
		{
            List<int> evens = new List<int>();
            foreach (int droid in droids)
			{
                if (droid % 2 == 0)
				{
                    evens.Add(droid);
				}
			}

            int sum = 0;
            foreach (int droid in evens)
			{
                sum += droid;
			}
            return sum / evens.Count;
		}

        static string TryToCatchDarthVader(string mystring)
		{
            try
			{
                int num = int.Parse(mystring);
                return "Vader Was Captured!";
            }
            catch (Exception ex)
			{
                return "Vader Got Away!";
			}
        }

        // Let's write a function called IsInt and it will take a string, and return a bool
        // We will parse the string. If parses successfully, we'll return true
        //                           If it doesn't parse, we'll return false
        // Examples:
        //      If I call this function with "123", I should get back True
        //      If I call this function with "abc", I should get back False
        //      If I call this function with "0", I should get back True
        //      If I call this function with "", I should get back False
        // Requirement: Use try/catch
        static bool IsInt(string mystring)
        {
            try
            {
                int num = int.Parse(mystring);
                return true;
            }
            catch
            {
                return false;
            }
        }


        static void Main(string[] args)
        {
			Console.WriteLine("Testing Yoda search");

            string[] chars1 = new string[] { "Obi wan", "Luke", "Anakin", "Yoda" };
			Console.WriteLine($"Expecting 3: I got {AddStarWarsCharacters(chars1)}");  // Expecting 3

            string[] chars2 = new string[] { "Obi wan", "Luke", "Anakin" };
            Console.WriteLine($"Expecting -1: I got {AddStarWarsCharacters(chars2)}");  // Expecting -1

            Dictionary<string, int> attackValues = new Dictionary<string, int>();
            // ahsoka
            attackValues["Ahsoka"] = 6;
            attackValues["Obi Wan"] = 10;
            attackValues["Anakin"] = 9;
            attackValues["Luke"] = 3;

			Console.WriteLine($"Expecting Obi Wan: I got {DeathStarCombat(attackValues)}"); // Expecting Obi Wan

            // List to test AverageDroids
            List<int> droids = new List<int>() { 5, 8, 7, 2, 10, 11, 14, 15 };
			Console.WriteLine($"Expecting 8, got {AverageDroids(droids)}"); // Expect 8

			Console.WriteLine($"Expecting Vader Was Captured!, got {TryToCatchDarthVader("123")}");
			Console.WriteLine($"Excepting Vader Got Away!, got {TryToCatchDarthVader("abc")}");

			//      If I call this function with "123", I should get back True
			//      If I call this function with "abc", I should get back False
			//      If I call this function with "0", I should get back True
			//      If I call this function with "", I should get back False
			Console.WriteLine($"Expecting true, got {IsInt("123")}");
            Console.WriteLine($"Expecting false, got {IsInt("abc")}");
            Console.WriteLine($"Expecting true, got {IsInt("0")}");
            Console.WriteLine($"Expecting false, got {IsInt("")}");

        }
    }
}
