using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TestingThings
    {
        //Private instance variable
        private int testNum;

        //Setter is public, getter is private
        public long NumberOfTests { private get; set; }

        // constant for pi
        public const double PI = 3.1415927;

        // read only variable initialzed in the constructor
        public readonly string TestName;

        // private byte array

        private byte[] bytes;

        //Overloaded Constructor
        public TestingThings(int testNum, string testName)
        {
            TestNum = testNum;
            TestName = testName;
            bytes = new byte[10];
        }


        //public property for testNum
        public int TestNum
        {
            get { return testNum; }
            private set { testNum = value; }
        }
        /// <summary>
        /// Number of tests times the test number
        /// </summary>
        /// <returns></returns>
        public long getNumberOfTests()
        {
            return NumberOfTests *testNum;
        }
        /// <summary>
        /// Input values into byte array.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="index"></param>
        public void InputByte(byte value, byte index)
        {
            if (index < 10 && value < 10)
            {
                bytes[index] = value;
                return;
            }
            throw new ArgumentException("Index / Value must be less than 10");
        }

        /// <summary>
        /// Returns a string representation of the bye array value
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var result = "";
            foreach(var v in bytes)
            {
                result += v;
            }

            return result;
        }



    }
}
