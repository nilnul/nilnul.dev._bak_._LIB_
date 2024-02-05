using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using nilnul.win.prog_;
using nilnul.win.program_;

namespace nilnul.fs.folder.dir.be_.deV_.baK_._unchart
{
	/// <summary>
	/// neglect this folder if the dir name includes, case insensitively, "(!Bak)" or the like:"!Bak)","(!Bak";
	/// </summary>
	/// <remarks>
	/// vs:
	///		"(!Git)"
	///			,ignore this from within the work of a repo;
	///		"(Git)"
	///			,ignore this from within the work of a repo, as that itself would be a git depo
	///			;
	///			
	/// </remarks>
	static public class _PerNameX
	{
		public const string CONTENT = "!Bak";

		public const string PREFIX =  CONTENT + ")";
		public const string SUFFIX ="("+ "!Bak";
		public const string INFIX = SUFFIX + ")";

		/// <summary>
		/// note: "(!Git" is for git to ignore, not for bak to neglect
		/// </summary>
		static public readonly nilnul.txts_.seq_.BothCases SUFFIXS = new nilnul.txts_.seq_.BothCases(SUFFIX);
		static public readonly nilnul.txts_.seq_.BothCases PREFIXS = new nilnul.txts_.seq_.BothCases(PREFIX);

		static public readonly nilnul.txts_.seq_.BothCases INFIXS = new nilnul.txts_.seq_.BothCases(INFIX);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// todo: commented is not considered. eg: (!Bak (downed from web))

		static public bool _Be_0dnt(string s)
		{
			if (
				(PREFIXS).Any(
					x=>
					s.StartsWith( x, StringComparison.InvariantCultureIgnoreCase  )
				)
				||
				(SUFFIXS).Any(
					x=>
					s.EndsWith( x, StringComparison.InvariantCultureIgnoreCase  )
				)
				||
				INFIXS.Any(x=>
					s.ToLower().Contains(x.ToLower())
				)
			)
			{
				return true;
			}
			return false;
		}
		static public bool _Be_0spear(string s)
		{
			return _Be_0dnt(
				System.IO.Path.GetFileName(s)
			);
		}

		static public bool _Be_0address(string s)
		{
			return _Be_0spear(
				s.TrimEnd('/','\\')
			);
		}

		static public bool Be(nilnul.fs._address._dst.Denote s)
		{
			return _Be_0dnt(s.ToString());
		
		}


		//static public bool Be(nilnul.fs._address.DirI s, nilnul.win.prog_.Git git =null) {
		//	if (
		//		nilnul.txts_.fs_._AppendDecksX.Arr(SUFFIX).Any(x=>
		//			s.ToString().EndsWith(  x  )
		//		)

		//		||
		//		s.ToString().Contains(INFIX)

		//	)
		//	{
		//		return true;
		//	}
		//	return false;
		//}
		public static bool Be(DirI child)
		{
			return Be(child.denote);
		}


		public static bool Be(ShieldI shield)
		{
			return Be( nilnul.fs.address_.shield_.BaseDir._Ov(shield).child);
		}
		static public bool Be_0address(string s) {
			return Be(nilnul.fs.address_.Shield.FroAddress(s));
		}

		public static bool Be(Exist address)
		{
			return Be(address.en);
		}

		static public bool Be(nilnul.fs.FolderI s) {
			return Be(s.address);
		}



	}
}
