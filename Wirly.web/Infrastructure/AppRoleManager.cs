﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Wirly.web.Models;

namespace Wirly.web.Infrastructure
{
    public class AppRoleManager : RoleManager<AppRole>, IDisposable
    {
        public AppRoleManager(RoleStore<AppRole> store): base(store)
        {


        }

        public static AppRoleManager Create(IdentityFactoryOptions<AppRoleManager> options, IOwinContext context)
        {
            return new AppRoleManager(new RoleStore<AppRole>(context.Get<WirlyDbContext>()));
        }
    }
}