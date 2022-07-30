//#define SOME_AMAZON_REPO_NOT_CREATED
using nilnul.fs.git.svr.client_.accVaulted_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.github.ensure_
{

	static public class _EnsureSvrFirstX
	{
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.github.client_.Vaulted client
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

			var url = nilnul.fs.git.svr_.github.client.repo.create_._PersonalX.Ensure(client,svrRepoName);


			

			Trace.TraceInformation(
				$"creating repo at github with given repoName{svrRepoName}; response:{url}."
			);
			
			_CreateX.Exe(
				gitTop
				,
				 txt_._vered_.Name.CreateByAppendingUnderscoreIfNecessary(
				remoteNameNom
				)
				 ,
				 client.username
				 ,
				 svrRepoName
				,
				git
			);
			

			return true;





		}


		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
						,
			string remoteNameNom

			,
			nilnul.fs.git.svr_.github.client_.Vaulted client
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null
			)
		{
			return NewlyCreated(
				gitTop
				,
				
					remoteNameNom
				
				,
				client
				,
				new svr.repo.Name(svrRepoName)
				,
				git
			);
		}

		internal static bool NewlyCreated(ModuleI gitTop, string name, Github github, svr.repo.Name svrRepoName, Git git)
		{
			return NewlyCreated(
				gitTop,name
				,
				fs. git.svr_.github.client_.Vaulted.Of(
					github
				)
				
				,svrRepoName,git
			);

		}

		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom

			,
			nilnul.fs.git.svr_.github.client_.Vaulted client
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null

			)
		{
			return NewlyCreated(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom,
				client,
				svrRepoName
				,
				git
				);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom



			,
			nilnul.fs.git.svr_.github.client_.Vaulted client
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(
				new nilnul.fs.git.Module(gitTop),
				remoteNameNom

				,
				client
				, svrRepoName
				,
				git
				);
		}

		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom

			,
			nilnul.fs.git.svr_.github.client_.Vaulted client
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null

			)
		{
			return NewlyCreated(
				gitTop
				, remoteNameNom
				,
				client
				, new nilnul.fs.git.svr.repo.Name(svrRepoName)
				,
				git

				);
		}


		public static bool NewlyCreated(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.github.client_.Vaulted client
, string svrRepoName
			,
			nilnul.win.prog_.Git git = null

			)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop)
				, remoteNameNom
				,
				client
				, (svrRepoName)
				,
				git
			);
		}

	}
}
