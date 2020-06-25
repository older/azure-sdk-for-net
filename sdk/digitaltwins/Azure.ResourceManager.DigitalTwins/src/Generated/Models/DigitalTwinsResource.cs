// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The common properties of a DigitalTwinsInstance. </summary>
    public partial class DigitalTwinsResource
    {
        /// <summary> Initializes a new instance of DigitalTwinsResource. </summary>
        /// <param name="location"> The resource location. </param>
        public DigitalTwinsResource(string location)
        {
            if (location == null)
            {
                throw new ArgumentNullException(nameof(location));
            }

            Location = location;
        }

        /// <summary> Initializes a new instance of DigitalTwinsResource. </summary>
        /// <param name="id"> The resource identifier. </param>
        /// <param name="name"> The resource name. </param>
        /// <param name="type"> The resource type. </param>
        /// <param name="location"> The resource location. </param>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="sku"> This property is reserved for future use, and will be ignored/omitted. </param>
        internal DigitalTwinsResource(string id, string name, string type, string location, IDictionary<string, string> tags, DigitalTwinsSkuInfo sku)
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
            Sku = sku;
        }

        /// <summary> The resource identifier. </summary>
        public string Id { get; }
        /// <summary> The resource name. </summary>
        public string Name { get; }
        /// <summary> The resource type. </summary>
        public string Type { get; }
        /// <summary> The resource location. </summary>
        public string Location { get; set; }
        /// <summary> The resource tags. </summary>
        public IDictionary<string, string> Tags { get; set; }
        /// <summary> This property is reserved for future use, and will be ignored/omitted. </summary>
        public DigitalTwinsSkuInfo Sku { get; set; }
    }
}
