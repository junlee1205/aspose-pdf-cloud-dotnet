﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SignTests.cs">
//   Copyright (c) 2018 Aspose.Pdf for Cloud
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

using System.IO;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///     Class for testing AppendApi
    /// </summary>
    [TestFixture]
    public class SignTests : TestsBase
    {
        private const string Name = "BlankWithSignature.pdf";
        private const string SignatureName = "test1234.pfx";

        private static readonly Signature Signature = new Signature(
            Authority: "Sergey Smal",
            Contact: "test@mail.ru",
            Date: "08/01/2012 12:15:00.000 PM",
            FormFieldName: "Signature1",
            Location: "Ukraine",
            Password: "test1234",
            Rectangle: new Rectangle2(
                X: 100,
                Y: 100,
                Width: 400,
                Height: 100),
            SignaturePath: Path.Combine(TempFolder, SignatureName),
            SignatureType: "PKCS7",
            Visible: true);

        /// <summary>
        /// Test DocumentPostSignDocument
        /// </summary>
        [Test]
        public void PostSignDocumentTest()
        {
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var response = PdfApi.PostSignDocument(Name, Signature, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }

        /// <summary>
        /// Test PagesPostSignPage
        /// </summary>
        [Test]
        public void PagesPostSignPageTest()
        {
            UploadFile(Name, Name);
            UploadFile(SignatureName, SignatureName);

            var response = PdfApi.PostSignPage(Name, pageNumber: 1, signature: Signature, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}