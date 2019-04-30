using Abp.AppFactory;
using Abp.AppFactory.Interfaces;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Identity;
using SmartLibraries.Authorization.Users;
using SmartLibraries.MultiTenancy;
using System;
using System.Threading.Tasks;

namespace SmartLibraries
{
    public class SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto> : SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, int>
          where TEntity : Entity<int>
          where TEntityDto : EntityDto
    {
        public SmartLibrariesAsyncCrudAppServiceBase(IRepository<TEntity, int> repository, ISyncHub syncHub) : base(repository, syncHub)
        {
        }
    }

    public class SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey> : SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, PagedAndSortedResultRequestDto>
        where TEntity : Entity<TPrimaryKey>
        where TEntityDto : EntityDto<TPrimaryKey>
    {
        public SmartLibrariesAsyncCrudAppServiceBase(IRepository<TEntity, TPrimaryKey> repository, ISyncHub syncHub) : base(repository, syncHub)
        {
        }
    }

    public class SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput> : SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TEntityDto, TEntityDto>
        where TEntity : Entity<TPrimaryKey>
        where TEntityDto : EntityDto<TPrimaryKey>
    {
        public SmartLibrariesAsyncCrudAppServiceBase(IRepository<TEntity, TPrimaryKey> repository, ISyncHub syncHub) : base(repository, syncHub)
        {
        }
    }

    public class SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput> : SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, EntityDto<TPrimaryKey>>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateInput : IEntityDto<TPrimaryKey>
    {
        public SmartLibrariesAsyncCrudAppServiceBase(IRepository<TEntity, TPrimaryKey> repository, ISyncHub syncHub) : base(repository, syncHub)
        {
        }
    }

    public class SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput> : SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, EntityDto<TPrimaryKey>>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateInput : IEntityDto<TPrimaryKey>
        where TGetInput : IEntityDto<TPrimaryKey>
    {
        public SmartLibrariesAsyncCrudAppServiceBase(IRepository<TEntity, TPrimaryKey> repository, ISyncHub syncHub) : base(repository, syncHub)
        {
        }
    }

    public class SmartLibrariesAsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput> : AsyncCrudAppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput, TGetInput, TDeleteInput>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateInput : IEntityDto<TPrimaryKey>
        where TGetInput : IEntityDto<TPrimaryKey>
        where TDeleteInput : IEntityDto<TPrimaryKey>
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected SmartLibrariesAsyncCrudAppServiceBase(IRepository<TEntity, TPrimaryKey> repository, ISyncHub syncHub) : base(repository, syncHub)
        {
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId().ToString());
            if (user == null)
            {
                throw new Exception("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}