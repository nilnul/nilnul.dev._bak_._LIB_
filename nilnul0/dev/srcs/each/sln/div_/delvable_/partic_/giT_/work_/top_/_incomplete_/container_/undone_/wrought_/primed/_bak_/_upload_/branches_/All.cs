using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload_.branches_
{
	/// <summary>
	/// </summary>
	public static class _AllX
	{
		/// <summary>
		/// use stash
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static bool _NoErr(
			string _location
						,
			IEnumerable<string> clients
			,
			CancellationToken cancel

			,
			nilnul.win.prog_.Git git = null)
		{

			bool noError = true;

			fs.git.Module module = nilnul.fs.git.Module.FroAddress(_location);

			Trace.TraceInformation($"{nilnul.app._TraceX.Txt()}@{_location} ...");
			try
			{

				IEnumerable<string> remotes = nilnul.fs.git.module.repo._cfg_.remotes_.dev_.baK._VwX.Name0nuls_moduleOfAddress(
				_location
				,
clients
			);

				if (remotes.Count() == 0)
				{
					Trace.TraceError(
						$"no remote with auto sync set found at {_location}"
					);
					return false;
				}

				var latestRemotes = remotes.Where(x => x != null);// 

				//then push all branches
				Trace.TraceInformation($"pusing all branches for { _location}");

				try
				{
					var pushAllResults = new Dictionary<string, int>();

					foreach (var remote in latestRemotes)
					{
						cancel.ThrowIfCancellationRequested();
						pushAllResults.Add(
							remote
							,
							nilnul.fs.git.module.repo.push_.remote.branches_.all.exitCode_._UiTitledX.Exe(
								module.ToString()
								, remote.ToString()
								, git
							)
						);
					}

					IEnumerable<KeyValuePair<string, int>> resultsErr = pushAllResults.Where(x => x.Value != 0);
					IEnumerable<KeyValuePair<string, int>> resultsSuccess = pushAllResults.Where(x => x.Value == 0);

					if (resultsErr.Any())
					{
						if (
							resultsSuccess.Count() < nilnul.dev.bak.Properties.Settings.Default.pushErrsAsWarningIfSuccessesGe
						)
						{
							Trace.TraceError(
								$@"exceptions when pushing all at {module} :(
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
								$@"exceptions when pushing all at {module} :(
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
							$@"success in pushing at {module} of all branches:(
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
					Trace.TraceError($"when pushing all branches for {_location} as workroot inside sln by sync with remote: " + e.Message);

				}




			}
			catch (OperationCanceledException ex)
			{
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

		public static bool _NoErr(
			fs.FolderI _module
									,
			IEnumerable<string> clients
			,
			CancellationToken cancel
			, nilnul.win.prog_.Git git = null)
		{
			return _NoErr(
				_module.ToString(),clients, cancel, git
			);
		}




	}
}
