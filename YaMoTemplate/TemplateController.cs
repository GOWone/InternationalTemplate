using YaMoTemplate.Configuration;
using YaMoTemplate.Interface;
using YaMoTemplate.StaticResource.Enum;

namespace YaMoTemplate
{
    public class TemplateController
    {
        #region Field
        /// <summary>
        /// Configuration
        /// </summary>
        public static IConfiguration _configuration;
        #endregion

        #region Ctor
        public TemplateController()
        {
                
        }
        #endregion

        #region Configuration
        /// <summary>
        /// Set Default Config
        /// </summary>
        public static void SetDefaultConfig()
        {
            _configuration = new TemplateConfiguration();
            Flush();
        }

        /// <summary>
        /// Set Configuration
        /// </summary>
        /// <param name="cofig"></param>
        public static void SetConfig(IConfiguration config)
        {
            _configuration = config;
            Flush();
        }

        /// <summary>
        /// Switch Template
        /// </summary>
        /// <param name="type">Template Type</param>
        public static void SwitchTemplate(TemplateType type)
        {
            _configuration = new TemplateConfiguration();
            Flush();
        }

        /// <summary>
        /// Set Configuration
        /// </summary>
        private static void Flush()
        {
            
        }
        #endregion

        #region Private Method
        #endregion

        #region Public Method
        #endregion
    }
}
