using System;

namespace NetCore.Core {
    public class TimeInterval {
        public DateTime From { get; set; }

        public DateTime To { get; set; }

        public static TimeInterval Interval (TimeIntervalEnum interval, int range) {
            var now = DateTime.Now;
            TimeInterval timeInterval = new TimeInterval { };
            switch (interval) {
                case TimeIntervalEnum.Day:
                    timeInterval.From = now.Date.AddDays (range);
                    timeInterval.To = timeInterval.From.AddDays (1).AddSeconds (-1);
                    break;
                case TimeIntervalEnum.Week:
                    timeInterval.From = now.AddDays (-1 * ((7 + now.DayOfWeek - DayOfWeek.Monday) % 7) + range * 7);
                    timeInterval.To = timeInterval.From.AddDays (7).AddSeconds (-1);
                    break;
                case TimeIntervalEnum.Month:
                    timeInterval.From = new DateTime (now.Year, now.Month, 1).AddMonths (range);
                    timeInterval.To = timeInterval.From.AddMonths (1).AddSeconds (-1);
                    break;
                case TimeIntervalEnum.Year:
                    timeInterval.From = new DateTime (now.Year, 1, 1).AddYears (range);
                    timeInterval.To = timeInterval.From.AddYears (1).AddSeconds (-1);
                    break;
            }
            return timeInterval;
        }
    }
}