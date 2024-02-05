using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.last.nulable.urls
{
	/// <summary>
	/// ensure the key.
	/// </summary>
	public class _EnsureX
	{
		public static string _Msg_0depo_1nob4each(
			string gitTop
			,
			IEnumerable<string> _nob4every
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var key = depo.repo._cfg_.remote_.deV_.baK_.all_.last.nulable._VwX._Vered_0depo(gitTop, git);
			if (key is null)
			{
				return all_.nonexist.create_._IfUrlsX._Msg_0depo_1nob4each(gitTop,_nob4every,git);
			}
			return last.urls._EnsureX._Msg_0depo_1remote4all_2nob4each(gitTop, key,_nob4every,git);
		}

		public static string _Msg_0depo(
			string gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> remotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Msg_0depo_1nob4each(
				gitTop
				,
				remotes.Select(n=>n.en)
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
			return _Msg_0depo(gitTop.top1.ToString(),remotes,git);

			//var key = last.nulable._VwX.NameVer(gitTop, git);
			//if (key is null)
			//{
			//	return all_.nonexist.create_._IfUrlsX.Msg(gitTop,remotes,git);

			//}

			//return last.urls._EnsureX.Msg(gitTop, key,remotes,git);

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
				remotes.Select(n=> new nilnul.txt_._vered.Name(n))
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
