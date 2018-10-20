using System;
using System.IO;
using System.Linq;
using ConsoleApp2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp2Tests
{
    [TestClass]
    public class ListDataToHtmlWriterTests
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void OutputAllDataToHtmlFile_WhenFileNameIsNullOrEmpty_ShouldThrowFileNotFoundException()
        {
            ListDataToHtmlWriter dataToHtmlWr = new ListDataToHtmlWriter("", "People (sorted by first name A-Z)", null); //people.OrderBy(o => o.FirstName).ToList());
            dataToHtmlWr.outputAllDataToHtmlFile();
        }
    }
}
