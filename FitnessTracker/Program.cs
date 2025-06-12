using FitnessTracker.Core.Data;
using FitnessTracker.Core.Models;
using FitnessTracker.Core.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;

namespace FitnessTracker.ConsoleApp
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var options = new DbContextOptionsBuilder<FitnessDbContext>()
                .UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                .Options;

            using var context = new FitnessDbContext(options);
            var fitnessService = new FitnessService(context);
            int userId = 1; // Für Demo-Zwecke festgelegt

            try
            {
                // Beispiel: Workout hinzufügen
                var workout = new Workout
                {
                    Date = DateTime.Now,
                    Exercise = "Bankdrücken",
                    Weight = 80.5,
                    Repetitions = 8,
                    Sets = 3,
                    UserId = userId
                };
                await fitnessService.AddWorkoutAsync(workout);
                Console.WriteLine("Workout hinzugefügt.");

                // Workouts anzeigen
                var workouts = await fitnessService.GetWorkoutsAsync(userId);
                Console.WriteLine("\nWorkouts:");
                foreach (var w in workouts)
                {
                    Console.WriteLine($"Datum: {w.Date}, Übung: {w.Exercise}, Gewicht: {w.Weight}kg, Wiederholungen: {w.Repetitions}, Sätze: {w.Sets}");
                }

                // Beispiel: Körpermaß hinzufügen
                var measurement = new BodyMeasurement
                {
                    Date = DateTime.Now,
                    Weight = 75.0,
                    MuscleCircumference = 35.5,
                    BodyFatPercentage = 15.0,
                    UserId = userId
                };
                await fitnessService.AddBodyMeasurementAsync(measurement);
                Console.WriteLine("Körpermaß hinzugefügt.");

                // Gewichtsverlauf anzeigen
                var measurements = await fitnessService.GetBodyMeasurementsAsync(userId);
                Console.WriteLine("\nGewichtsverlauf:");
                foreach (var m in measurements)
                {
                    Console.WriteLine($"Datum: {m.Date}, Gewicht: {m.Weight}kg");
                }

                // Beispiel: Trainingsplan hinzufügen
                var plan = new TrainingPlan
                {
                    Name = "Kraftplan",
                    Description = "Plan für Muskelaufbau",
                    UserId = userId,
                    Exercises = new List<PlanExercise>
                    {
                        new PlanExercise { Exercise = "Kniebeugen", Sets = 4, Repetitions = 10 }
                    }
                };
                await fitnessService.AddTrainingPlanAsync(plan);
                Console.WriteLine("Trainingsplan hinzugefügt.");

                // Trainingspläne anzeigen
                var plans = await fitnessService.GetTrainingPlansAsync(userId);
                Console.WriteLine("\nTrainingspläne:");
                foreach (var p in plans)
                {
                    Console.WriteLine($"Name: {p.Name}, Beschreibung: {p.Description}");
                    foreach (var e in p.Exercises)
                    {
                        Console.WriteLine($"  Übung: {e.Exercise}, Sätze: {e.Sets}, Wiederholungen: {e.Repetitions}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }
    }
}