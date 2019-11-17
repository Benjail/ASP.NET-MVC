using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.Data.Models
{
    public class Car
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Shortdesc { get; set; }
    public string LongDesc { get; set; }
    public string Img { get; set; }
    public ushort Price  { get; set; }
    public bool IsFavourite { get; set; }
    public bool IsAvailible { get; set; }
    public int CategoryId { get; set; } //ID категории товара
    public virtual Category Category { get; set; } //категория товара

}
}
