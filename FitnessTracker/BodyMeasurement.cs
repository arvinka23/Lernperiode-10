namespace FitnessTracker.Core.Models
{
    public class BodyMeasurement
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Weight { get; set; }
        public double? MuscleCircumference { get; set; }
        public double? BodyFatPercentage { get; set; }
        public int UserId { get; set; }
    }
}