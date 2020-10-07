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

        public bool FreioLigado { get; set; }
        public bool ArCondicionadoLigado { get; set; }
        public bool MP3Ligado { get; set; }

        public string ValorTotalFormatado 
        {
            get
            {
                return String.Format(GetDescricaoValorTotal(), GetValorTotal());
            }
        }

        public string GetDescricaoValorTotal()
        {
            return "Valor Total R$ {0} ";
        }

        public decimal GetValorTotal()
        {
            return Valor + (FreioLigado ? valorFreio : 0) + (ArCondicionadoLigado ? valorArCondicionado : 0) + (MP3Ligado ? valorMP3 : 0);
        }
    }
}
