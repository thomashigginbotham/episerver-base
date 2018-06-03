using System;
using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiserverBase.Models.Pages
{
    [ContentType(DisplayName = "Site Settings", GUID = "df56a3b0-be6c-4450-8cd8-4e7f18c9004d", Description = "")]
    public class SiteSettingsPage : PageData
    {
        [CultureSpecific]
        [Display(
            Name = "Logo Image",
            Description = "The website logo.",
            GroupName = SystemTabNames.Content,
            Order = 100)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference LogoImage { get; set; }
    }
}