using System.Xml.Linq;

namespace EfCoreMigrations.DTO;

public class VipStatus
{
    public DateTime UntilTo { get; set; }
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
