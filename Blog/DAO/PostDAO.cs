using Blog.Infra;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DAO
{
    public class PostDAO
    {
        // list the posts
        public IList<Post> List()

        {
            IList<Post> postList = new List<Post>();

            // Create obj as SqlConnection
            using (SqlConnection connection = ConnectionFactory.CreateConnectionOpen())
            {
                // Not necessary open connection

                // Create database command
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select * from Posts";

                // Exec command
                SqlDataReader reader = command.ExecuteReader();

                // Iteraction line of line as database
                while (reader.Read())
                {
                    Post post = new Post()
                    {
                        // Convert because dictionary value is not espected
                        Id = Convert.ToInt32(reader["Id"]),
                        Title = Convert.ToString(reader["Title"]),
                        Resume = Convert.ToString(reader["Resume"]),
                        Category = Convert.ToString(reader["Category"]),
                    };

                    postList.Add(post);
                }

                return postList;
            }
        }

        public void AddPost(Post post)
        {
            using (SqlConnection conection = ConnectionFactory.CreateConnectionOpen())
            {
                // Create command for database
                SqlCommand command = conection.CreateCommand();

                command.CommandText = "insert into Posts (Title, Resume, Category) " +
                    "values (@title, @resume, @category)";

                // Send value for parameters 
                command.Parameters.Add(new SqlParameter("title", post.Title));
                command.Parameters.Add(new SqlParameter("resume", post.Resume));
                command.Parameters.Add(new SqlParameter("category", post.Category));

                // Exec command
                command.ExecuteNonQuery();
            }
        }
    }
}
