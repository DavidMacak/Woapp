using WoappLibrary;
using WoappLibrary.Models;

List<string> foundtWorkouts = WoappLibrary.JsonCrud.FindWorkouts();
foreach(string foundWorkout in foundtWorkouts)
{
    Console.WriteLine(foundWorkout);
}

WorkoutModel wo = Workout.Create();

wo.WorkoutChanged += (sender, args) => JsonCrud.SaveWorkoutModel((WorkoutModel)sender);


wo.Description = "Klasika shyby";

wo.Exercises = new List<ExerciseModel>();

wo.Exercises.Add(new ExerciseModel());
wo.Exercises[0].ExerciseType = "Shyby";
wo.Exercises[0].Rest = new TimeOnly(0,2,0);
wo.Exercises[0].Repetitions.Add(10);
wo.Exercises[0].Repetitions.Add(10);
wo.Exercises[0].Repetitions.Add(7);
wo.Exercises[0].Repetitions.Add(7);
wo.Exercises[0].Repetitions.Add(5);
wo.Exercises[0].Repetitions.Add(5);



Console.WriteLine(wo.WorkoutDate);
Console.WriteLine(wo.Description);
foreach(var exercises in wo.Exercises)
{
    Console.WriteLine(exercises.ExerciseType);
    Console.WriteLine(exercises.Rest);
    foreach (var rep in exercises.Repetitions)
    {
        Console.WriteLine(rep);
    }
}






//ExerciseModel mujExercise1 = Exercise.Create();
//ExerciseModel mujExercise2 = Exercise.Create();

//mujWorkout.Exercises.Add(mujExercise1);
//mujWorkout.Exercises.Add(mujExercise2);
