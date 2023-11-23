﻿//==========================================================
// Copyright (c) Coalition of Good-Hearted Engineers
// Free to use to order in your workplace
//==========================================================

using Microsoft.EntityFrameworkCore;
using Tarteeb.Api.Models.Tasks;

namespace Tarteeb.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Task> Tasks { get; set; }
    }
}
