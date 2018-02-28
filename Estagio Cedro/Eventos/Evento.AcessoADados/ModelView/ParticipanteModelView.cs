using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Eventos.AcessoADados.ModelView
{
    public class ParticipanteModelView
    {

        //Bonus Points
        [Required]
        public string NomeParticipante { get; set; }
        public string EmailParticipante { get; set; }
    }
}
