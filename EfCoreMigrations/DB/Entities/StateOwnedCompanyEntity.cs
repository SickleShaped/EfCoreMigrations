using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfCoreMigrations.DB.Entities;

[Table("state_owned_companies")]
public class StateOwnedCompanyEntity:CompanyEntity
{
    [Required]
    public string CompanyCountry { get; set; } = default!;
}
