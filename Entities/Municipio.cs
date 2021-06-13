using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
      public  class Municipio
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int Id { get; set; }
      
        [Required]
         [StringLength(50)]
        public string MunicipioName { get; set; }
        public int Pop { get; set; }
        public string Area { get; set; }
        public string Map1 { get; set; }

        [ForeignKey("IslandId")]
        public int IslandId { get; set; }
        public Island Island { get; set; }

        public ICollection<Zone> Zones { get; set; } =
         new List<Zone>();

        /*
         [Column("pop")]
         public int? Pop { get; set; }

         [Column("area")]
         [StringLength(10)]
         public string Area { get; set; }

         [Column("map1")]
         [StringLength(150)]
         public string Map1 { get; set; }

         [Column("map2")]
         [StringLength(150)]
         public string Map2 { get; set; }

         [Column("map3")]
         [StringLength(150)]
         public string Map3 { get; set; }

         [StringLength(10)]
         public string Lat { get; set; }

         [StringLength(10)]
         public string Long { get; set; }

         public int? ZonasNum { get; set; }

         [Column("website")]
         [StringLength(250)]
         public string Website { get; set; }
         [StringLength(12)]
         public string Tel { get; set; }

         [StringLength(12)]
         public string TelAlcard { get; set; }

         [StringLength(50)]
         public string Email { get; set; }

         [StringLength(50)]
         public string Direcion { get; set; }

         [StringLength(5)]
         public string CodigoPostal { get; set; }

         [StringLength(12)]
         public string PartidoPolitical { get; set; }

         [StringLength(50)]
         public string Alcard { get; set; }

         [Column("AlcardFotoURL")]
         [StringLength(250)]
         public string AlcardFotoUrl { get; set; }

         [Column("votantes")]
         public int? Votantes { get; set; }

         [Column("abstenciones")]
         public int? Abstenciones { get; set; }

         [StringLength(4)]
         public string Codmun { get; set; }

         [StringLength(3)]
         public string Codpro { get; set; }
        */

    }
}
