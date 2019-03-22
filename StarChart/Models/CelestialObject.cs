using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
   public class CelestialObject
   {

<<<<<<< HEAD
       public int Id { get; set; }
       [Required]
       public string Name { get; set; }
=======
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }    
        
        public int? OrbitedObjectId { get; set; }
        [NotMapped]
        public List<CelestialObject> Satellites {get; set;}
        public TimeSpan OrbitalPeriod { get; set; }
>>>>>>> c076c6a4ba5dcdd961db09916f9c3f9a1293f8f9

       public int? OrbitedObject { get; set; }
       [NotMapped]
       public List<CelestialObject> Satellites {get; set;}
       public TimeSpan OrbitalPeriod { get; set; }
   }
}