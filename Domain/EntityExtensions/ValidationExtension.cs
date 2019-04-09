#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Domain.EntityExtensions
* 项目描述 ：
* 类 名 称 ：ValidationExtension
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Domain.EntityExtensions
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 20:57:40
* 更新时间 ：2019/4/9 20:57:40
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Text;


namespace Domain.EntityExtensions
{
    public static class ValidationExtension
    {
        public static bool IsObjectNull(this IEntity entity)
        {
            return entity == null;
        }

        public static bool IsEmptyObject(this IEntity entity)
        {
            return entity == null;
        }
    }
}
