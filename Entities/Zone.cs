using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Entities
{
     public class Zone
    {

         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
         public int Id { get; set; }
       
        [StringLength(100)]
        public string ZoneName { get; set; }
        
        //[Column("postcode")]
 /*         public int? PostCode { get; set; }
        
        [Column("pop")]
        public int? Pop { get; set; }

        [ForeignKey("MunicipioId")]

        public int MunicipioId { get; set; }




        
        [Column("chicos")]
        public int? Chicos { get; set; }
        
        [Column("chicas")]
        public int? Chicas { get; set; }
        
        [StringLength(32)]
        public string Longitude { get; set; }
        
        [StringLength(32)]
        public string Latitude { get; set; }
        
        [Column("date_created", TypeName = "smalldatetime")]
        public DateTime? DateCreated { get; set; }
        
        [Column("date_updated", TypeName = "smalldatetime")]
        public DateTime? DateUpdated { get; set; }
        */

    }
}
