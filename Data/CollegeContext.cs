using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallinnaRakenduslikKolled__TARpe24.Models;

namespace TallinnaRakenduslikKolled__TARpe24.Data
{
    public class CollegeContext : DbContext
    {
        public CollegeContext (DbContextOptions<CollegeContext> options)
            : base(options)
        {
        }

        public DbSet<TallinnaRakenduslikKolled__TARpe24.Models.Course> Course { get; set; } = default!;
        public DbSet<TallinnaRakenduslikKolled__TARpe24.Models.Department> Department { get; set; } = default!;
        public DbSet<TallinnaRakenduslikKolled__TARpe24.Models.Student> Student { get; set; } = default!;
        public DbSet<TallinnaRakenduslikKolled__TARpe24.Models.Instructor> Instructor { get; set; } = default!;
    }
}
