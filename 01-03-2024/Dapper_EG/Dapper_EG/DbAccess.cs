using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_EG
{
    internal class DbAccess
    {
        string connectionString = "Server=.\\MSSQLSERVER01;Initial Catalog=Article;Integrated Security=true;TrustServerCertificate=True";

        public ICollection<Article> GetArticles() 
        {
            
            using(var connection=new SqlConnection(connectionString))
            {
                var sql = "select * from ArticleTable";
                var articles = connection.Query<Article>(sql);
                return articles.ToList();
            }
           
        } 

        public int GetCount()
        {
            using(var connection=new SqlConnection(connectionString))
            {
                var sql = "select count(*) from ArticleTable";
                int count = connection.ExecuteScalar<int>(sql);
                return count;
            }
        }

        public Article GetArticleByName(string name)
        {
            using(var connection=new SqlConnection(connectionString))
            {
                var sql = "SELECT * FROM ArticleTable WHERE articleName = @articleName";
                // Define parameters using an anonymous type or a parameter object
                var parameters = new { articleName = name };

                // Execute the query and retrieve the count
                Article article = connection.QuerySingle<Article>(sql, parameters);
                return article;
            }
        }

        public bool InsertArticle(Article article)
        {
            using(var connection=new SqlConnection(connectionString))
            {
                
                string articleName = article.articleName;
                string content= article.content;
                DateTime publishedDate = article.publishedDate;
                DateTime lastModifiedDate= article.lastModifiedDate;

                string sql = "insert into ArticleTable(articleName,content,publishedDate,lastModifiedDate)" +
                    " values (@articleName,@content,@publishedDate,@lastModifiedDate)";

                var parameters=new { articleName = articleName, content = content, 
                    publishedDate = publishedDate, lastModifiedDate = lastModifiedDate };

                int affectedRows=connection.Execute(sql, parameters);
                if (affectedRows>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        

    }
}
