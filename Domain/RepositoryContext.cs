#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Domain
* 项目描述 ：
* 类 名 称 ：RepositoryContext
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Domain
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 20:51:55
* 更新时间 ：2019/4/9 20:51:55
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Domain
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions options):base(options)
        {
        }

        [Display(Description = "角色")]
        public DbSet<Role> Role { get; set; }
        [Display(Description = "菜单")]
        public DbSet<Menu> Menu { get; set; }


    }
}
