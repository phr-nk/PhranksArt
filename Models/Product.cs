using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PhranksArt.Models
{
  public class Product
  {
    public string  Id { get; set; }
    public string Maker { get; set; }
    [JsonPropertyName("img")]
    public string Image { get; set; }
    [JsonPropertyName("3dObject")]
    public string ThreeDObject { get; set; }
    public string Title { get; set; }

    public int[] Ratings { get; set; }

    public override string ToString() => JsonSerializer.Serialize<Product>(this);
    
  }
}
