using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace EpiserverBase.Models.Media
{
	[ContentType(GUID = "eb5a5c46-8584-4998-b2be-39b86cf58a3f")]
	[MediaDescriptor(ExtensionString = "jpg,jpeg,png,gif,webp")]
	public class ImageFile : ImageData
	{
		/// <summary>
		/// Gets or sets a short description of the image.
		/// </summary>
		[CultureSpecific]
		[Display(
			GroupName = SystemTabNames.Content,
			Order = 100)]
		public virtual string Description { get; set; }
	}
}