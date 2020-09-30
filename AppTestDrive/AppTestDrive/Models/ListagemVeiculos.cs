using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AppTestDrive.Models
{
    public class ListagemVeiculos
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemVeiculos()
        {
            Veiculos = new List<Veiculo>()
            {
                new Veiculo {Nome="Azera v6", Valor = 60000},
                new Veiculo {Nome="Fiesta 2.0", Valor = 50000},
                new Veiculo { Nome = "HB20S", Valor = 40000 }
            };
        }
    }
}
