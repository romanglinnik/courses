using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dev3Test
{
    [TestClass]
    public class TranslitTest
    {
        private Dev3.TransliteManager _transliter = new Dev3.TransliteManager();

        [TestMethod]
        [DataRow(null, null)]
        [DataRow("privet", "ןנטגוע")]
        [DataRow("svet", "סגוע")]
        [DataRow("qwert", "ךגונע")]
        [DataRow("ÊÂÅÐÒÉ", "QWERTY")]
        [DataRow("azsvd", "אחסגה")]
        [DataRow("קט", "chi")]
        public void TestGetTranslitString(string actual, string expected)
        {
            Assert.AreEqual(expected, _transliter.Translit(actual));
        }
        [TestMethod]
        public void TestGetTranslitString_EmptyString()
        {
            Assert.AreEqual(string.Empty, _transliter.Translit(string.Empty));
        }

        [TestMethod]
        [DataRow("ghbd!.,@##$", null)]
        [DataRow("123", null)]
        [DataRow("1hello", null)]
        [DataRow("1Hey", null)]
        [DataRow("2גמגמגמ", null)]
        [DataRow("2ÎכמקנךÐ", null)]
        [DataRow("2גמגמגמghdbt", null)]
        [DataRow("2גHKJHגמגמgÐÏÐÏdbt", null)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetTranslitString_Exception(string actual, string expected)
        {
            Assert.AreEqual(expected, _transliter.Translit(actual));
        }
    }
}
