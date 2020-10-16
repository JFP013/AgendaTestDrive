using AppTestDrive.Models;
using AppTestDrive.ViewModels;
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
        public AgendamentoViewModel ViewModel { get; set; }

        public AgendamentoView(Veiculo veiculo)
        {
            InitializeComponent();
            ViewModel = new AgendamentoViewModel(veiculo);
            BindingContext = ViewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MessagingCenter.Subscribe<Agendamento>(this, "Agendamento",
                (msg) =>
                {
                    DisplayAlert("Agendamento",
                String.Format(@"Veiculo: {0}
Nome: {1}
Fone: {2}
E-Mail: {3}
Data: {4}
Hora {5}",
ViewModel.Agendamento.Veiculo.Nome,
ViewModel.Agendamento.Nome,
ViewModel.Agendamento.Fone,
ViewModel.Agendamento.Email,
ViewModel.Agendamento.Data.ToString("dd/MM/yyyy"),
ViewModel.Agendamento.Hora),
                "OK");
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            MessagingCenter.Unsubscribe<Agendamento>(this, "Agendamento");
        }
    }
}