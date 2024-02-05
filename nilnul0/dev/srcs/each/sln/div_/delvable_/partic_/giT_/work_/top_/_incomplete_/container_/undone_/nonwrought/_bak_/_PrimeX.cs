using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought._bak_
{
	/// <summary>
	/// config the repo, including config, ignore,exclude, attributes, description, etc
	/// </summary>
	static public class _PrimeX
	{
		static public void _Exe(string _folder_address, CancellationToken cancel, nilnul.win.prog_.Git git = null)
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

				if (name.Length > 64)
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

			#region check whether there are uncommited in index.
			 ///:if there are uncommited, issue a warning
			/// <see cref="nonwrought_.primed.Bak"/>
			#endregion


			//var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Results(_folder_address, name).ToArray();

			cancel.ThrowIfCancellationRequested();

			#region remotes ensure
			Trace.TraceInformation(
				$"{folder} is ensuring all the bak remotes"
			);

			var ensured = nilnul.fs.git.module.repo._cfg_.remotes_.dev_.baK._UpsertOmegaX.Msg(
				_folder_address
				,
				name
				,
				git
			);


			#endregion


			Trace.TraceInformation(
				$@"created remotes : ({
					ensured
				})
				"
			);

			///todo: commit index?
			//Trace.Unindent();
			Trace.TraceInformation("primed");
		}
	}
}
