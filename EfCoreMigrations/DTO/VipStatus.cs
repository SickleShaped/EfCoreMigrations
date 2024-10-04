using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Xml.Linq;

namespace EfCoreMigrations.DTO;

//[ComplexType]
public class VipStatus
{
    private byte _saleProcent;

    [JsonPropertyName("untilTo")]
    public DateTime UntilTo { get; set; }
    
    [JsonPropertyName("saleProcent")]
    public Byte SaleProcent
    {
        get
        {
            return _saleProcent;
        }
        set
        {
            if(value<=100)
            {
                _saleProcent = value;
            }
            else
            {
                _saleProcent = 0;
            }
        }
    }
}
