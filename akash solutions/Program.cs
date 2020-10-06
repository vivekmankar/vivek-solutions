using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        printTriangle(5);
    }

    private static void printTriangle(int n)
    {

        //validate input

        if (n > 0)
        {

            int level = 1;

            int spaces = n;

            for (int i = 1; i < n; i++)

            {

                spaces -= 1;

                //getting space to add in each level

                string inter_space = new String(' ', spaces);

                //computing the number of stars at each level

                string stars = new String('*', (level * 2) - 1);

                Console.WriteLine(inter_space + stars + inter_space + "\n");
                Console.ReadKey();

                //updating level 

                level++;

            }

        }
        else
        {

            Console.WriteLine("Please provide valide input to print a triagle");



        }

    }

}

================================================================================================

using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        getOddNumSeries(5);
    }

    private static void getOddNumSeries(int n)
    {

        //empty array to store odd elements

        int[] oddNumbers = new int[n];

        int count = 0;

        int numbers = 1;

        int seriesSum = 0;

        //loop till the N value

        while (count < n)
        {

            //check if number is odd

            if (numbers % 2 != 0)
            {

                //compute the sum

                seriesSum += numbers;

                //add odd number to array

                oddNumbers[count] = numbers;

            }

            //incremet by 2 as its odd numbers

            numbers += 2;

            //updating counter

            count++;

        }

        Console.WriteLine("The odd numbers are: " + string.Join(",", oddNumbers));

        Console.WriteLine(seriesSum);
        Console.ReadKey();


    }



    private static void printSeriesSum(int n2)
    {

        //validate input

        if (n2 > 0)
        {

            getOddNumSeries(n2);



        }
        else
        {

            Console.WriteLine("Please provide valide input");



        }

    }

}

////===============================================================================================================
using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[] A = new int[] { 1, 7, 2, 6 };
        bool check = monotonicCheck(A);
        Console.WriteLine(check);
        Console.ReadKey();

    }

    private static bool monotonicCheck(int[] arr)
    {

        //validate input

        if (arr.Length > 0)
        {



            //decide the inital directio

            bool isPositive = arr[0] < arr[1];

            bool isMonotonic = true;

            //looping on array

            for (int i = 0; i < arr.Length - 1; i++)
            {

                //check for positve montonocity

                if (isPositive)
                {

                    if (arr[i] <= arr[i + 1])
                    {

                        isMonotonic = true;

                    }
                    else
                    {

                        return false;

                    }

                }
                else
                {

                    if (arr[i] >= arr[i + 1])
                    {

                        isMonotonic = true;

                    }
                    else
                    {

                        return false;

                    }

                }

            }

            return isMonotonic;



        }
        else
        {

            Console.WriteLine("Please provide valide input");

            return false;

        }


    }
}


////================================================================================================

using System.IO;
using System;

class Program
{
    static void Main()
    {
        int[] nums = new int[] { 3, 1, 4, 1, 5 };
        int k = 2;
        int pairs = diffPairs(nums, k);
        Console.WriteLine(pairs);

    }

    private static int diffPairs(int[] nums, int k)
    {

        //validate input

        if (nums.Length > 0 && k >= 0)
        {

            int numberOfPairs = 0;

            int length = nums.Length;

            int cantorIndex = 0;

            //computing length to store unique values n*(n-1)*0.5

            int cantorLength = (int)(length * (length - 1) * 0.5);

            double[] CantorValues = new double[cantorLength];

            for (int i = 0; i <= nums.Length - 1; i++)
            {

                for (int j = i + 1; j <= nums.Length - 1; j++)
                {

                    //calculating unique values for each pair using Cantor pairing fucntion

                    double uniqueValue = 0.5 * (nums[i] + nums[j]) * (nums[i] + nums[j] + 1) + nums[j];

                    //check if pair exists 

                    if (Array.IndexOf(CantorValues, uniqueValue) == -1)
                    {

                        if (nums[i] - nums[j] == k || -1 * (nums[i] - nums[j]) == k)
                        {

                            numberOfPairs++;

                        }

                    }

                    //update unique pair values in array

                    CantorValues[cantorIndex] = uniqueValue;

                    cantorIndex++;



                }



            }

            return numberOfPairs;





        }
        else
        {

            Console.WriteLine("Please provide valide input");

            return 0;

        }


    }
}

