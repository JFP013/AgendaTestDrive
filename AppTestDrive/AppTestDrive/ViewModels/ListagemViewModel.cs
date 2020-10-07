using AppTestDrive.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTestDrive.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        public ListagemViewModel()
        {
            Veiculos = new ListagemVeiculos().Veiculos;
        }
    }
}
