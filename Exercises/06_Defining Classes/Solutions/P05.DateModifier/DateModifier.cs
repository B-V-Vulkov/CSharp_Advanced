namespace DefiningClasses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDay, string secondDay)
        {
            this.firstDate = firstDay;
            this.secondDate = secondDay;
        }

        public string DaysBetween()
        {
            string[] splittedFirstDate = firstDate
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] splittedSecondDate = secondDate
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int firstYear = int.Parse(splittedFirstDate[0]);
            int firstMonth = int.Parse(splittedFirstDate[1]);
            int firstDay = int.Parse(splittedFirstDate[2]);

            int secondYear = int.Parse(splittedSecondDate[0]);
            int secondMonth = int.Parse(splittedSecondDate[1]);
            int secondDay = int.Parse(splittedSecondDate[2]);

            DateTime firstDateTime = new DateTime(firstYear, firstMonth, firstDay);
            DateTime secondDateTime = new DateTime(secondYear, secondMonth, secondDay);

            int daysBetween = int.Parse((secondDateTime - firstDateTime).TotalDays.ToString());

            return Math.Abs(daysBetween).ToString();
        }
    }
}
