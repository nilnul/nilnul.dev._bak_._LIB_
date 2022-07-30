using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought_.primed_.stageDirty._bak_._upload_.branch_._shelf.put
{
	/// <summary>
	/// if the last two bakBranches are same in contents, delete the last one, 
	/// </summary>
	public static class _BranchOfNewContentX
	{
		/// <summary>
		/// </summary>
		/// <param name="_location"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>the branch of the latest content.</returns>

		public static string _Branch(
			string _location
			
			//,
			// ConcurrentBag<DivI> innerModules
			,
			CancellationToken cancel
			, out bool newlyCreated  

			,
			nilnul.win.prog_.Git git = null)
		{
			var branch=_PutX._Branch(_location,  cancel, git);

			var newBranch= _branchWithContent._BranchOfNewContentX._Succeed(_location, branch, git);
			newlyCreated = (branch == newBranch);
			return newBranch;
		}

		public static string _Branch(
			fs.FolderI _module
			//,
			// ConcurrentBag<DivI> innerModules
			,
			CancellationToken cancel
						, out bool newlyCreated

			, nilnul.win.prog_.Git git = null
		)
		{
			return _Branch(_module.ToString(), /*innerModules,*/ cancel,out newlyCreated, git);
		}
	}
}
