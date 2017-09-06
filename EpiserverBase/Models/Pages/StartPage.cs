using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiserverBase.Models.Pages
{
	[ContentType(DisplayName = "StartPage", GUID = "5f5a391f-6b6a-4659-8e40-67a1860c2e52", Description = "")]
	public class StartPage : PageData
	{

		[CultureSpecific]
		[Display(
			Name = "Main body",
			Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
			GroupName = SystemTabNames.Content,
			Order = 1)]
		public virtual XhtmlString MainBody { get; set; }

	}
}