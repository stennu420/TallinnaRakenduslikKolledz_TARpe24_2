using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolled__TARpe24.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Kabinet")]
        public required string Location { get; set; }
    }
}