namespace TimeCare.WorkSchedule.Abstractions;

public interface IWorkScheduleReader
{
    Task<WorkSchedule> Read();
}
