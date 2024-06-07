using System.ComponentModel.DataAnnotations.Schema;

namespace CountryBackendTask.Models.Entities
{
    public class Country
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }

    }
}
