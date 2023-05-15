namespace WoappLibrary.Models
{
    public class WorkoutModel
    {

        public event EventHandler WorkoutChanged;

        private DateOnly workoutDate;
        private string description;
        private List<ExerciseModel> exercises;

        public DateOnly WorkoutDate
        {
            get => workoutDate; 
            set
            {
                workoutDate = value;
                OnWorkoutModelChanged();
            }
        }
        public string Description
        {
            get => description; 
            set
            {
                description = value;
                OnWorkoutModelChanged();
            }
        }
        public List<ExerciseModel> Exercises
        {
            get => exercises; 
            set
            {
                UnsubscribeFromExcerciseModelChanged();
                exercises = value;
                SubscribeToExcerciseModelChanged();
                OnWorkoutModelChanged();
            }
        }
        protected virtual void OnWorkoutModelChanged()       //Když se změní něco ve workoutmodelu tak se to uloží
        {
            WorkoutChanged?.Invoke(this, EventArgs.Empty);
        }

        private void SubscribeToExcerciseModelChanged()                //Při každé uložení se modely přihlásí k odběru
        {
            if(exercises != null)
            {
                foreach (var exercise in exercises)
                {
                    exercise.ModelChanged += OnExerciseModelChanged;
                }

            }
        }
        private void UnsubscribeFromExcerciseModelChanged()                //Při každé uložení se modely přihlásí k odběru
        {
            if(exercises != null)
            {
                foreach (var exercise in exercises)
                {
                    exercise.ModelChanged -= OnExerciseModelChanged;
                }
            }
        }

        private void OnExerciseModelChanged(object? sender, EventArgs e) //Když se změní něco v exercisemodelu tak to vyvolá Onworkout který invokuje event a ten uloží snad celý objekt
        {
            OnWorkoutModelChanged();
        }
    }
}
