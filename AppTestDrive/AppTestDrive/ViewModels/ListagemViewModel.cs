using AppTestDrive.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppTestDrive.ViewModels
{
    public class ListagemViewModel
    {
        public List<Veiculo> Veiculos { get; set; }

        private Veiculo veiculoSelecionado;
        public Veiculo VeiculoSelecionado
        {
            get 
            {
                return veiculoSelecionado;
            }
            set 
            {
                veiculoSelecionado = value;
                if(value != null)
                {
                    MessagingCenter.Send(veiculoSelecionado, "VeiculoSelecionado");
                }
            } 
        }

        public ListagemViewModel()
        {
            Veiculos = new ListagemVeiculos().Veiculos;
        }
    }
}
