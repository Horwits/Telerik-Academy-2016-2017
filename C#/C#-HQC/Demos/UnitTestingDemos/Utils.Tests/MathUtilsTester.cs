using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Utils.Tests
{
    [TestClass]
    public class MathUtilsTester
    {
        private TestContext context;

        public TestContext Context
        {
            get
            {
                return context;
            }

            set
            {
                context = value;
            }
        }

        [Ignore]
        [DeploymentItem(@".\Data.xml"), TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"..\Data.xml", "Row", DataAccessMethod.Sequential)]
        public void MathUtils_SumTwoNumbers_ShouldSumRight()
        {
            var utils = new MathUtils();
            int a = int.Parse((string)context.DataRow["A"]);
            int b = int.Parse((string)context.DataRow["B"]);
            int res = int.Parse((string)context.DataRow["Expected"]);

            var sum = utils.Sum(a, b);

            Assert.AreEqual(res, sum);
        }
    }
}
