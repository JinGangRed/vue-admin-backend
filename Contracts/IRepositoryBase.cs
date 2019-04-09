#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Contracts
* 项目描述 ：
* 类 名 称 ：IRepositoryBase
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Contracts
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 21:05:54
* 更新时间 ：2019/4/9 21:05:54
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IEnumerable<T> FindAll();

        IEnumerable<T> Find(Expression<Func<T, bool>> expression);

        void Create(T entity);

        void CreateRange(IEnumerable<T> entities);

        void Edit(T entity);

        void Delete(T entity);

        void Save();
    }
}
