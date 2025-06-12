namespace FitnessTracker.Core.Models
{
    public class PlanExercise
    {
        public int Id { get; set; }
        public int TrainingPlanId { get; set; }
        public string Exercise { get; set; } = string.Empty;
        public int Sets { get; set; }
        public int Repetitions { get; set; }
    }
}