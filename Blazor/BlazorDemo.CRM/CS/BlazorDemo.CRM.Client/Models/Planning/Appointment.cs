namespace BlazorDemo.CRM.Models {
    public class Appointment {
        public int AppointmentType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string? Caption { get; set; }
        public string? Description { get; set; }
        public string? Location { get; set; }
        public int? Label { get; set; }
        public int Status { get; set; }
        public bool AllDay { get; set; }
        public string? Recurrence { get; set; }
        public int? ResourceId { get; set; }
        public int? LabelId { get; set; }
        public string? Resources { get; set; }
        public bool Accepted { get; set; }
    }

    public static class Appointments {
        public static List<Appointment> Create(IEnumerable<WorkTaskDetail> tasks) {
            var appointmentDays = GetAppointmentDates();
            return tasks.Take(11).Select((task, index) => {
                var startDate = appointmentDays[index];
                var status = task.Status switch {
                    "Open" => 0,
                    "In Progress" => 1,
                    "Completed" => 2,
                    _ => 3
                };
                return new Appointment {
                    AppointmentType = 0,
                    StartDate = startDate,
                    EndDate = startDate.AddHours(3),
                    Caption = task.Text,
                    ResourceId = (int)startDate.DayOfWeek - 1,
                    Status = status
                };
            }).ToList();
        }

        static DateTime[] GetAppointmentDates() {
            var now = DateTime.Now;
            var mondayMidnight = new DateTime(now.Year, now.Month, now.Day, 0, 0, 0, 0).AddDays(1 - (int)now.DayOfWeek);
            return [
                mondayMidnight.AddHours(7).AddMinutes(30),
                mondayMidnight.AddDays(1).AddHours(10),
                mondayMidnight.AddDays(2).AddHours(8).AddMinutes(30),
                mondayMidnight.AddDays(3).AddHours(7),
                mondayMidnight.AddDays(7).AddHours(9),
                mondayMidnight.AddDays(8).AddHours(7),
                mondayMidnight.AddDays(9).AddHours(8).AddMinutes(30),
                mondayMidnight.AddDays(10).AddHours(9).AddMinutes(30),
                mondayMidnight.AddDays(15).AddHours(8).AddMinutes(20),
                mondayMidnight.AddDays(16).AddHours(9).AddMinutes(40),
                mondayMidnight.AddDays(17).AddHours(8).AddMinutes(30)
            ];
        }
    }
}
