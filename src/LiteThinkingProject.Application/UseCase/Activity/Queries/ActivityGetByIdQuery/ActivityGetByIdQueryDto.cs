﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteThinkingProject.Application.UseCase.Activity.Queries.ActivityGetByIdQuery
{
    public class ActivityGetByIdQueryDto
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? StateText { get; set; }
    }
}
