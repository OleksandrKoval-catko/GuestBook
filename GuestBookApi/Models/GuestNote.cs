using System.ComponentModel.DataAnnotations;
using System;

namespace GuestBookApi.Models
{
    public class GuestNote
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public string Mail { get; set; }
        public DateTime Date { get; set; }
    }
}