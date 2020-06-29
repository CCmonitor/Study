using Ruanmou.Bussiness.Interface;

namespace Ruanmou.Bussiness.Service
{
    public class UserService : BaseService, IUserService
    {
        public UserService(DbContext context) : base(context)
        {
        }

        public void UpdateLastLogin(User user)
        {
            User userDB = base.Find<User>(user.Id);
            userDB.LastLoginTime = DateTime.Now;
            this.Commit();
        }
    }
}