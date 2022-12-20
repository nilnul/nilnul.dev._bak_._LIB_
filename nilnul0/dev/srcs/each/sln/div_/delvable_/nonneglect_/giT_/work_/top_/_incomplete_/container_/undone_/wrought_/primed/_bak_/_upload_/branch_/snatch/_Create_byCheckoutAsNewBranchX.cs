using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.wrought_.primed._bak_.branch_.snap
{
	/// <summary>
	/// add a new separate (disjoint with current DacS) <see cref="nilnul.rel_.net_.IDac"/>
	/// </summary>
	/// <seealso cref="nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload_.branch_._shelf._PutX"/>
	///
	/// consider using git switch
	public static class _Create_byCheckoutAsNewBranchX
	{
		public const int MILLISECONDS4PAUSE = 10 * 1000;

		/// <summary>
		/// use stash
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static string _Branch(
			string _location
			//,
			// ConcurrentBag<DivI> innerModules
			,
			CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null
		)
		{

			/// todo: utilizing stash to create the worksiet commit and bakbranch.

			fs.git.Module module = nilnul.fs.git.Module.FroAddress(_location);

			Trace.TraceInformation($"syncing {_location} ...");

			string timestamp = nilnul.time_.datetime.phrase_.Full.Singleton.phrase();
			string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul.dev.bak.Properties.Settings.Default.branchBak);
			string snapBranch = $"{bakVeredKey}_{"snap"}{timestamp}";


			string _oldHead = fs.git.module.repo.head._VwX.Txt(module, git);
			Trace.TraceInformation($"oldHead:{_oldHead} of {_location}");
			Trace.TraceInformation($"switching to branch {snapBranch}  for {_location}");


			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"checkout -b {bakBranch}", $"exception when: checkout -b {bakBranch} @ {_location}", git);

			/// todo: consider using "git stash"; 
			/// simulate git stash; we don't use git Stash as it errors if what to stash is empty.
			try
			{
				//fs.git.module.head.set_.ref_._BranchX.Exe(module, bakBranch,git);


				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();

				nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX.OfAddress(
					_location, $"checkout --orphan {snapBranch}", git
				);        //if the worktree is to be overridden by the checked-out files, an error will be thrown.
						  //// todo: "checkout -b" means if large files are commited in somewhere in the history, that file won't be bunced by server quota; consider using "checkout --orphan" in addtion to this to keep the current snapshot without history;

			}
			catch (Exception x)
			{

				throw new Exception($"exception {x} when: checkout -b {snapBranch} @ {_location}", x);
			}

			Trace.TraceInformation($"committing worksite for {_location}");

			try
			{
				//;// avoid the lock of files in .git such as head.lock or index.lock
				//nilnul.fs.git.module.exe_._TilUnlockX._TilUnlock_ofTopAddress(_location, git);

				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
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

				//;// avoid the lock of files in .git such as head.lock or index.lock
				//nilnul.fs.git.module.exe_._TilUnlockX._TilUnlock_ofTopAddress(_location, git);

				//await Task.Delay(5000);
				///todo: seemingly stalled here once
				///

				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);
				Trace.TraceInformation($"setted head to original @ {_location}");

				throw;
			}


			Trace.TraceInformation($"adding and committing all changes at {_location}");

			try
			{
				//// avoid the lock of files in .git such as head.lock or index.lock
				//nilnul.fs.git.module.exe_._TilUnlockX._TilUnlock_ofTopAddress(_location, git);

				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
				new nilnul.obj.vow_.true_.xpn_.Unacceptable(
					$"exception when further adding all and commiting for {_location}"
				).vow(
					nilnul.fs.git.module.index.add_.all_.minWinTitled.commit_.allowEmpty_._MinWinTitledX.CommitExitCode_AddAndCommit(_location, $"add and commit all for backup", git) == 0
				);


			}
			catch (Exception e)
			{
				Trace.TraceError($" when commiting all for stashing for {_location}:{e}");

				Trace.TraceInformation($"setting head to original @ {_location}");


				//try
				//{

				//}
				//catch (Exception)
				//{
				//	Trace.TraceError($"git rest  @ {_location} when resetting ");

				//	throw;
				//}
				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();

				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);

				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
				nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, "reset", git);

				Trace.TraceInformation($"setted head to original   @ {_location}");
				throw;
			}

			Trace.TraceInformation($"added and committing all changes at {_location}");

			///create temp branch to backoff
			///
			string tempBranch = nilnul.dev.bak.Properties.Settings.Default.branchTmp
				+
				timestamp;
			//nilnul.txt_._GuidX.Construct_noHyphen(Guid.NewGuid());

			Trace.TraceInformation($"creating temp branch:{tempBranch} @ {_location}");

			//// avoid the lock of files in .git such as head.lock or index.lock

			try
			{
				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
				nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"checkout -b {tempBranch}", $"exception when checkout -b {tempBranch} @{_location}", git);

			}
			catch (Exception)
			{
				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);
				throw;
			}


			Trace.TraceInformation($"created temp branch{tempBranch}  @ {_location}");
			Trace.TraceInformation($"backtracking head  @ {_location}");

			//// avoid the lock of files in .git such as head.lock or index.lock

			//change the index
			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, "reset HEAD~", git);
			nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX.OfAddress(_location, "reset HEAD~", git);

			Trace.TraceInformation($"backtracked  @ {_location}");

			Trace.TraceInformation($"setting head to original  @ {_location}");

			nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
			fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);

			Trace.TraceInformation($"setted head to original  @ {_location}");
			Trace.TraceInformation($"removing tmp branch  @ {_location}");

			//nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);

			nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(_location).Wait();
			nilnul.win.prog_.git.run_.ui.exitCode.vow_._NilX.OfAddress(_location, $"branch -D {tempBranch}", git);
			Trace.TraceInformation($"removed tmp branch  @ {_location}");

			//todo: find any previous branch is the same as this new one



			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelled after adding/committing all at {_location}");
				cancel.ThrowIfCancellationRequested();
				//Settings.Default.doneAt = _location;
				//return false;
			}


			return snapBranch;


		}


		public static string _Branch(fs.FolderI _module, /*ConcurrentBag<DivI> innerModules,*/ CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			return _Branch(_module.ToString(),/* innerModules, */cancel, git);
			//throw new NotImplementedException();
		}




	}
}
