//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using global::nilnul.win.prog_;

//#define SOME_AMAZON_REPO_NOT_CREATED
using nilnul.fs.git.svr.client_.accVaulted_;
using nilnul.win.prog_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.SourceControl.WebApi;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.github_.vered_.newest.ensure_.svr1st_
{


	/// <summary>
	/// we use the returned bool value to decide we need to append a new bakAll remote.
	/// </summary>
	static public class _EnsureSshX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="remoteNameNom">assume nom</param>
		/// <param name="client"></param>
		/// <param name="svrRepoName">assume unnormed</param>
		/// <param name="git"></param>
		/// <returns>
		/// we use the old remote or create a new one
		/// </returns>
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
			var newest = nilnul.fs.git.module.repo._cfg_.remote_.vered_.name_.newest._NulableX.Txt(
				gitTop
				,
				remoteNameNom
				,
				git
			);

			bool created4next(string r)
			{


				
				nilnul.fs.git.module.repo._cfg_.remote_.dev_.baK_.github.ensure_._EnsureSvrFirstX.NewlyCreated
					(

					gitTop
					,
					r
					 ,
					 client
					 ,
					 svrRepoName
					,
					git
				);
				return true;

			}

			if (newest is null)
			{

				created4next(remoteNameNom);
				return true;

			}


			var urns = nilnul.fs.git.module.repo._cfg_.remote.urls._VwX.Txts(

					gitTop

				,
				newest
			).Select(a => a.Trim());


			var changedInPlace = false; // if changed in place, the nilnulBakAll remote needs to be appended anew.

			if (
				urns.Any(   /// we tried to change url, if any url is unrepairable, we need to change the whole remote
					u => //unrepairable
					{
						if (u.StartsWith("git@"))
						{
							return false;
						}

						//try parse to url
						nilnul.web.url_.SchemedNodewise url;
						try
						{
							url = nilnul.web.url_.SchemedNodewise.Parse(u);

						}
						catch (Exception x)
						{
							Trace.TraceError($"{gitTop}:{newest}{u} is not url");
							return true;
							//throw;
						}

						var h = nilnul.web._url._origin._authority._socket.HostA.Polish(url.nodewise.authority0nul.socket.host);


						if (
							h is nilnul.web._url._origin._authority._socket.host_.named_.DomainedI domained

						)
						{
							var d = domained.domain.ToString().ToLower();
							if (
								d == "github.com"
							)
							{
								// change to ssh

								nilnul.fs.git.module.repo._cfg_.remote.urn._ChangeX.Void(
									gitTop,
									newest,

									u

									,
									$"git@github.com:{url.nodewise.resource0nul.render.route.division}"
								);
								if (!changedInPlace)
								{
									changedInPlace = true;
								}
								return false;

							}
							return true;

						}
						return true;
					}
				)
			)
			{
				//var remoteParsed = nilnul.txt_.Vered3.Parse(newest);

				nilnul.fs.git.module.repo._cfg_.remote.name._ChangeX._Vod_addressAssumeModule_assumeValids(
					gitTop.top1.en.address.en.ToString()
					,
					newest
					,
					$@"{newest}{1}L{new BigInteger(Guid.NewGuid().ToByteArray().Append((byte)0).ToArray())}r"
				);

				created4next(newest);
				return true;

			}
			if (changedInPlace)
			{
				/// a new nilnulBakAll remote needs to be created.
				return true;
			}
			return false;







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
				gitTop, name
				,
				fs.git.svr_.github.client_.Vaulted.Of(
					github
				)

				, svrRepoName, git
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
