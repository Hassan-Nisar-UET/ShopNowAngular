using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
<<<<<<< HEAD
=======
using ShopNowAngular.Authorization.Users;
>>>>>>> 9079531492e70da8ce373f28213f9d65c4ec72aa
using ShopNowAngular.Roles.Dto;
using ShopNowAngular.Users.Dto;

namespace ShopNowAngular.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task DeActivate(EntityDto<long> user);
        Task Activate(EntityDto<long> user);
        Task<ListResultDto<RoleDto>> GetRoles();
        Task ChangeLanguage(ChangeUserLanguageDto input);

        Task<bool> ChangePassword(ChangePasswordDto input);
<<<<<<< HEAD
=======
        Task<User> GetUserEntityByNameAndEmail(string usernameAndEmail);
>>>>>>> 9079531492e70da8ce373f28213f9d65c4ec72aa
    }
}
