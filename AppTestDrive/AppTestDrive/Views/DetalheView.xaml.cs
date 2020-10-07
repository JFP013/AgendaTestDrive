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
    public partial class DetalheView : ContentPage
    {
        public Veiculo Veiculo { get; set; }

        public string DescricaoFreio 
        {
            get { return String.Format("Freio Abs - R$ {0}", Veiculo.valorFreio); }
        }
        public string DescricaoArCondicionado 
        { 
            get { return String.Format("Ar Condicionado - R$ {0}", Veiculo.valorArCondicionado); } 
        }
        public string DescricaoMP3 
        {
            get { return String.Format("MP3 Player - R$ {0}", Veiculo.valorMP3); } 
        }

        
        public bool FreioLigado { 
            get 
            {
                return Veiculo.FreioLigado;
            } 
            set 
            {
                Veiculo.FreioLigado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            } 
        }

        public bool ArCondicionadoLigado
        {
            get
            {
                return Veiculo.ArCondicionadoLigado;
            }
            set
            {
                Veiculo.ArCondicionadoLigado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public bool MP3Ligado
        {
            get
            {
                return Veiculo.MP3Ligado;
            }
            set
            {
                Veiculo.MP3Ligado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return Veiculo.ValorTotalFormatado;
            }
        }

        public DetalheView(Veiculo veiculo)
        {
            InitializeComponent();
            Veiculo = veiculo;
            BindingContext = this;
        }

        private void BtnProximo_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AgendamentoView(Veiculo));
        }
    }
}