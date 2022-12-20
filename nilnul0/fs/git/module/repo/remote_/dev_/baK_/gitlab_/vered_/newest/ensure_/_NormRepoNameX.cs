//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.gitlab_.vered_.newest.ensure_
{

	static public class _NormRepoNameX
	{
		/// <summary>
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="remoteNameNom"></param>
		/// <param name="client"></param>
		/// <param name="svrRepoName"></param>
		/// <param name="git"></param>
		/// <returns>
		/// true if a new remote is created
		/// </returns>
		public static bool _Created_repoNameAssumeUnnormed(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,
			nilnul.fs.git.svr.client_.accVaulted_.GitlabI client
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
				//create_._SvrNoErrX.SvrNoErr
				_cfg_.remote_.dev_.baK_.gitlab._CreateX.Exe
					//azure.create_._SvrFirstX.SvrNoErr
					(
					gitTop
					,
					 r
					 ,
					 client.usr
					 ,
					 svrRepoName
					,
					git
				);
				return true;
			}
			if (newest is null)
			{
				return created4next(remoteNameNom);
			}

			var urns = nilnul.fs.git.module.repo._cfg_.remote.urls._VwX.Txts(
				gitTop
				,
				newest
			).Select(a => a.Trim());

			if (
				urns.Any(   /// we tried to change url, if any url is unrepairable, we need to change the whole remote
					u => //unrepairable
					{

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

							if (d == "gitlab.com")
							{
								//change invalid repoName
								var repoName = url.nodewise.resource0nul.render.route.division.denotes.Last().en;

								if (
									!repoName.EndsWith(".git")
								)
								{
									return true; //need change name
								}
								if (

									Regex.IsMatch(
										repoName,@"\A\W|\W\W|\W\z"
									)
								//new nilnul.obj.co.str.of_._PeekAhead_ovStr<char>(
								//	repoName
								//).Any(
								//	(a) => isPunc(a.Item1) && isPunc(a.Item2)
								//)

								)
								{
									return true;
								}

								return false;

							
							}
						}
						return true;
					}
				)
			)
			{
				var remoteParsed = nilnul.txt_.Vered3.Parse(newest);

				nilnul.fs.git.module.repo._cfg_.remote.name._ChangeX._Vod_addressAssumeModule_assumeValids(
					gitTop.top1.en.address.en.ToString()
					,
					newest
					,
					$@"{newest}{1}L{new BigInteger(Guid.NewGuid().ToByteArray().Append((byte)0).ToArray())}r"
				);

				return created4next(newest);

			}
			return false;
		}

		public static bool _Created_repoNameAssumeUnnormed(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.gitlab.client_.AccInVault client
			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			,
			nilnul.win.prog_.Git git = null
		)
		{
			return _Created_repoNameAssumeUnnormed(
				gitTop
				,
				remoteNameNom
				,
				(nilnul.fs.git.svr.client_.accVaulted_.GitlabI)client
				,
				svrRepoName
				,
				git
			);
		}

		public static bool _Created_repoNameAssumeUnnormed(
			nilnul.fs.git.ModuleI gitTop
						,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.gitlab.client_.AccInVault client

			,
			string svrRepoName,
			nilnul.win.prog_.Git git = null
			)
		{
			return _Created_repoNameAssumeUnnormed(
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


		public static bool _Created_repoNameAssumeUnnormed(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.gitlab.client_.AccInVault client

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			)
		{
			return _Created_repoNameAssumeUnnormed(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom,
				client,
				svrRepoName);
		}


		public static bool _Created_repoNameAssumeUnnormed(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom

			,
			nilnul.fs.git.svr_.gitlab.client_.AccInVault client


			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			return _Created_repoNameAssumeUnnormed(new nilnul.fs.git.Module(gitTop), remoteNameNom, client, svrRepoName);
		}

		public static bool _Created_repoNameAssumeUnnormed(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.gitlab.client_.AccInVault client

			,
			string svrRepoName
		)
		{
			return _Created_repoNameAssumeUnnormed(
				gitTop
				, remoteNameNom
				,
				client
				, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static bool _Created_repoNameAssumeUnnormed(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
						,
			nilnul.fs.git.svr_.gitlab.client_.AccInVault client

			, string svrRepoName
		)
		{
			return _Created_repoNameAssumeUnnormed(
				new fs.folder_.git_.Top(gitTop)
				, remoteNameNom
				, client
				, (svrRepoName)
			);
		}

	}
}
