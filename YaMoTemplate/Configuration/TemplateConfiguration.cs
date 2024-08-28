using System;
using YaMoTemplate.Extension;
using YaMoTemplate.Interface;
using YaMoTemplate.Interface.Factory;
using YaMoTemplate.StaticResource.Enum;

namespace YaMoTemplate.Configuration
{
    public class TemplateConfiguration : IConfiguration
    {
        #region Field
        /// <summary>
        /// 文件类Factory
        /// </summary>
        private IFileFactory _fileFactory;
        /// <summary>
        /// 数据库类Factory
        /// </summary>
        private IDbFactory _dbFactory;
        #endregion

        #region Properties
        private WorkModeType _workModeType;
        /// <summary>
        /// 模块工作模式
        /// </summary>
        public WorkModeType WorkModeType
        {
            get { return _workModeType; }
            set { _workModeType = value; }
        }

        private string _dbName;
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string DbName
        {
            get { return _dbName; }
            set { _dbName = value; }
        }

        private string _fileName;
        /// <summary>
        /// 文件名称
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }

        private string _filePath;
        /// <summary>
        /// 文件路径
        /// </summary>
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        #endregion

        #region Ctor
        public TemplateConfiguration()
        {

        }
        #endregion

        #region SET Method
        /// <summary>
        /// 设置基础存储路径
        /// Set Base Path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public TemplateConfiguration SetBasePath(string linkStr,WorkModeType modeType = WorkModeType.Local)
        {
            this._workModeType = modeType;
            return this;
        }

        /// <summary>
        /// 设置数据加密方法
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public TemplateConfiguration SetEncryption(EncryptionType type = EncryptionType.None)
        {
            return this;
        }

        /// <summary>
        /// 设置语言模板类型
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public TemplateConfiguration SetTemplateType(TemplateType type = TemplateType.zh_CN)
        {
            return this;
        }

        /// <summary>
        /// 设置存储介质工作行为
        /// </summary>
        /// <param name="mediaType"></param>
        /// <param name="modeType"></param>
        /// <param name="mediaName"></param>
        /// <returns></returns>
        public TemplateConfiguration SetStorageMedia(StorageMediaType mediaType = StorageMediaType.Txt, string mediaName = null)
        {
            return this;
        }
        #endregion

        #region GET Method
        #endregion
    }
}
