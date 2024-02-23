﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KutuphaneWeb.Models
{
    public class KitapTuru
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Kitap Tür Adı Boş Bırakılamaz!")]
        [DisplayName("Kitap Türü Adı")]
        [MaxLength(25)]
        public string Ad { get; set; }
    }
}
