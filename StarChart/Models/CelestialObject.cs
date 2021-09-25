using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StarChart.Models
{
    public class CelestialObject
    {
        int Id { get; set; }
        [Required]
        string Name { get; set; }
        int? OrbitedObjectId { get; set; }
        [NotMapped]
        List<CelestialObject> Satellites { get; set; }
        TimeSpan OrbitalPeriod { get; set; }

    }
}
