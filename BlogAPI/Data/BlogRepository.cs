using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using BlogAPI.Models;

namespace BlogAPI.Data
{
    public class BlogRepository
    {
        private readonly string _connectionString;

        public BlogRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<Blog> GetAllBlogs()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Blog>("SELECT * FROM Blogs");
            }
        }
    }
}
