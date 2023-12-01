// <copyright file="FormFormGroupModel.cs" company="DocuSign">
// Copyright (c) DocuSign. All rights reserved.
// </copyright>

namespace DocuSign.CodeExamples.Rooms.Models
{
    using DocuSign.Rooms.Model;
    using System;
    using System.Collections.Generic;

    public class FormFormGroupModel
    {
        public string FormGroupId { get; set; }

        public List<FormGroupSummary> FormGroups { get; set; }

        public Guid FormId { get; set; }

        public List<FormSummary> Forms { get; set; }
    }
}
