using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.vs
{
	////extern alias git;
	static public class _CreateX
	{
		static public void _Vod_0depo_1nub4remote_2acc_3repoName(
			string _gitTop
			,
			string remoteNom
			,
			string prefix
			,
			string svrRepoName

			,
			nilnul.win.prog_.Git git = null
		)
		{

			nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_assumeModuleAddress1Remote1Urn(
				_gitTop
				, 
				remoteNom
								
,
				nilnul.fs.git.svr_.vs_.prefixed.repo._UrlX.Gen(prefix, svrRepoName)
				, 
				git
			);
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_gitTop"></param>
		/// <param name="remoteNom"></param>
		/// <param name="svrRepoName">the nom, excluding the version</param>
		/// <param name="git"></param>
		static public void Void(
			nilnul.fs.git.ModuleI _gitTop
			,
			string remoteNom
			,
			string prefix
			,
			nilnul.fs.git.svr.repo.Name svrRepoName

			,
			nilnul.win.prog_.Git git = null
		)
		{

			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				, 
				remoteNom
								
,
				nilnul.fs.git.svr_.vs_.prefixed.repo._UrlX.Gen(prefix, svrRepoName)
				, 
				git
			);
		}

		static public void Void(nilnul.fs.git.Module _gitTop
			,
			string remoteNom
						,
			string prefix

			,
			nilnul.fs.git.svr.repo.Name svrRepoName,
			nilnul.win.prog_.Git git = null)
		{
			Void(
				_gitTop as nilnul.fs.git.ModuleI
				,
				remoteNom
								, prefix
,
				svrRepoName,
				git);
		}

	

		static public void Void(nilnul.fs.folder_.git_.Top _gitTop
			,
			string remoteNom
			,
			string prefix

			,
			nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void( new nilnul.fs.git.Module( _gitTop), remoteNom, prefix
, svrRepoName, git);
		}


		static public void Void(
			nilnul.fs.folder_.git_.Top _gitTop
			,
			string remoteNom
			,
			string prefix

			,
			string svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void(
				_gitTop
				,
				remoteNom
					, prefix
			,
				new svr.repo.Name( svrRepoName)
				, git);
		}

		static public void Void(nilnul.fs.FolderI _gitTop
			,
			string remoteNom
			,
			string prefix
			,
			string svrRepoName,  nilnul.win.prog_.Git git = null)
		{


			Void(
				new
				///*git::*/
				nilnul.fs.folder_.git_.Top(_gitTop),
				remoteNom
				,prefix
				,
				svrRepoName,
				git
			);

		}

	}
}
