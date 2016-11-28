using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace StreetLight.App_Start
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // 在此处插入电子邮件服务可发送电子邮件。
            return Task.FromResult(0);
        }
    }
}