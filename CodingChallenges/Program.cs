using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");

            List<List<int>> lst = new List<List<int>>();
            lst.Add(new List<int>(new int[] { 11, 2, 4 }));
            lst.Add(new List<int>(new int[] { 4, 5, 6 }));
            lst.Add(new List<int>(new int[] { 10, 8, -12 }));
            Program p = new Program();
            int result = p.diagonalDifference(lst);

            p.plusMinus(new int[] { -4, 3, -9, 0, 4, 1 });
            */

            Program p = new Program();
            //p.staircase(6);
            // 06:40:03AM
            //Console.WriteLine(p.timeConversion("12:45:54PM"));
            //p.gradingStudents(new List<int>(new int[] { 4, 73, 67, 38, 33 }));

            //p.countApplesAndOranges(7, 11, 5, 15, new int[] { -2, 2, 1}, new int[] { 5, -6});

            //p.kangaroo(21, 6, 47, 3);

            //int a = getTotalX(new List<int>(new int[] { 100, 99, 98, 97, 96, 95, 94, 93, 92, 91 }), new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }));
            //Console.WriteLine(a);

            //getTotalX(new List<int>(new int[] { 2, 4 }), new List<int>(new int[] { 16, 32, 96 }));

            //birthday(new List<int>(new int[] { 5, 2, 2, 1, 5, 3, 2 }), 9, 3);

            //migratoryBirds(new List<int>(new int[] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }));

            string a = dayOfProgrammer(1800);
            Console.WriteLine(a);
        }

        public int simpleArraySum(int[] ar)
        {
            return ar.Sum();
        }

        public List<int> compareTriplets(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            for (int i = 0; i < a.Count; i++) {
                if (a[i] > b[i])
                {
                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }
            }

            return new List<int>(new int[] { alice, bob });
        }

        public long aVeryBigSum(long[] ar)
        {
            Int64 sum = 0;
            for (int i = 0; i < ar.Length; i++) {
                sum += ar[i];
            }
            return sum;
        }

        public int diagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = arr.Count() - 1;

            int leftToRightSum = 0;
            int rightToLeftSum = 0;
            for (int i = 0; i < arr.Count(); i++) {
                leftToRightSum += arr[i][leftToRight];
                rightToLeftSum += arr[i][rightToLeft];

                leftToRight++;
                rightToLeft--;
            }

            return Math.Abs(leftToRightSum - rightToLeftSum);

        }

        public void plusMinus(int[] arr)
        {
            double negatives = 0;
            double positives = 0;
            double zeros = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) {
                    negatives++;
                }
                else if (arr[i] == 0) {
                    zeros++;
                }
                else
                {
                    positives++;
                }
            }

            double p = positives / arr.Length;
            double n = negatives / arr.Length;
            double z = zeros / arr.Length;
            Console.WriteLine(String.Format("{0:0.000000}", Math.Round(p, 6)));
            Console.WriteLine(String.Format("{0:0.000000}", Math.Round(n, 6)));
            Console.WriteLine(String.Format("{0:0.000000}", Math.Round(z, 6)));

        }


        public void staircase(int n)
        {
            string hashtag = "#";

            for (int i = 1; i <= n; i++) {
                Console.WriteLine(string.Concat(Enumerable.Repeat(hashtag, i)).PadLeft(6));
            }

        }

        public void miniMaxSum(int[] arr)
        {
            long[] arrayLong = arr.Select(i => (long)i).ToArray();
            Array.Sort(arrayLong);

            long min = arrayLong[0] + arrayLong[1] + arrayLong[2] + arrayLong[3];
            long max = arrayLong[1] + arrayLong[2] + arrayLong[3] + arrayLong[4];

            Console.WriteLine(min + " " + max);

        }

        public int birthdayCakeCandles(int[] ar)
        {
            Array.Sort(ar);

            int count = 1;

            int index = ar[ar.Length - 1];
            for (int i = ar.Length - 2; i >= 0; i--) {
                if (ar[i] == index)
                {
                    count++;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        public string timeConversion(string s)
        {
            string amOrPm = s.Substring(s.Length - 2, 2);
            int hour = Int32.Parse(s.Substring(0, 2));

            string hourStr = "";

            if (amOrPm == "PM")
            {
                if (hour != 12)
                {
                    hour += 12;
                }

                hourStr = hour.ToString();

            }
            else
            {
                if (hour == 12)
                {
                    hourStr = "00";
                }
                else if (hour < 10)
                {
                    hourStr = "0" + hour.ToString();
                }
                else
                {
                    hourStr = hour.ToString();
                }
            }

            string pm = s.Replace(s.Substring(0, 2), hourStr);

            return pm.Substring(0, pm.Length - 2);
        }


        public List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count(); i++) {
                int difference = 5 - (grades[i] % 5);
                if (difference < 3)
                {
                    if (grades[i] + difference >= 38) {
                        grades[i] = grades[i] + difference;
                    }
                }
            }
            return grades;
        }


        public void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int countApple = 0;
            int countOranges = 0;

            for (int i = 0; i < apples.Length; i++)
            {
                apples[i] = a + apples[i];
                if (apples[i] >= s && apples[i] <= t)
                {
                    countApple++;
                }
            }

            for (int i = 0; i < oranges.Length; i++)
            {
                oranges[i] = b + oranges[i];
                if (oranges[i] >= s && oranges[i] <= t) 
                {
                    countOranges++;
                } 
            }

            Console.WriteLine(countApple);
            Console.WriteLine(countOranges);
        }

        public string kangaroo(int x1, int v1, int x2, int v2)
        {
           
            while (x1 != x2) {
                x1 += v1;
                x2 += v2;
            }

            return x2 > x1 || v2 > v1 ? "YES" : "NO";
        }





        public static int getTotalX(List<int> a, List<int> b)
        {
            int lcmA = a[0];
            for (int i = 1; i < a.Count; i++) {
                lcmA = lcm(lcmA, a[i]);
            }

            int gcdB = b[0];
            for (int i = 1; i < b.Count; i++)
            {
                gcdB = gcd(gcdB, b[i]);
            }

            int count = 0;
            int idx = 1;
            int n = 0;

            while (n < gcdB) 
            {
                n = lcmA * idx;
                if (gcdB % n == 0)
                {
                    count++;
                }
                idx++;
            }

            return count;
        }

        public static int gcd(int x, int y) {
            if (y == 0) {
                return x;
            }
            return gcd(y, x % y);
        }

        public static int lcm(int x, int y) {
            return (x * y) / gcd(x, y);
        }


        static int[] breakingRecords(int[] scores)
        {
            int high = scores[0];
            int low = scores[0];

            int[] record = { 0, 0}; 
            for (int i = 1; i < scores.Length; i++) {
                if (scores[i] > high) {
                    high = scores[i];
                    record[0]++; 
                }
                if (scores[i] < low)
                {
                    low = scores[i];
                    record[1]++;
                }
            }

            return record;
        }


        static int birthday(List<int> s, int d, int m)
        {
            var count = 0;
            for (var i = 0; i < s.Count - m + 1; i++)
            {
                var sum = 0;
                for (var j = 0; j < m; j++)
                {
                    sum = sum + s[i + j];
                }
                if (sum == d)
                {
                    count++;
                }

            }


            return count;

        }

        static int divisibleSumPairs(int n, int k, int[] ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++) {

                for (int j = i + 1; j < n; j++) {
                    if ((ar[i] + ar[j]) % k == 0) {
                        count++;
                    }
                }
            }

            return count++;
        }


        static int migratoryBirds(List<int> arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < arr.Count; i++) {
                if (!d.ContainsKey(arr[i]))
                {
                    d.Add(arr[i], 1);
                }
                else 
                {
                    int val = d[arr[i]];
                    d[arr[i]] = val + 1;
                }
            }

            var sortedDict = d.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            int bird = 0;
            for (int i = sortedDict.Count() - 1; i > 0; i--) {
                int currentKey = sortedDict.Keys.ElementAt(i);
                int nextKey = sortedDict.Keys.ElementAt(i-1);

                int currentValue = sortedDict[currentKey];
                int nextValue = sortedDict[nextKey];
                if (currentValue > nextValue) {
                    bird = currentKey;
                    break;
                }
            }

            return bird;
        }

        static string dayOfProgrammer(int year)
        {

            StringBuilder fallDate = new StringBuilder();

            if (year == 1918)
            { 
                return fallDate.Append("26.09.1918").ToString(); 
            }
            else if (year % 4 == 0 && (year < 1918 || year % 400 == 0 || year % 100 != 0))
            {
                return fallDate.Append("12.09." + year).ToString();
            }
            
            return fallDate.Append("13.09." + year).ToString();
        }
    }
}