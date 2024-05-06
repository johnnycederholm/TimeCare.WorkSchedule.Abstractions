namespace TimeCare.WorkSchedule.Abstractions
{
    public record WorkShift
    {
        public required DateTime Start { get; set; }

        public required DateTime End { get; set; }

        public string Code { get; set; } = string.Empty;

        public required TimeSpan Pause { get; set; }

        public TimeSpan Duration => End.Subtract(Start);

        public string Location { get; set; } = string.Empty;

        public string Notes { get; set; } = string.Empty;
    }
}
