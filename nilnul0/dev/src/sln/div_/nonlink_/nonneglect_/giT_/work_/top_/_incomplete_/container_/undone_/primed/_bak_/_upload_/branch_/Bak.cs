using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload_.branch_
{
	/// <summary>
	/// </summary>
	public static class _BakX
	{


	

		public static bool _Void(
			string _location
			,
			 ConcurrentBag<DivI2> innerModules,

			CancellationToken cancel
			,string bakBranch
			,
			nilnul.win.program_.Git git = null)
		{
			bool noError = true;

			fs.git.Module1 module = nilnul.fs.git.Module1.OfAddress(_location);
			Trace.TraceInformation($"syncing {_location} ...");
			try
			{
				#region pushup the bakBranch.

				IEnumerable<txt_.NameVer> remotes = nilnul.fs.git.module._cfg_.remotes_.bak_.awGlVs._VwX.LatestOrDefault(
					_location
				);

				if (remotes.Count() == 0)
				{
					// cannot decide the remote repo name. 
					//err log and return.

					Trace.TraceError(
						$"no remote with auto sync set found at {_location}"
					);

					return false;
				}



				IEnumerable<txt_.NameVer> latestRemotes = remotes.Where(x => x != null);// 
				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled before pushing bak branch for {_location}");
					cancel.ThrowIfCancellationRequested();
					return false;
				}

				Trace.TraceInformation($"pushing {bakBranch} for { _location}");

				try
				{
					Dictionary<txt_.NameVer, int> results = new Dictionary<txt_.NameVer, int>();



					foreach (txt_.NameVer remote in latestRemotes)
					{
						cancel.ThrowIfCancellationRequested();

						//get last time pushed.
						nilnul.fs.git.module._cfg_.section.Sub


						results.Add(
								remote
								,
								 nilnul.fs.git.module.repo.push_.remote.branch_._UiTitledX.ExitCode(
									module.ToString()
									, remote.ToString()
									, bakBranch
									, git
								)
						);
					}

					IEnumerable<KeyValuePair<txt_.NameVer, int>> resultsErr = results.Where(x => x.Value != 0);
					IEnumerable<KeyValuePair<txt_.NameVer, int>> resultsSuccess = results.Where(x => x.Value == 0);

					if (resultsErr.Any())
					{
						Trace.TraceError(
							$@"exceptions when pushing at {module} of branch_ {bakBranch}:(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsErr.Select(r => $@"{r.Key}:{r.Value}:{ nilnul.fs.git.repo._push.ExitCodeX.Explain(r.Value)}")
								)}
							)"
						);
						noError = false;
					}
					if (resultsSuccess.Any())
					{
						Trace.TraceInformation(
							$@"success in pushing at {module} of branch_ {bakBranch}:(
								{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
									resultsSuccess.Select(r => $@"{r.Key}:{r.Value}")
								)}
							)"
						);
					}


				}
				catch (OperationCanceledException ex)
				{
					throw;
				}
				catch (Exception e)
				{
					noError = false;
					Trace.TraceError($"when pushing {bakBranch} for {_location} as workroot inside sln by sync with remote: " + e.Message);

					//throw;
				}



				if (cancel.IsCancellationRequested)
				{

					Trace.TraceWarning($"user cancelled before pushing all branches at {_location}");
					cancel.ThrowIfCancellationRequested();
					return false;
				}
				#endregion
			}
			catch (OperationCanceledException ex)
			{
				noError = false;

				throw;
			}
			catch (Exception e)
			{
				noError = false;
				Trace.TraceError($"when processing {_location} as workroot inside sln by sync with remote: " + e.Message);
				//throw;
			}
			return noError;
		}

		public static bool _SyncThis(fs.FolderI3 _module, ConcurrentBag<DivI2> innerModules, CancellationToken cancel, string bakBranch, nilnul.win.program_.Git git = null)
		{
			return _Void(_module.ToString(), innerModules, cancel,bakBranch, git);
			//throw new NotImplementedException();
		}




	}
}
