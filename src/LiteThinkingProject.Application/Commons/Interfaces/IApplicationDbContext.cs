﻿using LiteThinkingProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LiteThinkingProject.Application.Commons.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Transaction> Transaction { get; set; }
    }

}