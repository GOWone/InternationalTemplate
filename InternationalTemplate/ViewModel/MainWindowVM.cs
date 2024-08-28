using YaMoTemplate;
using YaMoTemplate.Configuration;
using YaMoTemplate.StaticResource.Enum;

namespace InternationalTemplate.ViewModel
{
    public class MainWindowVM
    {
        public MainWindowVM()
        {
            TemplateConfiguration config = new TemplateConfiguration();
            TemplateController.SetDefaultConfig();
            TemplateController.SetConfig(config);
            TemplateController.SwitchTemplate(TemplateType.zh_CN);
            TemplateConfiguration tem = new TemplateConfiguration();

        }
    }
}
