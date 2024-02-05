using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.amazon_.ohio
{
	////extern alias git;
	static public class _CreateX
	{
		static public void _Vod_0depo_1remote_2repoName(
			string _gitTop
			,
			string remote
			,
			string svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_assumeModuleAddress1Remote1Urn(
				_gitTop
				, 
				remote
				, 
				nilnul.fs.git.svr_.aw_.ohio.repo._UrlX.Create(svrRepoName)
				, 
				git
			);
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_gitTop"></param>
		/// <param name="remote"></param>
		/// <param name="svrRepoName">the nom, excluding the version</param>
		/// <param name="git"></param>
		static public void _Vod_0depo_1remote(
			string _gitTop
			,
			string remote
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_assumeModuleAddress1Remote1Urn(
				_gitTop
				, 
				remote
				, 
				nilnul.fs.git.svr_.aw_.ohio.repo._UrlX.Create(svrRepoName)
				, 
				git
			);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_gitTop"></param>
		/// <param name="remote"></param>
		/// <param name="svrRepoName">the nom, excluding the version</param>
		/// <param name="git"></param>
		static public void Void(
			nilnul.fs.git.ModuleI _gitTop
			,
			string remote
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				, 
				remote
				, 
				nilnul.fs.git.svr_.aw_.ohio.repo._UrlX.Create(svrRepoName)
				, 
				git
			);
		}

		static public void Void(nilnul.fs.git.Module _gitTop
			,
			string remoteNom
			,
			nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void(
				_gitTop as nilnul.fs.git.ModuleI
				,
				remoteNom
				,
				svrRepoName,
				git);
		}

	

		static public void Void(nilnul.fs.folder_.git_.Top _gitTop
			,
			string remoteNom

			,
			nilnul.fs.git.svr.repo.Name svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void( new nilnul.fs.git.Module( _gitTop), remoteNom, svrRepoName, git);
		}


		static public void Void(
			nilnul.fs.folder_.git_.Top _gitTop
			,
			string remoteNom

			,
			string svrRepoName,  nilnul.win.prog_.Git git = null)
		{
			Void(
				_gitTop
				,
				remoteNom
				, 
				new svr.repo.Name( svrRepoName)
				, git);
		}

		static public void Void(nilnul.fs.FolderI _gitTop
			,
			string remoteNom
			,
			string svrRepoName,  nilnul.win.prog_.Git git = null)
		{


			Void(
				new
				///*git::*/
				nilnul.fs.folder_.git_.Top(_gitTop),
				remoteNom
				,
				svrRepoName,
				git
			);

		}

	}
}
