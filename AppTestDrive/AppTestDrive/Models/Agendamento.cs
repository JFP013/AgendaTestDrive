using System;
using System.Collections.Generic;
using System.Text;

namespace AppTestDrive.Models
{
    public class Agendamento
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
    }
}
