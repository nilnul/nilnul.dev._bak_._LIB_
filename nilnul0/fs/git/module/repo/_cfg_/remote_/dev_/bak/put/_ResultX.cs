using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo._cfg_.remote_.dev_.bak.put
{
	static public class _ResultX
	{

		/// <summary>
		/// name assume unnormed
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="svrRepoName">assume unnormed</param>
		/// <param name="client"></param>
		/// <param name="git"></param>
		/// <returns></returns>
		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Named client
			,
			nilnul.win.prog_.Git git = null
		)
		{

			switch (client.client)
			{
				case nilnul.fs.git.svr_.amazon.client_.AccInVault amazon:
					/// todo: if its ohio?
					try
					{
						return new nilnul._op.result_.Explain<bool>(
							baK_.amazon_.ohio.put_._EnsureSvrFirstX.NewlyCreated(
								gitTop
								,
								nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
									client.name
								)
								,
								amazon
								,
								svrRepoName
								,
								git
							)
						);
					}
					catch (Exception e)
					{
						return _op.result_.Explain<bool>.FroXpn(e.ToString());
						//throw;
					}
					break;

				case nilnul.fs.git.svr_.azure.client_.Vaulted azure:

					try
					{
						return new nilnul._op.result_.Explain<bool>(
							baK_.azure.create.ensure_._SvrFirstX.NewlyCreated(
								gitTop
								,
								nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
									client.name
								)
								, azure, svrRepoName, git
							)
						);
					}
					catch (Exception e) /*Aggregate Exception: inner: ProjectAlreadyExistsException: TF200019: The following project already exists on the Azure DevOps Server: -_nilnulEdu_. You cannot create a new project with the same name as an existing project. Provide a different name.
*/
					{
						Trace.TraceError(
							$"{typeof(_ResultX).FullName }.{nameof(NewlyCreated)}({gitTop}, azure, {svrRepoName}): {e.ToString()}"
						);
						return _op.result_.Explain<bool>.FroXpn(e.ToString());
						//throw;
					}
					break;

				case nilnul.fs.git.svr_.github.client_.Vaulted github:

					try
					{
						return new nilnul._op.result_.Explain<bool>(
							baK_.github.ensure_._EnsureSvrFirstX.NewlyCreated(
								gitTop
								,
								nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
									client.name
								)
								, github, svrRepoName, git
							)
						);
					}
					catch (Exception e)
					{
						return _op.result_.Explain<bool>.FroXpn(e.ToString());
						//throw;
					}
					break;

				case nilnul.fs.git.svr.client_.accVaulted_.Github github:

					try
					{
						return new nilnul._op.result_.Explain<bool>(
							baK_.github.ensure_._EnsureSvrFirstX.NewlyCreated(
								gitTop
								,
								nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
									client.name
								)
								, github, svrRepoName, git
							)
						);
					}
					catch (Exception e)
					{
						return _op.result_.Explain<bool>.FroXpn(e.ToString());
						//throw;
					}
					break;

				case nilnul.fs.git.svr.client_.accVaulted_.GitlabI gitlab:
					try
					{
						return
							baK_.gitlab.ensure._ResultX.NewlyCreated(
								gitTop,
																nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
									client.name
								)

								, gitlab.usr, svrRepoName, git
							)
						;
					}
					catch (Exception e)
					{
						return _op.result_.Explain<bool>.FroXpn(e.ToString());
						//throw;
					}
					break;


				case nilnul.fs.git.svr_.vs.client_.AccInVault vs:

					try
					{
						return new nilnul._op.result_.Explain<bool>(
							baK_.vs.put_.ensureSvrFirst_._EnsureKeyX.NewlyCreated(
								gitTop
								,
								nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
									client.name
								)
								,
								vs
								,
								svrRepoName
								,
								git
							)
						);
					}
					catch (Exception e)
					{
						return _op.result_.Explain<bool>.FroXpn(e.ToString());
						//throw;
					}
					break;
				default:
					throw new UnexpectedReachException();
					break;
			}

		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.git.ModuleI gitTop,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Named client
			,

			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(gitTop, new svr.repo.Name(svrRepoName), client, git);
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.git.Module gitTop,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Named client
			,

			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(
				gitTop as nilnul.fs.git.ModuleI
				,
				svrRepoName
				, client
				, git
			);
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Named client
			,

			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(
				new nilnul.fs.git.Module(gitTop)
				,
				svrRepoName
				, client
				, git
			);
		}

		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Named client
			,

			nilnul.win.prog_.Git git = null
		)
		{
			return NewlyCreated(
				gitTop
				,
				new nilnul.fs.git.svr.repo.Name(svrRepoName)
			,
			 client
			,

			 git

			);
		}


		public static nilnul._op.result_.Explain<bool> NewlyCreated(
			nilnul.fs.FolderI gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Named client
			,

			nilnul.win.prog_.Git git = null

		)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop)
				,
				(svrRepoName)
				,
				client
				, git
			);
		}

	}
}
