using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MIS.Core
{
    public class DbContextProxy : MarshalByRefObject
    {
        private DbContext _dbContext;

        public DbContextProxy()
        {
            //_dbContext = dbContext;
        }

        ///// <summary>
        ///// 提供对用于处理实体的更改跟踪的上下文功能的访问。
        ///// </summary>
        //public DbChangeTracker ChangeTracker { get { return _dbContext.ChangeTracker; } }

        ///// <summary>
        ///// 提供对上下文的配置选项的访问。
        ///// </summary>
        //public DbContextConfiguration Configuration { get { return _dbContext.Configuration; } }

        ///// <summary>
        ///// 为此上下文创建一个数据库实例，该上下文允许您对基础数据库执行创建/删除/存在性检查操作。
        ///// </summary>
        //public Database Database { get { return _dbContext.Database; } }

        ///// <summary>
        ///// 获取给定实体的 System.Data.Entity.Infrastructure.DbEntityEntry 对象，以便提供对与该实体有关的信息的访问以及对实体执行操作的功能。
        ///// </summary>
        ///// <param name="entity">实体。</param>
        ///// <returns>实体的项。</returns>
        //public DbEntityEntry Entry(object entity)
        //{
        //    return _dbContext.Entry(entity);
        //}

        ///// <summary>
        ///// 获取给定实体的 System.Data.Entity.Infrastructure.DbEntityEntry`1 对象，以便提供对与该实体有关的信息的访问以及对实体执行操作的功能。
        ///// </summary>
        ///// <typeparam name="TEntity">实体的类型。</typeparam>
        ///// <param name="entity">实体。</param>
        ///// <returns>实体的项。</returns>
        //public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        //{
        //    return _dbContext.Entry<TEntity>(entity);
        //}

        ///// <summary>
        ///// 验证跟踪实体，并返回包含验证结果的 System.Data.Entity.Validation.DbEntityValidationResult 的集合。
        ///// </summary>
        ///// <returns>无效实体的验证结果集合。集合决不为 null，且不得包含 null 值或有效实体的结果。</returns>
        //public IEnumerable<DbEntityValidationResult> GetValidationErrors()
        //{
        //    return _dbContext.GetValidationErrors();
        //}

        ///// <summary>
        ///// 将在此上下文中所做的所有更改保存到基础数据库。
        ///// </summary>
        ///// <returns>已写入基础数据库的对象的数目。</returns>
        //public virtual int SaveChanges()
        //{
        //    return _dbContext.SaveChanges();
        //}

        ///// <summary>
        ///// 将在此上下文中所做的所有更改异步保存到基础数据库。
        ///// </summary>
        ///// <returns>表示异步保存操作的任务。任务结果包含已写入基础数据库的对象数目。</returns>
        //public virtual Task<int> SaveChangesAsync()
        //{
        //    return _dbContext.SaveChangesAsync();
        //}

        ///// <summary>
        ///// 将在此上下文中所做的所有更改异步保存到基础数据库。
        ///// </summary>
        ///// <param name="cancellationToken">等待任务完成期间要观察的 System.Threading.CancellationToken。</param>
        ///// <returns>表示异步保存操作的任务。任务结果包含已写入基础数据库的对象数目。</returns>
        //public virtual Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        //{
        //    return _dbContext.SaveChangesAsync(cancellationToken);
        //}

        ///// <summary>
        ///// 针对对上下文和基础存储中给定类型的实体的访问返回一个非泛型 System.Data.Entity.DbSet 实例。
        ///// </summary>
        ///// <param name="entityType">应为其返回一个集的实体的类型。</param>
        ///// <returns>给定实体类型的集。</returns>
        //public virtual DbSet Set(Type entityType)
        //{
        //    return _dbContext.Set(entityType);
        //}

        ///// <summary>
        ///// 针对对上下文和基础存储中给定类型的实体的访问返回一个 System.Data.Entity.DbSet`1 实例。
        ///// </summary>
        ///// <typeparam name="TEntity">应为其返回一个集的类型实体。</typeparam>
        ///// <returns>给定实体类型的集。</returns>
        //public virtual DbSet<TEntity> Set<TEntity>() where TEntity : class
        //{
        //    return _dbContext.Set<TEntity>();
        //}

        public string Test() { return "success"; }
    }
}