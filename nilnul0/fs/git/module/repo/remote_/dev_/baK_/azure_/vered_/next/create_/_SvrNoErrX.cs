//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.azure_.vered_.newest.create_
{

	static public class _SvrNoErrX
	{
		/// <summary>
		/// ensure the newest exists and the url is valid (repoName doesnot start with '_' as the server disallows;)
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="remoteNameNom"></param>
		/// <param name="client"></param>
		/// <param name="svrRepoName"></param>
		/// <param name="git"></param>
		/// <returns>
		/// false if there already exists a remote;
		/// true otherwise;
		///
		/// </returns>
		public static bool SvrNoErr(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			var r = nilnul.fs.git.svr_.azure.client.teamwork.create_.personal._EnsureX.Result(
				client
				,
				svrRepoName
			);

			Trace.TraceInformation(
				$"creating repo at dev.azure.com with given repoName: {svrRepoName}; response:{r}."
			);

			var nextId = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NextX.NameVer(
				gitTop,
 txt_._vered_.Name.CreateByAppendingUnderscoreIfNecessary(
					remoteNameNom
					)
				,
		git
			);

			_cfg_.remote_.dev_.baK_.azure._CreateX.Exe(
				gitTop
				,
				nextId
				 ,
				 client.org
				 ,
				 svrRepoName
				,
				git
			);

			if (r.isXpn())
			{   //not created.
				Trace.TraceError(
					$"create {svrRepoName} at azure {client.org} failed: {r.xpn}"
				);
				return false;

			}

			return true;

		}


		public static bool SvrNoErr(
			nilnul.fs.git.ModuleI gitTop
						,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			string svrRepoName,
			nilnul.win.prog_.Git git = null
			)
		{
			return SvrNoErr(
				gitTop
				,

					remoteNameNom
					, client

				,
				new svr.repo.Name(svrRepoName)
			);
		}


		public static bool SvrNoErr(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			)
		{
			return SvrNoErr(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom,
				client,
				svrRepoName);
		}


		public static bool SvrNoErr(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom

			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client


			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			return SvrNoErr(new nilnul.fs.git.Module(gitTop), remoteNameNom, client, svrRepoName);
		}

		public static bool SvrNoErr(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			string svrRepoName)
		{
			return SvrNoErr(
				gitTop
				, remoteNameNom
				,
				client
				, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static bool SvrNoErr(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
						,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

, string svrRepoName)
		{
			return SvrNoErr(
				new fs.folder_.git_.Top(gitTop)
				, remoteNameNom
				, client
				, (svrRepoName)
			);
		}

	}
}
