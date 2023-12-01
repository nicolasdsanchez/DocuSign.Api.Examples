// <copyright file="RoomsListModel.cs" company="DocuSign">
// Copyright (c) DocuSign. All rights reserved.
// </copyright>

namespace DocuSign.CodeExamples.Rooms.Models
{
    using DocuSign.Rooms.Model;
    using System.Collections.Generic;

    public class RoomsListModel
    {
        public int RoomId { get; set; }

        public List<RoomSummary> Rooms { get; set; }
    }
}