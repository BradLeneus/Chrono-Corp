using ChronoCorp.Model;
using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChronoCorp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employee { get; set; }
        public DbSet<EmployeeCredentials> Employee_Credentials { get; set; }
        public DbSet<TypeQuart> Type_Quart { get; set; }
        public DbSet<CeduleQuart> Cedule_Quart { get; set; }
        public DbSet<CedulePointage> Cedule_Pointage { get; set; }
        public DbSet<DemandeConge> Demande_Conge { get; set; }
        public DbSet<Messagerie> Messagerie { get; set; }
        public DbSet<FichePaie> Fiche_Paie { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;password=;database=chronocorp;";
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CeduleQuart>().HasOne(cedule => cedule.Employee).WithMany(emp => emp.CeduleQuartsEmp)
                .HasForeignKey(cedule => cedule.IdEmployee).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CeduleQuart>().HasOne(cedule => cedule.Gestionnaire).WithMany(emp => emp.CeduleQuartsGest)
                .HasForeignKey(cedule => cedule.IdCreateur).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DemandeConge>().HasOne(demande => demande.Employee).WithMany(emp => emp.DemandeConges)
                .HasForeignKey(cedule => cedule.IdEmetteur).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DemandeConge>().HasOne(demande => demande.Gestionnaire).WithMany(emp => emp.ApprobationConges)
                .HasForeignKey(cedule => cedule.IdDestinataire).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Messagerie>().HasOne(message => message.Employee1).WithMany(emp => emp.MessagerieSender)
                .HasForeignKey(cedule => cedule.IdEmetteur).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Messagerie>().HasOne(message => message.Employee2).WithMany(emp => emp.MessagerieReceiver)
                .HasForeignKey(cedule => cedule.IdDestinataire).OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
