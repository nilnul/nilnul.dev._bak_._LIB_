using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.next
{
	/// <summary>
	/// creating an aggregate remote with the urls of all the specified remotes.
	/// </summary>
	static public class _CreateX
	{
		public static IEnumerable<string> _Urns_assumeModuleAddress_remoteAssumeValidKey(
			string gitTop
			,
			IEnumerable<string> _key4remotEs
			,
			nilnul.win.prog_.Git git = null
		)
		{


			///get the urls
			///

			var remotes = _key4remotEs.Select(
				r => nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(
					gitTop
					,
					r
					,
					git
				)
			);

			var notNuls = remotes.Where(x => x != null);
			var urns = new List<string>();

			if (notNuls.Any())
			{

				//var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(
				//	gitTop
				//	,
				//	notNuls.First().ToString()
				//);

				var firstUrn = nilnul.fs.git.module.repo._cfg_.remote.urn._VwX._Txt_assumesModuleAddress1Remote(
					gitTop
					,
					
					notNuls.First()		//.ToString()
					
				);

				urns.Add(firstUrn);

				var nextKey =
nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.newly._VwX._Vered_assumeModuleAddress
					//nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlVs_.newest_.next._VwX.NameVer
					(gitTop, git);

				//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(gitTop.ToString()).Wait();
				nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_assumeModuleAddress1Remote1Urn(
					gitTop
					,
					nextKey.ToString()
					,
					firstUrn
					,
					git
				);


				//nilnul.fs.git.module.repo._cfg_.remote_.nameInId_.next._CreateX.Void(gitTop, _AwGlBbVsX.GetLastAsName(), firstUrl);

				//var newestKey = newest._VwX.NameVer(gitTop, git);
				///append
				///
				notNuls.Skip(1).ForEach(
					x =>
					{
						var u = nilnul.fs.git.module.repo._cfg_.remote.urn._VwX._Txt_assumesModuleAddress1Remote(
							gitTop
							,
							
								x
							
						);

						urns.Add(u);

						//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(gitTop).Wait();
						nilnul.fs.git.module.repo._cfg_.remote.urns_.push._InsX._Vod_moduleAssumeAddress_urnAssume(
							gitTop,
							nextKey.ToString()
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
			return urns;
		}
		public static IEnumerable<string> Urns(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Urns_assumeModuleAddress_remoteAssumeValidKey(
				gitTop.top1.en.ToString()
				,
				individualRemotes.Select(i=>i.ToString())
				,
				git
			);
		}

		[Obsolete(nameof(Urns))]
		public static IEnumerable<string> Urls(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Urns(gitTop,individualRemotes,git);
		}


		public static IEnumerable<string> _Urns_remoteAssumeNom(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<string> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{

			///get the urls
			///

			return _Urns_assumeModuleAddress_remoteAssumeValidKey(
				gitTop.ToString()
				,
				individualRemotes
				,
				git
			);

		}

		[Obsolete(nameof(Urns))]
		public static IEnumerable<string> Urls(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<string> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{

			///get the urls
			///

			return _Urns_remoteAssumeNom(
				gitTop
				,
				individualRemotes
				,
				git
			);

		}



		public static IEnumerable<string> Urns(
			nilnul.fs.git.Module gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> _Urns_remoteAssumeNom(gitTop as ModuleI, individualRemotes, git);

		[Obsolete(nameof(Urns))]
		public static IEnumerable<string> Urls(
			nilnul.fs.git.Module gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Urns(gitTop, individualRemotes, git);


		public static IEnumerable<string> Urns(
			nilnul.fs.folder_.git_.Top gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Urns(new nilnul.fs.git.Module(gitTop), individualRemotes, git);


		[Obsolete(nameof(Urns))]
		public static IEnumerable<string> Urls(
			nilnul.fs.folder_.git_.Top gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Urns(gitTop, individualRemotes, git);

	}
}
