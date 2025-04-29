using System;
using System.Collections.Generic;

namespace Eticaretproject.Models;

public partial class Kategoriler
{
    public int KategoriId { get; set; }

    public string? KategoriAdi { get; set; }

    public virtual ICollection<Urunler> Urunlers { get; set; } = new List<Urunler>();
}
