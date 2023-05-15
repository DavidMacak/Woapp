using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WoappLibrary.Models;

namespace WoappLibrary
{
    public static class JsonCrud
    {
        public static string GetWorkoutsFolderPath()
        {
            string personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string woappFolder = "Woapp";
            string woappWorkoutFolder = "Workouts";
            return Path.Combine(personalFolder, woappFolder, woappWorkoutFolder);
        }
        public static string GetFullPath(string filename)
        {
            string woappFolder = GetWorkoutsFolderPath();
            return Path.Combine(woappFolder, filename);
        }
        public static List<string> FindWorkouts()
        {
            string path = GetWorkoutsFolderPath();
            List<string> workouts = new();
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            workouts = Directory.GetFiles(path, "*.json").ToList();
            return workouts;
        }
        public static WorkoutModel LoadWorkout(string filename)
        {
            string json = File.ReadAllText(filename);
            WorkoutModel workout = JsonConvert.DeserializeObject<WorkoutModel>(json);
            return workout;
        }
        public static List<WorkoutModel> LoadAllWorkouts()
        {
            List<string> workoutsFilenames = FindWorkouts();
            List<WorkoutModel> workouts = new();
            foreach (string filename in workoutsFilenames)
            {
                workouts.Add(LoadWorkout(filename));
            }
            return workouts;
        }
        public static void SaveWorkoutModel(WorkoutModel workout)
        {
            string json = JsonConvert.SerializeObject(workout);
            string filename = $"{workout.WorkoutDate.Year}-{workout.WorkoutDate.Month}-{workout.WorkoutDate.Day}.json";
            string fullpath = GetFullPath(filename);
            File.WriteAllText(fullpath, json);
        }

        public static void DeleteWorkoutModel(WorkoutModel workout)
        {
            string filename = $"{workout.WorkoutDate.Year}-{workout.WorkoutDate.Month}-{workout.WorkoutDate.Day}.json";
            string fullpath = GetFullPath(filename);
            if(File.Exists(fullpath))
            {
                File.Delete(fullpath);
            }
        }
    }
}
