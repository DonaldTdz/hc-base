using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Modules;
using Abp.Quartz;
using Abp.Quartz.Configuration;
using Abp.Reflection.Extensions;
using Abp.Threading;
using Abp.Threading.BackgroundWorkers;
using HC.AbpCore.Authorization;
using Quartz;

namespace HC.AbpCore
{
    [DependsOn(
        typeof(AbpCoreCoreModule),
        typeof(AbpAutoMapperModule),
        typeof(AbpQuartzModule))]
    public class AbpCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpCoreAuthorizationProvider>();

            Configuration.Modules.AbpQuartz().Scheduler.JobFactory = new AbpQuartzJobFactory(IocManager);
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpCoreApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }

        public override void PostInitialize()
        {
            IocManager.RegisterIfNot<IJobListener, AbpQuartzJobListener>();

            Configuration.Modules.AbpQuartz().Scheduler.ListenerManager.AddJobListener(IocManager.Resolve<IJobListener>());

            if (Configuration.BackgroundJobs.IsJobExecutionEnabled)
            {
                IocManager.Resolve<IBackgroundWorkerManager>().Add(IocManager.Resolve<IQuartzScheduleJobManager>());
            }
        }
    }
}
