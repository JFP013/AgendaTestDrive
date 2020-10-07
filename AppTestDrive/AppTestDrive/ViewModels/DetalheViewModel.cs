using AppTestDrive.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace AppTestDrive.ViewModels
{
    public class DetalheViewModel : INotifyPropertyChanged
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


        public bool FreioLigado
        {
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

        public DetalheViewModel(Veiculo veiculo)
        {
            Veiculo = veiculo;

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
