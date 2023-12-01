// <copyright file="RoomDocumentModel.cs" company="DocuSign">
// Copyright (c) DocuSign. All rights reserved.
// </copyright>

namespace DocuSign.CodeExamples.Rooms.Models
{
    using DocuSign.Rooms.Model;
    using System;
    using System.Collections.Generic;

    public class RoomDocumentModel
    {
        public int? RoomId { get; set; }

        public List<RoomSummary> Rooms { get; set; }

        public Guid DocumentId { get; set; }

        public List<RoomDocument> Documents { get; set; }
    }
}