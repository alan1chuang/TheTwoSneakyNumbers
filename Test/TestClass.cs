using TheTwoSneakyNumbers;
using NUnit.Framework;
namespace Test
{
    public class TestClass
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 0, 1, 1, 0 }, new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 3, 2, 1, 3, 2 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 7, 1, 5, 4, 3, 4, 6, 0, 9, 5, 8, 2 }, new int[] { 4, 5 })]
        public void GivenArrary(int[] input, int[] output)
        {
            var sut = new Class1();

            var ans = sut.GetSneakyNumbers(input);

            Assert.That(output.Contains(ans[0]), Is.True);
            Assert.That(output.Contains(ans[1]), Is.True);
        }
    }
}
