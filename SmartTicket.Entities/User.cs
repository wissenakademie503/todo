using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTicket.Entities
{
    public class User:BaseEntitiy
    {
        [StringLength(200, ErrorMessage = "200 karakterden fazla giriş yaptınız.")]
        [Required(ErrorMessage = "Kullanıcı Adı zorunludur.")]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [StringLength(200, ErrorMessage = "200 karakterden fazla giriş yaptınız.")]
        [Required(ErrorMessage = "Şifre zorunludur.")]
        [DisplayName("Şifre")]
        public string Password { get; set; }

        [StringLength(200, ErrorMessage = "200 karakterden fazla giriş yaptınız.")]
        [Required(ErrorMessage = "Adı zorunludur.")]
        [DisplayName("Adı")]
        public string Name { get; set; }

        [StringLength(200, ErrorMessage = "200 karakterden fazla giriş yaptınız.")]
        [Required(ErrorMessage = "Soyadı zorunludur.")]
        [DisplayName("Soyadı")]
        public string SurName { get; set; }

        [StringLength(15, ErrorMessage = "15 karakterden fazla giriş yaptınız.")]
        [Required(ErrorMessage = "Telefon zorunludur.")]
        [DisplayName("Telefon")]
        public string Phone { get; set; }

        [StringLength(100, ErrorMessage = "100 karakterden fazla giriş yaptınız.")]
        [Required(ErrorMessage = "Mail zorunludur.")]
        [DisplayName("Mail")]
        public string Mail { get; set; }

        
        [Required(ErrorMessage = "Cinsiyet zorunludur.")]
        [DisplayName("Cinsiyet")]
        public bool Gender { get; set; }

        
        [DisplayName("Doğum Tarihi")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? BirthDay { get; set; }


        public virtual ICollection<Order> Orders { get; set; }


    }
}
