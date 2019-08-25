﻿using System;
using System.Collections.Generic;
using System.Text;
using ZFS.Core.Entity;
using ZFS.Core.Interfaces;
using ZFS.EFCore.DbFile;

namespace ZFS.EFCore.Repositories
{
    public class GroupUserRepository : BaseRepository<GroupUser>, IGroupUserRepository
    {
        public GroupUserRepository(ZfsDbContext context) : base(context)
        {

        }
    }
}