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

        private bool _freioLigado;
        public bool FreioLigado { 
            get 
            {
                return _freioLigado;
            } 
            set 
            {
                _freioLigado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            } 
        }

        private bool _arCondicionadoLigado;
        public bool ArCondicionadoLigado
        {
            get
            {
                return _arCondicionadoLigado;
            }
            set
            {
                _arCondicionadoLigado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        private bool _mp3Ligado;
        public bool MP3Ligado
        {
            get
            {
                return _mp3Ligado;
            }
            set
            {
                _mp3Ligado = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ValorTotal));
            }
        }

        public string ValorTotal
        {
            get
            {
                return String.Format(GetDescricaoValorTotal() , GetValorTotal());
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

        public string GetDescricaoValorTotal()
        {
            return "Valor Total R$ {0} ";
        }

        public decimal GetValorTotal()
        {
            return Veiculo.Valor + (_freioLigado ? Veiculo.valorFreio : 0) + (_arCondicionadoLigado ? Veiculo.valorArCondicionado : 0) + (_mp3Ligado ? Veiculo.valorMP3 : 0);
        }
    }
}