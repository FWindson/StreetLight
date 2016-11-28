using Microsoft.AspNet.Identity;
using StreetLight.Models;
using StreetLight.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace StreetLight.App_Start
{
    public class UserService
    {
        public ClaimsIdentity CreateIdentity(Guid userId, string name, string email)
        {
            ClaimsIdentity identity = new ClaimsIdentity(DefaultAuthenticationTypes.ApplicationCookie);
            identity.AddClaim(new Claim(ClaimTypes.PrimarySid, userId.ToString()));
            identity.AddClaim(new Claim(ClaimTypes.Name, name));
            identity.AddClaim(new Claim(ClaimTypes.Email, email));
            return identity;
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public ResultModel Create(string name, string email, string password)
        {
            try
            {
                using (SLDb dbContext = new SLDb())
                {
                    User exsted = dbContext.User.FirstOrDefault(n => n.Name == name);
                    if (exsted != null)
                    {
                        return ResultModel.BuildError("该用户名已被使用");
                    }
                    exsted = dbContext.User.FirstOrDefault(n => n.Email == email);
                    if (exsted != null)
                    {
                        return ResultModel.BuildError("该邮箱已被使用");
                    }
                    User user = new User()
                    {
                        Id = Guid.NewGuid(),
                        Name = name,
                        Email = email,
                        IsDeleted = false,
                        Password = password,
                        CreateTime = DateTime.Now,
                        CreateBy = name
                    };
                    dbContext.User.Add(user);
                    dbContext.SaveChanges();

                    return ResultModel.BuildSuccess(this.CreateIdentity(user.Id, user.Name, user.Email));
                }
            }
            catch (Exception ex)
            {
                LogUtil.LogError(this, ex, "新建用户失败");
                return ResultModel.BuildError("系统抛出异常");
            }

        }
    }
}