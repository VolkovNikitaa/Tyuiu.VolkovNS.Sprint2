﻿using Tyuiu.VolkovNS.Sprint2.Task0.V10.Lib;

namespace Tyuiu.VolkovNS.Sprint2.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 1305;
            int y = 475;
            bool[] res = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(res,ds.GetCompareOperations(x,y));
        }
    }
}
