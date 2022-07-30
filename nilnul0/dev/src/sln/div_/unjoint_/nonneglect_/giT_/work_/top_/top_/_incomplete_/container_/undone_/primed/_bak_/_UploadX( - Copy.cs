using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.div_.nonneglect_.unjoint_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_
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
			//string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul._dev_._bak_._LIB_.Properties.Settings.Default.branchBak);
			string bakBranch;// = bakVeredKey + timestamp;
			bool newlyCreatedBak;

			try
			{
				bakBranch = _bak_._upload_.branch_._bak.put._BranchOfNewContentX._Branch(
				   _location, /*innerModules,*/ cancel, out newlyCreatedBak, git
			   );

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
					$"{nilnul.app._TraceX.Txt()}@{_location}:{e.ToString()}"
				);
				return noError;
				//throw;
			}

			try
			{
				if (newlyCreatedBak)
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
						 git = null
					);

					if (!bakBranchSuccess)
					{
						noError = false;
					}
					#endregion

					if (!_upload_.branch_._AllX._NoErr(_location, cancel, git))
					{
						noError = false;
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



		public static bool _SyncThis(fs.FolderI _module, ConcurrentBag<DivI> innerModules, CancellationToken cancel, nilnul.win.prog_.Git git = null)
		{
			return _Void(_module.ToString(), /*innerModules,*/ cancel, git);
			//throw new NotImplementedException();
		}




	}
}
