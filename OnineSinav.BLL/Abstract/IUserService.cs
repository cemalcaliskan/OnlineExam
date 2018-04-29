﻿using OnlineSinav.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnineSinav.BLL.Abstract
{
    interface IUserService : IServiceBase<User>
    {
        User GetByActivationCode(Guid code);
        User GetByMailAndPassword(string mail, string passsword);
    }
}
