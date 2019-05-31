

using System;
using System.Threading.Tasks;
using Abp;
using Abp.Domain.Services;
using HC.AbpCore.DingTalk.Employees;


namespace HC.AbpCore.DingTalk.Employees.DomainService
{
    public interface IEmployeeManager : IDomainService
    {

        /// <summary>
        /// 初始化方法
        ///</summary>
        void InitEmployee();





    }
}
