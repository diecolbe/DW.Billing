using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace DW.Billing.ORM.Manager
{
    public class DataBaseManager : IDisposable
    {
        private bool disposedValue;

        public string ConnectionString { get; private set; }

        public DataBaseManager(string connection)
        {
            ConnectionString = connection;
        }

        public async Task<IEnumerable<T>> ExecuteQuerySelect<T>(string query, object filter = null)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                return filter == null
                    ? await conn.QueryAsync<T>(query).ConfigureAwait(false)
                    : await conn.QueryAsync<T>(query, filter).ConfigureAwait(false);
            }            
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
