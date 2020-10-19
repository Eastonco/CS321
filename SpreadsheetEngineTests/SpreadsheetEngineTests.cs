// <copyright file="SpreadsheetEngineTests.cs" company="Connor Easton (11557902)">
// Copyright (c) Connor Easton (11557902). All rights reserved.
// </copyright>

using NUnit.Framework;

namespace Cpts321.Tests
{
    /// <summary>
    /// Main test class.
    /// </summary>
    [TestFixture]
    internal class SpreadsheetEngineTests
    {
        /// <summary>
        /// testing cell update.
        /// </summary>
        [Test]
        public void SpreadsheetCellUpdate()
        {
            var sheet = new Spreadsheet(1, 1);
            var cell1 = sheet.GetCell("A1");
            Assert.IsNotNull(cell1);
            cell1.Text = "Hello";
            Assert.AreEqual("Hello", cell1.Text);
        }

        /// <summary>
        /// testing refrence cell update.
        /// </summary>
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
    }
}
