using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_._defer
{
	/// <summary>
	/// after (not until) the given date to bak. baking will not be carried out before/lt() this date.
	/// </summary>
	///
	[Obsolete(nameof(nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_._defer._PerHierX))]
	public class _OfDotNilnulAsXmlX
	{

		public static bool? _Be(XDocument xdoc)
		{
			var xpath = @"/*/*[local-name()='bak']/*[local-name()='aft']";

			var xel = xdoc.XPathSelectElements(
				xpath
			);

			if (xel.Skip(1).Any())
			{
				Trace.TraceError(
					$"multiple {xpath} found; only the last will be effective."
				);
			}

			var xel1 = xel.LastOrDefault();
			if (xel1 is null)
			{
				return null;
			}

			var trimmed = xel1.Value?.Trim() ?? "";


			DateTimeOffset benchmark;// = new DateTime();
			bool parsed = DateTimeOffset.TryParse(trimmed, out benchmark);
			if (parsed)
			{
				return DateTimeOffset.UtcNow <= benchmark;
			}
			else
			{
				return null;
			}
		}

		public static bool? _Be_blobOfNulable(string blob0nul)
		{
			if (blob0nul is null)
			{
				return null;
			}
			if (string.IsNullOrWhiteSpace(blob0nul))
			{
				return null;
			}
			try
			{
				var xdoc = XDocument.Load(
					 new StringReader(blob0nul)
				);

				return _Be(xdoc);

			}
			catch (Exception e)
			{
				//Trace.TraceError();
				//return null;
				throw;
			}




		}
		public static bool? Be(nilnul.fs.FolderI s)
		{
			var spear = new address_.spear_.ParentDoc(s.address.en, ".nilnul");
			var spearAsTxt = spear.ToString();
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				XDocument xdoc;
				try
				{
					xdoc = XDocument.Load(spearAsTxt);

				}
				catch (System.Exception)
				{
					Trace.TraceError(
						$"{spearAsTxt} is not xml."
					);
					return null;

					//throw;
				}

				var xpath = @"/*/*[local-name()='bak']/*[local-name()='aft']";

				var xel = xdoc.XPathSelectElements(
					xpath
				);
				if (xel.Skip(1).Any())
				{
					Trace.TraceError(
						$"multiple {xpath} found; only the last will be effective."
					);

				}
				var xel1 = xel.LastOrDefault();
				if (xel1 is null)
				{
					return null;
				}

				var trimmed = xel1.Value?.Trim() ?? "";


				DateTimeOffset benchmark;// = new DateTime();
				bool parsed = DateTimeOffset.TryParse(trimmed, out benchmark);
				if (parsed)
				{
					return DateTimeOffset.UtcNow <= benchmark;
				}
				else
				{
					return null;
				}


			}
			else
			{
				return null;
			}




		}

		public static bool? Be(nilnul.fs.address_.ShieldI s)
		{
			return Be(new nilnul.fs.Folder(s));
		}

		public static bool? Be_ofAddress(string s)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s));
		}
	}
}
