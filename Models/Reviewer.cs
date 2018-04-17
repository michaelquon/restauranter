using System;
using System.ComponentModel.DataAnnotations;

namespace Rest.Models
{
    public class Reviewer
    {
        public int id { get; set; }
        public string name { get; set; }
        public int stars { get; set; }
        public string rest_name { get; set; }
        public string review { get; set;}
        public DateTime date { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime updated_at {get; set; } = DateTime.Now;
    }
}