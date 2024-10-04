using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace EfCoreMigrations.DTO;

[ComplexType]
public class VipStatus
{
    [JsonPropertyName("untilTo")]
    public DateTime UntilTo { get; set; }
    [JsonPropertyName("saleProcent")]
    private byte saleProcent;
    public Byte SaleProcent
    {
        get
        {
            return saleProcent;
        }
        set
        {
            if(value<=100)
            {
                saleProcent = value;
            }
            else
            {
                saleProcent = 0;
            }
        }
    }
}
