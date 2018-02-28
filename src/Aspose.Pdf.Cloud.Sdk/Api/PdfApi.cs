// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PdfApi.cs">
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

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Aspose.Pdf.Cloud.Sdk.Client;
using Aspose.Pdf.Cloud.Sdk.Model;

namespace Aspose.Pdf.Cloud.Sdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPdfApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete document page by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse DeletePage (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Delete document page by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> DeletePageWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Delete custom document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse DeleteProperties (string name, string storage = null, string folder = null);

        /// <summary>
        /// Delete custom document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> DeletePropertiesWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Delete document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse DeleteProperty (string name, string propertyName, string storage = null, string folder = null);

        /// <summary>
        /// Delete document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> DeletePropertyWithHttpInfo (string name, string propertyName, string storage = null, string folder = null);
        /// <summary>
        /// Read common document info or convert to some format if the format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetDocument (string name, string format = null, string storage = null, string folder = null, string outPath = null);

        /// <summary>
        /// Read common document info or convert to some format if the format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetDocumentWithHttpInfo (string name, string format = null, string storage = null, string folder = null, string outPath = null);
        /// <summary>
        /// Read document attachment info by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AttachmentResponse</returns>
        AttachmentResponse GetDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null);

        /// <summary>
        /// Read document attachment info by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AttachmentResponse</returns>
        ApiResponse<AttachmentResponse> GetDocumentAttachmentByIndexWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null);
        /// <summary>
        /// Read document attachments info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        AttachmentsResponse GetDocumentAttachments (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document attachments info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AttachmentsResponse</returns>
        ApiResponse<AttachmentsResponse> GetDocumentAttachmentsWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read document bookmarks.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>BookmarksResponse</returns>
        BookmarksResponse GetDocumentBookmarks (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document bookmarks.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of BookmarksResponse</returns>
        ApiResponse<BookmarksResponse> GetDocumentBookmarksWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentPropertiesResponse</returns>
        DocumentPropertiesResponse GetDocumentProperties (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentPropertiesResponse</returns>
        ApiResponse<DocumentPropertiesResponse> GetDocumentPropertiesWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read document property by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentPropertyResponse</returns>
        DocumentPropertyResponse GetDocumentProperty (string name, string propertyName, string storage = null, string folder = null);

        /// <summary>
        /// Read document property by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentPropertyResponse</returns>
        ApiResponse<DocumentPropertyResponse> GetDocumentPropertyWithHttpInfo (string name, string propertyName, string storage = null, string folder = null);
        /// <summary>
        /// Download document attachment content by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetDownloadDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null);

        /// <summary>
        /// Download document attachment content by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetDownloadDocumentAttachmentByIndexWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null);
        /// <summary>
        /// Get document field by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>FieldResponse</returns>
        FieldResponse GetField (string name, string fieldName, string storage = null, string folder = null);

        /// <summary>
        /// Get document field by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of FieldResponse</returns>
        ApiResponse<FieldResponse> GetFieldWithHttpInfo (string name, string fieldName, string storage = null, string folder = null);
        /// <summary>
        /// Get document fields.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>FieldsResponse</returns>
        FieldsResponse GetFields (string name, string storage = null, string folder = null);

        /// <summary>
        /// Get document fields.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of FieldsResponse</returns>
        ApiResponse<FieldsResponse> GetFieldsWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read page fragment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        TextItemsResponse GetFragment (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page fragment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        ApiResponse<TextItemsResponse> GetFragmentWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read page fragment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextFormatResponse</returns>
        TextFormatResponse GetFragmentTextFormat (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read page fragment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextFormatResponse</returns>
        ApiResponse<TextFormatResponse> GetFragmentTextFormatWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read page fragments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        TextItemsResponse GetFragments (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page fragments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        ApiResponse<TextItemsResponse> GetFragmentsWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document image by number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetImage (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document image by number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetImageWithHttpInfo (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ImagesResponse</returns>
        ImagesResponse GetImages (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of ImagesResponse</returns>
        ApiResponse<ImagesResponse> GetImagesWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document page info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream GetPage (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document page info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetPageWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document page annotation by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AnnotationResponse</returns>
        AnnotationResponse GetPageAnnotation (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document page annotation by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AnnotationResponse</returns>
        ApiResponse<AnnotationResponse> GetPageAnnotationWithHttpInfo (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read documant page annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AnnotationsResponse</returns>
        AnnotationsResponse GetPageAnnotations (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read documant page annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AnnotationsResponse</returns>
        ApiResponse<AnnotationsResponse> GetPageAnnotationsWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document page link annotation by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>LinkAnnotationResponse</returns>
        LinkAnnotationResponse GetPageLinkAnnotationByIndex (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null);

        /// <summary>
        /// Read document page link annotation by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of LinkAnnotationResponse</returns>
        ApiResponse<LinkAnnotationResponse> GetPageLinkAnnotationByIndexWithHttpInfo (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null);
        /// <summary>
        /// Read document page link annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>LinkAnnotationsResponse</returns>
        LinkAnnotationsResponse GetPageLinkAnnotations (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document page link annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of LinkAnnotationsResponse</returns>
        ApiResponse<LinkAnnotationsResponse> GetPageLinkAnnotationsWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextRectsResponse</returns>
        TextRectsResponse GetPageText (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextRectsResponse</returns>
        ApiResponse<TextRectsResponse> GetPageTextWithHttpInfo (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);
        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        TextItemsResponse GetPageTextItems (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        ApiResponse<TextItemsResponse> GetPageTextItemsWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document pages info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>DocumentPagesResponse</returns>
        DocumentPagesResponse GetPages (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document pages info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentPagesResponse</returns>
        ApiResponse<DocumentPagesResponse> GetPagesWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemResponse</returns>
        TextItemResponse GetSegment (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemResponse</returns>
        ApiResponse<TextItemResponse> GetSegmentWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read segment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextFormatResponse</returns>
        TextFormatResponse GetSegmentTextFormat (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read segment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextFormatResponse</returns>
        ApiResponse<TextFormatResponse> GetSegmentTextFormatWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read fragment segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        TextItemsResponse GetSegments (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read fragment segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        ApiResponse<TextItemsResponse> GetSegmentsWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document text.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextRectsResponse</returns>
        TextRectsResponse GetText (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);

        /// <summary>
        /// Read document text.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextRectsResponse</returns>
        ApiResponse<TextRectsResponse> GetTextWithHttpInfo (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        TextItemsResponse GetTextItems (string name, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read document text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        ApiResponse<TextItemsResponse> GetTextItemsWithHttpInfo (string name, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Get number of words per document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>WordCountResponse</returns>
        WordCountResponse GetWordsPerPage (string name, string storage = null, string folder = null);

        /// <summary>
        /// Get number of words per document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of WordCountResponse</returns>
        ApiResponse<WordCountResponse> GetWordsPerPageWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Append document to existing one.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>DocumentResponse</returns>
        DocumentResponse PostAppendDocument (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null);

        /// <summary>
        /// Append document to existing one.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        ApiResponse<DocumentResponse> PostAppendDocumentWithHttpInfo (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null);
        /// <summary>
        /// Create field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PostCreateField (string name, int? page, Field field = null, string storage = null, string folder = null);

        /// <summary>
        /// Create field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PostCreateFieldWithHttpInfo (string name, int? page, Field field = null, string storage = null, string folder = null);
        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentTextReplaceResponse</returns>
        DocumentTextReplaceResponse PostDocumentReplaceText (string name, TextReplaceRequest textReplace, string storage = null, string folder = null);

        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentTextReplaceResponse</returns>
        ApiResponse<DocumentTextReplaceResponse> PostDocumentReplaceTextWithHttpInfo (string name, TextReplaceRequest textReplace, string storage = null, string folder = null);
        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentTextReplaceResponse</returns>
        DocumentTextReplaceResponse PostDocumentReplaceTextList (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);

        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentTextReplaceResponse</returns>
        ApiResponse<DocumentTextReplaceResponse> PostDocumentReplaceTextListWithHttpInfo (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);
        /// <summary>
        /// Document&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextReplaceResponse</returns>
        TextReplaceResponse PostDocumentTextReplace (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null);

        /// <summary>
        /// Document&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextReplaceResponse</returns>
        ApiResponse<TextReplaceResponse> PostDocumentTextReplaceWithHttpInfo (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null);
        /// <summary>
        /// Move page to new position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PostMovePage (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null);

        /// <summary>
        /// Move page to new position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PostMovePageWithHttpInfo (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null);
        /// <summary>
        /// Optimize document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PostOptimizeDocument (string name, OptimizeOptions options = null, string storage = null, string folder = null);

        /// <summary>
        /// Optimize document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PostOptimizeDocumentWithHttpInfo (string name, OptimizeOptions options = null, string storage = null, string folder = null);
        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>PageTextReplaceResponse</returns>
        PageTextReplaceResponse PostPageReplaceText (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null);

        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of PageTextReplaceResponse</returns>
        ApiResponse<PageTextReplaceResponse> PostPageReplaceTextWithHttpInfo (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null);
        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>PageTextReplaceResponse</returns>
        PageTextReplaceResponse PostPageReplaceTextList (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);

        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of PageTextReplaceResponse</returns>
        ApiResponse<PageTextReplaceResponse> PostPageReplaceTextListWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);
        /// <summary>
        /// Page&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextReplaceResponse</returns>
        TextReplaceResponse PostPageTextReplace (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);

        /// <summary>
        /// Page&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextReplaceResponse</returns>
        ApiResponse<TextReplaceResponse> PostPageTextReplaceWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);
        /// <summary>
        /// Replace document image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ImageResponse</returns>
        ImageResponse PostReplaceImage (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null);

        /// <summary>
        /// Replace document image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of ImageResponse</returns>
        ApiResponse<ImageResponse> PostReplaceImageWithHttpInfo (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null);
        /// <summary>
        /// Sign document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PostSignDocument (string name, Signature signature = null, string storage = null, string folder = null);

        /// <summary>
        /// Sign document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PostSignDocumentWithHttpInfo (string name, Signature signature = null, string storage = null, string folder = null);
        /// <summary>
        /// Sign page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PostSignPage (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null);

        /// <summary>
        /// Sign page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PostSignPageWithHttpInfo (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null);
        /// <summary>
        /// Split document to parts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SplitResultResponse</returns>
        SplitResultResponse PostSplitDocument (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null);

        /// <summary>
        /// Split document to parts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SplitResultResponse</returns>
        ApiResponse<SplitResultResponse> PostSplitDocumentWithHttpInfo (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null);
        /// <summary>
        /// Add new page to end of the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>DocumentPagesResponse</returns>
        DocumentPagesResponse PutAddNewPage (string name, string storage = null, string folder = null);

        /// <summary>
        /// Add new page to end of the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentPagesResponse</returns>
        ApiResponse<DocumentPagesResponse> PutAddNewPageWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Add text to PDF document page. Deprecate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PutAddParagraph (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);

        /// <summary>
        /// Add text to PDF document page. Deprecate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PutAddParagraphWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);
        /// <summary>
        /// Add text to PDF document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PutAddText (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);

        /// <summary>
        /// Add text to PDF document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PutAddTextWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);
        /// <summary>
        /// Convert document from request content to format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream PutConvertDocument (string format = null, string url = null, string outPath = null);

        /// <summary>
        /// Convert document from request content to format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> PutConvertDocumentWithHttpInfo (string format = null, string url = null, string outPath = null);
        /// <summary>
        /// Create new document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>DocumentResponse</returns>
        DocumentResponse PutCreateDocument (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null);

        /// <summary>
        /// Create new document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        ApiResponse<DocumentResponse> PutCreateDocumentWithHttpInfo (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null);
        /// <summary>
        /// Create new document from images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>DocumentResponse</returns>
        DocumentResponse PutCreateDocumentFromImages (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null);

        /// <summary>
        /// Create new document from images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        ApiResponse<DocumentResponse> PutCreateDocumentFromImagesWithHttpInfo (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null);
        /// <summary>
        /// Save document as Tiff image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PutDocumentSaveAsTiff (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null);

        /// <summary>
        /// Save document as Tiff image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PutDocumentSaveAsTiffWithHttpInfo (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null);
        /// <summary>
        /// Merge a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>DocumentResponse</returns>
        DocumentResponse PutMergeDocuments (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null);

        /// <summary>
        /// Merge a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        ApiResponse<DocumentResponse> PutMergeDocumentsWithHttpInfo (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null);
        /// <summary>
        /// Add page stamp.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PutPageAddStamp (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null);

        /// <summary>
        /// Add page stamp.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PutPageAddStampWithHttpInfo (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null);
        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        SaaSposeResponse PutSearchableDocument (string name, string storage = null, string folder = null, string lang = null);

        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        ApiResponse<SaaSposeResponse> PutSearchableDocumentWithHttpInfo (string name, string storage = null, string folder = null, string lang = null);
        /// <summary>
        /// Add/update document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentPropertyResponse</returns>
        DocumentPropertyResponse PutSetProperty (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null);

        /// <summary>
        /// Add/update document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentPropertyResponse</returns>
        ApiResponse<DocumentPropertyResponse> PutSetPropertyWithHttpInfo (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null);
        /// <summary>
        /// Update field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>FieldResponse</returns>
        FieldResponse PutUpdateField (string name, string fieldName, Field field = null, string storage = null, string folder = null);

        /// <summary>
        /// Update field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of FieldResponse</returns>
        ApiResponse<FieldResponse> PutUpdateFieldWithHttpInfo (string name, string fieldName, Field field = null, string storage = null, string folder = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete document page by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> DeletePageAsync (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Delete document page by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> DeletePageAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Delete custom document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> DeletePropertiesAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Delete custom document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> DeletePropertiesAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Delete document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> DeletePropertyAsync (string name, string propertyName, string storage = null, string folder = null);

        /// <summary>
        /// Delete document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> DeletePropertyAsyncWithHttpInfo (string name, string propertyName, string storage = null, string folder = null);
        /// <summary>
        /// Read common document info or convert to some format if the format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetDocumentAsync (string name, string format = null, string storage = null, string folder = null, string outPath = null);

        /// <summary>
        /// Read common document info or convert to some format if the format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetDocumentAsyncWithHttpInfo (string name, string format = null, string storage = null, string folder = null, string outPath = null);
        /// <summary>
        /// Read document attachment info by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AttachmentResponse</returns>
        System.Threading.Tasks.Task<AttachmentResponse> GetDocumentAttachmentByIndexAsync (string name, int? attachmentIndex, string storage = null, string folder = null);

        /// <summary>
        /// Read document attachment info by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AttachmentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttachmentResponse>> GetDocumentAttachmentByIndexAsyncWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null);
        /// <summary>
        /// Read document attachments info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AttachmentsResponse</returns>
        System.Threading.Tasks.Task<AttachmentsResponse> GetDocumentAttachmentsAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document attachments info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AttachmentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AttachmentsResponse>> GetDocumentAttachmentsAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read document bookmarks.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of BookmarksResponse</returns>
        System.Threading.Tasks.Task<BookmarksResponse> GetDocumentBookmarksAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document bookmarks.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (BookmarksResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BookmarksResponse>> GetDocumentBookmarksAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentPropertiesResponse</returns>
        System.Threading.Tasks.Task<DocumentPropertiesResponse> GetDocumentPropertiesAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document properties.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPropertiesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentPropertiesResponse>> GetDocumentPropertiesAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read document property by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentPropertyResponse</returns>
        System.Threading.Tasks.Task<DocumentPropertyResponse> GetDocumentPropertyAsync (string name, string propertyName, string storage = null, string folder = null);

        /// <summary>
        /// Read document property by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPropertyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentPropertyResponse>> GetDocumentPropertyAsyncWithHttpInfo (string name, string propertyName, string storage = null, string folder = null);
        /// <summary>
        /// Download document attachment content by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetDownloadDocumentAttachmentByIndexAsync (string name, int? attachmentIndex, string storage = null, string folder = null);

        /// <summary>
        /// Download document attachment content by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetDownloadDocumentAttachmentByIndexAsyncWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null);
        /// <summary>
        /// Get document field by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of FieldResponse</returns>
        System.Threading.Tasks.Task<FieldResponse> GetFieldAsync (string name, string fieldName, string storage = null, string folder = null);

        /// <summary>
        /// Get document field by name.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (FieldResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldResponse>> GetFieldAsyncWithHttpInfo (string name, string fieldName, string storage = null, string folder = null);
        /// <summary>
        /// Get document fields.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of FieldsResponse</returns>
        System.Threading.Tasks.Task<FieldsResponse> GetFieldsAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Get document fields.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (FieldsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldsResponse>> GetFieldsAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read page fragment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        System.Threading.Tasks.Task<TextItemsResponse> GetFragmentAsync (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page fragment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetFragmentAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read page fragment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextFormatResponse</returns>
        System.Threading.Tasks.Task<TextFormatResponse> GetFragmentTextFormatAsync (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read page fragment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextFormatResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextFormatResponse>> GetFragmentTextFormatAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read page fragments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        System.Threading.Tasks.Task<TextItemsResponse> GetFragmentsAsync (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page fragments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetFragmentsAsyncWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document image by number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetImageAsync (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document image by number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetImageAsyncWithHttpInfo (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ImagesResponse</returns>
        System.Threading.Tasks.Task<ImagesResponse> GetImagesAsync (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (ImagesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImagesResponse>> GetImagesAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document page info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetPageAsync (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document page info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetPageAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document page annotation by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AnnotationResponse</returns>
        System.Threading.Tasks.Task<AnnotationResponse> GetPageAnnotationAsync (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document page annotation by its number.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AnnotationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnnotationResponse>> GetPageAnnotationAsyncWithHttpInfo (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read documant page annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AnnotationsResponse</returns>
        System.Threading.Tasks.Task<AnnotationsResponse> GetPageAnnotationsAsync (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read documant page annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AnnotationsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AnnotationsResponse>> GetPageAnnotationsAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read document page link annotation by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of LinkAnnotationResponse</returns>
        System.Threading.Tasks.Task<LinkAnnotationResponse> GetPageLinkAnnotationByIndexAsync (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null);

        /// <summary>
        /// Read document page link annotation by its index.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (LinkAnnotationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LinkAnnotationResponse>> GetPageLinkAnnotationByIndexAsyncWithHttpInfo (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null);
        /// <summary>
        /// Read document page link annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of LinkAnnotationsResponse</returns>
        System.Threading.Tasks.Task<LinkAnnotationsResponse> GetPageLinkAnnotationsAsync (string name, int? pageNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read document page link annotations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (LinkAnnotationsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<LinkAnnotationsResponse>> GetPageLinkAnnotationsAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextRectsResponse</returns>
        System.Threading.Tasks.Task<TextRectsResponse> GetPageTextAsync (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextRectsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextRectsResponse>> GetPageTextAsyncWithHttpInfo (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);
        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        System.Threading.Tasks.Task<TextItemsResponse> GetPageTextItemsAsync (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read page text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetPageTextItemsAsyncWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document pages info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of DocumentPagesResponse</returns>
        System.Threading.Tasks.Task<DocumentPagesResponse> GetPagesAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Read document pages info.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPagesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentPagesResponse>> GetPagesAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Read segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemResponse</returns>
        System.Threading.Tasks.Task<TextItemResponse> GetSegmentAsync (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read segment.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextItemResponse>> GetSegmentAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read segment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextFormatResponse</returns>
        System.Threading.Tasks.Task<TextFormatResponse> GetSegmentTextFormatAsync (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);

        /// <summary>
        /// Read segment text format.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextFormatResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextFormatResponse>> GetSegmentTextFormatAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null);
        /// <summary>
        /// Read fragment segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        System.Threading.Tasks.Task<TextItemsResponse> GetSegmentsAsync (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read fragment segments.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetSegmentsAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document text.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextRectsResponse</returns>
        System.Threading.Tasks.Task<TextRectsResponse> GetTextAsync (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);

        /// <summary>
        /// Read document text.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextRectsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextRectsResponse>> GetTextAsyncWithHttpInfo (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null);
        /// <summary>
        /// Read document text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        System.Threading.Tasks.Task<TextItemsResponse> GetTextItemsAsync (string name, string withEmpty = null, string storage = null, string folder = null);

        /// <summary>
        /// Read document text items.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetTextItemsAsyncWithHttpInfo (string name, string withEmpty = null, string storage = null, string folder = null);
        /// <summary>
        /// Get number of words per document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of WordCountResponse</returns>
        System.Threading.Tasks.Task<WordCountResponse> GetWordsPerPageAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Get number of words per document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (WordCountResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<WordCountResponse>> GetWordsPerPageAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Append document to existing one.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>Task of DocumentResponse</returns>
        System.Threading.Tasks.Task<DocumentResponse> PostAppendDocumentAsync (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null);

        /// <summary>
        /// Append document to existing one.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PostAppendDocumentAsyncWithHttpInfo (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null);
        /// <summary>
        /// Create field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PostCreateFieldAsync (string name, int? page, Field field = null, string storage = null, string folder = null);

        /// <summary>
        /// Create field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostCreateFieldAsyncWithHttpInfo (string name, int? page, Field field = null, string storage = null, string folder = null);
        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentTextReplaceResponse</returns>
        System.Threading.Tasks.Task<DocumentTextReplaceResponse> PostDocumentReplaceTextAsync (string name, TextReplaceRequest textReplace, string storage = null, string folder = null);

        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentTextReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentTextReplaceResponse>> PostDocumentReplaceTextAsyncWithHttpInfo (string name, TextReplaceRequest textReplace, string storage = null, string folder = null);
        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentTextReplaceResponse</returns>
        System.Threading.Tasks.Task<DocumentTextReplaceResponse> PostDocumentReplaceTextListAsync (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);

        /// <summary>
        /// Document&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentTextReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentTextReplaceResponse>> PostDocumentReplaceTextListAsyncWithHttpInfo (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);
        /// <summary>
        /// Document&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextReplaceResponse</returns>
        System.Threading.Tasks.Task<TextReplaceResponse> PostDocumentTextReplaceAsync (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null);

        /// <summary>
        /// Document&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextReplaceResponse>> PostDocumentTextReplaceAsyncWithHttpInfo (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null);
        /// <summary>
        /// Move page to new position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PostMovePageAsync (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null);

        /// <summary>
        /// Move page to new position.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostMovePageAsyncWithHttpInfo (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null);
        /// <summary>
        /// Optimize document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PostOptimizeDocumentAsync (string name, OptimizeOptions options = null, string storage = null, string folder = null);

        /// <summary>
        /// Optimize document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostOptimizeDocumentAsyncWithHttpInfo (string name, OptimizeOptions options = null, string storage = null, string folder = null);
        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of PageTextReplaceResponse</returns>
        System.Threading.Tasks.Task<PageTextReplaceResponse> PostPageReplaceTextAsync (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null);

        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (PageTextReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTextReplaceResponse>> PostPageReplaceTextAsyncWithHttpInfo (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null);
        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of PageTextReplaceResponse</returns>
        System.Threading.Tasks.Task<PageTextReplaceResponse> PostPageReplaceTextListAsync (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);

        /// <summary>
        /// Page&#39;s replace text method. Deprecated
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (PageTextReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PageTextReplaceResponse>> PostPageReplaceTextListAsyncWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);
        /// <summary>
        /// Page&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextReplaceResponse</returns>
        System.Threading.Tasks.Task<TextReplaceResponse> PostPageTextReplaceAsync (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);

        /// <summary>
        /// Page&#39;s replace text method.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextReplaceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TextReplaceResponse>> PostPageTextReplaceAsyncWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null);
        /// <summary>
        /// Replace document image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ImageResponse</returns>
        System.Threading.Tasks.Task<ImageResponse> PostReplaceImageAsync (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null);

        /// <summary>
        /// Replace document image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageResponse>> PostReplaceImageAsyncWithHttpInfo (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null);
        /// <summary>
        /// Sign document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PostSignDocumentAsync (string name, Signature signature = null, string storage = null, string folder = null);

        /// <summary>
        /// Sign document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostSignDocumentAsyncWithHttpInfo (string name, Signature signature = null, string storage = null, string folder = null);
        /// <summary>
        /// Sign page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PostSignPageAsync (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null);

        /// <summary>
        /// Sign page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostSignPageAsyncWithHttpInfo (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null);
        /// <summary>
        /// Split document to parts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SplitResultResponse</returns>
        System.Threading.Tasks.Task<SplitResultResponse> PostSplitDocumentAsync (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null);

        /// <summary>
        /// Split document to parts.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SplitResultResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SplitResultResponse>> PostSplitDocumentAsyncWithHttpInfo (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null);
        /// <summary>
        /// Add new page to end of the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of DocumentPagesResponse</returns>
        System.Threading.Tasks.Task<DocumentPagesResponse> PutAddNewPageAsync (string name, string storage = null, string folder = null);

        /// <summary>
        /// Add new page to end of the document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPagesResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentPagesResponse>> PutAddNewPageAsyncWithHttpInfo (string name, string storage = null, string folder = null);
        /// <summary>
        /// Add text to PDF document page. Deprecate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PutAddParagraphAsync (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);

        /// <summary>
        /// Add text to PDF document page. Deprecate
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutAddParagraphAsyncWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);
        /// <summary>
        /// Add text to PDF document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PutAddTextAsync (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);

        /// <summary>
        /// Add text to PDF document page.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutAddTextAsyncWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null);
        /// <summary>
        /// Convert document from request content to format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> PutConvertDocumentAsync (string format = null, string url = null, string outPath = null);

        /// <summary>
        /// Convert document from request content to format specified.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> PutConvertDocumentAsyncWithHttpInfo (string format = null, string url = null, string outPath = null);
        /// <summary>
        /// Create new document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>Task of DocumentResponse</returns>
        System.Threading.Tasks.Task<DocumentResponse> PutCreateDocumentAsync (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null);

        /// <summary>
        /// Create new document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PutCreateDocumentAsyncWithHttpInfo (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null);
        /// <summary>
        /// Create new document from images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>Task of DocumentResponse</returns>
        System.Threading.Tasks.Task<DocumentResponse> PutCreateDocumentFromImagesAsync (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null);

        /// <summary>
        /// Create new document from images.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PutCreateDocumentFromImagesAsyncWithHttpInfo (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null);
        /// <summary>
        /// Save document as Tiff image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PutDocumentSaveAsTiffAsync (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null);

        /// <summary>
        /// Save document as Tiff image.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutDocumentSaveAsTiffAsyncWithHttpInfo (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null);
        /// <summary>
        /// Merge a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>Task of DocumentResponse</returns>
        System.Threading.Tasks.Task<DocumentResponse> PutMergeDocumentsAsync (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null);

        /// <summary>
        /// Merge a list of documents.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PutMergeDocumentsAsyncWithHttpInfo (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null);
        /// <summary>
        /// Add page stamp.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PutPageAddStampAsync (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null);

        /// <summary>
        /// Add page stamp.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutPageAddStampAsyncWithHttpInfo (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null);
        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        System.Threading.Tasks.Task<SaaSposeResponse> PutSearchableDocumentAsync (string name, string storage = null, string folder = null, string lang = null);

        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutSearchableDocumentAsyncWithHttpInfo (string name, string storage = null, string folder = null, string lang = null);
        /// <summary>
        /// Add/update document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentPropertyResponse</returns>
        System.Threading.Tasks.Task<DocumentPropertyResponse> PutSetPropertyAsync (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null);

        /// <summary>
        /// Add/update document property.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPropertyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DocumentPropertyResponse>> PutSetPropertyAsyncWithHttpInfo (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null);
        /// <summary>
        /// Update field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of FieldResponse</returns>
        System.Threading.Tasks.Task<FieldResponse> PutUpdateFieldAsync (string name, string fieldName, Field field = null, string storage = null, string folder = null);

        /// <summary>
        /// Update field.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (FieldResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<FieldResponse>> PutUpdateFieldAsyncWithHttpInfo (string name, string fieldName, Field field = null, string storage = null, string folder = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PdfApi : IPdfApi
    {
        private Aspose.Pdf.Cloud.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PdfApi(string apiKey, string appSid)
            : this(new Configuration(apiKey, appSid ))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PdfApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PdfApi(Configuration configuration)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException("configuration");
            }
            
            Configuration = configuration;
            ApiClient = new ApiClient(Configuration);           
            ExceptionFactory = Aspose.Pdf.Cloud.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ApiClient ApiClient {get; set;}

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Aspose.Pdf.Cloud.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Delete document page by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse DeletePage (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = DeletePageWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete document page by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > DeletePageWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->DeletePage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->DeletePage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Delete document page by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> DeletePageAsync (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await DeletePageAsyncWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete document page by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> DeletePageAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->DeletePage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->DeletePage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeletePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Delete custom document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse DeleteProperties (string name, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = DeletePropertiesWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete custom document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > DeletePropertiesWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->DeleteProperties");

            var localVarPath = "/pdf/{name}/documentproperties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Delete custom document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> DeletePropertiesAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await DeletePropertiesAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete custom document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> DeletePropertiesAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->DeleteProperties");

            var localVarPath = "/pdf/{name}/documentproperties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse DeleteProperty (string name, string propertyName, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = DeletePropertyWithHttpInfo(name, propertyName, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > DeletePropertyWithHttpInfo (string name, string propertyName, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->DeleteProperty");
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PdfApi->DeleteProperty");

            var localVarPath = "/pdf/{name}/documentproperties/{propertyName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (propertyName != null) localVarPathParams.Add("propertyName", ApiClient.ParameterToString(propertyName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> DeletePropertyAsync (string name, string propertyName, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await DeletePropertyAsyncWithHttpInfo(name, propertyName, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> DeletePropertyAsyncWithHttpInfo (string name, string propertyName, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->DeleteProperty");
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PdfApi->DeleteProperty");

            var localVarPath = "/pdf/{name}/documentproperties/{propertyName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (propertyName != null) localVarPathParams.Add("propertyName", ApiClient.ParameterToString(propertyName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Read common document info or convert to some format if the format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetDocument (string name, string format = null, string storage = null, string folder = null, string outPath = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetDocumentWithHttpInfo(name, format, storage, folder, outPath);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read common document info or convert to some format if the format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > GetDocumentWithHttpInfo (string name, string format = null, string storage = null, string folder = null, string outPath = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocument");

            var localVarPath = "/pdf/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (outPath != null) localVarQueryParams.Add("outPath", ApiClient.ParameterToString(outPath)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Read common document info or convert to some format if the format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetDocumentAsync (string name, string format = null, string storage = null, string folder = null, string outPath = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetDocumentAsyncWithHttpInfo(name, format, storage, folder, outPath);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read common document info or convert to some format if the format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetDocumentAsyncWithHttpInfo (string name, string format = null, string storage = null, string folder = null, string outPath = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocument");

            var localVarPath = "/pdf/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (outPath != null) localVarQueryParams.Add("outPath", ApiClient.ParameterToString(outPath)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Read document attachment info by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AttachmentResponse</returns>
        public AttachmentResponse GetDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
             ApiResponse<AttachmentResponse> localVarResponse = GetDocumentAttachmentByIndexWithHttpInfo(name, attachmentIndex, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document attachment info by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AttachmentResponse</returns>
        public ApiResponse< AttachmentResponse > GetDocumentAttachmentByIndexWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentAttachmentByIndex");
            // verify the required parameter 'attachmentIndex' is set
            if (attachmentIndex == null)
                throw new ApiException(400, "Missing required parameter 'attachmentIndex' when calling PdfApi->GetDocumentAttachmentByIndex");

            var localVarPath = "/pdf/{name}/attachments/{attachmentIndex}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (attachmentIndex != null) localVarPathParams.Add("attachmentIndex", ApiClient.ParameterToString(attachmentIndex)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentAttachmentByIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AttachmentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachmentResponse) ApiClient.Deserialize(localVarResponse, typeof(AttachmentResponse)));
        }

        /// <summary>
        /// Read document attachment info by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AttachmentResponse</returns>
        public async System.Threading.Tasks.Task<AttachmentResponse> GetDocumentAttachmentByIndexAsync (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
             ApiResponse<AttachmentResponse> localVarResponse = await GetDocumentAttachmentByIndexAsyncWithHttpInfo(name, attachmentIndex, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document attachment info by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AttachmentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttachmentResponse>> GetDocumentAttachmentByIndexAsyncWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentAttachmentByIndex");
            // verify the required parameter 'attachmentIndex' is set
            if (attachmentIndex == null)
                throw new ApiException(400, "Missing required parameter 'attachmentIndex' when calling PdfApi->GetDocumentAttachmentByIndex");

            var localVarPath = "/pdf/{name}/attachments/{attachmentIndex}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (attachmentIndex != null) localVarPathParams.Add("attachmentIndex", ApiClient.ParameterToString(attachmentIndex)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentAttachmentByIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AttachmentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachmentResponse) ApiClient.Deserialize(localVarResponse, typeof(AttachmentResponse)));
        }

        /// <summary>
        /// Read document attachments info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AttachmentsResponse</returns>
        public AttachmentsResponse GetDocumentAttachments (string name, string storage = null, string folder = null)
        {
             ApiResponse<AttachmentsResponse> localVarResponse = GetDocumentAttachmentsWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document attachments info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AttachmentsResponse</returns>
        public ApiResponse< AttachmentsResponse > GetDocumentAttachmentsWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentAttachments");

            var localVarPath = "/pdf/{name}/attachments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentAttachments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachmentsResponse) ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        /// <summary>
        /// Read document attachments info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AttachmentsResponse</returns>
        public async System.Threading.Tasks.Task<AttachmentsResponse> GetDocumentAttachmentsAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<AttachmentsResponse> localVarResponse = await GetDocumentAttachmentsAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document attachments info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AttachmentsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AttachmentsResponse>> GetDocumentAttachmentsAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentAttachments");

            var localVarPath = "/pdf/{name}/attachments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentAttachments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AttachmentsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AttachmentsResponse) ApiClient.Deserialize(localVarResponse, typeof(AttachmentsResponse)));
        }

        /// <summary>
        /// Read document bookmarks. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>BookmarksResponse</returns>
        public BookmarksResponse GetDocumentBookmarks (string name, string storage = null, string folder = null)
        {
             ApiResponse<BookmarksResponse> localVarResponse = GetDocumentBookmarksWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document bookmarks. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of BookmarksResponse</returns>
        public ApiResponse< BookmarksResponse > GetDocumentBookmarksWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentBookmarks");

            var localVarPath = "/pdf/{name}/bookmarks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentBookmarks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BookmarksResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BookmarksResponse) ApiClient.Deserialize(localVarResponse, typeof(BookmarksResponse)));
        }

        /// <summary>
        /// Read document bookmarks. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of BookmarksResponse</returns>
        public async System.Threading.Tasks.Task<BookmarksResponse> GetDocumentBookmarksAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<BookmarksResponse> localVarResponse = await GetDocumentBookmarksAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document bookmarks. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (BookmarksResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BookmarksResponse>> GetDocumentBookmarksAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentBookmarks");

            var localVarPath = "/pdf/{name}/bookmarks";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentBookmarks", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BookmarksResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (BookmarksResponse) ApiClient.Deserialize(localVarResponse, typeof(BookmarksResponse)));
        }

        /// <summary>
        /// Read document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentPropertiesResponse</returns>
        public DocumentPropertiesResponse GetDocumentProperties (string name, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPropertiesResponse> localVarResponse = GetDocumentPropertiesWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentPropertiesResponse</returns>
        public ApiResponse< DocumentPropertiesResponse > GetDocumentPropertiesWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentProperties");

            var localVarPath = "/pdf/{name}/documentproperties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPropertiesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPropertiesResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPropertiesResponse)));
        }

        /// <summary>
        /// Read document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentPropertiesResponse</returns>
        public async System.Threading.Tasks.Task<DocumentPropertiesResponse> GetDocumentPropertiesAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPropertiesResponse> localVarResponse = await GetDocumentPropertiesAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document properties. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPropertiesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentPropertiesResponse>> GetDocumentPropertiesAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentProperties");

            var localVarPath = "/pdf/{name}/documentproperties";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentProperties", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPropertiesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPropertiesResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPropertiesResponse)));
        }

        /// <summary>
        /// Read document property by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentPropertyResponse</returns>
        public DocumentPropertyResponse GetDocumentProperty (string name, string propertyName, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPropertyResponse> localVarResponse = GetDocumentPropertyWithHttpInfo(name, propertyName, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document property by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentPropertyResponse</returns>
        public ApiResponse< DocumentPropertyResponse > GetDocumentPropertyWithHttpInfo (string name, string propertyName, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentProperty");
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PdfApi->GetDocumentProperty");

            var localVarPath = "/pdf/{name}/documentproperties/{propertyName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (propertyName != null) localVarPathParams.Add("propertyName", ApiClient.ParameterToString(propertyName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPropertyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPropertyResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPropertyResponse)));
        }

        /// <summary>
        /// Read document property by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentPropertyResponse</returns>
        public async System.Threading.Tasks.Task<DocumentPropertyResponse> GetDocumentPropertyAsync (string name, string propertyName, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPropertyResponse> localVarResponse = await GetDocumentPropertyAsyncWithHttpInfo(name, propertyName, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document property by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPropertyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentPropertyResponse>> GetDocumentPropertyAsyncWithHttpInfo (string name, string propertyName, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDocumentProperty");
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PdfApi->GetDocumentProperty");

            var localVarPath = "/pdf/{name}/documentproperties/{propertyName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (propertyName != null) localVarPathParams.Add("propertyName", ApiClient.ParameterToString(propertyName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDocumentProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPropertyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPropertyResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPropertyResponse)));
        }

        /// <summary>
        /// Download document attachment content by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetDownloadDocumentAttachmentByIndex (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetDownloadDocumentAttachmentByIndexWithHttpInfo(name, attachmentIndex, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download document attachment content by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > GetDownloadDocumentAttachmentByIndexWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDownloadDocumentAttachmentByIndex");
            // verify the required parameter 'attachmentIndex' is set
            if (attachmentIndex == null)
                throw new ApiException(400, "Missing required parameter 'attachmentIndex' when calling PdfApi->GetDownloadDocumentAttachmentByIndex");

            var localVarPath = "/pdf/{name}/attachments/{attachmentIndex}/download";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (attachmentIndex != null) localVarPathParams.Add("attachmentIndex", ApiClient.ParameterToString(attachmentIndex)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDownloadDocumentAttachmentByIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Download document attachment content by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetDownloadDocumentAttachmentByIndexAsync (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetDownloadDocumentAttachmentByIndexAsyncWithHttpInfo(name, attachmentIndex, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download document attachment content by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="attachmentIndex">The attachment index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetDownloadDocumentAttachmentByIndexAsyncWithHttpInfo (string name, int? attachmentIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetDownloadDocumentAttachmentByIndex");
            // verify the required parameter 'attachmentIndex' is set
            if (attachmentIndex == null)
                throw new ApiException(400, "Missing required parameter 'attachmentIndex' when calling PdfApi->GetDownloadDocumentAttachmentByIndex");

            var localVarPath = "/pdf/{name}/attachments/{attachmentIndex}/download";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (attachmentIndex != null) localVarPathParams.Add("attachmentIndex", ApiClient.ParameterToString(attachmentIndex)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetDownloadDocumentAttachmentByIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Get document field by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>FieldResponse</returns>
        public FieldResponse GetField (string name, string fieldName, string storage = null, string folder = null)
        {
             ApiResponse<FieldResponse> localVarResponse = GetFieldWithHttpInfo(name, fieldName, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get document field by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of FieldResponse</returns>
        public ApiResponse< FieldResponse > GetFieldWithHttpInfo (string name, string fieldName, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetField");
            // verify the required parameter 'fieldName' is set
            if (fieldName == null)
                throw new ApiException(400, "Missing required parameter 'fieldName' when calling PdfApi->GetField");

            var localVarPath = "/pdf/{name}/fields/{fieldName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (fieldName != null) localVarPathParams.Add("fieldName", ApiClient.ParameterToString(fieldName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldResponse) ApiClient.Deserialize(localVarResponse, typeof(FieldResponse)));
        }

        /// <summary>
        /// Get document field by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of FieldResponse</returns>
        public async System.Threading.Tasks.Task<FieldResponse> GetFieldAsync (string name, string fieldName, string storage = null, string folder = null)
        {
             ApiResponse<FieldResponse> localVarResponse = await GetFieldAsyncWithHttpInfo(name, fieldName, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get document field by name. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (FieldResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldResponse>> GetFieldAsyncWithHttpInfo (string name, string fieldName, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetField");
            // verify the required parameter 'fieldName' is set
            if (fieldName == null)
                throw new ApiException(400, "Missing required parameter 'fieldName' when calling PdfApi->GetField");

            var localVarPath = "/pdf/{name}/fields/{fieldName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (fieldName != null) localVarPathParams.Add("fieldName", ApiClient.ParameterToString(fieldName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldResponse) ApiClient.Deserialize(localVarResponse, typeof(FieldResponse)));
        }

        /// <summary>
        /// Get document fields. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>FieldsResponse</returns>
        public FieldsResponse GetFields (string name, string storage = null, string folder = null)
        {
             ApiResponse<FieldsResponse> localVarResponse = GetFieldsWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get document fields. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of FieldsResponse</returns>
        public ApiResponse< FieldsResponse > GetFieldsWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFields");

            var localVarPath = "/pdf/{name}/fields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldsResponse) ApiClient.Deserialize(localVarResponse, typeof(FieldsResponse)));
        }

        /// <summary>
        /// Get document fields. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of FieldsResponse</returns>
        public async System.Threading.Tasks.Task<FieldsResponse> GetFieldsAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<FieldsResponse> localVarResponse = await GetFieldsAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get document fields. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (FieldsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldsResponse>> GetFieldsAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFields");

            var localVarPath = "/pdf/{name}/fields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldsResponse) ApiClient.Deserialize(localVarResponse, typeof(FieldsResponse)));
        }

        /// <summary>
        /// Read page fragment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        public TextItemsResponse GetFragment (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = GetFragmentWithHttpInfo(name, pageNumber, fragmentNumber, withEmpty, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read page fragment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        public ApiResponse< TextItemsResponse > GetFragmentWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFragment");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetFragment");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetFragment");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFragment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read page fragment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        public async System.Threading.Tasks.Task<TextItemsResponse> GetFragmentAsync (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = await GetFragmentAsyncWithHttpInfo(name, pageNumber, fragmentNumber, withEmpty, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read page fragment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetFragmentAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFragment");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetFragment");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetFragment");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFragment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read page fragment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextFormatResponse</returns>
        public TextFormatResponse GetFragmentTextFormat (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null)
        {
             ApiResponse<TextFormatResponse> localVarResponse = GetFragmentTextFormatWithHttpInfo(name, pageNumber, fragmentNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read page fragment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextFormatResponse</returns>
        public ApiResponse< TextFormatResponse > GetFragmentTextFormatWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFragmentTextFormat");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetFragmentTextFormat");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetFragmentTextFormat");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/textFormat";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFragmentTextFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextFormatResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextFormatResponse) ApiClient.Deserialize(localVarResponse, typeof(TextFormatResponse)));
        }

        /// <summary>
        /// Read page fragment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextFormatResponse</returns>
        public async System.Threading.Tasks.Task<TextFormatResponse> GetFragmentTextFormatAsync (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null)
        {
             ApiResponse<TextFormatResponse> localVarResponse = await GetFragmentTextFormatAsyncWithHttpInfo(name, pageNumber, fragmentNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read page fragment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextFormatResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextFormatResponse>> GetFragmentTextFormatAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFragmentTextFormat");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetFragmentTextFormat");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetFragmentTextFormat");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/textFormat";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFragmentTextFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextFormatResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextFormatResponse) ApiClient.Deserialize(localVarResponse, typeof(TextFormatResponse)));
        }

        /// <summary>
        /// Read page fragments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        public TextItemsResponse GetFragments (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = GetFragmentsWithHttpInfo(name, pageNumber, withEmpty, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read page fragments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        public ApiResponse< TextItemsResponse > GetFragmentsWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFragments");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetFragments");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFragments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read page fragments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        public async System.Threading.Tasks.Task<TextItemsResponse> GetFragmentsAsync (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = await GetFragmentsAsyncWithHttpInfo(name, pageNumber, withEmpty, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read page fragments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetFragmentsAsyncWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetFragments");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetFragments");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFragments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read document image by number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetImage (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetImageWithHttpInfo(name, pageNumber, imageNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document image by number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > GetImageWithHttpInfo (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetImage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetImage");
            // verify the required parameter 'imageNumber' is set
            if (imageNumber == null)
                throw new ApiException(400, "Missing required parameter 'imageNumber' when calling PdfApi->GetImage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (imageNumber != null) localVarPathParams.Add("imageNumber", ApiClient.ParameterToString(imageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Read document image by number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetImageAsync (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetImageAsyncWithHttpInfo(name, pageNumber, imageNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document image by number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image format.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetImageAsyncWithHttpInfo (string name, int? pageNumber, int? imageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetImage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetImage");
            // verify the required parameter 'imageNumber' is set
            if (imageNumber == null)
                throw new ApiException(400, "Missing required parameter 'imageNumber' when calling PdfApi->GetImage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (imageNumber != null) localVarPathParams.Add("imageNumber", ApiClient.ParameterToString(imageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Read document images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ImagesResponse</returns>
        public ImagesResponse GetImages (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<ImagesResponse> localVarResponse = GetImagesWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of ImagesResponse</returns>
        public ApiResponse< ImagesResponse > GetImagesWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetImages");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetImages");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/images";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetImages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImagesResponse) ApiClient.Deserialize(localVarResponse, typeof(ImagesResponse)));
        }

        /// <summary>
        /// Read document images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ImagesResponse</returns>
        public async System.Threading.Tasks.Task<ImagesResponse> GetImagesAsync (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<ImagesResponse> localVarResponse = await GetImagesAsyncWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (ImagesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImagesResponse>> GetImagesAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetImages");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetImages");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/images";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetImages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImagesResponse) ApiClient.Deserialize(localVarResponse, typeof(ImagesResponse)));
        }

        /// <summary>
        /// Read document page info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream GetPage (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetPageWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document page info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > GetPageWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Read document page info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetPageAsync (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetPageAsyncWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document page info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetPageAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Read document page annotation by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AnnotationResponse</returns>
        public AnnotationResponse GetPageAnnotation (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null)
        {
             ApiResponse<AnnotationResponse> localVarResponse = GetPageAnnotationWithHttpInfo(name, pageNumber, annotationNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document page annotation by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AnnotationResponse</returns>
        public ApiResponse< AnnotationResponse > GetPageAnnotationWithHttpInfo (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageAnnotation");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageAnnotation");
            // verify the required parameter 'annotationNumber' is set
            if (annotationNumber == null)
                throw new ApiException(400, "Missing required parameter 'annotationNumber' when calling PdfApi->GetPageAnnotation");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/annotations/{annotationNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (annotationNumber != null) localVarPathParams.Add("annotationNumber", ApiClient.ParameterToString(annotationNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageAnnotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnnotationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnnotationResponse) ApiClient.Deserialize(localVarResponse, typeof(AnnotationResponse)));
        }

        /// <summary>
        /// Read document page annotation by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AnnotationResponse</returns>
        public async System.Threading.Tasks.Task<AnnotationResponse> GetPageAnnotationAsync (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null)
        {
             ApiResponse<AnnotationResponse> localVarResponse = await GetPageAnnotationAsyncWithHttpInfo(name, pageNumber, annotationNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document page annotation by its number. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="annotationNumber">The annotation number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AnnotationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnnotationResponse>> GetPageAnnotationAsyncWithHttpInfo (string name, int? pageNumber, int? annotationNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageAnnotation");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageAnnotation");
            // verify the required parameter 'annotationNumber' is set
            if (annotationNumber == null)
                throw new ApiException(400, "Missing required parameter 'annotationNumber' when calling PdfApi->GetPageAnnotation");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/annotations/{annotationNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (annotationNumber != null) localVarPathParams.Add("annotationNumber", ApiClient.ParameterToString(annotationNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageAnnotation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnnotationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnnotationResponse) ApiClient.Deserialize(localVarResponse, typeof(AnnotationResponse)));
        }

        /// <summary>
        /// Read documant page annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>AnnotationsResponse</returns>
        public AnnotationsResponse GetPageAnnotations (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<AnnotationsResponse> localVarResponse = GetPageAnnotationsWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read documant page annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of AnnotationsResponse</returns>
        public ApiResponse< AnnotationsResponse > GetPageAnnotationsWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageAnnotations");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageAnnotations");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/annotations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageAnnotations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnnotationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnnotationsResponse) ApiClient.Deserialize(localVarResponse, typeof(AnnotationsResponse)));
        }

        /// <summary>
        /// Read documant page annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of AnnotationsResponse</returns>
        public async System.Threading.Tasks.Task<AnnotationsResponse> GetPageAnnotationsAsync (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<AnnotationsResponse> localVarResponse = await GetPageAnnotationsAsyncWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read documant page annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (AnnotationsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AnnotationsResponse>> GetPageAnnotationsAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageAnnotations");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageAnnotations");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/annotations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageAnnotations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AnnotationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AnnotationsResponse) ApiClient.Deserialize(localVarResponse, typeof(AnnotationsResponse)));
        }

        /// <summary>
        /// Read document page link annotation by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>LinkAnnotationResponse</returns>
        public LinkAnnotationResponse GetPageLinkAnnotationByIndex (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null)
        {
             ApiResponse<LinkAnnotationResponse> localVarResponse = GetPageLinkAnnotationByIndexWithHttpInfo(name, pageNumber, linkIndex, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document page link annotation by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of LinkAnnotationResponse</returns>
        public ApiResponse< LinkAnnotationResponse > GetPageLinkAnnotationByIndexWithHttpInfo (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageLinkAnnotationByIndex");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageLinkAnnotationByIndex");
            // verify the required parameter 'linkIndex' is set
            if (linkIndex == null)
                throw new ApiException(400, "Missing required parameter 'linkIndex' when calling PdfApi->GetPageLinkAnnotationByIndex");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/links/{linkIndex}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (linkIndex != null) localVarPathParams.Add("linkIndex", ApiClient.ParameterToString(linkIndex)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageLinkAnnotationByIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LinkAnnotationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LinkAnnotationResponse) ApiClient.Deserialize(localVarResponse, typeof(LinkAnnotationResponse)));
        }

        /// <summary>
        /// Read document page link annotation by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of LinkAnnotationResponse</returns>
        public async System.Threading.Tasks.Task<LinkAnnotationResponse> GetPageLinkAnnotationByIndexAsync (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null)
        {
             ApiResponse<LinkAnnotationResponse> localVarResponse = await GetPageLinkAnnotationByIndexAsyncWithHttpInfo(name, pageNumber, linkIndex, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document page link annotation by its index. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="linkIndex">The link index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (LinkAnnotationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LinkAnnotationResponse>> GetPageLinkAnnotationByIndexAsyncWithHttpInfo (string name, int? pageNumber, int? linkIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageLinkAnnotationByIndex");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageLinkAnnotationByIndex");
            // verify the required parameter 'linkIndex' is set
            if (linkIndex == null)
                throw new ApiException(400, "Missing required parameter 'linkIndex' when calling PdfApi->GetPageLinkAnnotationByIndex");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/links/{linkIndex}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (linkIndex != null) localVarPathParams.Add("linkIndex", ApiClient.ParameterToString(linkIndex)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageLinkAnnotationByIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LinkAnnotationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LinkAnnotationResponse) ApiClient.Deserialize(localVarResponse, typeof(LinkAnnotationResponse)));
        }

        /// <summary>
        /// Read document page link annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>LinkAnnotationsResponse</returns>
        public LinkAnnotationsResponse GetPageLinkAnnotations (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<LinkAnnotationsResponse> localVarResponse = GetPageLinkAnnotationsWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document page link annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of LinkAnnotationsResponse</returns>
        public ApiResponse< LinkAnnotationsResponse > GetPageLinkAnnotationsWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageLinkAnnotations");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageLinkAnnotations");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/links";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageLinkAnnotations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LinkAnnotationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LinkAnnotationsResponse) ApiClient.Deserialize(localVarResponse, typeof(LinkAnnotationsResponse)));
        }

        /// <summary>
        /// Read document page link annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of LinkAnnotationsResponse</returns>
        public async System.Threading.Tasks.Task<LinkAnnotationsResponse> GetPageLinkAnnotationsAsync (string name, int? pageNumber, string storage = null, string folder = null)
        {
             ApiResponse<LinkAnnotationsResponse> localVarResponse = await GetPageLinkAnnotationsAsyncWithHttpInfo(name, pageNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document page link annotations. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (LinkAnnotationsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LinkAnnotationsResponse>> GetPageLinkAnnotationsAsyncWithHttpInfo (string name, int? pageNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageLinkAnnotations");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageLinkAnnotations");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/links";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageLinkAnnotations", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LinkAnnotationsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LinkAnnotationsResponse) ApiClient.Deserialize(localVarResponse, typeof(LinkAnnotationsResponse)));
        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextRectsResponse</returns>
        public TextRectsResponse GetPageText (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
             ApiResponse<TextRectsResponse> localVarResponse = GetPageTextWithHttpInfo(name, pageNumber, X, Y, width, height, format, regex, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextRectsResponse</returns>
        public ApiResponse< TextRectsResponse > GetPageTextWithHttpInfo (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageText");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageText");
            // verify the required parameter 'X' is set
            if (X == null)
                throw new ApiException(400, "Missing required parameter 'X' when calling PdfApi->GetPageText");
            // verify the required parameter 'Y' is set
            if (Y == null)
                throw new ApiException(400, "Missing required parameter 'Y' when calling PdfApi->GetPageText");
            // verify the required parameter 'width' is set
            if (width == null)
                throw new ApiException(400, "Missing required parameter 'width' when calling PdfApi->GetPageText");
            // verify the required parameter 'height' is set
            if (height == null)
                throw new ApiException(400, "Missing required parameter 'height' when calling PdfApi->GetPageText");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (regex != null) localVarQueryParams.Add("regex", ApiClient.ParameterToString(regex)); // query parameter
            if (X != null) localVarQueryParams.Add("X", ApiClient.ParameterToString(X)); // query parameter
            if (Y != null) localVarQueryParams.Add("Y", ApiClient.ParameterToString(Y)); // query parameter
            if (width != null) localVarQueryParams.Add("Width", ApiClient.ParameterToString(width)); // query parameter
            if (height != null) localVarQueryParams.Add("Height", ApiClient.ParameterToString(height)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextRectsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextRectsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextRectsResponse)));
        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextRectsResponse</returns>
        public async System.Threading.Tasks.Task<TextRectsResponse> GetPageTextAsync (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
             ApiResponse<TextRectsResponse> localVarResponse = await GetPageTextAsyncWithHttpInfo(name, pageNumber, X, Y, width, height, format, regex, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextRectsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextRectsResponse>> GetPageTextAsyncWithHttpInfo (string name, int? pageNumber, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageText");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageText");
            // verify the required parameter 'X' is set
            if (X == null)
                throw new ApiException(400, "Missing required parameter 'X' when calling PdfApi->GetPageText");
            // verify the required parameter 'Y' is set
            if (Y == null)
                throw new ApiException(400, "Missing required parameter 'Y' when calling PdfApi->GetPageText");
            // verify the required parameter 'width' is set
            if (width == null)
                throw new ApiException(400, "Missing required parameter 'width' when calling PdfApi->GetPageText");
            // verify the required parameter 'height' is set
            if (height == null)
                throw new ApiException(400, "Missing required parameter 'height' when calling PdfApi->GetPageText");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (regex != null) localVarQueryParams.Add("regex", ApiClient.ParameterToString(regex)); // query parameter
            if (X != null) localVarQueryParams.Add("X", ApiClient.ParameterToString(X)); // query parameter
            if (Y != null) localVarQueryParams.Add("Y", ApiClient.ParameterToString(Y)); // query parameter
            if (width != null) localVarQueryParams.Add("Width", ApiClient.ParameterToString(width)); // query parameter
            if (height != null) localVarQueryParams.Add("Height", ApiClient.ParameterToString(height)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextRectsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextRectsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextRectsResponse)));
        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        public TextItemsResponse GetPageTextItems (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = GetPageTextItemsWithHttpInfo(name, pageNumber, withEmpty, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        public ApiResponse< TextItemsResponse > GetPageTextItemsWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageTextItems");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageTextItems");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/textItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageTextItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        public async System.Threading.Tasks.Task<TextItemsResponse> GetPageTextItemsAsync (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = await GetPageTextItemsAsyncWithHttpInfo(name, pageNumber, withEmpty, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read page text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetPageTextItemsAsyncWithHttpInfo (string name, int? pageNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPageTextItems");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetPageTextItems");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/textItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPageTextItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read document pages info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>DocumentPagesResponse</returns>
        public DocumentPagesResponse GetPages (string name, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPagesResponse> localVarResponse = GetPagesWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document pages info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentPagesResponse</returns>
        public ApiResponse< DocumentPagesResponse > GetPagesWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPages");

            var localVarPath = "/pdf/{name}/pages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPagesResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPagesResponse)));
        }

        /// <summary>
        /// Read document pages info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of DocumentPagesResponse</returns>
        public async System.Threading.Tasks.Task<DocumentPagesResponse> GetPagesAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPagesResponse> localVarResponse = await GetPagesAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document pages info. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPagesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentPagesResponse>> GetPagesAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetPages");

            var localVarPath = "/pdf/{name}/pages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPagesResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPagesResponse)));
        }

        /// <summary>
        /// Read segment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemResponse</returns>
        public TextItemResponse GetSegment (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
             ApiResponse<TextItemResponse> localVarResponse = GetSegmentWithHttpInfo(name, pageNumber, fragmentNumber, segmentNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read segment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemResponse</returns>
        public ApiResponse< TextItemResponse > GetSegmentWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetSegment");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetSegment");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetSegment");
            // verify the required parameter 'segmentNumber' is set
            if (segmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'segmentNumber' when calling PdfApi->GetSegment");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments/{segmentNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (segmentNumber != null) localVarPathParams.Add("segmentNumber", ApiClient.ParameterToString(segmentNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSegment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemResponse)));
        }

        /// <summary>
        /// Read segment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemResponse</returns>
        public async System.Threading.Tasks.Task<TextItemResponse> GetSegmentAsync (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
             ApiResponse<TextItemResponse> localVarResponse = await GetSegmentAsyncWithHttpInfo(name, pageNumber, fragmentNumber, segmentNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read segment. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextItemResponse>> GetSegmentAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetSegment");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetSegment");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetSegment");
            // verify the required parameter 'segmentNumber' is set
            if (segmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'segmentNumber' when calling PdfApi->GetSegment");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments/{segmentNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (segmentNumber != null) localVarPathParams.Add("segmentNumber", ApiClient.ParameterToString(segmentNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSegment", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemResponse)));
        }

        /// <summary>
        /// Read segment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextFormatResponse</returns>
        public TextFormatResponse GetSegmentTextFormat (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
             ApiResponse<TextFormatResponse> localVarResponse = GetSegmentTextFormatWithHttpInfo(name, pageNumber, fragmentNumber, segmentNumber, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read segment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextFormatResponse</returns>
        public ApiResponse< TextFormatResponse > GetSegmentTextFormatWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetSegmentTextFormat");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetSegmentTextFormat");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetSegmentTextFormat");
            // verify the required parameter 'segmentNumber' is set
            if (segmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'segmentNumber' when calling PdfApi->GetSegmentTextFormat");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments/{segmentNumber}/textformat";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (segmentNumber != null) localVarPathParams.Add("segmentNumber", ApiClient.ParameterToString(segmentNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSegmentTextFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextFormatResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextFormatResponse) ApiClient.Deserialize(localVarResponse, typeof(TextFormatResponse)));
        }

        /// <summary>
        /// Read segment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextFormatResponse</returns>
        public async System.Threading.Tasks.Task<TextFormatResponse> GetSegmentTextFormatAsync (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
             ApiResponse<TextFormatResponse> localVarResponse = await GetSegmentTextFormatAsyncWithHttpInfo(name, pageNumber, fragmentNumber, segmentNumber, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read segment text format. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="segmentNumber"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextFormatResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextFormatResponse>> GetSegmentTextFormatAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, int? segmentNumber, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetSegmentTextFormat");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetSegmentTextFormat");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetSegmentTextFormat");
            // verify the required parameter 'segmentNumber' is set
            if (segmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'segmentNumber' when calling PdfApi->GetSegmentTextFormat");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments/{segmentNumber}/textformat";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (segmentNumber != null) localVarPathParams.Add("segmentNumber", ApiClient.ParameterToString(segmentNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSegmentTextFormat", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextFormatResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextFormatResponse) ApiClient.Deserialize(localVarResponse, typeof(TextFormatResponse)));
        }

        /// <summary>
        /// Read fragment segments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        public TextItemsResponse GetSegments (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = GetSegmentsWithHttpInfo(name, pageNumber, fragmentNumber, withEmpty, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read fragment segments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        public ApiResponse< TextItemsResponse > GetSegmentsWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetSegments");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetSegments");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetSegments");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSegments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read fragment segments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        public async System.Threading.Tasks.Task<TextItemsResponse> GetSegmentsAsync (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = await GetSegmentsAsyncWithHttpInfo(name, pageNumber, fragmentNumber, withEmpty, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read fragment segments. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="fragmentNumber"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetSegmentsAsyncWithHttpInfo (string name, int? pageNumber, int? fragmentNumber, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetSegments");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->GetSegments");
            // verify the required parameter 'fragmentNumber' is set
            if (fragmentNumber == null)
                throw new ApiException(400, "Missing required parameter 'fragmentNumber' when calling PdfApi->GetSegments");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/fragments/{fragmentNumber}/segments";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (fragmentNumber != null) localVarPathParams.Add("fragmentNumber", ApiClient.ParameterToString(fragmentNumber)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSegments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read document text. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextRectsResponse</returns>
        public TextRectsResponse GetText (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
             ApiResponse<TextRectsResponse> localVarResponse = GetTextWithHttpInfo(name, X, Y, width, height, format, regex, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document text. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextRectsResponse</returns>
        public ApiResponse< TextRectsResponse > GetTextWithHttpInfo (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetText");
            // verify the required parameter 'X' is set
            if (X == null)
                throw new ApiException(400, "Missing required parameter 'X' when calling PdfApi->GetText");
            // verify the required parameter 'Y' is set
            if (Y == null)
                throw new ApiException(400, "Missing required parameter 'Y' when calling PdfApi->GetText");
            // verify the required parameter 'width' is set
            if (width == null)
                throw new ApiException(400, "Missing required parameter 'width' when calling PdfApi->GetText");
            // verify the required parameter 'height' is set
            if (height == null)
                throw new ApiException(400, "Missing required parameter 'height' when calling PdfApi->GetText");

            var localVarPath = "/pdf/{name}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (regex != null) localVarQueryParams.Add("regex", ApiClient.ParameterToString(regex)); // query parameter
            if (X != null) localVarQueryParams.Add("X", ApiClient.ParameterToString(X)); // query parameter
            if (Y != null) localVarQueryParams.Add("Y", ApiClient.ParameterToString(Y)); // query parameter
            if (width != null) localVarQueryParams.Add("Width", ApiClient.ParameterToString(width)); // query parameter
            if (height != null) localVarQueryParams.Add("Height", ApiClient.ParameterToString(height)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextRectsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextRectsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextRectsResponse)));
        }

        /// <summary>
        /// Read document text. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextRectsResponse</returns>
        public async System.Threading.Tasks.Task<TextRectsResponse> GetTextAsync (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
             ApiResponse<TextRectsResponse> localVarResponse = await GetTextAsyncWithHttpInfo(name, X, Y, width, height, format, regex, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document text. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="format"> (optional)</param>
        /// <param name="regex"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextRectsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextRectsResponse>> GetTextAsyncWithHttpInfo (string name, int? X, int? Y, int? width, int? height, List<string> format = null, string regex = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetText");
            // verify the required parameter 'X' is set
            if (X == null)
                throw new ApiException(400, "Missing required parameter 'X' when calling PdfApi->GetText");
            // verify the required parameter 'Y' is set
            if (Y == null)
                throw new ApiException(400, "Missing required parameter 'Y' when calling PdfApi->GetText");
            // verify the required parameter 'width' is set
            if (width == null)
                throw new ApiException(400, "Missing required parameter 'width' when calling PdfApi->GetText");
            // verify the required parameter 'height' is set
            if (height == null)
                throw new ApiException(400, "Missing required parameter 'height' when calling PdfApi->GetText");

            var localVarPath = "/pdf/{name}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (regex != null) localVarQueryParams.Add("regex", ApiClient.ParameterToString(regex)); // query parameter
            if (X != null) localVarQueryParams.Add("X", ApiClient.ParameterToString(X)); // query parameter
            if (Y != null) localVarQueryParams.Add("Y", ApiClient.ParameterToString(Y)); // query parameter
            if (width != null) localVarQueryParams.Add("Width", ApiClient.ParameterToString(width)); // query parameter
            if (height != null) localVarQueryParams.Add("Height", ApiClient.ParameterToString(height)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextRectsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextRectsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextRectsResponse)));
        }

        /// <summary>
        /// Read document text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextItemsResponse</returns>
        public TextItemsResponse GetTextItems (string name, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = GetTextItemsWithHttpInfo(name, withEmpty, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read document text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextItemsResponse</returns>
        public ApiResponse< TextItemsResponse > GetTextItemsWithHttpInfo (string name, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetTextItems");

            var localVarPath = "/pdf/{name}/textItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTextItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Read document text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextItemsResponse</returns>
        public async System.Threading.Tasks.Task<TextItemsResponse> GetTextItemsAsync (string name, string withEmpty = null, string storage = null, string folder = null)
        {
             ApiResponse<TextItemsResponse> localVarResponse = await GetTextItemsAsyncWithHttpInfo(name, withEmpty, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Read document text items. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="withEmpty"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextItemsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextItemsResponse>> GetTextItemsAsyncWithHttpInfo (string name, string withEmpty = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetTextItems");

            var localVarPath = "/pdf/{name}/textItems";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (withEmpty != null) localVarQueryParams.Add("withEmpty", ApiClient.ParameterToString(withEmpty)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetTextItems", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextItemsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextItemsResponse) ApiClient.Deserialize(localVarResponse, typeof(TextItemsResponse)));
        }

        /// <summary>
        /// Get number of words per document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>WordCountResponse</returns>
        public WordCountResponse GetWordsPerPage (string name, string storage = null, string folder = null)
        {
             ApiResponse<WordCountResponse> localVarResponse = GetWordsPerPageWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get number of words per document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of WordCountResponse</returns>
        public ApiResponse< WordCountResponse > GetWordsPerPageWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetWordsPerPage");

            var localVarPath = "/pdf/{name}/pages/wordCount";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWordsPerPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WordCountResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WordCountResponse) ApiClient.Deserialize(localVarResponse, typeof(WordCountResponse)));
        }

        /// <summary>
        /// Get number of words per document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of WordCountResponse</returns>
        public async System.Threading.Tasks.Task<WordCountResponse> GetWordsPerPageAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<WordCountResponse> localVarResponse = await GetWordsPerPageAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get number of words per document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (WordCountResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<WordCountResponse>> GetWordsPerPageAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->GetWordsPerPage");

            var localVarPath = "/pdf/{name}/pages/wordCount";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetWordsPerPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<WordCountResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (WordCountResponse) ApiClient.Deserialize(localVarResponse, typeof(WordCountResponse)));
        }

        /// <summary>
        /// Append document to existing one. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>DocumentResponse</returns>
        public DocumentResponse PostAppendDocument (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = PostAppendDocumentWithHttpInfo(name, appendDocument, appendFile, startPage, endPage, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Append document to existing one. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        public ApiResponse< DocumentResponse > PostAppendDocumentWithHttpInfo (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostAppendDocument");

            var localVarPath = "/pdf/{name}/appendDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (appendFile != null) localVarQueryParams.Add("appendFile", ApiClient.ParameterToString(appendFile)); // query parameter
            if (startPage != null) localVarQueryParams.Add("startPage", ApiClient.ParameterToString(startPage)); // query parameter
            if (endPage != null) localVarQueryParams.Add("endPage", ApiClient.ParameterToString(endPage)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (appendDocument != null && appendDocument.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(appendDocument); // http body (model) parameter
            }
            else
            {
                localVarPostBody = appendDocument; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostAppendDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Append document to existing one. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>Task of DocumentResponse</returns>
        public async System.Threading.Tasks.Task<DocumentResponse> PostAppendDocumentAsync (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = await PostAppendDocumentAsyncWithHttpInfo(name, appendDocument, appendFile, startPage, endPage, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Append document to existing one. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The original document name.</param>
        /// <param name="appendDocument">with the append document data. (optional)</param>
        /// <param name="appendFile">Append file server path. (optional)</param>
        /// <param name="startPage">Appending start page. (optional, default to 0)</param>
        /// <param name="endPage">Appending end page. (optional, default to 0)</param>
        /// <param name="storage">The documents storage. (optional)</param>
        /// <param name="folder">The original document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PostAppendDocumentAsyncWithHttpInfo (string name, AppendDocument appendDocument = null, string appendFile = null, int? startPage = null, int? endPage = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostAppendDocument");

            var localVarPath = "/pdf/{name}/appendDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (appendFile != null) localVarQueryParams.Add("appendFile", ApiClient.ParameterToString(appendFile)); // query parameter
            if (startPage != null) localVarQueryParams.Add("startPage", ApiClient.ParameterToString(startPage)); // query parameter
            if (endPage != null) localVarQueryParams.Add("endPage", ApiClient.ParameterToString(endPage)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (appendDocument != null && appendDocument.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(appendDocument); // http body (model) parameter
            }
            else
            {
                localVarPostBody = appendDocument; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostAppendDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Create field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PostCreateField (string name, int? page, Field field = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PostCreateFieldWithHttpInfo(name, page, field, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PostCreateFieldWithHttpInfo (string name, int? page, Field field = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostCreateField");
            // verify the required parameter 'page' is set
            if (page == null)
                throw new ApiException(400, "Missing required parameter 'page' when calling PdfApi->PostCreateField");

            var localVarPath = "/pdf/{name}/fields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (page != null) localVarQueryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (field != null && field.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(field); // http body (model) parameter
            }
            else
            {
                localVarPostBody = field; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostCreateField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Create field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PostCreateFieldAsync (string name, int? page, Field field = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PostCreateFieldAsyncWithHttpInfo(name, page, field, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="page">Document page number.</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostCreateFieldAsyncWithHttpInfo (string name, int? page, Field field = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostCreateField");
            // verify the required parameter 'page' is set
            if (page == null)
                throw new ApiException(400, "Missing required parameter 'page' when calling PdfApi->PostCreateField");

            var localVarPath = "/pdf/{name}/fields";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (page != null) localVarQueryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (field != null && field.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(field); // http body (model) parameter
            }
            else
            {
                localVarPostBody = field; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostCreateField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentTextReplaceResponse</returns>
        public DocumentTextReplaceResponse PostDocumentReplaceText (string name, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
             ApiResponse<DocumentTextReplaceResponse> localVarResponse = PostDocumentReplaceTextWithHttpInfo(name, textReplace, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentTextReplaceResponse</returns>
        public ApiResponse< DocumentTextReplaceResponse > PostDocumentReplaceTextWithHttpInfo (string name, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostDocumentReplaceText");
            // verify the required parameter 'textReplace' is set
            if (textReplace == null)
                throw new ApiException(400, "Missing required parameter 'textReplace' when calling PdfApi->PostDocumentReplaceText");

            var localVarPath = "/pdf/{name}/replaceText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplace != null && textReplace.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplace); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplace; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostDocumentReplaceText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentTextReplaceResponse)));
        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentTextReplaceResponse</returns>
        public async System.Threading.Tasks.Task<DocumentTextReplaceResponse> PostDocumentReplaceTextAsync (string name, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
             ApiResponse<DocumentTextReplaceResponse> localVarResponse = await PostDocumentReplaceTextAsyncWithHttpInfo(name, textReplace, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentTextReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentTextReplaceResponse>> PostDocumentReplaceTextAsyncWithHttpInfo (string name, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostDocumentReplaceText");
            // verify the required parameter 'textReplace' is set
            if (textReplace == null)
                throw new ApiException(400, "Missing required parameter 'textReplace' when calling PdfApi->PostDocumentReplaceText");

            var localVarPath = "/pdf/{name}/replaceText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplace != null && textReplace.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplace); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplace; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostDocumentReplaceText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentTextReplaceResponse)));
        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentTextReplaceResponse</returns>
        public DocumentTextReplaceResponse PostDocumentReplaceTextList (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
             ApiResponse<DocumentTextReplaceResponse> localVarResponse = PostDocumentReplaceTextListWithHttpInfo(name, textReplaceListRequest, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentTextReplaceResponse</returns>
        public ApiResponse< DocumentTextReplaceResponse > PostDocumentReplaceTextListWithHttpInfo (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostDocumentReplaceTextList");
            // verify the required parameter 'textReplaceListRequest' is set
            if (textReplaceListRequest == null)
                throw new ApiException(400, "Missing required parameter 'textReplaceListRequest' when calling PdfApi->PostDocumentReplaceTextList");

            var localVarPath = "/pdf/{name}/replaceTextList";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplaceListRequest != null && textReplaceListRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplaceListRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplaceListRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostDocumentReplaceTextList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentTextReplaceResponse)));
        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentTextReplaceResponse</returns>
        public async System.Threading.Tasks.Task<DocumentTextReplaceResponse> PostDocumentReplaceTextListAsync (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
             ApiResponse<DocumentTextReplaceResponse> localVarResponse = await PostDocumentReplaceTextListAsyncWithHttpInfo(name, textReplaceListRequest, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Document&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentTextReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentTextReplaceResponse>> PostDocumentReplaceTextListAsyncWithHttpInfo (string name, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostDocumentReplaceTextList");
            // verify the required parameter 'textReplaceListRequest' is set
            if (textReplaceListRequest == null)
                throw new ApiException(400, "Missing required parameter 'textReplaceListRequest' when calling PdfApi->PostDocumentReplaceTextList");

            var localVarPath = "/pdf/{name}/replaceTextList";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplaceListRequest != null && textReplaceListRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplaceListRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplaceListRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostDocumentReplaceTextList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentTextReplaceResponse)));
        }

        /// <summary>
        /// Document&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextReplaceResponse</returns>
        public TextReplaceResponse PostDocumentTextReplace (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null)
        {
             ApiResponse<TextReplaceResponse> localVarResponse = PostDocumentTextReplaceWithHttpInfo(name, textReplace, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Document&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextReplaceResponse</returns>
        public ApiResponse< TextReplaceResponse > PostDocumentTextReplaceWithHttpInfo (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostDocumentTextReplace");
            // verify the required parameter 'textReplace' is set
            if (textReplace == null)
                throw new ApiException(400, "Missing required parameter 'textReplace' when calling PdfApi->PostDocumentTextReplace");

            var localVarPath = "/pdf/{name}/text/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplace != null && textReplace.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplace); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplace; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostDocumentTextReplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(TextReplaceResponse)));
        }

        /// <summary>
        /// Document&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextReplaceResponse</returns>
        public async System.Threading.Tasks.Task<TextReplaceResponse> PostDocumentTextReplaceAsync (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null)
        {
             ApiResponse<TextReplaceResponse> localVarResponse = await PostDocumentTextReplaceAsyncWithHttpInfo(name, textReplace, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Document&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextReplaceResponse>> PostDocumentTextReplaceAsyncWithHttpInfo (string name, TextReplaceListRequest textReplace, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostDocumentTextReplace");
            // verify the required parameter 'textReplace' is set
            if (textReplace == null)
                throw new ApiException(400, "Missing required parameter 'textReplace' when calling PdfApi->PostDocumentTextReplace");

            var localVarPath = "/pdf/{name}/text/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplace != null && textReplace.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplace); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplace; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostDocumentTextReplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(TextReplaceResponse)));
        }

        /// <summary>
        /// Move page to new position. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PostMovePage (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PostMovePageWithHttpInfo(name, pageNumber, newIndex, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Move page to new position. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PostMovePageWithHttpInfo (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostMovePage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostMovePage");
            // verify the required parameter 'newIndex' is set
            if (newIndex == null)
                throw new ApiException(400, "Missing required parameter 'newIndex' when calling PdfApi->PostMovePage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/movePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (newIndex != null) localVarQueryParams.Add("newIndex", ApiClient.ParameterToString(newIndex)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostMovePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Move page to new position. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PostMovePageAsync (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PostMovePageAsyncWithHttpInfo(name, pageNumber, newIndex, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Move page to new position. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="newIndex">The new page position/index.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostMovePageAsyncWithHttpInfo (string name, int? pageNumber, int? newIndex, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostMovePage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostMovePage");
            // verify the required parameter 'newIndex' is set
            if (newIndex == null)
                throw new ApiException(400, "Missing required parameter 'newIndex' when calling PdfApi->PostMovePage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/movePage";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (newIndex != null) localVarQueryParams.Add("newIndex", ApiClient.ParameterToString(newIndex)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostMovePage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Optimize document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PostOptimizeDocument (string name, OptimizeOptions options = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PostOptimizeDocumentWithHttpInfo(name, options, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Optimize document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PostOptimizeDocumentWithHttpInfo (string name, OptimizeOptions options = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostOptimizeDocument");

            var localVarPath = "/pdf/{name}/optimize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (options != null && options.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(options); // http body (model) parameter
            }
            else
            {
                localVarPostBody = options; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostOptimizeDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Optimize document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PostOptimizeDocumentAsync (string name, OptimizeOptions options = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PostOptimizeDocumentAsyncWithHttpInfo(name, options, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Optimize document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="options">The optimization options. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostOptimizeDocumentAsyncWithHttpInfo (string name, OptimizeOptions options = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostOptimizeDocument");

            var localVarPath = "/pdf/{name}/optimize";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (options != null && options.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(options); // http body (model) parameter
            }
            else
            {
                localVarPostBody = options; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostOptimizeDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>PageTextReplaceResponse</returns>
        public PageTextReplaceResponse PostPageReplaceText (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
             ApiResponse<PageTextReplaceResponse> localVarResponse = PostPageReplaceTextWithHttpInfo(name, pageNumber, textReplace, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of PageTextReplaceResponse</returns>
        public ApiResponse< PageTextReplaceResponse > PostPageReplaceTextWithHttpInfo (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostPageReplaceText");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostPageReplaceText");
            // verify the required parameter 'textReplace' is set
            if (textReplace == null)
                throw new ApiException(400, "Missing required parameter 'textReplace' when calling PdfApi->PostPageReplaceText");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/replaceText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplace != null && textReplace.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplace); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplace; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostPageReplaceText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(PageTextReplaceResponse)));
        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of PageTextReplaceResponse</returns>
        public async System.Threading.Tasks.Task<PageTextReplaceResponse> PostPageReplaceTextAsync (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
             ApiResponse<PageTextReplaceResponse> localVarResponse = await PostPageReplaceTextAsyncWithHttpInfo(name, pageNumber, textReplace, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplace"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (PageTextReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTextReplaceResponse>> PostPageReplaceTextAsyncWithHttpInfo (string name, int? pageNumber, TextReplaceRequest textReplace, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostPageReplaceText");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostPageReplaceText");
            // verify the required parameter 'textReplace' is set
            if (textReplace == null)
                throw new ApiException(400, "Missing required parameter 'textReplace' when calling PdfApi->PostPageReplaceText");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/replaceText";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplace != null && textReplace.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplace); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplace; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostPageReplaceText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(PageTextReplaceResponse)));
        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>PageTextReplaceResponse</returns>
        public PageTextReplaceResponse PostPageReplaceTextList (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
             ApiResponse<PageTextReplaceResponse> localVarResponse = PostPageReplaceTextListWithHttpInfo(name, pageNumber, textReplaceListRequest, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of PageTextReplaceResponse</returns>
        public ApiResponse< PageTextReplaceResponse > PostPageReplaceTextListWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostPageReplaceTextList");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostPageReplaceTextList");
            // verify the required parameter 'textReplaceListRequest' is set
            if (textReplaceListRequest == null)
                throw new ApiException(400, "Missing required parameter 'textReplaceListRequest' when calling PdfApi->PostPageReplaceTextList");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/replaceTextList";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplaceListRequest != null && textReplaceListRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplaceListRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplaceListRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostPageReplaceTextList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(PageTextReplaceResponse)));
        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of PageTextReplaceResponse</returns>
        public async System.Threading.Tasks.Task<PageTextReplaceResponse> PostPageReplaceTextListAsync (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
             ApiResponse<PageTextReplaceResponse> localVarResponse = await PostPageReplaceTextListAsyncWithHttpInfo(name, pageNumber, textReplaceListRequest, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Page&#39;s replace text method. Deprecated 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (PageTextReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PageTextReplaceResponse>> PostPageReplaceTextListAsyncWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostPageReplaceTextList");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostPageReplaceTextList");
            // verify the required parameter 'textReplaceListRequest' is set
            if (textReplaceListRequest == null)
                throw new ApiException(400, "Missing required parameter 'textReplaceListRequest' when calling PdfApi->PostPageReplaceTextList");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/replaceTextList";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplaceListRequest != null && textReplaceListRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplaceListRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplaceListRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostPageReplaceTextList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PageTextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PageTextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(PageTextReplaceResponse)));
        }

        /// <summary>
        /// Page&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>TextReplaceResponse</returns>
        public TextReplaceResponse PostPageTextReplace (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
             ApiResponse<TextReplaceResponse> localVarResponse = PostPageTextReplaceWithHttpInfo(name, pageNumber, textReplaceListRequest, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Page&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of TextReplaceResponse</returns>
        public ApiResponse< TextReplaceResponse > PostPageTextReplaceWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostPageTextReplace");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostPageTextReplace");
            // verify the required parameter 'textReplaceListRequest' is set
            if (textReplaceListRequest == null)
                throw new ApiException(400, "Missing required parameter 'textReplaceListRequest' when calling PdfApi->PostPageTextReplace");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/text/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplaceListRequest != null && textReplaceListRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplaceListRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplaceListRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostPageTextReplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(TextReplaceResponse)));
        }

        /// <summary>
        /// Page&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of TextReplaceResponse</returns>
        public async System.Threading.Tasks.Task<TextReplaceResponse> PostPageTextReplaceAsync (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
             ApiResponse<TextReplaceResponse> localVarResponse = await PostPageTextReplaceAsyncWithHttpInfo(name, pageNumber, textReplaceListRequest, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Page&#39;s replace text method. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="pageNumber"></param>
        /// <param name="textReplaceListRequest"></param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (TextReplaceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TextReplaceResponse>> PostPageTextReplaceAsyncWithHttpInfo (string name, int? pageNumber, TextReplaceListRequest textReplaceListRequest, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostPageTextReplace");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostPageTextReplace");
            // verify the required parameter 'textReplaceListRequest' is set
            if (textReplaceListRequest == null)
                throw new ApiException(400, "Missing required parameter 'textReplaceListRequest' when calling PdfApi->PostPageTextReplace");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/text/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (textReplaceListRequest != null && textReplaceListRequest.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(textReplaceListRequest); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textReplaceListRequest; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostPageTextReplace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TextReplaceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TextReplaceResponse) ApiClient.Deserialize(localVarResponse, typeof(TextReplaceResponse)));
        }

        /// <summary>
        /// Replace document image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ImageResponse</returns>
        public ImageResponse PostReplaceImage (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null)
        {
             ApiResponse<ImageResponse> localVarResponse = PostReplaceImageWithHttpInfo(name, pageNumber, imageNumber, imageFile, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Replace document image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of ImageResponse</returns>
        public ApiResponse< ImageResponse > PostReplaceImageWithHttpInfo (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostReplaceImage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostReplaceImage");
            // verify the required parameter 'imageNumber' is set
            if (imageNumber == null)
                throw new ApiException(400, "Missing required parameter 'imageNumber' when calling PdfApi->PostReplaceImage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (imageNumber != null) localVarPathParams.Add("imageNumber", ApiClient.ParameterToString(imageNumber)); // path parameter
            if (imageFile != null) localVarQueryParams.Add("imageFile", ApiClient.ParameterToString(imageFile)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostReplaceImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageResponse) ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Replace document image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ImageResponse</returns>
        public async System.Threading.Tasks.Task<ImageResponse> PostReplaceImageAsync (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null)
        {
             ApiResponse<ImageResponse> localVarResponse = await PostReplaceImageAsyncWithHttpInfo(name, pageNumber, imageNumber, imageFile, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Replace document image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="imageNumber">The image number.</param>
        /// <param name="imageFile">Path to image file if specified. Request content is used otherwise. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageResponse>> PostReplaceImageAsyncWithHttpInfo (string name, int? pageNumber, int? imageNumber, string imageFile = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostReplaceImage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostReplaceImage");
            // verify the required parameter 'imageNumber' is set
            if (imageNumber == null)
                throw new ApiException(400, "Missing required parameter 'imageNumber' when calling PdfApi->PostReplaceImage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/images/{imageNumber}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (imageNumber != null) localVarPathParams.Add("imageNumber", ApiClient.ParameterToString(imageNumber)); // path parameter
            if (imageFile != null) localVarQueryParams.Add("imageFile", ApiClient.ParameterToString(imageFile)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostReplaceImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ImageResponse) ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Sign document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PostSignDocument (string name, Signature signature = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PostSignDocumentWithHttpInfo(name, signature, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sign document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PostSignDocumentWithHttpInfo (string name, Signature signature = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostSignDocument");

            var localVarPath = "/pdf/{name}/sign";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (signature != null && signature.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(signature); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signature; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSignDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Sign document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PostSignDocumentAsync (string name, Signature signature = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PostSignDocumentAsyncWithHttpInfo(name, signature, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sign document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostSignDocumentAsyncWithHttpInfo (string name, Signature signature = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostSignDocument");

            var localVarPath = "/pdf/{name}/sign";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (signature != null && signature.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(signature); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signature; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSignDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Sign page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PostSignPage (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PostSignPageWithHttpInfo(name, pageNumber, signature, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Sign page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PostSignPageWithHttpInfo (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostSignPage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostSignPage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/sign";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (signature != null && signature.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(signature); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signature; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSignPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Sign page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PostSignPageAsync (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PostSignPageAsyncWithHttpInfo(name, pageNumber, signature, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Sign page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="signature">Signature object containing signature data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PostSignPageAsyncWithHttpInfo (string name, int? pageNumber, Signature signature = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostSignPage");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PostSignPage");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/sign";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (signature != null && signature.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(signature); // http body (model) parameter
            }
            else
            {
                localVarPostBody = signature; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSignPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Split document to parts. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SplitResultResponse</returns>
        public SplitResultResponse PostSplitDocument (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null)
        {
             ApiResponse<SplitResultResponse> localVarResponse = PostSplitDocumentWithHttpInfo(name, format, from, to, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Split document to parts. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SplitResultResponse</returns>
        public ApiResponse< SplitResultResponse > PostSplitDocumentWithHttpInfo (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostSplitDocument");

            var localVarPath = "/pdf/{name}/split";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (from != null) localVarQueryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
            if (to != null) localVarQueryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSplitDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SplitResultResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SplitResultResponse) ApiClient.Deserialize(localVarResponse, typeof(SplitResultResponse)));
        }

        /// <summary>
        /// Split document to parts. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SplitResultResponse</returns>
        public async System.Threading.Tasks.Task<SplitResultResponse> PostSplitDocumentAsync (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null)
        {
             ApiResponse<SplitResultResponse> localVarResponse = await PostSplitDocumentAsyncWithHttpInfo(name, format, from, to, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Split document to parts. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Document name.</param>
        /// <param name="format">Resulting documents format. (optional)</param>
        /// <param name="from">Start page if defined. (optional)</param>
        /// <param name="to">End page if defined. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SplitResultResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SplitResultResponse>> PostSplitDocumentAsyncWithHttpInfo (string name, string format = null, int? from = null, int? to = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PostSplitDocument");

            var localVarPath = "/pdf/{name}/split";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (from != null) localVarQueryParams.Add("from", ApiClient.ParameterToString(from)); // query parameter
            if (to != null) localVarQueryParams.Add("to", ApiClient.ParameterToString(to)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PostSplitDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SplitResultResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SplitResultResponse) ApiClient.Deserialize(localVarResponse, typeof(SplitResultResponse)));
        }

        /// <summary>
        /// Add new page to end of the document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>DocumentPagesResponse</returns>
        public DocumentPagesResponse PutAddNewPage (string name, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPagesResponse> localVarResponse = PutAddNewPageWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add new page to end of the document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentPagesResponse</returns>
        public ApiResponse< DocumentPagesResponse > PutAddNewPageWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutAddNewPage");

            var localVarPath = "/pdf/{name}/pages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutAddNewPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPagesResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPagesResponse)));
        }

        /// <summary>
        /// Add new page to end of the document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of DocumentPagesResponse</returns>
        public async System.Threading.Tasks.Task<DocumentPagesResponse> PutAddNewPageAsync (string name, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPagesResponse> localVarResponse = await PutAddNewPageAsyncWithHttpInfo(name, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add new page to end of the document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPagesResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentPagesResponse>> PutAddNewPageAsyncWithHttpInfo (string name, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutAddNewPage");

            var localVarPath = "/pdf/{name}/pages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutAddNewPage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPagesResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPagesResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPagesResponse)));
        }

        /// <summary>
        /// Add text to PDF document page. Deprecate 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PutAddParagraph (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PutAddParagraphWithHttpInfo(name, pageNumber, paragraph, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add text to PDF document page. Deprecate 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PutAddParagraphWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutAddParagraph");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PutAddParagraph");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/paragraph";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (paragraph != null && paragraph.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(paragraph); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paragraph; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutAddParagraph", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Add text to PDF document page. Deprecate 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PutAddParagraphAsync (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PutAddParagraphAsyncWithHttpInfo(name, pageNumber, paragraph, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add text to PDF document page. Deprecate 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutAddParagraphAsyncWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutAddParagraph");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PutAddParagraph");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/paragraph";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (paragraph != null && paragraph.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(paragraph); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paragraph; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutAddParagraph", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Add text to PDF document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PutAddText (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PutAddTextWithHttpInfo(name, pageNumber, paragraph, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add text to PDF document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PutAddTextWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutAddText");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PutAddText");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (paragraph != null && paragraph.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(paragraph); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paragraph; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutAddText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Add text to PDF document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PutAddTextAsync (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PutAddTextAsyncWithHttpInfo(name, pageNumber, paragraph, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add text to PDF document page. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the document to which text should be added.</param>
        /// <param name="pageNumber">Number of page (starting with 1) to which text should be added.</param>
        /// <param name="paragraph">Paragraph data. (optional)</param>
        /// <param name="storage">File storage to be used. (optional)</param>
        /// <param name="folder">Document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutAddTextAsyncWithHttpInfo (string name, int? pageNumber, Paragraph paragraph = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutAddText");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PutAddText");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (paragraph != null && paragraph.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(paragraph); // http body (model) parameter
            }
            else
            {
                localVarPostBody = paragraph; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutAddText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Convert document from request content to format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream PutConvertDocument (string format = null, string url = null, string outPath = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = PutConvertDocumentWithHttpInfo(format, url, outPath);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Convert document from request content to format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > PutConvertDocumentWithHttpInfo (string format = null, string url = null, string outPath = null)
        {

            var localVarPath = "/pdf/convert";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (url != null) localVarQueryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (outPath != null) localVarQueryParams.Add("outPath", ApiClient.ParameterToString(outPath)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutConvertDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Convert document from request content to format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> PutConvertDocumentAsync (string format = null, string url = null, string outPath = null)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await PutConvertDocumentAsyncWithHttpInfo(format, url, outPath);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Convert document from request content to format specified. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="format">The format to convert. (optional)</param>
        /// <param name="url"> (optional)</param>
        /// <param name="outPath">Path to save result (optional)</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> PutConvertDocumentAsyncWithHttpInfo (string format = null, string url = null, string outPath = null)
        {

            var localVarPath = "/pdf/convert";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "multipart/form-data"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (format != null) localVarQueryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (url != null) localVarQueryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (outPath != null) localVarQueryParams.Add("outPath", ApiClient.ParameterToString(outPath)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutConvertDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Create new document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>DocumentResponse</returns>
        public DocumentResponse PutCreateDocument (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = PutCreateDocumentWithHttpInfo(name, templateFile, dataFile, templateType, storage, folder, url, fitSize);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        public ApiResponse< DocumentResponse > PutCreateDocumentWithHttpInfo (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutCreateDocument");

            var localVarPath = "/pdf/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (templateFile != null) localVarQueryParams.Add("templateFile", ApiClient.ParameterToString(templateFile)); // query parameter
            if (dataFile != null) localVarQueryParams.Add("dataFile", ApiClient.ParameterToString(dataFile)); // query parameter
            if (templateType != null) localVarQueryParams.Add("templateType", ApiClient.ParameterToString(templateType)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (url != null) localVarQueryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (fitSize != null) localVarQueryParams.Add("fitSize", ApiClient.ParameterToString(fitSize)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutCreateDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Create new document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>Task of DocumentResponse</returns>
        public async System.Threading.Tasks.Task<DocumentResponse> PutCreateDocumentAsync (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = await PutCreateDocumentAsyncWithHttpInfo(name, templateFile, dataFile, templateType, storage, folder, url, fitSize);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="templateFile">The template file server path if defined. (optional)</param>
        /// <param name="dataFile">The data file path (for xml template only). (optional)</param>
        /// <param name="templateType">The template type, can be xml, html, bmp, jpg, png, tiff, emf, cgm, tex. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <param name="url">The url of web page if defined. (optional)</param>
        /// <param name="fitSize">Draw a margin around content in resulting pdf. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PutCreateDocumentAsyncWithHttpInfo (string name, string templateFile = null, string dataFile = null, string templateType = null, string storage = null, string folder = null, string url = null, bool? fitSize = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutCreateDocument");

            var localVarPath = "/pdf/{name}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (templateFile != null) localVarQueryParams.Add("templateFile", ApiClient.ParameterToString(templateFile)); // query parameter
            if (dataFile != null) localVarQueryParams.Add("dataFile", ApiClient.ParameterToString(dataFile)); // query parameter
            if (templateType != null) localVarQueryParams.Add("templateType", ApiClient.ParameterToString(templateType)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (url != null) localVarQueryParams.Add("url", ApiClient.ParameterToString(url)); // query parameter
            if (fitSize != null) localVarQueryParams.Add("fitSize", ApiClient.ParameterToString(fitSize)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutCreateDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Create new document from images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>DocumentResponse</returns>
        public DocumentResponse PutCreateDocumentFromImages (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = PutCreateDocumentFromImagesWithHttpInfo(name, images, ocr, ocrLang, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create new document from images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        public ApiResponse< DocumentResponse > PutCreateDocumentFromImagesWithHttpInfo (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutCreateDocumentFromImages");

            var localVarPath = "/pdf/{name}/fromimages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (ocr != null) localVarQueryParams.Add("ocr", ApiClient.ParameterToString(ocr)); // query parameter
            if (ocrLang != null) localVarQueryParams.Add("ocrLang", ApiClient.ParameterToString(ocrLang)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (images != null && images.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(images); // http body (model) parameter
            }
            else
            {
                localVarPostBody = images; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutCreateDocumentFromImages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Create new document from images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>Task of DocumentResponse</returns>
        public async System.Threading.Tasks.Task<DocumentResponse> PutCreateDocumentFromImagesAsync (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = await PutCreateDocumentFromImagesAsyncWithHttpInfo(name, images, ocr, ocrLang, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create new document from images. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The new document name.</param>
        /// <param name="images">The images file paths set.   (optional)</param>
        /// <param name="ocr">To create OCR layer for image or not. (optional, default to false)</param>
        /// <param name="ocrLang">The language which is defined for OCR engine. Default is eng. (optional, default to eng)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The new document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PutCreateDocumentFromImagesAsyncWithHttpInfo (string name, ImagesListRequest images = null, bool? ocr = null, string ocrLang = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutCreateDocumentFromImages");

            var localVarPath = "/pdf/{name}/fromimages";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (ocr != null) localVarQueryParams.Add("ocr", ApiClient.ParameterToString(ocr)); // query parameter
            if (ocrLang != null) localVarQueryParams.Add("ocrLang", ApiClient.ParameterToString(ocrLang)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (images != null && images.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(images); // http body (model) parameter
            }
            else
            {
                localVarPostBody = images; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutCreateDocumentFromImages", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Save document as Tiff image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PutDocumentSaveAsTiff (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PutDocumentSaveAsTiffWithHttpInfo(name, exportOptions, resultFile, brightness, compression, colorDepth, leftMargin, rightMargin, topMargin, bottomMargin, orientation, skipBlankPages, width, height, xResolution, yResolution, pageIndex, pageCount, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Save document as Tiff image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PutDocumentSaveAsTiffWithHttpInfo (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutDocumentSaveAsTiff");

            var localVarPath = "/pdf/{name}/SaveAs/tiff";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (resultFile != null) localVarQueryParams.Add("resultFile", ApiClient.ParameterToString(resultFile)); // query parameter
            if (brightness != null) localVarQueryParams.Add("brightness", ApiClient.ParameterToString(brightness)); // query parameter
            if (compression != null) localVarQueryParams.Add("compression", ApiClient.ParameterToString(compression)); // query parameter
            if (colorDepth != null) localVarQueryParams.Add("colorDepth", ApiClient.ParameterToString(colorDepth)); // query parameter
            if (leftMargin != null) localVarQueryParams.Add("leftMargin", ApiClient.ParameterToString(leftMargin)); // query parameter
            if (rightMargin != null) localVarQueryParams.Add("rightMargin", ApiClient.ParameterToString(rightMargin)); // query parameter
            if (topMargin != null) localVarQueryParams.Add("topMargin", ApiClient.ParameterToString(topMargin)); // query parameter
            if (bottomMargin != null) localVarQueryParams.Add("bottomMargin", ApiClient.ParameterToString(bottomMargin)); // query parameter
            if (orientation != null) localVarQueryParams.Add("orientation", ApiClient.ParameterToString(orientation)); // query parameter
            if (skipBlankPages != null) localVarQueryParams.Add("skipBlankPages", ApiClient.ParameterToString(skipBlankPages)); // query parameter
            if (width != null) localVarQueryParams.Add("width", ApiClient.ParameterToString(width)); // query parameter
            if (height != null) localVarQueryParams.Add("height", ApiClient.ParameterToString(height)); // query parameter
            if (xResolution != null) localVarQueryParams.Add("xResolution", ApiClient.ParameterToString(xResolution)); // query parameter
            if (yResolution != null) localVarQueryParams.Add("yResolution", ApiClient.ParameterToString(yResolution)); // query parameter
            if (pageIndex != null) localVarQueryParams.Add("pageIndex", ApiClient.ParameterToString(pageIndex)); // query parameter
            if (pageCount != null) localVarQueryParams.Add("pageCount", ApiClient.ParameterToString(pageCount)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (exportOptions != null && exportOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(exportOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = exportOptions; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutDocumentSaveAsTiff", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Save document as Tiff image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PutDocumentSaveAsTiffAsync (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PutDocumentSaveAsTiffAsyncWithHttpInfo(name, exportOptions, resultFile, brightness, compression, colorDepth, leftMargin, rightMargin, topMargin, bottomMargin, orientation, skipBlankPages, width, height, xResolution, yResolution, pageIndex, pageCount, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Save document as Tiff image. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="exportOptions">with tiff export options. (optional)</param>
        /// <param name="resultFile">The resulting file. (optional)</param>
        /// <param name="brightness">The image brightness. (optional)</param>
        /// <param name="compression">Tiff compression. Possible values are: LZW, CCITT4, CCITT3, RLE, None. (optional)</param>
        /// <param name="colorDepth">Image color depth. Possible valuse are: Default, Format8bpp, Format4bpp, Format1bpp. (optional)</param>
        /// <param name="leftMargin">Left image margin. (optional)</param>
        /// <param name="rightMargin">Right image margin. (optional)</param>
        /// <param name="topMargin">Top image margin. (optional)</param>
        /// <param name="bottomMargin">Bottom image margin. (optional)</param>
        /// <param name="orientation">Image orientation. Possible values are: None, Landscape, Portait. (optional)</param>
        /// <param name="skipBlankPages">Skip blank pages flag. (optional)</param>
        /// <param name="width">Image width. (optional)</param>
        /// <param name="height">Image height. (optional)</param>
        /// <param name="xResolution">Horizontal resolution. (optional)</param>
        /// <param name="yResolution">Vertical resolution. (optional)</param>
        /// <param name="pageIndex">Start page to export. (optional)</param>
        /// <param name="pageCount">Number of pages to export. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutDocumentSaveAsTiffAsyncWithHttpInfo (string name, TiffExportOptions exportOptions = null, string resultFile = null, double? brightness = null, string compression = null, string colorDepth = null, int? leftMargin = null, int? rightMargin = null, int? topMargin = null, int? bottomMargin = null, string orientation = null, bool? skipBlankPages = null, int? width = null, int? height = null, int? xResolution = null, int? yResolution = null, int? pageIndex = null, int? pageCount = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutDocumentSaveAsTiff");

            var localVarPath = "/pdf/{name}/SaveAs/tiff";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (resultFile != null) localVarQueryParams.Add("resultFile", ApiClient.ParameterToString(resultFile)); // query parameter
            if (brightness != null) localVarQueryParams.Add("brightness", ApiClient.ParameterToString(brightness)); // query parameter
            if (compression != null) localVarQueryParams.Add("compression", ApiClient.ParameterToString(compression)); // query parameter
            if (colorDepth != null) localVarQueryParams.Add("colorDepth", ApiClient.ParameterToString(colorDepth)); // query parameter
            if (leftMargin != null) localVarQueryParams.Add("leftMargin", ApiClient.ParameterToString(leftMargin)); // query parameter
            if (rightMargin != null) localVarQueryParams.Add("rightMargin", ApiClient.ParameterToString(rightMargin)); // query parameter
            if (topMargin != null) localVarQueryParams.Add("topMargin", ApiClient.ParameterToString(topMargin)); // query parameter
            if (bottomMargin != null) localVarQueryParams.Add("bottomMargin", ApiClient.ParameterToString(bottomMargin)); // query parameter
            if (orientation != null) localVarQueryParams.Add("orientation", ApiClient.ParameterToString(orientation)); // query parameter
            if (skipBlankPages != null) localVarQueryParams.Add("skipBlankPages", ApiClient.ParameterToString(skipBlankPages)); // query parameter
            if (width != null) localVarQueryParams.Add("width", ApiClient.ParameterToString(width)); // query parameter
            if (height != null) localVarQueryParams.Add("height", ApiClient.ParameterToString(height)); // query parameter
            if (xResolution != null) localVarQueryParams.Add("xResolution", ApiClient.ParameterToString(xResolution)); // query parameter
            if (yResolution != null) localVarQueryParams.Add("yResolution", ApiClient.ParameterToString(yResolution)); // query parameter
            if (pageIndex != null) localVarQueryParams.Add("pageIndex", ApiClient.ParameterToString(pageIndex)); // query parameter
            if (pageCount != null) localVarQueryParams.Add("pageCount", ApiClient.ParameterToString(pageCount)); // query parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (exportOptions != null && exportOptions.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(exportOptions); // http body (model) parameter
            }
            else
            {
                localVarPostBody = exportOptions; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutDocumentSaveAsTiff", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Merge a list of documents. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>DocumentResponse</returns>
        public DocumentResponse PutMergeDocuments (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = PutMergeDocumentsWithHttpInfo(name, mergeDocuments, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Merge a list of documents. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>ApiResponse of DocumentResponse</returns>
        public ApiResponse< DocumentResponse > PutMergeDocumentsWithHttpInfo (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutMergeDocuments");

            var localVarPath = "/pdf/{name}/merge";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (mergeDocuments != null && mergeDocuments.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(mergeDocuments); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mergeDocuments; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutMergeDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Merge a list of documents. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>Task of DocumentResponse</returns>
        public async System.Threading.Tasks.Task<DocumentResponse> PutMergeDocumentsAsync (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentResponse> localVarResponse = await PutMergeDocumentsAsyncWithHttpInfo(name, mergeDocuments, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Merge a list of documents. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Resulting documen name.</param>
        /// <param name="mergeDocuments">with a list of documents. (optional)</param>
        /// <param name="storage">Resulting document storage. (optional)</param>
        /// <param name="folder">Resulting document folder. (optional)</param>
        /// <returns>Task of ApiResponse (DocumentResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentResponse>> PutMergeDocumentsAsyncWithHttpInfo (string name, MergeDocuments mergeDocuments = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutMergeDocuments");

            var localVarPath = "/pdf/{name}/merge";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (mergeDocuments != null && mergeDocuments.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(mergeDocuments); // http body (model) parameter
            }
            else
            {
                localVarPostBody = mergeDocuments; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutMergeDocuments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentResponse)));
        }

        /// <summary>
        /// Add page stamp. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PutPageAddStamp (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PutPageAddStampWithHttpInfo(name, pageNumber, stamp, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add page stamp. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PutPageAddStampWithHttpInfo (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutPageAddStamp");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PutPageAddStamp");
            // verify the required parameter 'stamp' is set
            if (stamp == null)
                throw new ApiException(400, "Missing required parameter 'stamp' when calling PdfApi->PutPageAddStamp");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/stamp";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (stamp != null && stamp.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(stamp); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stamp; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutPageAddStamp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Add page stamp. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PutPageAddStampAsync (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PutPageAddStampAsyncWithHttpInfo(name, pageNumber, stamp, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add page stamp. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="stamp">with data.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutPageAddStampAsyncWithHttpInfo (string name, int? pageNumber, Stamp stamp, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutPageAddStamp");
            // verify the required parameter 'pageNumber' is set
            if (pageNumber == null)
                throw new ApiException(400, "Missing required parameter 'pageNumber' when calling PdfApi->PutPageAddStamp");
            // verify the required parameter 'stamp' is set
            if (stamp == null)
                throw new ApiException(400, "Missing required parameter 'stamp' when calling PdfApi->PutPageAddStamp");

            var localVarPath = "/pdf/{name}/pages/{pageNumber}/stamp";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (pageNumber != null) localVarPathParams.Add("pageNumber", ApiClient.ParameterToString(pageNumber)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (stamp != null && stamp.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(stamp); // http body (model) parameter
            }
            else
            {
                localVarPostBody = stamp; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutPageAddStamp", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>SaaSposeResponse</returns>
        public SaaSposeResponse PutSearchableDocument (string name, string storage = null, string folder = null, string lang = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = PutSearchableDocumentWithHttpInfo(name, storage, folder, lang);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>ApiResponse of SaaSposeResponse</returns>
        public ApiResponse< SaaSposeResponse > PutSearchableDocumentWithHttpInfo (string name, string storage = null, string folder = null, string lang = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutSearchableDocument");

            var localVarPath = "/pdf/{name}/ocr";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (lang != null) localVarQueryParams.Add("lang", ApiClient.ParameterToString(lang)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutSearchableDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>Task of SaaSposeResponse</returns>
        public async System.Threading.Tasks.Task<SaaSposeResponse> PutSearchableDocumentAsync (string name, string storage = null, string folder = null, string lang = null)
        {
             ApiResponse<SaaSposeResponse> localVarResponse = await PutSearchableDocumentAsyncWithHttpInfo(name, storage, folder, lang);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create searchable PDF document. Generate OCR layer for images in input PDF document. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <param name="lang">language for OCR engine. Possible values: eng, ara, bel, ben, bul, ces, dan, deu, ell, fin, fra, heb, hin, ind, isl, ita, jpn, kor, nld, nor, pol, por, ron, rus, spa, swe, tha, tur, ukr, vie, chi_sim, chi_tra or thier combination e.g. eng,rus  (optional)</param>
        /// <returns>Task of ApiResponse (SaaSposeResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SaaSposeResponse>> PutSearchableDocumentAsyncWithHttpInfo (string name, string storage = null, string folder = null, string lang = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutSearchableDocument");

            var localVarPath = "/pdf/{name}/ocr";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (lang != null) localVarQueryParams.Add("lang", ApiClient.ParameterToString(lang)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutSearchableDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SaaSposeResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SaaSposeResponse) ApiClient.Deserialize(localVarResponse, typeof(SaaSposeResponse)));
        }

        /// <summary>
        /// Add/update document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>DocumentPropertyResponse</returns>
        public DocumentPropertyResponse PutSetProperty (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPropertyResponse> localVarResponse = PutSetPropertyWithHttpInfo(name, propertyName, property, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Add/update document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>ApiResponse of DocumentPropertyResponse</returns>
        public ApiResponse< DocumentPropertyResponse > PutSetPropertyWithHttpInfo (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutSetProperty");
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PdfApi->PutSetProperty");

            var localVarPath = "/pdf/{name}/documentproperties/{propertyName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (propertyName != null) localVarPathParams.Add("propertyName", ApiClient.ParameterToString(propertyName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (property != null && property.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(property); // http body (model) parameter
            }
            else
            {
                localVarPostBody = property; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutSetProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPropertyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPropertyResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPropertyResponse)));
        }

        /// <summary>
        /// Add/update document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of DocumentPropertyResponse</returns>
        public async System.Threading.Tasks.Task<DocumentPropertyResponse> PutSetPropertyAsync (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null)
        {
             ApiResponse<DocumentPropertyResponse> localVarResponse = await PutSetPropertyAsyncWithHttpInfo(name, propertyName, property, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Add/update document property. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name"></param>
        /// <param name="propertyName"></param>
        /// <param name="property"> (optional)</param>
        /// <param name="storage"> (optional)</param>
        /// <param name="folder"> (optional)</param>
        /// <returns>Task of ApiResponse (DocumentPropertyResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DocumentPropertyResponse>> PutSetPropertyAsyncWithHttpInfo (string name, string propertyName, DocumentProperty property = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutSetProperty");
            // verify the required parameter 'propertyName' is set
            if (propertyName == null)
                throw new ApiException(400, "Missing required parameter 'propertyName' when calling PdfApi->PutSetProperty");

            var localVarPath = "/pdf/{name}/documentproperties/{propertyName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (propertyName != null) localVarPathParams.Add("propertyName", ApiClient.ParameterToString(propertyName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (property != null && property.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(property); // http body (model) parameter
            }
            else
            {
                localVarPostBody = property; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutSetProperty", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DocumentPropertyResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (DocumentPropertyResponse) ApiClient.Deserialize(localVarResponse, typeof(DocumentPropertyResponse)));
        }

        /// <summary>
        /// Update field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>FieldResponse</returns>
        public FieldResponse PutUpdateField (string name, string fieldName, Field field = null, string storage = null, string folder = null)
        {
             ApiResponse<FieldResponse> localVarResponse = PutUpdateFieldWithHttpInfo(name, fieldName, field, storage, folder);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>ApiResponse of FieldResponse</returns>
        public ApiResponse< FieldResponse > PutUpdateFieldWithHttpInfo (string name, string fieldName, Field field = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutUpdateField");
            // verify the required parameter 'fieldName' is set
            if (fieldName == null)
                throw new ApiException(400, "Missing required parameter 'fieldName' when calling PdfApi->PutUpdateField");

            var localVarPath = "/pdf/{name}/fields/{fieldName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (fieldName != null) localVarPathParams.Add("fieldName", ApiClient.ParameterToString(fieldName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (field != null && field.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(field); // http body (model) parameter
            }
            else
            {
                localVarPostBody = field; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutUpdateField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldResponse) ApiClient.Deserialize(localVarResponse, typeof(FieldResponse)));
        }

        /// <summary>
        /// Update field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of FieldResponse</returns>
        public async System.Threading.Tasks.Task<FieldResponse> PutUpdateFieldAsync (string name, string fieldName, Field field = null, string storage = null, string folder = null)
        {
             ApiResponse<FieldResponse> localVarResponse = await PutUpdateFieldAsyncWithHttpInfo(name, fieldName, field, storage, folder);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update field. 
        /// </summary>
        /// <exception cref="Aspose.Pdf.Cloud.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The document name.</param>
        /// <param name="fieldName">The field name/</param>
        /// <param name="field">with the field data. (optional)</param>
        /// <param name="storage">The document storage. (optional)</param>
        /// <param name="folder">The document folder. (optional)</param>
        /// <returns>Task of ApiResponse (FieldResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FieldResponse>> PutUpdateFieldAsyncWithHttpInfo (string name, string fieldName, Field field = null, string storage = null, string folder = null)
        {
            // verify the required parameter 'name' is set
            if (name == null)
                throw new ApiException(400, "Missing required parameter 'name' when calling PdfApi->PutUpdateField");
            // verify the required parameter 'fieldName' is set
            if (fieldName == null)
                throw new ApiException(400, "Missing required parameter 'fieldName' when calling PdfApi->PutUpdateField");

            var localVarPath = "/pdf/{name}/fields/{fieldName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (name != null) localVarPathParams.Add("name", ApiClient.ParameterToString(name)); // path parameter
            if (fieldName != null) localVarPathParams.Add("fieldName", ApiClient.ParameterToString(fieldName)); // path parameter
            if (storage != null) localVarQueryParams.Add("storage", ApiClient.ParameterToString(storage)); // query parameter
            if (folder != null) localVarQueryParams.Add("folder", ApiClient.ParameterToString(folder)); // query parameter
            if (field != null && field.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(field); // http body (model) parameter
            }
            else
            {
                localVarPostBody = field; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PutUpdateField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FieldResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FieldResponse) ApiClient.Deserialize(localVarResponse, typeof(FieldResponse)));
        }

    }
}
