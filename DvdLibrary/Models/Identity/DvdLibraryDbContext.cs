﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DvdLibrary.Models.Identity
{
    public class DvdLibraryDbContext : IdentityDbContext<AppUser>
    {
        public DvdLibraryDbContext() : base("DVDLibrary")
        {

        }
    }
}