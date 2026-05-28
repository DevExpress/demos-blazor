using System.ComponentModel;
using System.Globalization;
using DevExpress.AIIntegration;
using DevExpress.Blazor;

namespace BlazorDemo.CRM.Client.Tools;

public class SchedulerTools {
    [AIIntegrationTool]
    [Description("Retrieves the current date and time.")]
    public static string GetCurrentTime() => DateTime.Now.ToString("F", CultureInfo.InvariantCulture);

    [AIIntegrationTool]
    [Description("Finds appointments within a specific date range.")]
    public IEnumerable<DxSchedulerAppointmentItem> GetAppointments([AIIntegrationToolTarget] DxScheduler scheduler, DateTime start, DateTime end) {
        return scheduler.DataStorage.GetAppointments(new(start, end));
    }

    [AIIntegrationTool]
    [Description("Returns the earliest date currently displayed in the scheduler's active view.")]
    public DateTime GetSchedulerStartDate([AIIntegrationToolTarget] DxScheduler scheduler) {
        return scheduler.StartDate;
    }

    [AIIntegrationTool]
    [Description("Navigates the scheduler view to the specified start date.")]
    public async Task SchedulerViewUpdate([AIIntegrationToolTarget] Func<DateTime, Task> updateFunc, DateTime start) {
        await updateFunc(start);
    }

    [AIIntegrationTool]
    [Description("Opens a pre-filled appointment form. The UI supports only one open form at a time.")]
    public async Task<string?> CreateAppointment(
        [AIIntegrationToolTarget] DxScheduler scheduler,
        [AIIntegrationToolTarget] bool appointmentFormVisible,
        [AIIntegrationToolTarget] Func<DateTime, Task> updateFunc,
        DateTime start,
        DateTime end,
        string title,
        bool allDay
    ) {
        if(appointmentFormVisible) {
            return "Close the current appointment form before creating a new appointment.";
        }
        if(scheduler.ActiveViewType == SchedulerViewType.WorkWeek && start.DayOfWeek is DayOfWeek.Sunday or DayOfWeek.Saturday) {
            return "Appointments cannot be scheduled on weekends. Please select a weekday instead.";
        }
        await updateFunc(start);
        var appointment = await scheduler.CreateAppointmentAsync(start, end, allDay, null);
        if(appointment == null) {
            throw new Exception("Failed to create an appointment.");
        }
        appointment.Subject = title;
        await scheduler.ShowAppointmentEditFormAsync(false, appointment);
        return null;
    }
}
