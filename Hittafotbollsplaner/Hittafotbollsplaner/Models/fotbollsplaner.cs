//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Hittafotbollsplaner.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class fotbollsplaner
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "F�ltet Namn kr�vs."), StringLength(25, MinimumLength = 3, ErrorMessage = "Namnet b�r vara minst tre bokst�ver.")]
        public string Namn { get; set; }
        [Required(ErrorMessage = "F�ltet Adress kr�vs."), StringLength(25, MinimumLength = 3, ErrorMessage = "Adressen b�r vara minst tre bokst�ver.")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "F�ltet Ort kr�vs."), StringLength(20, MinimumLength = 3, ErrorMessage = "Ortsnamnet b�r vara minst tre bokst�ver.")]
        public string Ort { get; set; }
        [Required(ErrorMessage = "F�ltet Postnummer kr�vs."), StringLength(5, MinimumLength = 5, ErrorMessage = "Postnummret b�r vara fem siffor ihop.")]
        public string Postnummer { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string AntalGras { get; set; }
        public string AntalGrus { get; set; }
        public string AntalKonstGras { get; set; }
        public Nullable<bool> Parkering { get; set; }
        public Nullable<bool> Kafe { get; set; }
        public Nullable<bool> Omkladnadsrum { get; set; }
        public Nullable<bool> Restaurang { get; set; }
        public Nullable<bool> Upplyst { get; set; }
        public Nullable<bool> Bokning { get; set; }
        public string Hemsida { get; set; }
    }
}
