/* Save format
ExerciseType: Shyby
Rest: 00:02:00
Repetitions: 10 10 10 8 8 5 5
 */

namespace WoappLibrary.Models
{
    public class ExerciseModel
    {
        public event EventHandler ModelChanged;

        private string exerciseType;
        private TimeOnly rest;
        private List<int> repetitions;

        public string ExerciseType
        {
            get => exerciseType; 
            set
            {
                exerciseType = value;
                OnModelChanged();
            }
        }
        public TimeOnly Rest
        {
            get => rest; 
            set
            {
                rest = value;
                OnModelChanged();
            }
        }
        public List<int> Repetitions
        {
            get => repetitions; 
            set
            {
                repetitions = value;
                OnModelChanged();
            }
        }

        protected virtual void OnModelChanged()
        {
            ModelChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
