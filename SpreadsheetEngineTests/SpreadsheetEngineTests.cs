using System;
using NUnit.Framework;
using Cpts321;

namespace Cpts321.Tests
{

    [TestFixture]
    /// <summary>
    /// Main test class.
    /// </summary>
    internal class SpreadsheetEngineTests
    {

        [Test]
        /// <summary>
        /// testing cell update.
        /// </summary>
        public void SpreadsheetCellUpdate()
        {
            var sheet = new Spreadsheet(1, 1);
            var cell1 = sheet.GetCell("A1");
            Assert.IsNotNull(cell1);
            cell1.Text = "Hello";
            Assert.AreEqual("Hello", cell1.Text);
        }


        [Test]
        /// <summary>
        /// testing refrence cell update.
        /// </summary>
        public void SpreadsheetCellRefrenceUpdate()
        {
            var sheet = new Spreadsheet(1, 2);
            var cell1 = sheet.GetCell("A1");
            var cell2 = sheet.GetCell("B1");
            Assert.IsNotNull(cell2);
            Assert.IsNotNull(cell1);
            cell1.Text = "Testing";
            cell2.Text = "=A1";
            Assert.AreEqual(cell1.Value, cell2.Value);
        }
    }
}
