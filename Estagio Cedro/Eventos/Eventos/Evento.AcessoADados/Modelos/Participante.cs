using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Eventos.AcessoADados.Modelos
{
    public class Participante
    {
        //Bonus Points
        [ForeignKey(name: "IdEvento")]
        public Evento IdEvento { get; set; }
        [Required]
        public string NomeParticipante { get; set; }
        public string EmailParticipante { get; set; }
    }
}
