using FitnessTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace FitnessTracker.Core.Data
{
    public class FitnessDbContext : DbContext
    {
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<BodyMeasurement> BodyMeasurements { get; set; }
        public DbSet<TrainingPlan> TrainingPlans { get; set; }
        public DbSet<PlanExercise> PlanExercises { get; set; }

        public FitnessDbContext(DbContextOptions<FitnessDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyMeasurement>()
                .Property(b => b.Weight)
                .HasPrecision(5, 2);

            modelBuilder.Entity<TrainingPlan>()
                .HasMany(tp => tp.Exercises)
                .WithOne()
                .HasForeignKey(pe => pe.TrainingPlanId);

            modelBuilder.Entity<Workout>()
                .HasIndex(w => new { w.UserId, w.Date });

            modelBuilder.Entity<BodyMeasurement>()
                .HasIndex(b => new { b.UserId, b.Date });
        }
    }
}