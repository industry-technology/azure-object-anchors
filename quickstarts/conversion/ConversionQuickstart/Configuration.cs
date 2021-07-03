// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Numerics;
using Azure.MixedReality.ObjectAnchors.Conversion;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ConversionQuickstart
{
    public class Configuration
    {
        // Azure Object Anchors account identifier
        public string AccountId = "75346a1c-6b6e-404e-8446-7db79f65f2b8";

        // Azure Object Anchors account primary key
        public string AccountKey = "z7Ld2AHQVFLe23ZbV+IUl45AsQP5ad7laQhouIBceT8=";

        // Azure Object Anchors account domain
        public string AccountDomain = "eastus2.mixedreality.azure.com";

        // Path to 3D asset file on your local machine
        public string InputAssetPath = "C:/Users/hamat/prog/azure-object-anchors/quickstarts/apps/unity/mrtk/Model/hondana.obj";

        // Timeout to wait for job completion
        public TimeSpan WaitForJobCompletionTimeout = TimeSpan.FromMinutes(40);

        // Gravity direction of 3D model
        public Vector3 Gravity = new Vector3(0.0f, -1.0f, 0.0f);

        // The unit of measurement of the 3D model
        [JsonConverter(typeof(StringEnumConverter))]
        public AssetLengthUnit AssetDimensionUnit = AssetLengthUnit.Meters;

        [JsonIgnore]
        public ILogger Logger = NullLogger.Instance;
    }
}
