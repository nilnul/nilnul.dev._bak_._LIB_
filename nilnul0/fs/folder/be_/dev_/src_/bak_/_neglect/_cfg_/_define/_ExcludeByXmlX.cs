using nilnul.win.prog_;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.fs.folder.be_.deV_.src_.bak_._neglect._cfg_._define
{

	/// <summary>
	/// .nilnul as xml
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="nilnul.fs.folder.dnt_.cfg_"/>
	public static class _ExcludeByXmlX
	{
		public static bool? _Be(XDocument xdoc)
		{
			var xpath = @"/*/*[local-name()='bak']/*[local-name()='neglect']";

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

			var trimmed = xel1.Value?.Trim();
			if (trimmed == "1")
			{
				return true;
			}
			if (trimmed == "0")
			{
				return false;
			}
			return null;
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
			catch (Exception)  //eg: the content is invalid
			{
				throw;
				//return null;
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

				var xpath = @"/*/*[local-name()='bak']/*[local-name()='neglect']";

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

				var trimmed = xel1.Value?.Trim();
				if (trimmed == "1")
				{
					return true;
				}
				if (trimmed == "0")
				{
					return false;
				}
				return null;
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