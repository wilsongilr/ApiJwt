using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiJwt.Models.Matic
{
    public class ITHTicket
    {
        [Key]
        public int IdTicket { get; set; }
        [ForeignKey("IdSolicitud")]
        public int IdSolicitud { get; set; }
        public string Solicitud { get; set; }
        public string Descripcion { get; set; }
        [ForeignKey("IdEstado")]
        public int IdEstado { get; set; }
        public string UsrSolicita { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public Boolean Adjunto { get; set; }    
    }
}
