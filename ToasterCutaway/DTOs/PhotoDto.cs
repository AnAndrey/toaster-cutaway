﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToasterCutaway.DTOs
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
    }
}