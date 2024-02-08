using ConsoleAppTaskdop1hw0502.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleAppTaskdop1hw0502.Context
{
    public class Applicationtext : DbContext
    {
        public DbSet<Assignment> Assignments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Task0502;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var methodInfo = typeof(Applicationtext).GetMethod(nameof(CalculateWorkdays), new[] { typeof(DateTime), typeof(DateTime) });
            // Сопоставление хранимой функции
            modelBuilder.HasDbFunction(methodInfo)
       .HasName("CalculateWorkdays") 
       .HasSchema("dbo"); 
       
        }

        //метод для использования хранимой функции
        public int CalculateWorkdays(DateTime startDate, DateTime endDate)
            => throw new InvalidOperationException("This method is for use with Entity Framework Core only and has no implementation.");

    }

}
