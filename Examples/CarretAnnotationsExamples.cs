using System.Collections.Generic;
using System.Net;
using Aspose.Pdf.Cloud.Sdk.Model;
using System;
using Aspose.Pdf.Cloud.Sdk.Api;
using System.Collections;
using System.IO;

namespace Aspose.Pdf.Cloud.Sdk.Examples
{

    public class CaretAnnotationsExamples
    {

        PdfApi api = new PdfApi("b125f13bf6b76ed81ee990142d841195", "78946fb4-3bd4-4d3e-b309-f9e2ff9ac6f9");

        string FolderName = "";
        private const string Name = "PdfWithAnnotations.pdf";
        private const int PageNumber = 2;

        protected void UploadFile(string sourcePath, string serverFileName)
        {
            using (var file = System.IO.File.OpenRead(Path.Combine("", sourcePath)))
            {
                var response = api.PutCreate(Path.Combine("", serverFileName), file);
            }
        }

        public void GetDocumentCaretAnnotationsTest()
        {
            UploadFile(Name, Name);
            var response = api.GetDocumentCaretAnnotations(Name, folder: FolderName);
            Console.WriteLine(response);
        }

        public void GetPageCaretAnnotationsTest()
        {
            UploadFile(Name, Name);
            var response = api.GetPageCaretAnnotations(Name, PageNumber, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PostPageCaretAnnotationsTest()
        {
            UploadFile(Name, Name);
            List<CaretAnnotation> annotations = new List<CaretAnnotation>
            {
                new CaretAnnotation()
                {
                    Name = "Test Caret Annotation",
                    Rect = new Rectangle(100, 100, 200, 200),
                    Flags = new List<AnnotationFlags> {AnnotationFlags.Hidden, AnnotationFlags.NoView},
                    HorizontalAlignment = HorizontalAlignment.Center,
                    RichText = "Rich Text",
                    Subject = "Subj",
                    ZIndex = 1,
                    Title = "Title",
                    Frame = new Rectangle(100, 100, 200, 200),
                    Modified = "01/01/2018 00:00:00.000 AM"
                }
            };

            var response = api.PostPageCaretAnnotations(Name, 1, annotations, folder: FolderName);
            Console.WriteLine(response);
        }


        public void GetCaretAnnotationTest()
        {
            UploadFile(Name, Name);
            var Caretresponse = api.GetDocumentCaretAnnotations(Name, folder: FolderName);
            string annotationId = Caretresponse.Annotations.List[0].Id;

            var response = api.GetCaretAnnotation(Name, annotationId, folder: FolderName);
            Console.WriteLine(response);
        }


        public void PutCaretAnnotationTest()
        {
            UploadFile(Name, Name);
            CaretAnnotation annotation = new CaretAnnotation()
            {
                Name = "Test Caret Annotation Updated",
                Rect = new Rectangle(101, 101, 201, 201),
                Flags = new List<AnnotationFlags> { AnnotationFlags.Hidden, AnnotationFlags.NoView },
                HorizontalAlignment = HorizontalAlignment.Center,
                RichText = "Rich Text Updated",
                Subject = "Subj Updated",
                ZIndex = 1,
                Title = "Title Updated",
                Frame = new Rectangle(100, 100, 200, 200),
                Modified = "02/02/2018 00:00:00.000 AM"
            };

            var lineResponse = api.GetDocumentCaretAnnotations(Name, folder: FolderName);
            string annotationId = lineResponse.Annotations.List[0].Id;

            var response = api.PutCaretAnnotation(Name, annotationId, annotation, folder: FolderName);
            Console.WriteLine(response);
        }
    }
}