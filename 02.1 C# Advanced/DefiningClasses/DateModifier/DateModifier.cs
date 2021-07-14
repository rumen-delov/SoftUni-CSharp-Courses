using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public int CalculateDateDifference(string firstDate, string secondDate)
        {
            int[] firstDateData = firstDate
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstDateYear = firstDateData[0];
            int firstDateMonth = firstDateData[1];
            int firstDateDay = firstDateData[2];

            DateTime firstDateTime = new DateTime(firstDateYear, firstDateMonth, firstDateDay);

            int[] secondDateData = secondDate
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int secondDateYear = secondDateData[0];
            int secondDateMonth = secondDateData[1];
            int secondDateDay = secondDateData[2];

            DateTime secondDateTime = new DateTime(secondDateYear, secondDateMonth, secondDateDay);

            return Math.Abs((firstDateTime - secondDateTime).Days);
        }
    }
}
