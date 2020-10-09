using System;
using NUnit.Framework;
using SpreadsheetEngine;

namespace SpreadsheetEngine.Tests
{
    [TestFixture]
    class SpreadsheetEngineTests
    {
        [Test]
        public void SpreadsheetCellUpdate()
        {
            var sheet = new Spreadsheet(1, 1);
            var cell1 = sheet.GetCell("A1");
            Assert.IsNotNull(cell1);
            cell1.Text = "Hello";
            Assert.AreEqual("Hello", cell1.Text);
        }

        [Test]
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

        [Test]
        public void test()
        {
            var sheet = new Spreadsheet(1, 2);
            var cell1 = sheet.GetCell("A1");
            var cell2 = sheet.GetCell("B1");
            Assert.IsNotNull(cell2);
            Assert.IsNotNull(cell1);
            cell1.Text = "Testing";
            cell2.Text = "=A1";
            Assert.AreEqual(cell1.Value, cell2.Value);

            var propertiesChanged = 0;

            cell2.PropertyChanged += (sender, args) =>
            {
                Assert.AreEqual(nameof(cell2.Value), args.PropertyName);
                propertiesChanged++;
            };
            cell1.PropertyChanged += (sender, args) =>
            {
                Assert.AreEqual(nameof(cell1.Text), args.PropertyName);
                propertiesChanged++;
            };
            cell1.Text = "Testing";
            Assert.AreEqual(0, propertiesChanged);
            cell1.Text = "Broken";
            Assert.AreEqual(2, propertiesChanged);
        }
    }
}
