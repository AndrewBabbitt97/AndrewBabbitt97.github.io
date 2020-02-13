using System;
using System.Text;

namespace AndrewBabbitt97.Models
{
    /// <summary>
    /// An experience
    /// </summary>
    public class Experience
    {
        /// <summary>
        /// The job title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The employer
        /// </summary>
        public string Employer { get; set; }

        /// <summary>
        /// The start date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// The end date
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// If the end date should be "Present"
        /// </summary>
        public bool EndDateIsPresent { get; set; }

        /// <summary>
        /// The summary
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// Gets the date range for work
        /// </summary>
        /// <returns>The date range</returns>
        public string GetDateRange()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append(StartDate.ToString("MMMM"));
            builder.Append(" ");
            builder.Append(StartDate.Year);

            builder.Append(" - ");

            if (EndDateIsPresent)
            {
                builder.Append("Present");
            }
            else
            {
                builder.Append(EndDate.ToString("MMMM"));
                builder.Append(" ");
                builder.Append(EndDate.Year);
            }

            return builder.ToString();
        }
    }
}
