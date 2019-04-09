#region << 版 本 注 释 >>
/*----------------------------------------------------------------
* 项目名称 ：Repository
* 项目描述 ：
* 类 名 称 ：RepositoryBase
* 类 描 述 ：
* 所在的域 ：KINGDESKTOP
* 命名空间 ：Repository
* 机器名称 ：KINGDESKTOP 
* CLR 版本 ：4.0.30319.42000
* 作    者 ：Kingkang
* 创建时间 ：2019/4/9 21:26:36
* 更新时间 ：2019/4/9 21:26:36
* 版 本 号 ：v1.0.0.0
*******************************************************************
* Copyright @ Kingkang 2019. All rights reserved.
*******************************************************************
//----------------------------------------------------------------*/
#endregion
using Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext RepositoryContext;

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public virtual void Create(T entity)
        {
            RepositoryContext.Set<T>().Add(entity);
            Save();
        }

        public virtual void CreateRange(IEnumerable<T> entities)
        {
            RepositoryContext.Set<T>().AddRange(entities);
            Save();
        }

        public virtual void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
            Save();
        }

        public virtual void Edit(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
            Save();
        }

        public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return RepositoryContext.Set<T>().Where(expression);
        }

        public virtual IEnumerable<T> FindAll()
        {
            return RepositoryContext.Set<T>();
        }

        public virtual void Save()
        {
            RepositoryContext.SaveChanges();
        }
    }
}
