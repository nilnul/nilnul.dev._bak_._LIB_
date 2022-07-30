using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.win.prog_;

namespace nilnul.fs.git.module.repo.doc_.cfg_.custom
{
	static public class _TimeX
	{
		/// <summary>
		/// in the repo dir of this module, ensure a file named per config such as ".nilnulCfg" to store the settings.
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="time"></param>
		/// <param name="git"></param>
		static public void Vod_ifModule(nilnul.fs.FolderI folder, DateTime? time = null, nilnul.win.prog_.Git git = null)
		{
			if (nilnul.fs.folder.be_.git_.work_.Top.Singleton.be(folder))
			{
				nilnul.fs.folder.dev_.src_._IniX.Set(
					nilnul.fs.git.module._RepoX.DefaultFolder_assumeModule(
								folder
					)
					,
					"baked.time"
					,
					nilnul.time_.datetime_.txt_.Full.Singleton.phrase(
						time ?? DateTime.UtcNow
					)
					,
					git
				);

			}
		}
		static public void Vod_ifModule(nilnul.fs.address_.ShieldI folder, DateTime? time = null, nilnul.win.prog_.Git git = null)
		{
			Vod_ifModule(
				new nilnul.fs.Folder(
					folder
				)

				,
				time
				,
				git
			);
		}

		public static void Vod_ifModule(string folder, DateTime? p = null, Git git = null)
		{
			Vod_ifModule(nilnul.fs.address_.Shield.FroAddress(folder), p, git);
		}
	}
}
