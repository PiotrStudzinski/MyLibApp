using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibApp.Domain.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ItemTypeId { get; set; }
        public virtual ItemType ItemType { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
