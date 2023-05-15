using WoappLibrary;
using WoappLibrary.Models;



List<string> foundtWorkouts = WoappLibrary.JsonCrud.FindWorkouts();
Console.WriteLine("Nalezeno: ");
foreach (string foundWorkout in foundtWorkouts)
{
    Console.WriteLine(foundWorkout);
}
Console.WriteLine();




WorkoutModel wo = Workout.Create();
wo.Description = "Klasika shyby";

wo.Exercises.Add(new ExerciseModel());
wo.Exercises[0].ExerciseType = "Shyby";
wo.Exercises[0].Rest = new TimeOnly(0,2,0);
wo.Exercises[0].Repetitions.Add(10);
wo.Exercises[0].Repetitions.Add(10);
wo.Exercises[0].Repetitions.Add(7);
wo.Exercises[0].Repetitions.Add(7);
wo.Exercises[0].Repetitions.Add(5);
wo.Exercises[0].Repetitions.Add(5);

wo.Exercises.Add(new ExerciseModel());
wo.Exercises[1].ExerciseType = "Dipy";
wo.Exercises[1].Rest = new TimeOnly(0, 2, 0);
wo.Exercises[1].Repetitions.Add(15);
wo.Exercises[1].Repetitions.Add(15);
wo.Exercises[1].Repetitions.Add(10);
wo.Exercises[1].Repetitions.Add(10);

//Save button
JsonCrud.SaveWorkoutModel(wo);





//Načte wol
List<WorkoutModel> workouts = new();
foreach(var foundwo in foundtWorkouts)
{
    workouts.Add(JsonCrud.LoadWorkout(foundwo));
}

foreach(var workout in workouts)
{
    Console.WriteLine(workout.WorkoutDate);
    Console.WriteLine(workout.Description);
    foreach (var exercises in workout.Exercises)
    {
        Console.WriteLine(exercises.ExerciseType);
        Console.WriteLine(exercises.Rest);
        foreach (var rep in exercises.Repetitions)
        {
            Console.WriteLine(rep);
        }
    }

}






//ExerciseModel mujExercise1 = Exercise.Create();
//ExerciseModel mujExercise2 = Exercise.Create();

//mujWorkout.Exercises.Add(mujExercise1);
//mujWorkout.Exercises.Add(mujExercise2);
