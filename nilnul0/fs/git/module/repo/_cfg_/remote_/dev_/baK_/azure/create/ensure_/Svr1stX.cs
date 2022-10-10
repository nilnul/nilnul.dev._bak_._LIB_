//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.azure.create.ensure_
{

	static public class _SvrFirstX
	{
		public static bool NewlyCreated(
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
			if (nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.vered.be_._AnyX.Be_remoteOfNom(
				gitTop
				,
				remoteNameNom
				,
				git
			))
			{
				return false;
			}

			//var url = client.gitUrl(svrRepoName);


			var r = nilnul.fs.git.svr_.azure.client.teamwork.create_.personal._EnsureX.Result(
				client
				,
				svrRepoName
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
				 svrRepoName
				,
				git
			);

			if (r.isXpn())
			{	//not created.
				return false;

			}

			return true;





		}


		public static bool NewlyCreated(
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
			return NewlyCreated(
				gitTop
				,
				
					remoteNameNom
					,client
				
				,
				new svr.repo.Name(svrRepoName)
			);
		}


		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			)
		{
			return NewlyCreated(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom,
				client,
				svrRepoName);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom

			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client


			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop), remoteNameNom,client, svrRepoName);
		}

		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			string svrRepoName)
		{
			return NewlyCreated(
				gitTop
				, remoteNameNom
				,
				client
				, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static bool NewlyCreated(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
						,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

, string svrRepoName)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop)
				, remoteNameNom
				,client
				, (svrRepoName)
			);
		}

	}
}
