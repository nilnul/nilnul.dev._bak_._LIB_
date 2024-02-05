using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.nonexist.create_
{
	/// <summary>
	/// create the key if any urn.
	/// </summary>
	public class _IfAnyX
	{
		public static string _Msg_0depo_1nob4each(
			string gitTop
			,
			IEnumerable<string> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			//return _IfUrlsX._Msg_0depo(gitTop, individualRemotes, git);

			///get the urls
			///
			

			var remotes = individualRemotes.Select(
				r=>
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX._Txt_0depo_1nob(gitTop,r,git)
			);

			var notNuls = remotes.Where(x => x is not null);

			var urls = new List<string>();

			if (notNuls.Any())
			{

				var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.urn._VwX._Txt_assumesModuleAddress1Remote(
					gitTop,

					notNuls.First()
				);
				urls.Add(firstUrl);

				var lastkey = _all.key._VwX.GetLastAsName();
				var moduleAddress = gitTop.ToString();

				//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(moduleAddress).Wait();
				nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_moduleOfAddress_assumeUrn(gitTop, lastkey, firstUrl);
				///append
				///
				notNuls.Skip(1).ForEach(
					x =>
					{
						var u = nilnul.fs.git.module.repo._cfg_.remote.urn._VwX._Txt_assumesModuleAddress1Remote(
							gitTop, x
						);
						urls.Add(u);

						nilnul.fs.git.depo.repo.vow_.unlocked_.wait_._TimeoutX._Vod_0depo(gitTop);

						//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(moduleAddress).Wait();
						nilnul.fs.git.depo.repo._cfg_.remote.uris_.push._InsertX._Vod_0depo_1remote_2uri(
							gitTop
							,
							lastkey
							//new _remote.Name(
							//	_AwGlBbVsX.GetLastAsName()
							//)
							,
							u
							,
							git
						);
					}
				);
			}
			return ($"created fro {nilnul.txts.accumulate_.AsLines.Singleton.accumulate(urls)}");
		}

		public static string _Msg_assumeModuleAddress(
			string gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Msg_0depo_1nob4each(gitTop, individualRemotes.Select(r => r.en), git);


		}

		public static string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return _Msg_assumeModuleAddress(
				gitTop.top1.ToString()
				,
				individualRemotes
				,
				git
			);
		
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
			IEnumerable<string> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(
				gitTop
				,
				individualRemotes.Select(x=> new txt_._vered.Name(x))
				,git
			);

		}



		public static string Msg(
			nilnul.fs.git.Module gitTop
			,
			IEnumerable<string> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(gitTop as nilnul.fs.git.ModuleI, individualRemotes, git);
		}

		public static string Msg(
			nilnul.fs.folder_.git_.Top gitTop
			,
			IEnumerable<string> individualRemotes

			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.git.Module(gitTop), individualRemotes, git);
		}

		public static string Msg(
			nilnul.fs.FolderI gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.folder_.git_.Top(gitTop),individualRemotes, git);
		}
	}
}
