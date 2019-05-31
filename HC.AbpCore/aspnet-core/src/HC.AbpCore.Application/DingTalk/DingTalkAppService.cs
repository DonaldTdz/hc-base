using Abp.Application.Services;
using Abp.Auditing;
using Abp.Authorization;
using Abp.Domain.Repositories;
using HC.AbpCore.DingTalk.Employees.DomainService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HC.AbpCore.DingTalk
{

    /// <summary>
    /// DingTalk应用层服务的接口实现方法  
    ///</summary>
    [AbpAuthorize]
    public class DingTalkAppService : AbpCoreAppServiceBase, IDingTalkAppService
    {
        private readonly IDingTalkManager _dingTalkManager;
        private readonly IEmployeeManager _employeeManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public DingTalkAppService(
        IDingTalkManager dingTalkManager,
        IEmployeeManager employeeManager
        )
        {
            _dingTalkManager = dingTalkManager;
            _employeeManager = employeeManager;
        }


       

    }
}

