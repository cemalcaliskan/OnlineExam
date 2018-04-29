using OnlineSinav.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineSinav.BLL.Abstract
{
    interface IUserRoleSercive : IServiceBase<UserRole>
    {
        UserRole GetByRoleName(string role);
    }
}
