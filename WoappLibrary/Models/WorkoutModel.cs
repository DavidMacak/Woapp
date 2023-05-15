namespace WoappLibrary.Models
{
    public class WorkoutModel
    {
        public DateOnly WorkoutDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public List<ExerciseModel> Exercises { get; set; } = new();
    }
}
