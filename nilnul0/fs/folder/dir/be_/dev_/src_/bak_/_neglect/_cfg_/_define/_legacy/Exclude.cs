using nilnul.win.prog_;
using System;
using System.Diagnostics;
using System.IO;
using System.Xml.Linq;

namespace nilnul.fs.folder.be_.deV_.src_.bak_._neglect._cfg_
{
	/// <summary>
	/// .nilnulCfg as ini
	/// </summary>
	/// <remarks>
	/// to be used in non-gitRepo folders, we shall put the cfg file in the folder rather than the ".git" folder, as normal folder will have no dir:".git"
	/// </remarks>
	/// <see cref="nilnul.fs.folder.dnt_.cfg_"/>
	///
	[Obsolete(nameof(_define._ExcludeByXmlX))]
	public static class _ExcludeX
	{


		public static bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{
			var spear = new address_.spear_.ParentDoc(s.address.en, ".nilnulCfg");
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				var r = nilnul.win.prog_.git_.cfg.read_._ResultX.Result(
					new address_.spear_.ParentDoc(s.address.en, ".nilnulCfg")
					,
					"bak.exclude"
					, 
					git
			   );
				return r.msg.Trim() == "1";

			}
			else
			{
				return false;
			}



		}

		public static bool Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null)
		{
			return Be(new nilnul.fs.Folder(s), git);
		}


		public static bool Be_ofAddress(string s, nilnul.win.prog_.Git git = null)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s), git);
		}

	}
}
