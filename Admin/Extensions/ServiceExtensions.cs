#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Admin.Extensions
* 项目描述 ：
* 类 名 称 ：ServiceExtensions
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Admin.Extensions
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 21:55:38
* 更新时间 ：2019/4/9 21:55:38
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using Admin.Exceptions;
using Contracts;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlServerContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["connectionString"];
            ConfigureSqlServerContext(services, connectionString);
        }

        public static void ConfigureSqlServerContext(this IServiceCollection services, string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new DBArgumentNullException($"{nameof(connectionString)} couldn't be empty,please check the appsettings.json");
            }
            services.AddDbContext<RepositoryContext>(
                o => o.UseSqlServer(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
