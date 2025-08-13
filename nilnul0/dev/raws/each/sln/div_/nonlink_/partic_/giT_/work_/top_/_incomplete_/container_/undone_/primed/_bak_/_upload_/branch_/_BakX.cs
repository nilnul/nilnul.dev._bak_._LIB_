using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.partic_.git_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload_.branch_
{
	/// <summary>
	/// pushing the branch of "bak...", 
	/// </summary>
	public static class _BakX
	{
		/// <summary>
		/// use stash
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static bool _Succed(
			string _location
			//,
			//ConcurrentBag<DivI> innerModules
			,
			CancellationToken cancel
			,
			string bakBranch
			,
			nilnul.win.prog_.Git git = null)
		{
			/// todo: check whether it's already pushed by comparing the tracked branch and this branch.
			bool noError = true;
			try
			{

				IEnumerable<txt_.NameVer> remotes = nilnul.fs.git.module.repo._cfg_.remotes_.bak_.awGlVs._VwX.LatestOrDefault(
					_location
				);  //.Where(x => x.StartsWith(DataFoldersGit.AutoRemotPrefix_NoUnderscore));

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

						results.Add(
								remote
								,
								 nilnul.fs.git.module.repo.push_.remote.branch_._UiTitledX.ExitCode(
									_location
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
						if (
							resultsSuccess.Count() < nilnul.dev.bak.Properties.Settings.Default.pushErrsAsWarningIfSuccessesGe
						)
						{
							Trace.TraceError(
								$@"exceptions when pushing at {_location} of branch_ {bakBranch}:(
									{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
										resultsErr.Select(r => $@"{r.Key}:{r.Value}:{ nilnul.fs.git.repo._push.ExitCodeX.Explain(r.Value)}")
									)}
								)"
							);

							noError = false;
						}
						else
						{
							Trace.TraceWarning(
								$@"exceptions when pushing at {_location} of branch_ {bakBranch}:(
									{nilnul.txt.accumulate_.join_.DuoLineBreak.Singleton.accumulate(
										resultsErr.Select(r => $@"{r.Key}:{r.Value}:{ nilnul.fs.git.repo._push.ExitCodeX.Explain(r.Value)}")
									)}
								)"
							);
						}
					}
					if (resultsSuccess.Any())
					{
						Trace.TraceInformation(
							$@"success in pushing at {_location} of branch_ {bakBranch}:(
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
			}
			catch (OperationCanceledException ex)
			{
				noError = false;

				///todo uncomment this one will make the button remain disabled after being cancelled.
				throw;
			}
			catch (Exception e)
			{
				noError = false;
				Trace.TraceError(
					$"{typeof(_BakX)}.{nameof(_Succed)}({_location}):{e} "
				);

				///todo uncomment this one will make the button remain disabled after being cancelled.
				//throw;
			}
			//if (noError)
			//{

			//	//nilnul.dev.srcs.bak_._retVoid.SettingX.modulesNewlyBaked.Add(_location);

			//}
			return noError;


		}



		public static bool _Succed(fs.FolderI _module, ConcurrentBag<DivI> innerModules, CancellationToken cancel, string bakBranch, nilnul.win.prog_.Git git = null)
		{
			return _Succed(_module.ToString(), /*innerModules, */cancel, bakBranch, git);
			//throw new NotImplementedException();
		}




	}
}
