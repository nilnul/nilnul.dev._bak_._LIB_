using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.dev_.baK
{
	/// <summary>
	/// ensure each client. umbrella remote for all is not tackled here.
	/// </summary>
	static public class _EnsureEachX
	{
		/// <summary>
		/// assume name unnormed.
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="svrRepoName"></param>
		/// <param name="clients"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			nilnul.fs.git.ModuleI gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return clients.Select(
				c=>remote_.dev_.bak.put._ResultX.NewlyCreated(
					gitTop
					,
					svrRepoName
					,
					c
					,
					git
				)
			);
		}

		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			nilnul.fs.git.Module gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null)
		{
			return NewlyCreatedS(
				gitTop as nilnul.fs.git.ModuleI
				,
				svrRepoName
				,
				clients
				,
				git
			);

		}

		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			nilnul.fs.folder_.git_.Top gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null)
		{
			return NewlyCreatedS(
				gitTop,
				svrRepoName,
				clients,
				git
			);

		}




		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			nilnul.fs.FolderI gitTop
			, 
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null
			
		)
		{
			return NewlyCreatedS(
				new fs.folder_.git_.Top(gitTop),
				svrRepoName,
				clients,
				git
			);

		}

		static public IEnumerable<nilnul._op.result_.Explain<bool>> NewlyCreatedS(
			string gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreatedS(nilnul.fs.Folder.FroAddress(gitTop), svrRepoName,clients, git);
		}



	}
}
