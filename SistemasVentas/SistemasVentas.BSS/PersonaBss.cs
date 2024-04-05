﻿using SistemasVentas.DAL;
using SistemasVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SistemasVentas.BSS
{
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonasBss()
        {
            return dal.ListarPersonasDal();
        }
        
        public int InsertarPersonaBss(Persona persona) 
        {
            return dal.InsertarPersonaDal(persona);
        }

        public Persona ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }

        public int ObtenerUltimoPersonaIdBss()
        {
            return dal.ObtenerUltimoPersonaId();
        }

        public void EditarPersonaBss(Persona persona)
        {
            dal.EditarPersonaDal(persona);
        }

        public void EliminarPersonaBss(int id) 
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
