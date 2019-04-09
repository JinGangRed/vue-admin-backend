#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Contracts
* 项目描述 ：
* 类 名 称 ：IRepositoryWrapper
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Contracts
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 21:08:50
* 更新时间 ：2019/4/9 21:08:50
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Text;

namespace Contracts
{
    public interface IRepositoryWrapper
    {
        IRoleRepository RoleRepository { get; }

        IMenuRepository MenuRepository { get;}
    }
}
