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
		public static string _Msg_0depo_0nob4each(
			string gitTop
			,
			IEnumerable<string> remotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var key = depo.repo._cfg_.remote_.deV_.baK_.all_.last.nulable._VwX._Vered_0depo(gitTop, git);
			if (key is null)
			{
				return all_.nonexist.create_._IfAnyX._Msg_0depo_1nob4each(gitTop,remotes,git);
			}
			return last.urns._EnsureX._Msg_0depo_1remote4all_2nob4each(gitTop, key,remotes,git);
		}

		public static string _Msg_0depo(
			string gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> remotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Msg_0depo_0nob4each(
				gitTop
				,
				remotes.Select(r=> r.en)
				,
				git
			);

		}

		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> remotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Msg_0depo(gitTop.top1.en.ToString(),remotes,git);
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
			return Msg(
				gitTop
				,
				remotes.Select(r=> new txt_._vered.Name(r))
				,
				git
			);
	

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
