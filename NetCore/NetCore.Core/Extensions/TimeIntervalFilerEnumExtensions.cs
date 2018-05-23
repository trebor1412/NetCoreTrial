namespace NetCore.Core 
{
    public static class TimeIntervalFilerEnumExtensions {
        public static TimeInterval Interval (this TimeIntervalFilterEnum interval) {
            switch (interval) {
                case TimeIntervalFilterEnum.Today:
                    return TimeInterval.Interval (TimeIntervalEnum.Day);
                case TimeIntervalFilterEnum.Yesterday:
                    return TimeInterval.Interval (TimeIntervalEnum.Day, -1);
                case TimeIntervalFilterEnum.ThisWeek:
                    return TimeInterval.Interval (TimeIntervalEnum.Week);
                case TimeIntervalFilterEnum.LastWeek:
                    return TimeInterval.Interval (TimeIntervalEnum.Week, -1);
                case TimeIntervalFilterEnum.ThisMonth:
                    return TimeInterval.Interval (TimeIntervalEnum.Month);
                case TimeIntervalFilterEnum.LastMonth:
                    return TimeInterval.Interval (TimeIntervalEnum.Month, -1);
                default:
                    return TimeInterval.Interval (TimeIntervalEnum.Day);
            }
        }
    }
}