using Abp.AspNetCore.Mvc.Controllers;
using DingTalk.Api;
using DingTalk.Api.Request;
using DingTalk.Api.Response;
using HC.AbpCore.Controllers;
using HC.AbpCore.DingTalk;
using HC.AbpCore.DingTalk.ApprovalCommon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Senparc.CO2NET.Helpers;
using Senparc.CO2NET.HttpUtility;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC.AbpCore.Web.Host.Controllers
{
    public class DingTalkController : AbpCoreControllerBase
    {
        private readonly IDingTalkManager _dingTalkManager;

        /// <summary>
        /// 构造函数 
        ///</summary>
        public DingTalkController(
        IDingTalkManager dingTalkManager
        )
        {
            _dingTalkManager = dingTalkManager;
        }
       
    }


}
