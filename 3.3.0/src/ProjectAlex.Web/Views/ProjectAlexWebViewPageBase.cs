using Abp.Web.Mvc.Views;

namespace ProjectAlex.Web.Views
{
    public abstract class ProjectAlexWebViewPageBase : ProjectAlexWebViewPageBase<dynamic>
    {

    }

    public abstract class ProjectAlexWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ProjectAlexWebViewPageBase()
        {
            LocalizationSourceName = ProjectAlexConsts.LocalizationSourceName;
        }
    }
}