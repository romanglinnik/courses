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
        [DataRow("privet", "������")]
        [DataRow("svet", "����")]
        [DataRow("qwert", "�����")]
        [DataRow("������", "QWERTY")]
        [DataRow("azsvd", "�����")]
        [DataRow("��", "chi")]
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
        [DataRow("2������", null)]
        [DataRow("2�������", null)]
        [DataRow("2������ghdbt", null)]
        [DataRow("2�HKJH����g����dbt", null)]
        [ExpectedException(typeof(ArgumentException))]
        public void TestGetTranslitString_Exception(string actual, string expected)
        {
            Assert.AreEqual(expected, _transliter.Translit(actual));
        }
    }
}
