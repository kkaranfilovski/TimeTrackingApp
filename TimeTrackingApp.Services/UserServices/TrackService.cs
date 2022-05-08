using TimeTrackingApp.Models.Classes;
using TimeTrackingApp.Models.Enums;
using TimeTrackingApp.Services.Helpers;
using TimeTrackingApp.Services.Menus;

namespace TimeTrackingApp.Services.UserServices
{
    public class TrackService
    {
        public void TrackActivityMenu(User user)
        {
            while (true)
            {
                try
                {
                    Screen.ActivityMenu();
                    string selection = Console.ReadLine();

                    if (selection == "1")
                    {
                        ReadingMenu(user);
                    }
                    else if (selection == "2")
                    {
                        ExercisingMenu(user);
                    }
                    else if (selection == "3")
                    {
                        WorkingMenu(user);
                    }
                    else if (selection == "4")
                    {
                        HobbyMenu(user);
                    }
                    else if (selection == "5")
                    {
                        Thread.Sleep(1000);
                        break;
                    }
                    else
                    {
                        throw new ApplicationException("invalid selection");
                    }
                }
                catch (ApplicationException ex)
                {
                    Helper.ShowError(ex.Message);
                    Logger.Log(ex.Message);
                }
            }
        }

        private void ReadingMenu(User user)
        {
            Console.WriteLine("Reading Menu");
            Console.WriteLine("Choose the type of book:");
            var type = Helper.GetType<ReadingTypes>();

            Console.WriteLine("Enter the number of pages of the book:");
            int numOfPages = Helper.ParseInput(Console.ReadLine());

            var reading = new Reading((ReadingTypes)type, numOfPages);
            user.Activities.Add(reading);

            Console.WriteLine("Starting to counting time. Press any key to stop!");
            reading.TrackTime.Start();
            Console.ReadLine();

            Console.WriteLine("Time tracking stopped!");
            reading.TrackTime.Stop();

            var time = reading.TrackTime.Elapsed;
            Console.WriteLine($"Time spent reading {reading.Type}: {time.Hours} hours, {time.Minutes} minutes, {time.Seconds} seconds");

            Console.ReadLine();
        }

        private void ExercisingMenu(User user)
        {
            Console.WriteLine("Exercise Menu");
            Console.WriteLine("Choose the type of exercise:");
            var type = Helper.GetType<ExerciseTypes>();

            var exercise = new Exercising((ExerciseTypes)type);
            user.Activities.Add(exercise);

            Console.WriteLine("Starting to counting time. Press any key to stop!");
            exercise.TrackTime.Start();

            Console.ReadLine();
            Console.WriteLine("Time tracking stopped!");
            exercise.TrackTime.Stop();

            var time = exercise.TrackTime.Elapsed;
            Console.WriteLine($"Time spent exercising {exercise.Type}: {time.Hours} hours, {time.Minutes} minutes, {time.Seconds} seconds");

            Console.ReadLine();
        }

        private void WorkingMenu(User user)
        {
            Console.WriteLine("Working Menu");
            Console.WriteLine("Choose the type of exercise:");
            var type = Helper.GetType<WorkingPlace>();

            var work = new Working((WorkingPlace)type);
            user.Activities.Add(work);

            Console.WriteLine("Starting to counting time. Press any key to stop!");
            work.TrackTime.Start();

            Console.ReadLine();
            Console.WriteLine("Time tracking stopped!");
            work.TrackTime.Stop();

            var time = work.TrackTime.Elapsed;
            Console.WriteLine($"Time spent working at {work.PlaceOfWork}: {time.Hours} hours, {time.Minutes} minutes, {time.Seconds} seconds");

            Console.ReadLine();
        }

        private void HobbyMenu(User user)
        {
            Console.WriteLine("Hobby Menu");
            Console.WriteLine("Enter the name of the hobby:");
            var name = Console.ReadLine();

            var hobby = new Hobbies(name);
            user.Activities.Add(hobby);

            Console.WriteLine("Starting to counting time. Press any key to stop!");
            hobby.TrackTime.Start();

            Console.ReadLine();
            Console.WriteLine("Time tracking stopped!");
            hobby.TrackTime.Stop();

            var time = hobby.TrackTime.Elapsed;
            Console.WriteLine($"Time spent at {hobby.Name}: {time.Hours} hours, {time.Minutes} minutes, {time.Seconds} seconds");

            Console.ReadLine();
        }
    }
}
