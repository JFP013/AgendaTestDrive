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
        public Veiculo Veiculo { get; set; }
        public string Nome { get; set; }
        public string Fone { get; set; }
        public string Email { get; set; }

        private DateTime _data = DateTime.Today;
        public DateTime Data 
        {
            get 
            {
                return _data;
            }
            set 
            {
                _data = value;
            } 
        }
        public TimeSpan Hora { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            Veiculo = veiculo;
            BindingContext = this;
        }

        private void btnAgendar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Agendamento",
                String.Format(@"Nome: {0}
Fone: {1}
E-Mail: {2}
Data: {3}
Hora {4}", 
Nome , 
Fone, 
Email, 
Data.ToString("dd/MM/yyyy"),
Hora),
                "OK");
        }
    }
}