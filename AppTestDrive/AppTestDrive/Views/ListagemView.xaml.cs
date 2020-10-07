﻿using AppTestDrive.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTestDrive.Views
{
    public partial class ListagemView : ContentPage
    {
        public ListagemView()
        {
            InitializeComponent();
        }

        private void listViewVeiculo_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var veiculo = (Veiculo)e.Item;

            Navigation.PushAsync(new DetalheView(veiculo));
        }
    }
}
