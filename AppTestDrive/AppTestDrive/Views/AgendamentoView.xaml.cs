using AppTestDrive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTestDrive.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AgendamentoView : ContentPage
    {
        public Agendamento Agendamento { get; set; }

        public Veiculo Veiculo 
        {
            get 
            {
                return Agendamento.Veiculo;
            }
            set 
            {
                Agendamento.Veiculo = value;
            } 
        }
        public string Nome { 
            get 
            {
                return Agendamento.Nome;
            }
            set 
            {
                Agendamento.Nome = value;
            } 
        }

        public string Fone 
        { 
            get
            {
                return Agendamento.Fone;
            }
            set
            {
                Agendamento.Fone = value;
            } 
        }

        public string Email 
        {
            get 
            {
                return Agendamento.Email;
            } 
            set 
            {
                Agendamento.Email = value;
            } 
        }

        public DateTime Data 
        {
            get 
            {
                return Agendamento.Data;
            }
            set 
            {
                Agendamento.Data = value;
            } 
        }
        public TimeSpan Hora 
        {
            get 
            {
                return Agendamento.Hora;
            }
            set 
            {
                Agendamento.Hora = value;
            } 
        }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            Agendamento = new Agendamento();
            Agendamento.Veiculo = veiculo;
            BindingContext = this;
        }

        private void btnAgendar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
                String.Format(@"Veiculo: {0}
Nome: {1}
Fone: {2}
E-Mail: {3}
Data: {4}
Hora {5}", 
Veiculo.Nome,
Nome , 
Fone, 
Email, 
Data.ToString("dd/MM/yyyy"),
Hora),
                "OK");
        }
    }
}