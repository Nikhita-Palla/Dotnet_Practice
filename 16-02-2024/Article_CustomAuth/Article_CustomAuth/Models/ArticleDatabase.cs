using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Article_CustomAuth.Models
{
    public class ArticleDatabase
    {
        public static string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public static List<string> GetRolesUser(string username)
        {
            List<string> roles = new List<string>();
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("GetRoleNamesUser"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string rolename = Convert.ToString(reader["RoleName"]);

                        roles.Add(rolename);
                    }
                }
            }

            return roles;

        }
        public static bool InsertArticle(string articleName, string content, DateTime publishedDate, DateTime lastModifiedDate)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("InsertArticle"))
            {
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@articleName", articleName);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@publishedDate", publishedDate);
                cmd.Parameters.AddWithValue("@lastModifiedDate", lastModifiedDate);


                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        public static List<ArticleModel> GetArticleById(int articleId)
        {
            List<ArticleModel> articles = new List<ArticleModel>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetArticleById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@articleId", articleId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ArticleModel article = new ArticleModel
                            {
                                ArticleId = Convert.ToInt32(reader["articleId"]),
                                Title = reader["articleName"].ToString(),
                                Content = reader["content"].ToString(),
                                PublishedDate = Convert.ToDateTime(reader["publishedDate"]),
                                LastModifiedDate = Convert.ToDateTime(reader["lastModifiedDate"])
                            };

                            articles.Add(article);
                        }
                    }
                }
            }

            return articles;
        }

        public static List<ArticleModel> GetAllArticles()
        {
            List<ArticleModel> articles = new List<ArticleModel>();

            using (SqlConnection conn = new SqlConnection(connection))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("GetAllArticles", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;


                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ArticleModel article = new ArticleModel
                            {
                                ArticleId = Convert.ToInt32(reader["articleId"]),
                                Title = reader["articleName"].ToString(),
                                Content = reader["content"].ToString(),
                                PublishedDate = Convert.ToDateTime(reader["publishedDate"]),
                                LastModifiedDate = Convert.ToDateTime(reader["lastModifiedDate"])
                            };

                            articles.Add(article);
                        }
                    }
                }
            }

            return articles;
        }

        public static bool UpdateArticle(int articleId, string articleName, string content, DateTime publishedDate, DateTime lastModifiedDate)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("UpdateArticle", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@articleId", articleId);
                cmd.Parameters.AddWithValue("@articleName", articleName);
                cmd.Parameters.AddWithValue("@content", content);
                cmd.Parameters.AddWithValue("@publishedDate", publishedDate);
                cmd.Parameters.AddWithValue("@lastModifiedDate", lastModifiedDate);

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public static bool DeleteArticle(int articleId)
        {
            SqlConnection conn = new SqlConnection(connection);
            conn.Open();

            using (SqlCommand cmd = new SqlCommand("DeleteArticle", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@articleId", articleId);

                int rows = cmd.ExecuteNonQuery();
                conn.Close();
                if (rows > 0)
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