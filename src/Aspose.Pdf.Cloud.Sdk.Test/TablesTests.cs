﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ScreenAnnotationsTests.cs">
//   Copyright (c) 2019 Aspose.PDF Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Stamp Api
    /// </summary>
    [TestFixture]
    class TablesTests : TestsBase
    {
        private const string Name = "PdfWithTable.pdf";
        private const int PageNumber = 1;

        public override void SetUp()
        {
            base.SetUp();
            UploadFile(Name, Name);
        }

        /// <summary>
        /// Test DeleteDocumentTables
        /// </summary>
        [Test]
        public void DeleteDocumentTablesTest()
        {
            var response = PdfApi.DeleteDocumentTables(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetDocumentTables
        /// </summary>
        [Test]
        public void GetDocumentTablesTest()
        {
            var response = PdfApi.GetDocumentTables(Name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetPageTables
        /// </summary>
        [Test]
        public void GetPageTablesTest()
        {
            var response = PdfApi.GetPageTables(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeletePageTables
        /// </summary>
        [Test]
        public void DeletePageTablesTest()
        {
            var response = PdfApi.DeletePageTables(Name, PageNumber, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test GetTable
        /// </summary>
        [Test]
        public void GetTableTest()
        {
            var tablesResponse = PdfApi.GetDocumentTables(Name, folder: TempFolder);
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = PdfApi.GetTable(Name, tableId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test DeleteTable
        /// </summary>
        [Test]
        public void DeleteTableTest()
        {
            var tablesResponse = PdfApi.GetDocumentTables(Name, folder: TempFolder);
            string tableId = tablesResponse.Tables.List[0].Id;

            var response = PdfApi.DeleteTable(Name, tableId, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }
}