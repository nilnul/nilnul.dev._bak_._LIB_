using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.github
{
	static public class _CreateX
	{
		static public void Exe(
			nilnul.fs.git.ModuleI _gitTop
			,
			string remoteNom
			,
			string usr
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git=null
		)
		{
			nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_assumeUrn(
				_gitTop
				,
				remoteNom
				,
				nilnul.fs.git.svr_.github.repo.urn_._SshX._Urn_assumesUsrRepo(
					usr,svrRepoName
				)
				//nilnul.fs.git.svr_.github.client.repo._UrlX.Url_withCred(usr,svrRepoName)
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