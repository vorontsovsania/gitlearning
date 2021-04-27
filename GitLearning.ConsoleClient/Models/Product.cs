using System;

namespace GitLearning.ConsoleClient.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public string CategoryId { get; set; }
        public DateTime LastModificationDatetime { get; set; }

        public override string ToString()
        {
            return $"{Id} {Title} {Description}";
        }
    }
}
