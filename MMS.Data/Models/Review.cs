using System;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MMS.Data.Models
{
    public class Review
    {     
        public int Id { get; set; }

        // name of reviewer
        [Required]//Valdidation
        public string Name { get; set; }

        // date review was made 
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")] // Validations added in
        public DateTime CreatedOn { get; set; } = DateTime.Now; //Setting the time to now for user Convenience

        // reviewer comments
        [Required] //Validation included so it is a requirement for the user to fill in
        [StringLength(500, MinimumLength = 5)]
        public string Comment { get; set; }

        // value between 1-10
        [Required] //Validation included so it is a requirement for the user to fill in
        [Range(0, 10)]
        public int Rating { get; set; }
    
        // EF Dependant Relationship Review belongs to a Movie
        public int MovieId { get; set; }

        // Navigation property
        public Movie Movie { get; set; }
 
    }
}