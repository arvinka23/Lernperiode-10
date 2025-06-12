namespace FitnessTracker.Core.Models
{
    public class Workout
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Exercise { get; set; } = string.Empty;
        public double Weight { get; set; }
        public int Repetitions { get; set; }
        public int Sets { get; set; }
        public int UserId { get; set; }
    }
}