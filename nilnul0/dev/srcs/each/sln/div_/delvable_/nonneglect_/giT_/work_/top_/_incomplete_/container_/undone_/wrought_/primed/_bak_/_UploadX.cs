using nilnul.fs._address;
using NuGet.Packaging.Signing;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_
{
	/// <summary>
	/// for unprimed module, we need to deal with the workspace.
	/// for primed module, we need only be concerned about the repo.
	/// So this is in fact a repo.
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
			//,
			// ConcurrentBag<DivI> innerModules
			,
			IEnumerable<string> nom2normlS
			,
			CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null
		)
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

			//string timestamp = nilnul.time_.datetime.phrase_.Full.Singleton.phrase();
			//string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul.dev.bak.Properties.Settings.Default.branchBak);
			string bakBranch;// = bakVeredKey + timestamp;
			string snapBranch;
			bool newlyCreatedBak;
			bool newlyCreatedSnap;
			cancel.ThrowIfCancellationRequested();
			string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul.dev.bak.Properties.Settings.Default.branchBak);

			try
			{


				bakBranch =
					nilnul.fs.git.module.stow._CreateX._Branch_addressAssumeModule_assumeNub(
						_location, bakVeredKey,  git
				);




				//nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_.branch_.shelf.create._CollapseX._Branch

				////_upload_.branch_._shelf.put._BranchOfNewContentX._Branch
				//(
				//  _location, /*innerModules,*/ cancel, out newlyCreatedBak, git
				// );



				var ver = nilnul.txt_.vered._VerX.Txt(bakBranch);
				var time = nilnul.time_.datetime.phrase_.Full.Singleton.parse(ver);
				var sinceNow = time - DateTime.UtcNow;
				if (sinceNow < -TimeSpan.FromDays(30 * 9))
				{
					Trace.TraceWarning($"{_location} is untouched since {time}");
				}
			}
			catch (Exception e)
			{
				noError = false;
				Trace.TraceError(
					$"when creating stow branch on basis of current snapshot: {nilnul.app._TraceX.Txt()}@{_location}:{e.ToString()}"
				);
				return noError;
				//throw;
			}
			#region snap branch
			cancel.ThrowIfCancellationRequested();
			try
			{

				string snapKey = $"{bakVeredKey}_{"snap"}";


				/// todo: when creating orphan branch, we need to later reset the current branch, and the stage; (the work would be unchanged all the time); Thus, we need not to reset in previous operation where we create the bakBranch.

				/// exception if bak branch has no previous history, as we need to take a step back during the process to restore index;
				snapBranch = nilnul.fs.git.module.work.commit_.orphan._CollapseX._Branch_addressAssumeModule_assumeShelfNub(_location, bakBranch, snapKey, out newlyCreatedSnap, git);

				/// now we remove the bakBranch:
				///
				var newBakBranch = fs.git.depo.repo.branch_.vered_.nob_.newest_.noncurrent.retract_._ToNonOrphanX._Regress_0moduleAddress_1branchNewestNoncurrent(_location, bakBranch, git);
				newlyCreatedBak = (bakBranch == newBakBranch); //if Branch is the new, not a previous one
				bakBranch = newBakBranch;

				//nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.wrought_.primed._bak_.branch_.snap.create._CollapseX._Branch

				////_upload_.branch_._shelf.put._BranchOfNewContentX._Branch
				//(
				//  _location,bakBranch, /*innerModules,*/ cancel, out newlyCreatedSnap, git
				// );



				//var ver = nilnul.txt_.vered._VerX.Txt(snapBranch);
				//var time = nilnul.time_.datetime.phrase_.Full.Singleton.parse(ver);
				//var sinceNow = time - DateTime.UtcNow;
				//if (sinceNow < -TimeSpan.FromDays(30 * 9))
				//{
				//	Trace.TraceWarning($"{_location} is untouched since {time}");
				//}
			}
			catch (Exception e)
			{
				noError = false;
				Trace.TraceError(
					$"{nilnul.app._TraceX.Txt()}@{_location}:{e.ToString()} when creating snap branch;"
				);
				return noError;
				//throw;
			}


			#endregion


			try
			{
				cancel.ThrowIfCancellationRequested();

				if (
					nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.wrought_.primed._bak_._upload.SettingsX.Default.push4nonchange
					/// even if there are no change since last bak commit, we still push it. Useful when we havenot resolved all the errors for last bak.
					||
					newlyCreatedSnap
				)
				{

					#region pushup the snapBranch.

					var snapBranchSuccess = _upload_.branch_._BakX._Succed(
						 _location
						//,
						// innerModules
						,
						 cancel
						 ,
						 snapBranch
						 ,
						 nom2normlS
						,
						 git = null
					);

					if (!snapBranchSuccess)
					{
						if (noError != false)
						{
							noError = false;
						}
					}
					#endregion
				} // or else it means we failed to create new branch. and that means all the work has been saved in the last bak branch, which shall have already been bakked (possible with err, but err is traced and handled).

				cancel.ThrowIfCancellationRequested();


				if (
					nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.wrought_.primed._bak_._upload.SettingsX.Default.push4nonchange
					/// even if there are no change since last bak commit, we still push it. Useful when we havenot resolved all the errors for last bak.
					||
					newlyCreatedBak
				)
				{
					#region pushup the bakBranch.
					var bakBranchSuccess = _upload_.branch_._BakX._Succed(
						 _location
						//,
						// innerModules
						,
						 cancel
						 ,
						 bakBranch
						 ,
						 nom2normlS
						,
						 git = null
					);

					if (!bakBranchSuccess)
					{
						if (noError != false)
						{
							noError = false;
						}
					}
					#endregion
				}

				cancel.ThrowIfCancellationRequested();
				if (
	nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.wrought_.primed._bak_._upload.SettingsX.Default.push4nonchange
/// even if there are no change since last bak commit, we still push it. Useful when we havenot resolved all the errors for last bak.
)
				{

					if (!_upload_.branches_._AllX._NoErr(_location, nom2normlS, cancel, git))
					{
						if (noError != false)
						{
							noError = false;
						}
					}
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


				// suppress the throw such that exception is not propaganted so as other modules can be processed.
				//throw; 
			}
			//if (noError)
			//{

			//	//nilnul.dev.srcs.bak_._retVoid.SettingX.modulesNewlyBaked.Add(_location);

			//}
			return noError;


		}



		public static bool _SyncThis(fs.FolderI _module,
			IEnumerable<string> nom2normlS
  ,

			CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			return _Void(
				_module.ToString()
				,
				/*innerModules,*/ nom2normlS
				,
				cancel
				,
				git
			);
			//throw new NotImplementedException();
		}




	}
}
