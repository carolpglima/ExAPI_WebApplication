using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExAPI_WebApplication.Models
{
    public class Cliente
    {
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Nome = nome;
            //ou this.Nome = nome;
        }
    }
}