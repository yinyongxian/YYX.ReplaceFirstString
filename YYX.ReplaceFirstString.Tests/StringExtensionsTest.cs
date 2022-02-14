using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace YYX.ReplaceFirstString.Tests
{
    [TestClass]
    public class StringExtensionsTest
    {
        [TestMethod]
        public void ReplaceFirst()  
        {
            {
                string replaceFirst = "YYX".ReplaceFirst("Y", "Yin");
                Assert.AreEqual(replaceFirst, "YinYX");
            }

            {
                string replaceFirst = "YYX<AUTO>".ReplaceFirst("<AUTO>", "ian");
                Assert.AreEqual(replaceFirst, "YYXian");
            }

            {
                string replaceFirst = "YYX<AUTO>YYX<AUTO>".ReplaceFirst("<AUTO>", "ian");
                Assert.AreEqual(replaceFirst, "YYXianYYX<AUTO>");
            }

            {
                string replaceFirst = "<AUTO>YYX<AUTO>YYX<AUTO>".ReplaceFirst("<AUTO>", "ian");
                Assert.AreEqual(replaceFirst, "ianYYX<AUTO>YYX<AUTO>");
            }
        }

        [TestMethod]
        public void Regex()
        {
            var regex = new Regex("<AUTO>");

            Assert.AreEqual(regex.Replace("YYX<AUTO>", "ian", 1),
                "YYX<AUTO>".ReplaceFirst("<AUTO>", "ian"));

            Assert.AreEqual(regex.Replace("YYX<AUTO>YYX<AUTO>", "ian", 1),
                "YYX<AUTO>YYX<AUTO>".ReplaceFirst("<AUTO>", "ian"));

            Assert.AreEqual(regex.Replace("<AUTO>YYX<AUTO>YYX<AUTO>", "ian", 1),
                "<AUTO>YYX<AUTO>YYX<AUTO>".ReplaceFirst("<AUTO>", "ian"));
        }
    }
}