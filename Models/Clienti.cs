using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AziendaSpedizioniDiLusso.Models
{
    public class Clienti
    {
        public int IdCliente { get; set; }

        [DisplayName("Nome Cliente")]
        [Required(ErrorMessage = "Nome obbligatorio")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Il nome deve essere compreso tra 3 e 50 caratteri")]
        public string Nominativo { get; set; }

        [DisplayName("Privato o azienda")]
        public bool IsAzienda { get; set; }

        [Remote("CheckCF", "Home", ErrorMessage = "Inserisci un codice fiscale valido")]
        public string CF { get; set; }
        [Remote("CheckPartitaIVA", "Home", ErrorMessage = "Inserisci una parita IVA valida")]
        public string PartitaIVA { get; set; }
    }
}