//#define SOME_AMAZON_REPO_NOT_CREATED
using nilnul.fs.git.svr.client_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.amazon_.ohio.put_
{

	static public class _EnsureSvrFirstX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		)
		{
			if (nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.vered.be_._AnyX.Be_remoteOfNom(
				gitTop
				,
				remoteNameNom
				,
				git
			))
			{
#if SOME_AMAZON_REPO_NOT_CREATED
				///ensure on the server
				///todo: remove this
				///
				Trace.TraceInformation(
					$@"ensuring repo with newest remote; response:{
						nilnul.fs.git.module.repo._cfg_.remote_.svr_.amazon_.newest._EnsureOhioRepoX.Json(
							gitTop, git
						)
					}"
				);
#endif
				return false;
			}

			var r = nilnul.fs.git.svr_.amazon.client.repo.create._EnsureX.Ret(
				amazon
				,
				svrRepoName
			);

			Trace.TraceInformation(
				$"creating repo at amazon  with given repoName {svrRepoName}; response:{r}."
			);

			nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.amazon_.ohio._CreateX.Void(
				gitTop
				,
				remoteNameNom
					,
				svrRepoName
			);
			
			return true;
		}

	

		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
						,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

			,
			string svrRepoName,
			nilnul.win.prog_.Git git=null
			)
		{
			return NewlyCreated(gitTop
				,
				
					remoteNameNom
					,
					amazon
				
				,
				new svr.repo.Name( svrRepoName)
			);
		}


		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			)
		{
			return NewlyCreated(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom
				,
				amazon,

				svrRepoName);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom

						,

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon


			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop),remoteNameNom, amazon,svrRepoName);
		}

		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom
			,

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

			,
			string svrRepoName)
		{
			return NewlyCreated(
				gitTop
				,remoteNameNom
				,
				amazon
				, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}

		
		public static bool NewlyCreated(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
						,

			nilnul.fs.git.svr_.amazon.client_.AccInVault amazon

, string svrRepoName
			)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop)
				,remoteNameNom
				,amazon
				, (svrRepoName)
			);
		}

	}
}
