namespace MyBlazorApp.Models
{
    public class EventModel
    {
        public string Name { get; set; } = string.Empty; // Default value to resolve warning
        public DateTime Date { get; set; }
        public string Location { get; set; } = string.Empty; // Default value to resolve warning
    }

    public static class MockData
    {
        public static List<EventModel> GetMockEvents()
        {
            return new List<EventModel>
            {
                new EventModel { Name = "Tech Conference", Date = DateTime.Now.AddDays(7), Location = "Stockholm" },
                new EventModel { Name = "Annual Gala", Date = DateTime.Now.AddMonths(1), Location = "Paris" },
                new EventModel { Name = "Startup Pitch", Date = DateTime.Now.AddDays(14), Location = "Berlin" }
            };
        }
    }
}

