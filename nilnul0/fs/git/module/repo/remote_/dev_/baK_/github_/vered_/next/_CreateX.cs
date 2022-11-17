//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.github_.vered_.next
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
			nilnul.win.prog_.Git git = null
		)
		{
			var nextId = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_._NextX.NameVer(
		_gitTop,
txt_._vered_.Name.CreateByAppendingUnderscoreIfNecessary(
			remoteNom
			)
		,
git
	);

			nilnul.fs.git.module.repo._cfg_.remote._CreateX._Vod_assumeUrn(
					_gitTop
					,
					nextId
					,
					nilnul.fs.git.svr_.github.repo.urn_._SshX._Urn_assumesUsrRepo(
						usr, svrRepoName
					)
					//nilnul.fs.git.svr_.github.client.repo._UrlX.Url_withCred(usr,svrRepoName)
					, git
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
			nilnul.win.prog_.Git git = null
		)
		{
			Exe(_gitTop as nilnul.fs.git.ModuleI, remoteNom, usr, svrRepoName, git);
		}

	}
}
