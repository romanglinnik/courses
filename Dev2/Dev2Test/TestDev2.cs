using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dev2;

namespace Dev2Test
{
    [TestClass]
    public class TestDev2
    {

        [TestMethod]
        public void GetMaximumNumberOfUnequalConsecutiveCharactersInAStringTest1()
        {
            int exp = 1;
            string teststr = "a";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfUnequalConsecutiveCharactersInAString(teststr));
        }
        [TestMethod]
        public void GetMaximumNumberOfUnequalConsecutiveCharactersInAStringTest2()
        {
            int exp = 2;
            string teststr = "ab";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfUnequalConsecutiveCharactersInAString(teststr));
        }
        [TestMethod]
        public void GetMaximumNumberOfUnequalConsecutiveCharactersInAStringTest3()
        {
            int exp = 2;
            string teststr = "ad!#$#%$^$%@#@#";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfUnequalConsecutiveCharactersInAString(teststr));
        }
        [TestMethod]
        public void GetMaximumNumberOfUnequalConsecutiveCharactersInAStringTest4()
        {
            int exp = 8;
            string teststr = "sdsdgfgwiejfifgued";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfUnequalConsecutiveCharactersInAString(teststr));
        }

        [TestMethod]
        public void GetMaximumNumberOfIdenticalConsecutiveDigitsInAStringTest1()
        {
            int exp = 2;
            string teststr = "dg3ghfj4jfbjd66dhfhfb";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfIdenticalConsecutiveDigitsInAString(teststr));
        }

        [TestMethod]
        public void GetMaximumNumberOfIdenticalConsecutiveDigitsInAStringTest2()
        {
            int exp = 4;
            string teststr = "12fg341fg1333324fg";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfIdenticalConsecutiveDigitsInAString(teststr));
        }

        [TestMethod]
        public void GetMaximumNumberOfIdenticalConsecutiveDigitsInAStringTest3()
        {
            int exp = 2;
            string teststr = "123456789987654321";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfIdenticalConsecutiveDigitsInAString(teststr));
        }

        [TestMethod]
        public void GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAStringTest1()
        {
            int exp = 2;
            string teststr = "gfhueff46fhd";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAString(teststr));
        }

        [TestMethod]
        public void GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAStringTest2()
        {
            int exp = 4;
            string teststr = "gfgghhhjjjfuuuu";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAString(teststr));
        }

        [TestMethod]
        public void GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAStringTest3()
        {
            int exp = 3;
            string teststr = "gf45ggfggg4";
            String str = new String(teststr);
            Assert.AreEqual(exp, str.GetMaximumNumberOfIdenticalConsecutiveLatinCharactersInAString(teststr));
        }
    }
}
