﻿using System;

namespace Itbeard.Models
{
    public class UrlModel : StatusCodeModel
    {
        public Guid Id { get; set; }
        
        public string TargetUrl { get; set; }
        
        public string ShortGuid { get; set; }
    }
}