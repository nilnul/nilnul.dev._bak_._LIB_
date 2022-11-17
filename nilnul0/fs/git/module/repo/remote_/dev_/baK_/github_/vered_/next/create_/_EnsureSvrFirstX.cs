//#define SOME_AMAZON_REPO_NOT_CREATED
using nilnul.fs.git.svr.client_.accVaulted_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.github_.vered_.next.create_
{

	static public class _EnsureSvrFirstX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="remoteNameNom">assume nom</param>
		/// <param name="client"></param>
		/// <param name="svrRepoName">assume unnormed</param>
		/// <param name="git"></param>
		/// <returns></returns>
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
			
			///
			string url=null;
			try
			{
				 url = nilnul.fs.git.svr_.github.client.repo.create_._PersonalX.Ensure(client,svrRepoName);

			}
			catch (Exception x)
			{
				Trace.TraceError(
					$"when creating {svrRepoName} at github: {x.ToString()}. "
				);
				/// we don't rethrow; instead we assume it's successful.
				//throw;
			}

			Trace.TraceInformation(
				$"creating repo at github with given repoName{svrRepoName}; response:{url}."
			);
			
			_CreateX.Exe(
				gitTop
				,
				 txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
				remoteNameNom
				)
				 ,
				 client.username
				 ,
				 svrRepoName
				,
				git
			);
			
			///here as the remote key is not found, we return true.
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
