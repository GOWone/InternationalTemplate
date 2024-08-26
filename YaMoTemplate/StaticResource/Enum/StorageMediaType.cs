namespace YaMoTemplate.StaticResource.Enum
{
    public enum StorageMediaType
    {
        #region Text
        /// <summary>
        /// .Txt
        /// </summary>
        Txt,
        /// <summary>
        /// .json
        /// </summary>
        Json,
        #endregion

        #region DataTable
        /// <summary>
        /// .xlsx, .xls
        /// </summary>
        Excel,
        /// <summary>
        /// .csv
        /// </summary>
        Csv,
        #endregion

        #region Database
        /// <summary>
        /// Sqlite数据库连接
        /// Sqlite database connection
        /// </summary>
        Sqlite,
        /// <summary>
        /// MySQL数据库连接
        /// Remote MySQL database connection
        /// </summary>
        MySQL,
        /// <summary>
        /// MSSQL数据库连接
        /// MSSQL database connection
        /// </summary>
        MSSQL,
        #endregion
    }
}
