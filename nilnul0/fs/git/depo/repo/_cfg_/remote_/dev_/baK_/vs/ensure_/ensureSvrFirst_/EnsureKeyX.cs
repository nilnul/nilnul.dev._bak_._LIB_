//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.vs.put_.ensureSvrFirst_
{

	static public class _EnsureKeyX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.vs.client_.AccInVault client
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			var remoteNewst = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NewestX.Txt(gitTop, remoteNameNom);
			if (nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.vered.be_._AnyX.Be_remoteOfNom(
				gitTop
				,
				remoteNameNom
				,
				git
			))
			{
				var r1 = nilnul.fs.git.module.repo._cfg_.remote.url_.svr_.vs.ensureSvr_._ViaLibX.Result(
					client
					,
					gitTop
					,
					remoteNewst
					,
					git

				);
				Trace.TraceInformation(
					$@"ensure svr reop for {gitTop} remote {remoteNewst}:
					{r1}
					"
				);

				///ensure svr
				return false;
			}

			//var url = client.gitUrl(svrRepoName);


			var r = nilnul.fs.git.svr_.vs.client.teamwork.create_.personal._EnsureX.Result(
				client
				,
				svrRepoName
			);

			//var r = nilnul.fs.git.svr_.vs_.prefixed.client.repo.create_.prjDefault._EnsureX.Result(
			//	client
			//	,
			//	svrRepoName
			//);

			Trace.TraceInformation(
				$"creating repo at visualstudio.com with given repoName: {svrRepoName}; response:{r}."
			);

			vs._CreateX.Void(
				gitTop
				,
				 txt_._vered_.Name.CreateByAppendingUnderscoreIfNecessary(
				remoteNameNom
				)
				 ,
				 client.prefix
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
			nilnul.fs.git.svr_.vs.client_.AccInVault client

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
			nilnul.fs.git.svr_.vs.client_.AccInVault client

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
			nilnul.fs.git.svr_.vs.client_.AccInVault client


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
			nilnul.fs.git.svr_.vs.client_.AccInVault client

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
			nilnul.fs.git.svr_.vs.client_.AccInVault client

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
