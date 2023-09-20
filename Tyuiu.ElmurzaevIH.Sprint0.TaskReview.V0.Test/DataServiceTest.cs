using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ElmurzaevIH.Sprint0.TaskReview.V0.Lib;

namespace Tyuiu.ElmurzaevIH.Sprint0.TaskReview.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            int FirstNum = 5;
            int SecondNum = 10;
            int ThirdNum = 20;
            int res = DataService.Calc(FirstNum, SecondNum, ThirdNum);
            Assert.AreEqual(175, res);
        }
    }
}
