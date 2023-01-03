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
		//public const int MILLISECONDS4PAUSE = 10 * 1000;

		/// <summary>
		/// use stash
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>

		public static string _Branch(
			string _location
			,
			string shelfTip
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


				//

				nilnul.os.prog_.git.run_.exit_.onDue.result._Vow_codOkX.OfAddress(
					_location, $"checkout --orphan {snapBranch}", git
				);        //if the worktree is to be overridden by the checked-out files, an error will be thrown.
						  //// todo: "checkout -b" means if large files are commited in somewhere in the history, that file won't be bunced by server quota; consider using "checkout --orphan" in addtion to this to keep the current snapshot without history;

			}
			catch (Exception x)
			{

				throw new Exception($"exception {x} when: checkout -orphan {snapBranch} and reset @ {_location}", x);
			}
			try
			{
				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(
					_location, $"reset", git
				); // 

			}
			catch (Exception)
			{
				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);

				throw;
			}



			Trace.TraceInformation($"committing worksite for {_location}");


			Trace.TraceInformation($"adding and committing all changes at {_location}");

			try
			{


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
				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(_location, $"reset {shelfTip}~", git);

				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);


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

				nilnul.win.prog_.git.run.exitCode.vow_._NilX.OfAddress(_location, $"checkout -b {tempBranch}", $"exception when checkout -b {tempBranch} @{_location}", git);

			}
			catch (Exception)
			{
				nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(_location, $"reset {shelfTip}~", git);

				fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);
				throw;
			}


			Trace.TraceInformation($"created temp branch{tempBranch}  @ {_location}");
			Trace.TraceInformation($"backtracking head  @ {_location}");


			//change the index


			nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(_location, $"reset {shelfTip}~", git);


			Trace.TraceInformation($"backtracked  @ {_location}");

			Trace.TraceInformation($"setting head to original  @ {_location}");


			fs.git.module.head.set_._ReferenceX.Exe(module, _oldHead);
			/// note the references may be nonbranch, and it might contains some parts (separated by slash) prepended to branch name 
			//nilnul.os.prog_.git.run_.exit.cod.vow_._NilX._Vod_ofAddress_ofArg(_location, $"reset --soft {_oldHead}", git);



			Trace.TraceInformation($"setted head to original  @ {_location}");
			Trace.TraceInformation($"removing tmp branch  @ {_location}");


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


		public static string _Branch(fs.FolderI _module, string shelfTip, /*ConcurrentBag<DivI> innerModules,*/ CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			return _Branch(_module.ToString(), shelfTip,/* innerModules, */cancel, git);
			//throw new NotImplementedException();
		}




	}
}
