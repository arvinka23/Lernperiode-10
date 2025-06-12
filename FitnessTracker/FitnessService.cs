using FitnessTracker.Core.Data;
using FitnessTracker.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FitnessTracker.Core.Services
{
    public class FitnessService
    {
        private readonly FitnessDbContext _context;

        public FitnessService(FitnessDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task AddWorkoutAsync(Workout workout)
        {
            if (workout == null) throw new ArgumentNullException(nameof(workout));
            if (string.IsNullOrWhiteSpace(workout.Exercise)) throw new ArgumentException("Exercise name is required.");
            if (workout.Weight < 0) throw new ArgumentException("Weight cannot be negative.");
            if (workout.Repetitions <= 0) throw new ArgumentException("Repetitions must be positive.");
            if (workout.Sets <= 0) throw new ArgumentException("Sets must be positive.");

            try
            {
                await _context.Workouts.AddAsync(workout);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Fehler beim Speichern des Workouts.", ex);
            }
        }

        public async Task<List<Workout>> GetWorkoutsAsync(int userId)
        {
            return await _context.Workouts
                .Where(w => w.UserId == userId)
                .OrderBy(w => w.Date)
                .ToListAsync();
        }

        public async Task AddBodyMeasurementAsync(BodyMeasurement measurement)
        {
            if (measurement == null) throw new ArgumentNullException(nameof(measurement));
            if (measurement.Weight <= 0) throw new ArgumentException("Weight must be positive.");

            try
            {
                await _context.BodyMeasurements.AddAsync(measurement);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Fehler beim Speichern der Körpermaße.", ex);
            }
        }

        public async Task<List<BodyMeasurement>> GetBodyMeasurementsAsync(int userId)
        {
            return await _context.BodyMeasurements
                .Where(b => b.UserId == userId)
                .OrderBy(b => b.Date)
                .ToListAsync();
        }

        public async Task AddTrainingPlanAsync(TrainingPlan plan)
        {
            if (plan == null) throw new ArgumentNullException(nameof(plan));
            if (string.IsNullOrWhiteSpace(plan.Name)) throw new ArgumentException("Plan name is required.");
            if (plan.Exercises.Any(e => string.IsNullOrWhiteSpace(e.Exercise))) throw new ArgumentException("Exercise name is required.");
            if (plan.Exercises.Any(e => e.Sets <= 0 || e.Repetitions <= 0)) throw new ArgumentException("Sets and repetitions must be positive.");

            try
            {
                await _context.TrainingPlans.AddAsync(plan);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("Fehler beim Speichern des Trainingsplans.", ex);
            }
        }

        public async Task<List<TrainingPlan>> GetTrainingPlansAsync(int userId)
        {
            return await _context.TrainingPlans
                .Include(tp => tp.Exercises)
                .Where(tp => tp.UserId == userId)
                .ToListAsync();
        }
    }
}