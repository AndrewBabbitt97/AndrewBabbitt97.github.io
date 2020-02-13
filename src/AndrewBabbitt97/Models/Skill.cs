namespace AndrewBabbitt97.Models
{
    /// <summary>
    /// A skill
    /// </summary>
    public class Skill
    {
        /// <summary>
        /// The skill icon
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// The skill description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// If the skill description should be shown
        /// </summary>
        public bool ShowDescription { get; set; }
    }
}
