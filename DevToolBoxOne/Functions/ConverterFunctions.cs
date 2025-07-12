// Ignore Spelling: Shamsi

using System;
using System.Globalization;

namespace DevToolBoxOne.Functions
{
    public static class ConverterFunctions
    {
        public static DateTime ToShamsiDate(int year = 0, int month = 0, int day = 0)
        {
            PersianCalendar newPersianCalender = new PersianCalendar();
            DateTime newGregorianDate = newPersianCalender.ToDateTime(year, month, day, 0, 0, 0, 0);
            return newGregorianDate;
        }
    }
}
