using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.last.nulable.urns
{
	/// <summary>
	/// ensure the key.
	/// </summary>
	public class _EnsureX
	{
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> remotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var key = last.nulable._VwX.NameVer(gitTop, git);
			if (key is null)
			{
				return all_.nonexist.create_._IfAnyX.Msg(gitTop,remotes,git);

			}

			return last.urns._EnsureX.Msg(gitTop, key,remotes,git);

		}
		/// <summary>
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<string> remotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var key = last.nulable._VwX.NameVer(gitTop, git);
			if (key is null)
			{
				return all_.nonexist.create_._IfAnyX.Msg(gitTop,remotes,git);

			}

			return last.urns._EnsureX.Msg(gitTop, key,remotes,git);

		}



		public static string Msg(
			nilnul.fs.git.Module gitTop
						,
			IEnumerable<string> remotes
,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(gitTop as nilnul.fs.git.ModuleI,remotes, git);
		}

		public static string Msg(
			nilnul.fs.folder_.git_.Top gitTop
						,
			IEnumerable<string> remotes
,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.git.Module(gitTop),remotes, git);
		}

		public static string Msg(
			nilnul.fs.FolderI gitTop
						,
			IEnumerable<string> remotes
,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.folder_.git_.Top(gitTop),remotes, git);
		}
	}
}
