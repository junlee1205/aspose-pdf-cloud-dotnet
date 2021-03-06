// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FieldsTests.cs">
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
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.Pdf.Cloud.Sdk.Test
{
    /// <summary>
    ///  Class for testing Fields Api
    /// </summary>
    [TestFixture]
    public class FieldsTests : TestsBase
    {
        /// <summary>
        /// Test GetField
        /// </summary>
        [Test]
        public void GetFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetField(name, "textField", folder: TempFolder);
            Assert.That(response.Field, Is.Not.Null);
        }

        /// <summary>
        /// Test GetFields
        /// </summary>
        [Test]
        public void GetFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.GetFields(name, folder: TempFolder);
            Assert.That(response.Fields, Is.Not.Null);
        }

        /// <summary>
        /// Test PostCreateField
        /// </summary>
        [Test]
        public void PostCreateFieldTest()
        {
            const string name = "Hello world.pdf";
            UploadFile(name, name);

            var field = new Field(
                Name: "checkboxfield",
                Type: FieldType.Boolean,
                Values: new List<string> {"1"},
                Rect: new Rectangle(
                    LLX: 50,
                    LLY: 200,
                    URX: 200,
                    URY: 400
                    ));
            var response = PdfApi.PostCreateField(name, 1, field, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutUpdateField
        /// </summary>
        [Test]
        public void PutUpdateFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var field = new Field(
                Name: fieldName,
                Type: FieldType.Text,
                Values: new List<string> {"Text field updated value."},
                Rect: new Rectangle(125, 735, 200, 752)                
                );

            var response = PdfApi.PutUpdateField(name, fieldName, field, folder: TempFolder);
            Assert.That(response.Field, Is.Not.Null);
        }

        /// <summary>
        /// Test PutUpdateFields
        /// </summary>
        [Test]
        public void PutUpdateFieldsTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var fields = new Fields(null, new List<Field>()
            {
                new Field(
                    Name: fieldName,
                    Type: FieldType.Text,
                    Values: new List<string> {"Text field updated value."})
                
            });
            
            var response = PdfApi.PutUpdateFields(name, fields, folder: TempFolder);
            Assert.That(response.Fields, Is.Not.Null);
        }


        /// <summary>
        /// Test DeleteField
        /// </summary>
        [Test]
        public void DeleteFieldTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var fieldName = "textField";

            var response = PdfApi.DeleteField(name, fieldName, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PutFieldsFlatten
        /// </summary>
        [Test]
        public void PutFieldsFlattenTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.PutFieldsFlatten(name, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }

        /// <summary>
        /// Test PostFlattenDocument
        /// </summary>
        [Test]
        public void PostFlattenDocumentTest()
        {
            const string name = "PdfWithAcroForm.pdf";
            UploadFile(name, name);

            var response = PdfApi.PostFlattenDocument(name, updateAppearances: true, hideButtons: true, folder: TempFolder);
            Assert.That(response.Code, Is.EqualTo(200));
        }
    }

}
