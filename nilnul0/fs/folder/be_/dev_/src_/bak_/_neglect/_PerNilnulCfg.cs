﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.deV_.src_.bak_._neglect
{
	/// <summary>
	/// </summary>
	static public class _PerNilnulCfgX
	{


		static public bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null) {
			return _cfg_._ExcludeX.Be(s, git) || bak_.aft.Anto.Be(s, git);
		}

		static public bool Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null) {
			return Be(new nilnul.fs.Folder(s),git);
		}


		static public bool Be_ofAddress(string s, nilnul.win.prog_.Git git = null) {
			return Be( nilnul.fs.address_.shield_._AddressX1.Create(s),git);
		}



	}
}
