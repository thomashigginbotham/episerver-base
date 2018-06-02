using EPiServer.Core;
using EPiServer.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EpiserverBase.Business
{
	/// <summary>
	/// Extension methods for Episerver content.
	/// </summary>
	public static class ContentExtensions
	{
		/// <summary>
		/// Filters out content that should not be visible to the user.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="contents"></param>
		/// <param name="requirePageTemplate"></param>
		/// <param name="requireVisibleInMenu"></param>
		/// <returns></returns>
		public static IEnumerable<T> FilterForDisplay<T>(
			this IEnumerable<T> contents,
			bool requirePageTemplate = false,
			bool requireVisibleInMenu = false) where T : IContent
		{
			var accessFilter = new FilterAccess();
			var publishedFilter = new FilterPublished();

			contents = contents.Where(x =>
				!publishedFilter.ShouldFilter(x) &&
				!accessFilter.ShouldFilter(x));

			if (requireVisibleInMenu)
			{
				contents = contents.Where(x => VisibleInMenu(x));
			}

			return contents;
		}

		/// <summary>
		/// Returns whether a page is set to be visible in menus.
		/// </summary>
		private static bool VisibleInMenu(IContent content)
		{
			if (content is PageData page)
			{
				return page.VisibleInMenu;
			}

			return true;
		}
	}
}