////==================================================================================================
using System.IO;
using System;

class Program
{
    static void Main()
    {
        string keyboard = "abcdefghijklmnopqrstuvwxyz";
        string word = "dis";
        int time = BUllsKeboard(keyboard, word);
        Console.WriteLine(time);


    }

    private static int BUllsKeboard(string keyboard, string word)
    {

        //validate input

        if (keyboard.Length > 0 && word.Length >= 0)
        {

            int totalTime = 0;

            int prevIndex = 0;

            int currentIndex = 0;

            int distanceTravel = 0;

            int keyBoardLength = keyboard.Length;

            //loop through word 

            foreach (char letter in word)
            {



                currentIndex = keyboard.IndexOf(letter);

                //calculate the distance travel

                distanceTravel = currentIndex - prevIndex;

                //incase travel in -ve direction

                if (distanceTravel < 0)
                {

                    distanceTravel = distanceTravel * -1;

                }

                totalTime += distanceTravel;

                prevIndex = currentIndex;

            }

            return totalTime;

        }
        else
        {

            Console.WriteLine("Please provide valide input");

            return 0;

        }


    }
}













===========================================================================
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string str1 = "sunday";
        string str2 = "saturday";
        int minEdits = BUllsKeboard(str1, str2);
        Console.WriteLine(minEdits);
        Console.ReadKey();



    }

    private static int BUllsKeboard(string str1, string str2)
    {

        validate input

        if (str1.Length > 0 && str2.Length >= 0)
        {

            int numberOfAdjustments = 0;

            get unique values

            var h = new HashSet<char>(str2);

            var h2 = new HashSet<char>(str1);

            converting sets to array

            char[] uniqueChar = h.ToArray();

            char[] uniqueChar2 = h2.ToArray();

            creating dictionary to map frequency of letter in a word

            Dictionary<char, int> str2Digest = new Dictionary<char, int>();

            Dictionary<char, int> str1Digest = new Dictionary<char, int>();



            create digest for str2

            map frequency of letter in str1

            for (int i = 0; i < uniqueChar.Length - 1; i++)
            {

                int letterCount = 0;

                for (int j = 0; j <= str2.Length - 1; j++)
                {

                    if (uniqueChar[i] == str2[j])
                    {

                        letterCount++;

                        check if key exists and update the count

                        if (str2Digest.ContainsKey(uniqueChar[i]))
                        {

                            str2Digest[uniqueChar[i]] += 1;

                        }
                        else
                        {

                            str2Digest.Add(uniqueChar[i], letterCount);

                        }

                    }

                }

            }



            create a digest for str1

            map frequency of letter in str1

            for (int i = 0; i < uniqueChar2.Length - 1; i++)
            {

                int letterCount = 0;

                for (int j = 0; j <= str1.Length - 1; j++)
                {

                    if (uniqueChar2[i] == str1[j])
                    {

                        letterCount++;

                        check if key exists and update the count

                        if (str1Digest.ContainsKey(uniqueChar2[i]))
                        {

                            str1Digest[uniqueChar2[i]] += 1;

                        }
                        else
                        {

                            str1Digest.Add(uniqueChar2[i], letterCount);

                        }

                    }

                }

            }



            foreach (var item in str2Digest)

            {

                compare now both the digest

                if (str1Digest.ContainsKey(item.Key))
                {

                    int changes = item.Value - str1Digest[item.Key];

                    if (changes < 0)
                    {

                        changes = changes * -1;

                    }

                    numberOfAdjustments += changes;

                }
                else
                {

                    numberOfAdjustments += item.Value;



                }

            }



            return numberOfAdjustments;

        }
        else
        {

            Console.WriteLine("Please provide valide input");

            return 0;

        }


    }
}





















