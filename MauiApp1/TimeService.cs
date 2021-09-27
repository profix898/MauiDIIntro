using System;
using System.Globalization;

namespace MauiApp1
{
    public class TimeService
    {
        private readonly DateTime _createdTime;

        public TimeService()
        {
            _createdTime = DateTime.Now;
        }

        public string GetCreatedTime()
        {
            return _createdTime.ToString(CultureInfo.CurrentCulture);
        }
    }
}