namespace YaMoTemplate.Interface.Factory
{
    public interface IFileFactory
    {
        string GetFilePath();
        /// <summary>
        /// Create File
        /// </summary>
        bool CreateFile();
        /// <summary>
        /// Delete File
        /// </summary>
        bool DeleteFile();
        /// <summary>
        /// Insert Field
        /// </summary>
        int InsertField();
        /// <summary>
        /// Delete Field
        /// </summary>
        int DeleteField();
        /// <summary>
        /// Update Field
        /// </summary>
        int UpdateField();
        /// <summary>
        /// Get Field
        /// </summary>
        object GetField();
    }
}
