using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Komis_aspnet_core_tutorial.Models
{
    public class Opinia
    {
        [BindNever]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa Użytkownika jest wymagana")]
        [StringLength(100, ErrorMessage ="Nazwa Użytkownika jest za długa")]
        public string NazwaUzytkownika { get; set; }

        [Required(ErrorMessage = "Email jest wymagany")]
        [StringLength(100, ErrorMessage ="Adres jest zbyt dlugi")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "To nie jest poprawny adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Wiadomość jest wymagana")]
        [StringLength(5000, ErrorMessage ="Wiadomość zbyt długa")]
        public string Wiadomosc { get; set; }
        public bool OczekujOdpowiedzi { get; set; }
    }
}
