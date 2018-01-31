/* 
 * Aspose.Pdf for Cloud API Reference
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Aspose.Pdf.Cloud.Sdk.Client.SwaggerDateConverter;

namespace Aspose.Pdf.Cloud.Sdk.Model
{
    /// <summary>
    /// Represents enumeration of the stamp types.
    /// </summary>
    /// <value>Represents enumeration of the stamp types.</value>
    public enum StampType
    {
        /// <summary>
        /// Text stamp
        /// </summary>
        Text,
        /// <summary>
        /// Image stamp
        /// </summary>
        Image,
        /// <summary>
        /// Page stamp
        /// </summary>
        Page,
        /// <summary>
        /// Page number stamp
        /// </summary>
        PageNumber
    }
}
