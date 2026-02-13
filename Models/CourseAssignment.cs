using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolled__TARpe24.Models
{
    public class CourseAssignment
    {
        [Key]
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int CourseID { get; set; }
        public required Instructor instructor { get; set; }
        public required Course Course { get; set; }
    }
}