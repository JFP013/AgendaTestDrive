using System;
using System.Collections.Generic;
using System.Text;

namespace AppTestDrive.Models
{
    public class Veiculo
    {
        public const decimal valorFreio = 800;
        public const decimal valorArCondicionado = 1000;
        public const decimal valorMP3 = 500;

        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public string PrecoFormatado
        {
            get { return String.Format("R$ {0}", Valor); }
        }
    }
}
