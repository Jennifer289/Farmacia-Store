﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaStore.BL
{
    public class Datosdeinicio:CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed (Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = "123";

            contexto.Usuarios.Add(nuevoUsuario);

            base.Seed(contexto);
        }
}
}

