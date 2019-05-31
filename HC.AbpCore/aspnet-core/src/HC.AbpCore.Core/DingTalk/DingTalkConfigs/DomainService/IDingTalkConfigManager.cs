

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using HC.AbpCore.DingTalk.DingTalkConfigs;


namespace HC.AbpCore.DingTalk.DingTalkConfigs.DomainService
{
    public interface IDingTalkConfigManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitDingTalkConfig();



		 
      
         

    }
}
