using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.win.prog_;

namespace nilnul.fs.folder.git_.cfg_.dev_.src_.baked_
{
	static public class _TimeX
	{
		/// <summary>
		/// in this very folder, ensure a file named per config such as ".nilnulCfg" to store the settings.
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="time"></param>
		/// <param name="git"></param>
		static public void Set(nilnul.fs.FolderI folder, DateTime? time=null, nilnul.win.prog_.Git git=null) {
			nilnul.fs.folder.dev_.src_._IniX.Set(
				folder
				,
				"baked.time"
				,
				nilnul.time_.datetime_.txt_.Full.Singleton.phrase(
					time??DateTime.UtcNow
				)
				,
				git
			);
		}
		static public void Set(nilnul.fs.address_.ShieldI folder, DateTime? time=null, nilnul.win.prog_.Git git=null) {
			Set(
				new nilnul.fs.Folder(
					folder
				)
				
				,
				time
				,
				git
			);
		}

		public static void Set(string folder, DateTime? p=null, Git git=null)
		{
			Set(nilnul.fs.address_.Shield.FroAddress(folder), p,git);
		}
	}
}
