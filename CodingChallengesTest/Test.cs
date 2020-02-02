using CodingChallenges;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingChallengesTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void simple_array_sum_test()
        {
            Program p = new Program();
            int expected = 31;
            int result = p.simpleArraySum(new int[] { 1, 2, 3, 4, 10, 11 });
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void compare_triplets_test()
        {
            Program p = new Program();
            List<int> expected = new List<int>(new int[] {2, 1});

            List<int> result = p.compareTriplets(new List<int>(new int[] { 17, 28, 30 }), new List<int>(new int[] { 99, 16, 8 }));
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void diagonal_difference_test()
        {
            Program p = new Program();
            int expected = 15;
            
            List<List<int>> lst = new List<List<int>>();
            lst.Add(new List<int>(new int[] { 11, 2, 4 }));
            lst.Add(new List<int>(new int[] { 4, 5, 6 }));
            lst.Add(new List<int>(new int[] { 10, 8, -12 }));

            int result = p.diagonalDifference(lst);
            Assert.AreEqual(expected, result);
        }
    }
}