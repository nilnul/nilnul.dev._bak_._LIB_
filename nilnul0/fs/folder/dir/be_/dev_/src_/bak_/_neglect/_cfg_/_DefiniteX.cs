using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.fs.folder.be_.deV_.src_.bak_._neglect._cfg_
{
	/// <summary>
	/// .nilnul as xml
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="nilnul.fs.folder.dnt_.cfg_"/>
	public static class _DefineX
	{


		public static bool? _Be_clobOfNulable(string blob0nul, nilnul.fs.FolderI  legacy, nilnul.win.prog_.Git git = null)
		{
			var t = _define._ExcludeByXmlX._Be_blobOfNulable(blob0nul);
			if (t is null)
			{
				return _cfg_._ExcludeX.Be(legacy, git);
			}
			return t;

		}

		public static bool? Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{
			var t = _define._ExcludeByXmlX.Be(s);
			if (t is null)
			{
				return _cfg_._ExcludeX.Be(s, git);
			}
			return t;

		}


		public static bool? Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null)
		{
			return Be(new nilnul.fs.Folder(s), git);
		}


		public static bool? Be_ofAddress(string s, nilnul.win.prog_.Git git = null)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s), git);
		}



	}
}
