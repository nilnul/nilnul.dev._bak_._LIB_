﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.newly
{
	/// <summary>
	/// creating an aggregate remote with the urls of all the specified remotes.
	/// </summary>
	static public class _CreateX
	{
		public static IEnumerable<string> Urls(
			nilnul.fs.git.ModuleI gitTop
			,
			IEnumerable<nilnul.txt_._vered.Name> individualRemotes
			,
			nilnul.win.prog_.Git git = null
		)
		{

			///get the urls
			///

			var remotes = individualRemotes.Select(
				r => nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(
					gitTop
					,
					r
					,
					git
				)
			);

			var notNuls = remotes.Where(x => x != null);
			var urls = new List<string>();

			if (notNuls.Any())
			{

				var firstUrl = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(
					gitTop
					,
					notNuls.First().ToString()
				);

				urls.Add(firstUrl);

				var nextKey =
nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.newly._VwX.NameVer
					//nilnul.fs.git.module.repo._cfg_.remote_.bak_.awGlVs_.newest_.next._VwX.NameVer
					(gitTop, git);

				nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
					gitTop
					,
					nextKey.ToString()
					,
					firstUrl
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
						var u = nilnul.fs.git.module.repo._cfg_.remote.url._VwX1.Exe(
							gitTop
							,
							x.ToString()
						);

						urls.Add(u);

						nilnul.fs.git.module.repo._cfg_.remote.urls_.push._InsX1.Exe(
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

			return urls;





		}


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

			return Urls(
				gitTop
				,
				individualRemotes.Select(
					r =>
					nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(
						gitTop
						,
						nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
							r
						)
						,git
					)
				)
				,
				git
			);

		}



		public static IEnumerable<string> Urls(
			nilnul.fs.git.Module gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Urls(gitTop as ModuleI, individualRemotes, git);

		public static IEnumerable<string> Urls(
			nilnul.fs.folder_.git_.Top gitTop
						,
			IEnumerable<string> individualRemotes
,
			nilnul.win.prog_.Git git = null
		)
		=> Urls(new nilnul.fs.git.Module(gitTop), individualRemotes, git);
	}
}
