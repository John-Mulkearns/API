using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
    public  class Island
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        [Required]
        [StringLength(50)]
        public string IslandName { get; set; }
              
       /*#region
        [StringLength(2)]
        public string LangCode { get; set; }
    

        [Column("ord")]
        public int? Ord { get; set; }
        

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
     
        public int? MunicipioNum { get; set; }
     
        public int? PostCodeNum { get; set; }
     
        public int? ZonasNum { get; set; }
        #endregion
       */

        public ICollection<Municipio> Municipios { get; set; } = 
        new List<Municipio>();
    }
    
}
