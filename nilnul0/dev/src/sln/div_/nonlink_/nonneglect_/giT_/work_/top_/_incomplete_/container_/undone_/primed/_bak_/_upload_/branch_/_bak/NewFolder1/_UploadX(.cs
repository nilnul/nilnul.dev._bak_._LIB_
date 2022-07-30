using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload_.branch_._bak
{
	/// <summary>
	/// before pushing the branch of "bak...", 
	/// </summary>
	public static class _UploadX
	{
		/// <summary>
		/// use stash
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static bool _Void(
			string _location
			,
			 ConcurrentBag<DivI> innerModules
			,
			CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null)
		{
			//if (nilnul.dev.srcs.bak_._retVoid.SettingX.IsModuleBaked(_location))
			//{
			//	Trace.TraceInformation($"{_location} already baked.");

			//}

			bool noError = true;
			fs.git.Module module = nilnul.fs.git.Module.FroAddress(_location);

			Trace.TraceInformation($"syncing {_location} ...");

			//string name = nilnul.fs.folder.repoName_.ThrowIfNotInSrc.Singleton.getName_ofAddress(_location);

			//nilnul.txts.accumulate_.DuoLineBreak.Singleton.accumulate(
			//	nilnul.fs.git.module.repo._cfg_.remotes_.bak_.vsAwGlBb._EnsureX.Txts(_location, name)
			//);

			string timestamp = nilnul.time_.datetime.phrase_.Full.Singleton.phrase();
			string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul._dev_._bak_._LIB_.Properties.Settings.Default.branchBak);
			string bakBranch = bakVeredKey + timestamp;

			/*
			 branch <branchname> [<stash>]
Creates and checks out a new branch named <branchname> starting from the commit at which the <stash> was originally created, applies the changes recorded in <stash> to the new working tree and index. If that succeeds, and <stash> is a reference of the form stash@{<revision>}, it then drops the <stash>. When no <stash> is given, applies the latest one.

This is useful if the branch on which you ran git stash push has changed enough that git stash apply fails due to conflicts. Since the stash entry is applied on top of the commit that was HEAD at the time git stash was run, it restores the originally stashed state with no conflicts.
			 */

			string _oldHead = fs.git.module.repo.head._VwX.Txt(module, git);
			Trace.TraceInformation($"oldHead:{_oldHead} of {_location}");
			Trace.TraceInformation($"switching to branch {bakBranch}  for { _location}");

			try
			{
				nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"checkout -b {bakBranch}",  $"exception when: checkout -b {bakBranch} @ {_location}",git);

				Trace.TraceInformation($"committing worksite for { _location}");

				try
				{
					//System.Threading.Thread.Sleep(5000);// avoid the lock of files in .git such as head.lock or index.lock
					//nilnul.fs.git.module.exe_._TilUnlockX._TilUnlock_ofTopAddress(_location, git);

					int exitCode = nilnul.fs.git.module.index.commit_.allowEmpty_._MinUiTitledX.ExitCode(
						_location
						,
						"commit workspace index for possibly restoring work site later"
						,
						git
					);

					new nilnul.obj.vow_.true_.xpn_.Unacceptable($"exception (exitCode:{exitCode}) When commiting worksite index/stage for {_location}: the exception is shown on the popped console, repeat the operation in git bash to repro").vow(
						exitCode
						==
						0
					);
				}
				catch (Exception ex)
				{
					Trace.TraceError($" when commiting worksite for {_location}:{ex}");
					Trace.TraceInformation($"setting head to original @ {_location}");

					/*System.Threading.Thread.Sleep(5000)*/;// avoid the lock of files in .git such as head.lock or index.lock
					//nilnul.fs.git.module.exe_._TilUnlockX._TilUnlock_ofTopAddress(_location, git);

					//await Task.Delay(5000);
					///todo: seemingly stalled here once
					fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);
					Trace.TraceInformation($"setted head to original @ {_location}");

					throw;
				}


				Trace.TraceInformation($"adding and committing all changes at { _location}");

				try
				{
					//System.Threading.Thread.Sleep(5000);// avoid the lock of files in .git such as head.lock or index.lock
					//nilnul.fs.git.module.exe_._TilUnlockX._TilUnlock_ofTopAddress(_location, git);

					new nilnul.obj.vow_.true_.xpn_.Unacceptable(
						$"exception when further adding all and commiting for {_location}"
					).vow(
						nilnul.fs.git.module.index.add_.allBut_.minWinTitled.commit_.allowEmpty_._MinWinTitledX.CommitExitCode_AddAndCommit(_location, innerModules, $"add and commit all for backup", git) == 0
					);


				}
				catch (Exception e)
				{
					Trace.TraceError($" when commiting all for stashing for {_location}:{e}");

					Trace.TraceInformation($"setting head to original @ {_location}");

					//System.Threading.Thread.Sleep(5000);// avoid the lock of files in .git such as head.lock or index.lock
					//nilnul.fs.git.module.exe_._TilUnlockX._TilUnlock_ofTopAddress(_location, git);


					fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);
					Trace.TraceInformation($"setted head to original   @ {_location}");
					throw;
				}

				Trace.TraceInformation($"added and committing all changes at { _location}");

				///create temp branch to backoff
				///
				string tempBranch = nilnul._dev_._bak_._LIB_.Properties.Settings.Default.branchTmp
					+
					timestamp;
				//nilnul.txt_._GuidX.Construct_noHyphen(Guid.NewGuid());

				Trace.TraceInformation($"creating temp branch:{tempBranch} @ {_location}");

				//System.Threading.Thread.Sleep(5000);// avoid the lock of files in .git such as head.lock or index.lock

				nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"checkout -b {tempBranch}", $"exception when checkout -b {tempBranch} @{_location}",git);
				Trace.TraceInformation($"created temp branch{tempBranch}  @ {_location}");

				Trace.TraceInformation($"backtracking head  @ {_location}");

				//System.Threading.Thread.Sleep(5000);// avoid the lock of files in .git such as head.lock or index.lock

				//change the index
				//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, "reset HEAD~", git);
				nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, "reset HEAD~", git);
				Trace.TraceInformation($"backtracked  @ {_location}");

				Trace.TraceInformation($"setting head to original  @ {_location}");

				//System.Threading.Thread.Sleep(5000);// avoid the lock of files in .git such as head.lock or index.lock

				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);

				Trace.TraceInformation($"setted head to original  @ {_location}");
				Trace.TraceInformation($"removing tmp branch  @ {_location}");

				//System.Threading.Thread.Sleep(5000);// avoid the lock of files in .git such as head.lock or index.lock
				//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);
				nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);
				Trace.TraceInformation($"removed tmp branch  @ {_location}");

				//todo: find any previous branch is the same as this new one





				if (cancel.IsCancellationRequested)
				{
					Trace.TraceWarning($"cancelled after adding/committing all at { _location}");
					cancel.ThrowIfCancellationRequested();
					//Settings.Default.doneAt = _location;
					return false;
				}

				#region pushup the bakBranch.

				txt_.Vered prevNulable = nilnul.fs.git.module.repo.branch_.vered_.key.delNewIfSame._RetPrevIfDelElseNulX.PrevNulabe_ofModuleAddress(
					_location
					,
					bakVeredKey
					, git

				);

				if (prevNulable != null)
				{
					bakBranch = prevNulable;
					Trace.TraceWarning($"{typeof(_UploadX).FullName}.{nameof(_Void)}({_location}): bakBranch changed to {prevNulable}");
				}


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


				if (!_upload_.branch_._AllX._NoErr(_location, cancel, git))
				{
					noError = false;
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
					$"{typeof(_UploadX)}.{nameof(_Void)}({_location}):{e} "
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



		public static bool _SyncThis(fs.FolderI _module, ConcurrentBag<DivI> innerModules, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			return _Void(_module.ToString(), innerModules, cancel, git);
			//throw new NotImplementedException();
		}




	}
}
