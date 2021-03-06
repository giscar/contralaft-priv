﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SBS.UIF.BUZ.Entity.Common;
using SBS.UIF.BUZ.DataAccess.Mapper;

namespace SBS.UIF.BUZ.DataAccess.Common
{
    public class PerfilDataAccess
    {
        public List<Perfil> listarPorPerfil()
        {
            return (BaseService<Perfil>.QueryForList("select_perfil", null));
        }

        public int guardarPerfil(Perfil _perfil)
        {
            return (Convert.ToInt32(MapperPro.Instance().Insert("insert_perfil", _perfil)));
        }
    }
}
