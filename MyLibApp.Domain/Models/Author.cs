﻿using System.Collections.Generic;

namespace MyLibApp.Domain.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Item> Items { get; set; }
    }
}