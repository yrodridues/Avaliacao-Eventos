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
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFinal { get; set; }
        public Boolean OpenBar { get; set; }
        public int QuantidadeAmbientes { get; set; }
        public string FaixaEtaria { get; set; }

        //Bonus Points
        [Required]
        public int MaximoIngressos { get; set; }
        [Required]
        public int IngressosVendidos { get; set; }
        public string QuantidadeIngressos { get; set; }
    }
}
