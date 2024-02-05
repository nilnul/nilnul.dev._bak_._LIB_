using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.azure
{
	static public class _CreateX
	{
		static public void _Vod_0depo_1nub4remote(
			string _gitTop
			,
			string remoteNom
			,
			string org
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_assumeModuleAddress1Remote1Urn(
				_gitTop
				,
				remoteNom
				,
				new 
				nilnul.fs.git.svr_.azure.client.teamwork.repo_.Defaulted(org,svrRepoName ).spear4git()

				,git
			);
		}

		static public void Exe(
			nilnul.fs.git.ModuleI _gitTop
			,
			string remoteNom
			,
			string org
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX.RetVoid(
				_gitTop
				,
				remoteNom
				,
				new 
				nilnul.fs.git.svr_.azure.client.teamwork.repo_.Defaulted(org,svrRepoName ).spear4git()

				,git
			);
		}
		static public void Exe(
			nilnul.fs.git.Module _gitTop
			,
			string remoteNom
				,
			string usr
		,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		) {
			Exe(_gitTop as nilnul.fs.git.ModuleI, remoteNom,usr, svrRepoName,git);
		}
		
	}
}