using System;
using System.Data;
using YaMoTemplate.Interface;

namespace YaMoTemplate.DataAccess
{
    public class SqlServerFactory : IDbFactory, IDisposable
    {
        public void BeginTransaction()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckDbExist(string datasource)
        {
            throw new System.NotImplementedException();
        }

        public void Commit()
        {
            throw new System.NotImplementedException();
        }

        public void DisConnect()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void Dispose(bool disposing)
        {
            throw new System.NotImplementedException();
        }

        public int ExcuteNonQuery(string sqlString)
        {
            throw new System.NotImplementedException();
        }

        public object ExcuteQueryScalar(string sqlString)
        {
            throw new System.NotImplementedException();
        }

        public DataRow ExcuteQueryToDr(string sqlString)
        {
            throw new System.NotImplementedException();
        }

        public DataSet ExcuteQueryToDs(string sqlString)
        {
            throw new System.NotImplementedException();
        }

        public DataTable ExcuteQueryToDt(string sqlString)
        {
            throw new System.NotImplementedException();
        }

        public void Init(string datasource)
        {
            throw new System.NotImplementedException();
        }

        public void Open()
        {
            throw new System.NotImplementedException();
        }

        public void Rollback()
        {
            throw new System.NotImplementedException();
        }
    }
}
