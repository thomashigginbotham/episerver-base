using EPiServer.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace EpiserverBase
{
    public class Global
    {
        /// <summary>
        /// Group names for content types and properties.
        /// </summary>
        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Metadata", Order = 2)]
            public const string Metadata = "Metadata";
        }

        /// <summary>
        /// Names for UIHint attributes.
        /// </summary>
        public static class SiteUIHints
        {
            public const string Strings = "StringList";
        }
    }
}
