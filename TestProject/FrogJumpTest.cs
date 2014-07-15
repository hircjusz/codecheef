using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CodeCheef.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class FrogJumpTest
    {
        /*
          A[0] = 1
          A[1] = 3
          A[2] = 1
          A[3] = 4
          A[4] = 2
          A[5] = 3
          A[6] = 5
          A[7] = 4
         */
        [TestMethod]
        public void SimpleTest()
        {

            int x = 5;
            int n = 7;
            int[] a= new int[8];
            int result = FrogJumpTime.Solution(x,a,n);
            Assert.AreEqual(6,result);
        }
    }
}
