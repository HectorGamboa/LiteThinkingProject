﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteThinkingProject.Domain.Entities
{
    public class Settings
    {
        public string? Uri { get; set; }
        public string? Key { get; set; }
        public string? DatabaseName { get; set; }
        public string? Container { get; set; }

        public Settings() { }
    }
}