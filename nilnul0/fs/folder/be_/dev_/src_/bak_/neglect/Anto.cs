using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_;

namespace nilnul.fs.folder.be_.deV_.src_.bak_.neglect
{
	public class Anto
	{
		public static bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{
			return !_NeglectX.Be(s, git);
		}

		public static bool Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null)
		{
			return Be(new nilnul.fs.Folder(s), git);
		}

		public static bool Be_ofAddress(string s, nilnul.win.prog_.Git git = null)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s), git);
		}

		internal static bool Be(folder_.Normal div_inSrc, nilnul.win.prog_.Git git = null)
		{
			return Be(div_inSrc.en,git);
		}
	}
}
