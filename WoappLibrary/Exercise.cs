using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoappLibrary.Models;

namespace WoappLibrary
{
    public static class Exercise
    {
        public static ExerciseModel Create()
        {
            ExerciseModel ex = new();

            return ex;
        }

        public static ExerciseModel Create(string exerciseType)
        {
            ExerciseModel ex = new();
            ex.ExerciseType = exerciseType;
            return ex;
        }
        public static ExerciseModel ChangeType(ExerciseModel ex, string exerciseType) 
        {
            ex.ExerciseType = exerciseType;
            return ex;
        }
        public static ExerciseModel Rest(ExerciseModel ex, TimeOnly time)
        {
            ex.Rest = time;

            return ex;
        }
        public static ExerciseModel AddRepetitions(ExerciseModel ex,int reps)
        {
            ex.Repetitions.Add(reps);
            return ex;
        }
    }
}
