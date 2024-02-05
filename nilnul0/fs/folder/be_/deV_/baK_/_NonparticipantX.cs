using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.fs.folder.be_.deV_.baK_
{
	/// <summary>
	/// neglect this folder
	/// </summary>
	///
	//[Obsolete(nameof(folder.dir.be_.deV_.baK_._UnopenX))]
	static public class _NonparticipantX
	{
		static public bool _Be_0folder(string s) {
			//return folder.dir.be_.deV_.baK_._UnopenX.Be(s);
			return
				//nilnul.fs.folder.be_.Empty.Singleton.be(s)
				//||
				//folder.dir.be_.dev_.baK_._nondelve._PerNameX._Be_0spear(s)  // this is determined from outside super.
				//||
				_nonpart._PerCfgX._Be_0folder(s)  //considered "aft"
			;
		}

		static public bool Be(nilnul.fs.FolderI s) {
			//return folder.dir.be_.deV_.baK_._UnopenX.Be(s);
			return
				//nilnul.fs.folder.be_.Empty.Singleton.be(s)
				//||
				//folder.dir.be_.dev_.baK_._nondelve._PerNameX.Be(s)  // this is determined from outside super.
				//||
				_nonpart._PerCfgX.Be(s)  //considered "aft"
			;
		}


		public static bool Be(ShieldI shield)
		{
			return Be(new nilnul.fs.Folder(shield));
		}

		static public bool Be_ofAddress(string s) {
			return Be(nilnul.fs.Folder.FroAddress(s));
		}
	}
}
