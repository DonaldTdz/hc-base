﻿using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HC.AbpCore.Configuration.Dto;

namespace HC.AbpCore.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpCoreAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
