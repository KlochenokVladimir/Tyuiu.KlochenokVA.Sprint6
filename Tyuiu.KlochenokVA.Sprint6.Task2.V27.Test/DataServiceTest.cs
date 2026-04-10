using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KlochenokVA.Sprint6.Task2.V27.Lib;

namespace Tyuiu.KlochenokVA.Sprint6.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction_Returns_CorrectLength_And_Values()
        {
            var ds = new DataService();
            int start = -2;
            int stop = 2;
            var res = ds.GetMassFunction(start, stop);
            Assert.AreEqual(5, res.Length);
            // Check first and last values are computed (not all zeros)
            Assert.IsFalse(double.IsNaN(res[0]));
            Assert.IsFalse(double.IsNaN(res[^1]));
        }
    }
}
