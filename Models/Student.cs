using System.ComponentModel.DataAnnotations;

namespace TallinnaRakenduslikKolled__TARpe24.Models;

public class Student
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
    public ICollection<Enrollment>? Enrollments { get; set; }
    public string? HomeAddress { get; set; }
    public int? Age { get; set; }
    public string? Email { get; set; }

}