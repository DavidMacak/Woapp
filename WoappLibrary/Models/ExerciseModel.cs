/* Save format
ExerciseType: Shyby
Rest: 00:02:00
Repetitions: 10 10 10 8 8 5 5
 */

namespace WoappLibrary.Models
{
    public class ExerciseModel
    {
        public string ExerciseType { get; set; } = string.Empty;
        public TimeOnly Rest { get; set; }
        public List<int> Repetitions { get; set; } = new List<int>();
    }
}
