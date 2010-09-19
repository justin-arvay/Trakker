﻿using System;
using System.Web.Mvc;
using Trakker.Data;
using System.Collections.Generic;

namespace Trakker.ViewData.UserData
{

    public class CreateEditUserViewData
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public int RoleId { get; set; }
        public IList<Role> Roles { get; set; }
    }

}