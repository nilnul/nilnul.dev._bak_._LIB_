//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.azure.create_
{

	/// <summary>
	/// ensure the repo
	/// </summary>
	/// <remarks>
	/// </remarks>
	/// <see cref="nilnul.fs.git.module.repo.remote_.dev_.baK_.azure_.vered_.newest.ensure_.svr1st_._NormRepoNameX"/>
	/// ensure svr first;

	static public class _SvrFirstX
	{
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


			/// note here in git repo cfg we need the normalized name.
			///
			var normalizedRepoName = nilnul.fs.git.svr_.azure.repo.Name.Of_byEncode(svrRepoName);

			var r = nilnul.fs.git.svr_.azure.client.teamwork.create_.personal._EnsureX.Result(
				client
				,
				normalizedRepoName
			);

			Trace.TraceInformation(
				$"creating repo at dev.azure.com with given repoName: {svrRepoName}; response:{r}."
			);

			azure._CreateX.Exe(
				gitTop
				,
				 txt_._vered_.Name.CreateByAppendingUnderscoreIfNecessary(
				remoteNameNom
				)
				 ,
				 client.org
				 ,
				 new svr.repo.Name(
					normalizedRepoName.ee
				 )
				,
				git
			);

			if (r.isXpn())
			{	//not created.
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
					,client
				
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
			return SvrNoErr(new nilnul.fs.git.Module(gitTop), remoteNameNom,client, svrRepoName);
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
				,client
				, (svrRepoName)
			);
		}

	}
}
