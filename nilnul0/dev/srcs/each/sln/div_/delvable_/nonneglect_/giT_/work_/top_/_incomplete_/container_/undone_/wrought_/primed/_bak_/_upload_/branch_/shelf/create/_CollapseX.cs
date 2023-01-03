using nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_.branch_._shelf;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_.branch_.shelf.create
{
	/// <summary>
	/// if the last two bakBranches are same in contents, delete the last one, 
	/// </summary>
	///
	[Obsolete(nameof(nilnul.fs.git.module.stow.create._CollapseX))]

	public static class _CollapseX
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
			

			///create the bak branch; and also reset the head; soe here, the bak branch is not the default branch, and thus can be force dropped;
			var branch=_Create_byCheckoutAsNewBranchX._Branch(_location,  cancel, git);



			
			var newBranch= _collapse._DropRedundantX._Succeed(_location, branch, git);
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
