using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.AcessoADados.ModelView
{
    public class EventoModelView
    {
        [Required]
        public string NomeEvento { get; set; }
        [Required]
        public DateTime DataEvento { get; set; }
        [Required]
        public string LocalEvento { get; set; }
        public int HorarioInicio { get; set; }
        public int HorarioFinal { get; set; }
        public Boolean OpenBar { get; set; }
        public int QuantidadeAmbientes { get; set; }
        public string FaixaEtaria { get; set; }
    }
}
