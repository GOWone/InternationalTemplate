using System;
using System.Data;

namespace YaMoTemplate.Interface
{
    public interface IDbFactory 
    {
        /// <summary>
        /// 释放托管资源
        /// Release managed resources
        /// </summary>
        void Dispose();
        /// <summary>
        /// 释放数据库资源
        /// Release database resources
        /// </summary>
        /// <param name="disposing"></param>
        void Dispose(bool disposing);
        /// <summary>
        /// 初始化数据库资源
        /// Initialize database resources
        /// </summary>
        /// <param name="datasource"></param>
        void Init(string datasource);
        /// <summary>
        /// 打开数据库
        /// Open Database
        /// </summary>
        void Open();
        /// <summary>
        /// 开启事务
        /// Begin Transaction
        /// </summary>
        void BeginTransaction();
        /// <summary>
        /// 提交事务
        /// Commit Transaction
        /// </summary>
        void Commit();
        /// <summary>
        /// 回滚
        /// Rollback
        /// </summary>
        void Rollback();
        /// <summary>
        /// 执行SQL语句
        /// Excute Non Query
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        int ExcuteNonQuery(string sqlString);
        /// <summary>
        /// 执行SQL语句并返回所有结果
        /// Excute Query To DataTable
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        DataTable ExcuteQueryToDt(string sqlString);
        /// <summary>
        /// 执行SQL语句并返回所有结果
        /// Excute Query To DataSet
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        DataSet ExcuteQueryToDs(string sqlString);
        /// <summary>
        /// 执行SQL语句并返回结果的第一行
        /// Excute Query To DataRow
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        DataRow ExcuteQueryToDr(string sqlString);
        /// <summary>
        /// 执行SQL语句并返回结果的第一行第一列
        /// Excute Query Scalar
        /// </summary>
        /// <param name="sqlString"></param>
        /// <returns></returns>
        Object ExcuteQueryScalar(string sqlString);
        /// <summary>
        /// 断开数据库连接
        /// DisConnect Database
        /// </summary>
        void DisConnect();
        /// <summary>
        /// 检查数据库是否存在
        /// Check if the database exists
        /// </summary>
        /// <param name="datasource"></param>
        /// <returns></returns>
        bool CheckDbExist(string datasource);
    }
}
