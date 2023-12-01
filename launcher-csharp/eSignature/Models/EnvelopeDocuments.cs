// <copyright file="EnvelopeDocuments.cs" company="DocuSign">
// Copyright (c) DocuSign. All rights reserved.
// </copyright>

namespace DocuSign.CodeExamples.Models
{
    using System.Collections.Generic;

    public class EnvelopeDocuments
    {
        public string EnvelopeId { get; set; }

        public List<EnvelopeDocItem> Documents { get; set; }
    }
}
