using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Repository.Repo
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly string connectionString = null;

        public Repository()
        {
            connectionString = ConfigurationManager.ConnectionStrings["dbo.Biblbioteca"].ConnectionString;
        }

        public int Add(T entity)
        {
            long generatedId = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                generatedId = conn.Insert(entity);

                conn.Close();

            }
            return Convert.ToInt32(generatedId);
        }

        public void Delete(T entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                conn.Delete(entity);

                conn.Close();
            }
        }

        public T Get(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var entity = conn.Get<T>(id);

                conn.Close();

                return entity;
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var entityList = conn.GetAll<T>();

                conn.Close();

                return entityList;
            }
        }

        public void Update(T entity)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                conn.Update<T>(entity);

                conn.Close();
            }
        }
    }
}
