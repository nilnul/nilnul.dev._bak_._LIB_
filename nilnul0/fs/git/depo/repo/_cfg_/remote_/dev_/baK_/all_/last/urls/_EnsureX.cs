using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.last.urls
{
	/// <summary>
	/// assume the existence of the key.
	/// ensure the urls
	/// </summary>
	public class _EnsureX
	{
		/// <summary>
		/// assume the newest last exists,
		/// </summary>
		/// <param name="_depo"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static string _Msg_0depo_1remote4all_2nob4each(
			string _depo
			,
			string _remote
			,
			IEnumerable<string> _nob4every
			,
			nilnul.win.prog_.Git git = null
		)
		{

			///get the urls
			///

			var remotes = _nob4every.Select(
				r =>
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX._Txt_0depo_1nob(_depo, r, git)
			);

			var notNuls = remotes.Where(x => x is not null);
			var urls = new List<string>();

			notNuls.ForEach(
				x =>
				{
					var u = nilnul.fs.git.module.repo._cfg_.remote.urn._VwX._Txt_assumesModuleAddress1Remote(_depo, x.ToString(),git);
					urls.Add(u);
				}
			);

			//var key = key;

			var oldUrls = nilnul.fs.git.module.repo._cfg_.remote.urls_._PushX._Txts_0depo_1remote(
				_depo
				,
				_remote
				,
				git);

			var urls2add = nilnul.web.url.nulable.str.combine_.except_._DelKeyX.Txts(
				urls,
				oldUrls
			);


			urls2add.ForEach(
				x =>
				{

					nilnul.fs.git.depo.repo._cfg_.remote.uris_.push._InsertX._Vod_0depo_1remote_2uri(
						_depo
						,
						_remote
						//new _remote.Name(
						//	_AwGlBbVsX.GetLastAsName()
						//)
						,
						x
						,
						git
					);

					nilnul.fs.git.depo.repo.vow_.unlocked_.wait_._TimeoutX._Vod_0depo(_depo, 5 * 1000, 1 * 1000);

				}
			);

			return ($"urls {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls2add)} added for {_remote}");
		}

		public static string _Msg_0depo_1remote4all(string v, string key, IEnumerable<txt_._vered.Name> atomics, Git git=null)
		{
			return _Msg_0depo_1remote4all_2nob4each(v,key,atomics.Select(x=>x.en) ,git);
		}





		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			string key
			,
			IEnumerable<nilnul.txt_._vered.Name> atomics
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return _Msg_0depo_1remote4all(gitTop.ToString(),key, atomics,git);

			///get the urls
			///


			var remotes = atomics.Select(
				r =>
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(gitTop, r, git)
			);

			var notNuls = remotes.Where(x => x != null);
			var urls = new List<string>();

			notNuls.ForEach(
				x =>
				{
					var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());
					urls.Add(u);
				}
			);


			//var key = key;

			var oldUrls = nilnul.fs.git.module.repo._cfg_.remote.urls_._PushX.Txts(
				gitTop
				,
				key.ToString()
				,
				git);

			var urls2add = nilnul.web.url.nulable.str.combine_.except_._DelKeyX.Txts(
				urls,
				oldUrls
			);


			urls2add.ForEach(
				x =>
				{
					try
					{
						/// some, such as ssh, might be not url
						nilnul.fs.git.module.repo._cfg_.remote.urns_.push._InsX._Vod_assumesValid(
							gitTop
							,
							key.ToString()
							//new _remote.Name(
							//	_AwGlBbVsX.GetLastAsName()
							//)
							,
							x
							,
							git
						);
					}

					catch (nilnul.exception_.ParseException parseXpn) {
						Trace.TraceError(
							$"when del pass from url by {typeof(_EnsureX).FullName}.{nameof(Msg)}, the parse failed: {parseXpn}"
						);
						

					}
					catch (Exception xpn1)
					{
						Trace.TraceError(
							$"when del pass from url by {typeof(_EnsureX).FullName}.{nameof(Msg)}: {xpn1}"
						);
						//throw;
					}
				}
			);

			return ($"urls {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls2add)} added for {key}");
		}

		/// <summary>
		/// assume the newest last exists,
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			string key
			,
			IEnumerable<string> atomics
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return Msg(gitTop,key, atomics.Select(n=> new nilnul.txt_._vered.Name(n)) ,git);
			///get the urls
			///


			var remotes = atomics.Select(
				r =>
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(gitTop, r, git)
			);

			var notNuls = remotes.Where(x => x is not null);
			var urls = new List<string>();

			notNuls.ForEach(
				x =>
				{
					var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(gitTop, x.ToString());
					urls.Add(u);
				}
			);


			//var key = key;

			var oldUrls = nilnul.fs.git.module.repo._cfg_.remote.urls_._PushX.Txts(
				gitTop
				,
				key.ToString()
				,
				git);

			var urls2add = nilnul.web.url.nulable.str.combine_.except_._DelKeyX.Txts(
				urls,
				oldUrls
			);


			urls2add.ForEach(
				x =>
				{

					nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
						gitTop
						,
						key.ToString()
						//new _remote.Name(
						//	_AwGlBbVsX.GetLastAsName()
						//)
						,
						x
						,
						git
					);
				}
			);

			return ($"urls {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls2add)} added for {key}");
		}

	

		public static string Msg(
			nilnul.fs.git.Module gitTop
			,
			string key
			,
			IEnumerable<string> atomics
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(
				gitTop as nilnul.fs.git.ModuleI
				,
				key
				,
				atomics
				,
				git
			);
		}

		public static string Msg(
			nilnul.fs.folder_.git_.Top gitTop
			,
			string key
			,
			IEnumerable<string> atomics

			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.git.Module(gitTop), key, atomics, git);
		}

		public static string Msg(
			nilnul.fs.FolderI gitTop
						,
			string key
			,
			IEnumerable<string> atomics
,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.folder_.git_.Top(gitTop), key, atomics, git);
		}
	}
}
