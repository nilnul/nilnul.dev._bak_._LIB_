using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.container_.undone._bak_
{
	static public class _PrimeX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="_folder_address"></param>
		/// <param name="innerModules"></param>
		/// <param name="innerModules2reinclude">
		/// delete this from _config_/exclude
		/// </param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		static public void _Exe(string _folder_address, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{

			Trace.TraceInformation($@"priming the {typeof(_PrimeX).FullName}: {_folder_address}");
			//Trace.Indent();

			var container = nilnul.fs.address_.Shield.Parse(
				_folder_address
			);
			var folder = new nilnul.fs.Folder(container);

			string name = "";
			try
			{
				name = nilnul.fs.folder.repoName_.ThrowIfNotInSrc.Singleton.getName_ofAddress(_folder_address);

				if (name.Length>64)
				{
					Trace.TraceError($@"repoName:{name} for {_folder_address} is longer than 64 which vs allowed. No exception is thrown; if there is already a remote of vs with a name shorter, the bak will proceed normally; but an exception will be thrown if new remote is to be created.");
				}
			}
			catch (Exception e)
			{
				//Trace.Unindent();
				Trace.TraceError($"when parsing {_folder_address} for a repoName:{e}");
				return;
				//throw;
			}

			Trace.TraceInformation(
				$"{folder} is ensuring the dotnet ignore"
			);
			cancel.ThrowIfCancellationRequested();
			//nilnul.fs.git._module.work._ignore.div_.top.doc.put_.dotnet._NilnulX.Exe(_folder_address);
			nilnul.fs.folder.doc_.git_.ignore_.vsNilnul._PutX.Vod_ofAddress(_folder_address);

			//

			Trace.TraceInformation(
				$"{folder} is ensuring the vsAwGlBb remotes"
			);

			//var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();

			//var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();
			cancel.ThrowIfCancellationRequested();

			var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlVs.ensure._UpsertOmegaX.Msg(_folder_address, name,git);

			Trace.TraceInformation(
				$@"created remotes : ({
					ensured
				})
				"
			);
			//Trace.Unindent();
			Trace.TraceInformation("primed");
		}
	}
}
