using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;

namespace nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_
{
	/// <summary>
	/// .nilnul as xml
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="nilnul.fs.folder.dnt_.cfg_"/>
	public static class _DeferX
	{
		public static bool _BeDeferred_0folder(string s)
		{
			return deV_.baK_._nonpart._cfg_._defer._PerHierX._BeDeferred_0folder(s);
		}

		public static bool? _Deferred0nul_0folder(string s)
		{
			return deV_.baK_._nonpart._cfg_._defer._PerHierX._Deferred0nul_0folder(s);
		}


		public static bool Be(nilnul.fs.FolderI s)
		{
			return _BeDeferred_0folder(s.ToString()); ;

		}

		public static bool? Be(nilnul.fs.address_.ShieldI s)
		{
			return Be(new nilnul.fs.Folder(s));
		}

		public static bool? Be_0address(string s)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s));
		}
	}
}