//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.vs.put_
{

	static public class _EnsureCfgFirstX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.vs.client_.AccInVault client
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var url = client.gitUrl(svrRepoName);

			if (
				nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest.nulable.url._AppendIfNoX.Appended(
					gitTop
					,
					remoteNameNom
					,
					url
					,
					git
				)
			)
			{
				var r = nilnul.fs.git.svr_.vs_.prefixed.client.repo.create_.prjDefault._EnsureX.Result(
					client
					,
					svrRepoName
				);

				Trace.TraceInformation(
					$"creating repo with given repoName; response:{r}."
				);

				
				return true;

			}
			return false;


		}


		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
						,
			string remoteNameNom

			,
			string svrRepoName,
			nilnul.win.prog_.Git git = null
			)
		{
			return NewlyCreated(gitTop
				,
				new svr.repo.Name(
					remoteNameNom
				)
				,
				new svr.repo.Name(svrRepoName)
			);
		}


		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			)
		{
			return NewlyCreated(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom,
				svrRepoName);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom



			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop), remoteNameNom, svrRepoName);
		}

		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom

			,
			string svrRepoName)
		{
			return NewlyCreated(
				gitTop
				, remoteNameNom
				, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static bool NewlyCreated(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
, string svrRepoName)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop)
				, remoteNameNom
				, (svrRepoName)
			);
		}

	}
}
