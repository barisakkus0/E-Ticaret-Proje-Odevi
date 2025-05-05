using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Eticaretproject.Models;

public partial class Oneriler
{

    public int OneriId { get; set; }

    public int? KullaniciId { get; set; }

    public int? UrunId { get; set; }

    public string? Gerekce { get; set; }

    public virtual Kullanicilar? Kullanici { get; set; }

    public virtual Urunler? Urun { get; set; }
}
