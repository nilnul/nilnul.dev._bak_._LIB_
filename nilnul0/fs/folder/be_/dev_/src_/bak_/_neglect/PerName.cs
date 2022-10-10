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

namespace nilnul.fs.folder.be_.deV_.src_.bak_._neglect
{
	/// <summary>
	/// neglect this folder
	/// </summary>
	static public class _PerNameX
	{
		public const string CONTENT = "!Bak";

		public const string PREFIX =  CONTENT + ")";
		public const string SUFFIX ="("+ "!Bak";
		public const string INFIX = SUFFIX + ")";

		/// <summary>
		/// note: "(!Git" is for git to ignore, not for bak to neglect
		/// </summary>
		static public nilnul.txts_.seq_.BothCases SUFFIXS = new nilnul.txts_.seq_.BothCases(SUFFIX);
		static public nilnul.txts_.seq_.BothCases PREFIXS = new nilnul.txts_.seq_.BothCases(PREFIX);

		static public nilnul.txts_.seq_.BothCases INFIXS = new nilnul.txts_.seq_.BothCases(INFIX);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="s"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		/// todo: commented is not considered. eg: (!Bak (downed from web))

		static public bool Be(nilnul.fs._address._dst.Denote s, nilnul.win.prog_.Git git =null)
		{
			if (
				(PREFIXS).Any(
					x=>
					s.ToString().StartsWith( x, StringComparison.InvariantCultureIgnoreCase  )
				)
				||
				(SUFFIXS).Any(
					x=>
					s.ToString().EndsWith( x, StringComparison.InvariantCultureIgnoreCase  )
				)
				||
				INFIXS.Any(x=>
					s.ToString().ToLower().Contains(x.ToLower())
				)
			)
			{
				return true;
			}
			return false;
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
		public static bool Be(DirI child, Git git=null)
		{
			return Be(child.denote);
		}


		public static bool Be(ShieldI shield, win.prog_.Git git=null)
		{
			return Be( nilnul.fs.address_.shield_.BaseDir._Ov(shield).child,git);
		}
		static public bool Be_ofAddress(string s, nilnul.win.prog_.Git git =null) {
			return Be(nilnul.fs.address_.Shield.FroAddress(s),git);
		}

		public static bool Be(Exist address,  win.prog_.Git git=null)
		{
			return Be(address.en);
		}

		static public bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git =null) {
			return Be(s.address);
		}



	}
}
