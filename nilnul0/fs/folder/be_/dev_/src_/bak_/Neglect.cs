using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.fs.folder.be_.deV_.src_.bak_
{
	/// <summary>
	/// neglect this folder
	/// </summary>
	static public class _NeglectX
	{
		static public bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git =null) {
			return 
				//nilnul.fs.folder.be_.Empty.Singleton.be(s)
				//||
				_neglect._PerNameX.Be(s,git)
				||
				_neglect._PerNilnulCfgX.Be(s,git)  //considered "aft"
			;
		}

		public static bool Be(ShieldI shield, win.prog_.Git git)
		{
			return Be(new nilnul.fs.Folder(shield),git);
		}

		static public bool Be_ofAddress(string s, nilnul.win.prog_.Git git =null) {
			return Be(nilnul.fs.Folder.FroAddress(s),git);
		}
	}
}
