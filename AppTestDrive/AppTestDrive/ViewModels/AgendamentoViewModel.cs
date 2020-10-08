using AppTestDrive.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppTestDrive.ViewModels
{
    public class AgendamentoViewModel
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
        public string Nome
        {
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

        public AgendamentoViewModel(Veiculo veiculo)
        {
            Agendamento = new Agendamento();
            Agendamento.Veiculo = veiculo;
        }
    }
}
