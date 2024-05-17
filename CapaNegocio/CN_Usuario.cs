﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objCD_Usuario = new CapaDatos.CD_Usuario();

        public List<Usuario> Listar()
        {
            return objCD_Usuario.Listar();
        }

        public int Registrar(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                mensaje += "Es necesario el nombre del usuario\n"; 
            }

            if (obj.Documento == "")
            {
                mensaje += "Es necesario el numero del usuario\n";
            }

            if (obj.Clave == "")
            {
                mensaje += "Es necesario la clave del usuario\n";
            }

            if(mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objCD_Usuario.Registrar(obj,out mensaje);
            }
            
        }

        public bool Editar(Usuario obj, out string mensaje)
        {

            mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Documento == "")
            {
                mensaje += "Es necesario el numero del usuario\n";
            }

            if (obj.Clave == "")
            {
                mensaje += "Es necesario la clave del usuario\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCD_Usuario.Editar(obj, out mensaje);
            }
            
        }

        public bool Eliminar(Usuario obj, out string mensaje)
        {

            mensaje = string.Empty;

            if (obj.NombreCompleto == "")
            {
                mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Documento == "")
            {
                mensaje += "Es necesario el numero del usuario\n";
            }

            if (obj.Clave == "")
            {
                mensaje += "Es necesario la clave del usuario\n";
            }

            if (mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCD_Usuario.Eliminar(obj, out mensaje);
            }

            
        }
    }
}
