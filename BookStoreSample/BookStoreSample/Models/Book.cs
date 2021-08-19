﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreSample.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        []
        public string Title { get; set; }
        public string Author { get; set; }
        public int PuplishYear { get; set; }
        public bool IsDeleted { get; set; }
    }
}
