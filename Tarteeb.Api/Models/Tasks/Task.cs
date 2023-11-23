﻿//==========================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to order in your workplace
//==========================================================

using System;

namespace Tarteeb.Api.Models.Tasks
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Guid? AssigneeId { get; set; }
        public TaskStatus status { get; set; }
        public DateTimeOffset CreatedDate { get; set;}
        public DateTimeOffset UpdatedDate { get; set;}
        public Guid CreatedUserId { get; set; }
        public Guid UpdatedUserId { get; set; }
    }
}
