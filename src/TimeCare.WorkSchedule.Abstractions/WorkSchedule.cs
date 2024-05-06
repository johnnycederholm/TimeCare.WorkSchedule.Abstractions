namespace TimeCare.WorkSchedule.Abstractions;

public record WorkSchedule
{
    public required IEnumerable<WorkShift> WorkShifts { get; set; }
}
