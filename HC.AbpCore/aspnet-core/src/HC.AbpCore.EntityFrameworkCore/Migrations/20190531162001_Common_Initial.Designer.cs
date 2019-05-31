using HC.AbpCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace HC.AbpCore.Migrations
{
    [DbContext(typeof(AbpCoreDbContext))]
    [Migration("20190531162001_Common_Initial")]
    public partial class Common_Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {

        }
    }
}
