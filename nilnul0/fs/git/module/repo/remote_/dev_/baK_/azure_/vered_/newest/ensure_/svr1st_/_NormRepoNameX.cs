//#define SOME_AMAZON_REPO_NOT_CREATED
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.git.module.repo.remote_.dev_.baK_.azure_.vered_.newest.ensure_.svr1st_
{

	static public class _NormRepoNameX
	{
		/// <summary>
		/// ensure the newest exists and the url is valid (repoName doesnot start with '_' as the server disallows;)
		/// </summary>
		/// <param name="gitTop"></param>
		/// <param name="remoteNameNom"></param>
		/// <param name="client"></param>
		/// <param name="svrRepoName"></param>
		/// <param name="git"></param>
		/// <returns>
		/// false if there already exists a remote;
		/// true otherwise;
		///
		/// </returns>
		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
			,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client
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

			bool created4next(string r) {


				//create_._SvrNoErrX.SvrNoErr

				
	

				azure.create_._SvrFirstX.SvrNoErr
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

							if (d == "azure.com")
							{
								//change invalid repoName
								//remove that
								if (
									url.nodewise.resource0nul.render.route.division.denotes.Last().en.StartsWith("_")
								)
								{
									return true; //need change name
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
					//$@"{newest}{1}L{new BigInteger(Guid.NewGuid().ToByteArray().Append((byte)0).ToArray())}r"

					//$@"{newest}{1}L{nilnul.time_.datetime._lex_.phrase_.yr_.decimalSubsecond_.NoSep.Singleton.phrase()}r"
					$@"{newest}{1}L{nilnul.time_.datetime.lex_.num_.YrInTwo.Singleton.phrase()}r" //use noncollapsed lest it conflicts with others;

				);

				return created4next(newest);

			}
			return false;
		}


		public static bool NewlyCreated(
			nilnul.fs.git.ModuleI gitTop
						,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			string svrRepoName,
			nilnul.win.prog_.Git git = null
			)
		{
			return NewlyCreated(
				gitTop
				,

					remoteNameNom
					, client

				,
				new svr.repo.Name(svrRepoName)
			);
		}


		public static bool NewlyCreated(
			nilnul.fs.git.Module gitTop
						,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			nilnul.fs.git.svr.repo.Name svrRepoName
			)
		{
			return NewlyCreated(
				gitTop as nilnul.fs.git.ModuleI,
				remoteNameNom,
				client,
				svrRepoName);
		}


		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
									,
			string remoteNameNom

			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client


			,
			nilnul.fs.git.svr.repo.Name svrRepoName
		)
		{
			return NewlyCreated(new nilnul.fs.git.Module(gitTop), remoteNameNom, client, svrRepoName);
		}

		public static bool NewlyCreated(
			nilnul.fs.folder_.git_.Top gitTop
												,
			string remoteNameNom
			,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

			,
			string svrRepoName)
		{
			return NewlyCreated(
				gitTop
				, remoteNameNom
				,
				client
				, new nilnul.fs.git.svr.repo.Name(svrRepoName));
		}


		public static bool NewlyCreated(
			nilnul.fs.FolderI gitTop
												,
			string remoteNameNom
						,
			nilnul.fs.git.svr_.azure.client_.Vaulted client

, string svrRepoName)
		{
			return NewlyCreated(
				new fs.folder_.git_.Top(gitTop)
				, remoteNameNom
				, client
				, (svrRepoName)
			);
		}

	}
}
