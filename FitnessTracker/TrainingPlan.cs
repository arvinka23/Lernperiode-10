namespace FitnessTracker.Core.Models
{
    public class TrainingPlan
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int UserId { get; set; }
        public List<PlanExercise> Exercises { get; set; } = new List<PlanExercise>();
    }
}