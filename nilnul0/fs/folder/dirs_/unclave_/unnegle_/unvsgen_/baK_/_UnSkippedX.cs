using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using nilnul.fs.address_.spear;
using nilnul.obj.seq;
using nilnul.obj.seq_.str.be_;
using nilnul.obj.str;

namespace nilnul.fs.folder.dirs_.unclave_.unnegle_.unvsgen_.baK_
{
	/// <summary>
	/// list all the dirs that are not bakked till after the given time;
	/// </summary>
	/// <remarks>
	/// note:
	///		for bak, it's not considered here whether it's intent, as intention is about a certain folder, not about iteration of dirs; that is, whether it's intentional, we still need to traverse it.
	///	note:
	///		whether it has been traversed before due to repetitive symlink's tgts, is not accounted for; 
	///	
	/// </remarks>
	/// alias:
	///		delvable
	///			,delve
	///		curated
	///		nominated
	///		appointed
	///

	public class _UnSkippedX
	{
		public static IEnumerable<DirectoryInfo> _Infos_0folder(DirectoryInfo s)
		{
			/// todo: assumeFolder
			return nilnul.fs.folder.dirs_.unnegle_.unvsgen_._UnClaveX._Infos_0folder(s).Where(
				d =>
				!nilnul.fs.folder.dir.be_.deV_.baK_._unchart._PerNameX._Be_0dnt(d.Name)
			); 
		}

		public static IEnumerable<DirectoryInfo> _Infos_0folder(string s)
		{
			return _Infos_0folder(new DirectoryInfo(s)) ;
		}

		public static IEnumerable<DirectoryInfo> Infos(nilnul.fs.FolderI s)
		{
			return _Infos_0folder( nilnul.fs.folder.to_._InfoX.To(s) ) ;
		}


		public static IEnumerable<DirectoryInfo> Infos(nilnul.fs.address_.ShieldI s)
		{
			return Infos(new nilnul.fs.Folder(s));
		}

		public static IEnumerable<DirectoryInfo> Infos_0address(string s )
		{
			return Infos(nilnul.fs.address_.shield_._AddressX1.Create(s));
		}
	}
}
