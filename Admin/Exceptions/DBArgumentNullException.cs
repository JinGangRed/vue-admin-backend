#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Admin.Exceptions
* 项目描述 ：
* 类 名 称 ：DBArgumentNullException
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Admin.Exceptions
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 22:09:47
* 更新时间 ：2019/4/9 22:09:47
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Exceptions
{
    public class DBArgumentNullException:DbException
    {
        public override string Message => base.Message;
        public DBArgumentNullException(string message):base(message)
        {
        }
    }
}
