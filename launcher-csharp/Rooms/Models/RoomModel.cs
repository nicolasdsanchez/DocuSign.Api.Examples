// <copyright file="RoomModel.cs" company="DocuSign">
// Copyright (c) DocuSign. All rights reserved.
// </copyright>

namespace DocuSign.CodeExamples.Rooms.Models
{
    using DocuSign.Rooms.Model;
    using System.Collections.Generic;

    public class RoomModel
    {
        public string Name { get; set; }

        public int TemplateId { get; set; }

        public List<RoomTemplate> Templates { get; set; }
    }
}
