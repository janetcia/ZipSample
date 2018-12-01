using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ZipSample.test
{
    [TestClass]
    public class ConcatTests
    {
        [TestMethod]
        public void concat_integers()
        {
            var first = new int[] {1, 3, 5};
            var second = new int[] {2, 4, 6};

            var actual = first.MyConcat(second).ToArray();

            var expected = new int[] {1, 3, 5, 2, 4, 6};
            expected.ToExpectedObject().ShouldEqual(actual);
        }

        [TestMethod]
        public void concat_string()
        {
            var first = new string[] { "1","3", "5" };
            var second = new string[] { "2", "4", "6" };

            var actual = first.MyConcat(second).ToArray();

            var expected = new string[] { "1", "3", "5", "2", "4", "6" };
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}