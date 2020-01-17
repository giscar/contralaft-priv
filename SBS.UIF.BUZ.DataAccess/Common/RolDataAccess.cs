﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SBS.UIF.BUZ.Entity.Common;
using SBS.UIF.BUZ.DataAccess.Mapper;

namespace SBS.UIF.BUZ.DataAccess.Common
{
    public class RolDataAccess
    {
        public List<Rol> listarPorRol()
        {
            return (BaseService<Rol>.QueryForList("select_rol", null));
        }
    }
}
