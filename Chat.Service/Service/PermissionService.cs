﻿using Chat.IService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chat.DTO.DTO;

namespace Chat.Service.Service
{
    public class PermissionService : IPermissionService
    {
        public long AddNew(string name, string description)
        {
            throw new NotImplementedException();
        }

        public void AddPermissionIds(long roleId, long[] permissionIds)
        {
            throw new NotImplementedException();
        }

        public PermissionDTO[] GetAll()
        {
            throw new NotImplementedException();
        }

        public PermissionDTO GetById(long id)
        {
            throw new NotImplementedException();
        }

        public PermissionDTO GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public PermissionDTO[] GetByRoleId(long roleId)
        {
            throw new NotImplementedException();
        }

        public bool MarkDeleted(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePermission(long id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public void UpdatePermissionIds(long roleId, long[] permissionIds)
        {
            throw new NotImplementedException();
        }
    }
}
