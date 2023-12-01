// <copyright file="ManifestGroup.cs" company="DocuSign">
// Copyright (c) DocuSign. All rights reserved.
// </copyright>

namespace DocuSign.CodeExamples.ESignature.Models
{

    /* Unmerged change from project 'Quick_ACG'
    Before:
        using System.Collections.Generic;
        using DocuSign.CodeExamples.ESignature.Models;
    After:
        using DocuSign.CodeExamples.ESignature.Models;
    */
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public class ManifestGroup
    {
        [JsonProperty("Examples")]
        public List<CodeExampleText> Examples { get; } = new List<CodeExampleText>();

        [JsonProperty("Name")]
        public string Name { get; set; }
    }
}
