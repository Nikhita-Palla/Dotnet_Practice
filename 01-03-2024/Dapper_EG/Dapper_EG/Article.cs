using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_EG
{
    internal class Article
    {
        public int articleId { get; set; }
        public string articleName { get; set; }
        public string content { get; set; }
        public DateTime publishedDate {  get; set; }
        public DateTime lastModifiedDate { get; set; }
    }

}
