using System.ComponentModel.DataAnnotations;

namespace CoreWebApp.Models
{
    public class ArticleModel
    {
        [Key]
        public int ArticleId { get; set; }
        public string ArticleName { get; set; }
        public string Content { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        

    }
}
