namespace Dapper_EG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbAccess access=new DbAccess(); ;
            List<Article> articles= (List<Article>)access.GetArticles();

            foreach(var article in articles)
            {
                Console.WriteLine($"{article.articleName} - {article.content} - {article.publishedDate} - {article.lastModifiedDate}");
            }
            Console.WriteLine();
            Console.WriteLine($"Number of Articles in ArticleTable:{access.GetCount()}");

            Console.WriteLine();

            Article article1 = access.GetArticleByName("Article 1");
            Console.WriteLine($"{article1.articleName} - {article1.content} - {article1.publishedDate} - {article1.lastModifiedDate}");

            Article newArticle=new Article() { articleName="Article 29",content="Content of Article 29",publishedDate=DateTime.Now,lastModifiedDate=DateTime.Now};
            bool insertion=access.InsertArticle(newArticle);
            if( insertion )
            {
                Console.WriteLine("Success!!");
            }
            else
            {
                Console.WriteLine("Something went wrong!!");
            }
        }
    }
}
