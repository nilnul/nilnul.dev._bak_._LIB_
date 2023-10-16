using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.gitlab
{

	static public class _EnsureOneX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="remoteNameNom"></param>
		/// <param name="usr"></param>
		/// <param name="svrRepoName">assume unnormed</param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,
			string usr
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


			gitlab._CreateX.Exe(
				gitTop
			,
			 remoteNameNom
			 ,usr

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
			string usr

			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(gitTop, remoteNameNom, usr,new svr.repo.Name(svrRepoName), git);
		}


		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom
			,
			string usr

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(gitTop as nilnul.fs.git.ModuleI, remoteNameNom, usr,svrRepoName, git);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
						,
			string remoteNameNom

			
			,
			string usr,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{

			return NewlyCreated(
				new nilnul.fs.git.Module(gitTop),

			 remoteNameNom
			 ,usr
,
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
			string usr

			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null

		)
		{
			return NewlyCreated(
				gitTop,
				remoteNameNom
				,usr
				,
				new nilnul.fs.git.svr.repo.Name(svrRepoName)
				,
				git
			);
		}



		public static bool NewlyCreated(
			nilnul.fs.FolderI gitTop
			,           
			string remoteNameNom
			,
			string usr

			,
			string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop),remoteNameNom, usr,(svrRepoName), git
			);
		}

		public static bool NewlyCreated_ofModuleAddress(
			string gitTop
						,
			string remoteNameNom
			,
			string usr

			,
			string svrRepoName, nilnul.win.prog_.Git git = null)
		{
			return NewlyCreated(
				nilnul.fs.Folder.FroAddress(gitTop)
				,
				remoteNameNom
				,usr
				,
				svrRepoName
				,
				git
			);
		}


	}
}
