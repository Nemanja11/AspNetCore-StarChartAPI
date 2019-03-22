using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
   public class CelestialObject
   {

       public int Id { get; set; }
       [Required]
       public string Name { get; set; }

       public int? OrbiteObject { get; set; }
       [NotMapped]
       public List<CelestialObject> Satelites {get; set;}
       public TimeSpan OrbitalPeriod { get; set; }




   }
}