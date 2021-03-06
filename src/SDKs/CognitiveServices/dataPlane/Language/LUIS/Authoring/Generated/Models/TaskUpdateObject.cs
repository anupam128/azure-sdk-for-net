// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object model for cloning an application's version.
    /// </summary>
    public partial class TaskUpdateObject
    {
        /// <summary>
        /// Initializes a new instance of the TaskUpdateObject class.
        /// </summary>
        public TaskUpdateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TaskUpdateObject class.
        /// </summary>
        /// <param name="version">The new version for the cloned model.</param>
        public TaskUpdateObject(string version = default(string))
        {
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the new version for the cloned model.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
