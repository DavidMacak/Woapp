namespace WoappLibrary.Models
{
    public class ExerciseModel
    {
        public string ExerciseType { get; set; } = string.Empty;
        public TimeOnly Rest { get; set; }
        public List<int> Repetitions { get; set; } = new();
    }
}
