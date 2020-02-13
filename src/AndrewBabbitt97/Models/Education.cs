using System;
using System.Text;

namespace AndrewBabbitt97.Models
{
    /// <summary>
    /// A education entry
    /// </summary>
    public class Education
    {
        /// <summary>
        /// The school attended
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// The certificate or degree
        /// </summary>
        public string CertificateOrDegree { get; set; }

        /// <summary>
        /// Any additional info
        /// </summary>
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// The GPA
        /// </summary>
        public decimal Gpa { get; set; }

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
        /// Gets the date range for school
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
