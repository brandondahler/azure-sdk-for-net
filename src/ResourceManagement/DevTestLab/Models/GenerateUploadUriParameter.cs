// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLab.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DevTestLab;
    using Microsoft.Azure.Management.DevTestLab.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties for generating an upload URI.
    /// </summary>
    public partial class GenerateUploadUriParameter
    {
        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriParameter class.
        /// </summary>
        public GenerateUploadUriParameter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GenerateUploadUriParameter class.
        /// </summary>
        /// <param name="blobName">The blob name of the upload URI.</param>
        public GenerateUploadUriParameter(string blobName = default(string))
        {
            BlobName = blobName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the blob name of the upload URI.
        /// </summary>
        [JsonProperty(PropertyName = "blobName")]
        public string BlobName { get; set; }

    }
}