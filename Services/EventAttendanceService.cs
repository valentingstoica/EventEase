using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
    public class EventAttendanceService
    {
        private readonly Dictionary<string, List<UserModel>> attendance = new();

        public void RegisterAttendance(string eventName, UserModel user)
        {
            if (!attendance.ContainsKey(eventName))
            {
                attendance[eventName] = new List<UserModel>();
            }
            attendance[eventName].Add(user);
        }

        public List<UserModel> GetAttendees(string eventName)
        {
            return attendance.ContainsKey(eventName) ? attendance[eventName] : new List<UserModel>();
        }
    }
}


