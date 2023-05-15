using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoappLibrary.Models;

namespace WoappLibrary
{
    public static class Workout
    {
        public static WorkoutModel Create()
        {
            WorkoutModel workout = new();
            DateTime today = DateTime.Now;
            workout.WorkoutDate = new(today.Year, today.Month, today.Day);
            JsonCrud.SaveWorkoutModel(workout);
            return workout;
        }
        public static WorkoutModel Save(WorkoutModel workout)
        {
            JsonCrud.SaveWorkoutModel(workout);
            return workout;
        }
        public static void Delete(WorkoutModel workout)
        {
            JsonCrud.DeleteWorkoutModel(workout);
        }
    }
}
