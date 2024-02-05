using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.folder_.git_;
using System.Threading;

namespace nilnul.fs.git.module.repo._cfg_.remotes_.dev_.baK
{
	/// <summary>
	/// upsert each remote. and also update an umbrella remote for them when necessary.
	/// </summary>
	static public class _UpsertOmegaX
	{
		static public string _Msg_0depo_1repoName(
			string gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null
			)
		{

			var newlyCreatedS = _EnsureEachX._NewlyCreatedEs_0depo(
				gitTop
				,
				svrRepoName
				,
				clients
				,
				git
			).ToArray(
			);

			var names = clients.Select(
				c=>nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
					c.name
				)
			);

			if (newlyCreatedS.Any(x => x.ret))
			{
				//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(gitTop.ToString()).Wait();
				var urls = nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.next._CreateX._Uris_0depo_1nub4remoteEs(
					gitTop, names, git
				)
					//.Select(
					//	u=> nilnul.web.url.op_.unary_._DelKeyX.Op(u).ToString()
					//)
				;

				return $@"created new bakAll branch,  of urls:
{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(urls)}";
			}
			else
			{
				//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(gitTop.ToString()).Wait();
				return remote_.dev_.baK_.all_.last.nulable.urns._EnsureX._Msg_0depo(
					gitTop
					,
					names
					,
					git
				);
			}
		}

		static public string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null
			)
		{

			var newlyCreatedS = _EnsureEachX.NewlyCreatedS(
				gitTop
				,
				svrRepoName
				,
				clients
				,
				git
			).ToArray(
			);

			var names = clients.Select(
				c=>nilnul.txt_._vered.Name.CreateByAppendingUnderscoreIfNecessary(
					c.name
				)
			);

			if (newlyCreatedS.Any(x => x.ret))
			{
				//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(gitTop.ToString()).Wait();
				var urls = nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.all_.next._CreateX.Urns(
					gitTop, names, git
				)
					//.Select(
					//	u=> nilnul.web.url.op_.unary_._DelKeyX.Op(u).ToString()
					//)
				;

				return $@"created new bakAll branch,  of urls:
{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(urls)}";
			}
			else
			{
				//nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(gitTop.ToString()).Wait();
				return remote_.dev_.baK_.all_.last.nulable.urns._EnsureX.Msg(
					gitTop
					,
					names
					,
					git
				);
			}
		}

		static public string Msg(
			nilnul.fs.git.ModuleI gitTop
			,
			string svrRepoName
		
			,
			nilnul.win.prog_.Git git = null
			)
		{
			return Msg(
				gitTop
				,
				svrRepoName
				,
				nilnul.fs.git.Properties.SettingsX.Clients_my
				,
				git
			);
		}

		public static string Msg(
			nilnul.fs.git.Module top2,
			string svrRepoName
						,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(top2 as nilnul.fs.git.ModuleI, svrRepoName,clients, git);
		}

		public static string Msg(
			Top top2,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return Msg(new nilnul.fs.git.Module(top2), svrRepoName,clients, git);
		}


		static public string Msg(
			nilnul.fs.FolderI gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients

			,
			nilnul.win.prog_.Git git = null
)
		{
			return Msg(new fs.folder_.git_.Top(gitTop), svrRepoName,clients,git);

		}


		static public string Msg(
			string gitTop
			,
			string svrRepoName
			,
			nilnul.fs.git.svr.client_.accVaulted.Nameds clients

			,
			nilnul.win.prog_.Git git = null)
		{
			return Msg( fs.Folder.FroAddress(gitTop), svrRepoName,clients, git);
		}

		static public string _Msg_0depo_1repoName(
			string gitTop
			,
			string svrRepoName

			,
			nilnul.win.prog_.Git git = null)
		{
			return _Msg_0depo_1repoName(
				(gitTop)
				,
				svrRepoName
				,
				nilnul.fs.git.Properties.SettingsX.Clients_my
				,
				git
			);
		}
		
		static public string Msg(
			string gitTop
			,
			string svrRepoName

			,
			nilnul.win.prog_.Git git = null)
		{
			return Msg(
				fs.Folder.FroAddress(gitTop)
				,
				svrRepoName
				,
				nilnul.fs.git.Properties.SettingsX.Clients_my
				,
				git
			);
		}
		



	}
}
