using System.Diagnostics;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_._upload_.branch_._shelf.put._branchWithContent
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
		public static string _Succeed(
			string _location
			,
			string newBakBranch
			,
			nilnul.win.prog_.Git git = null)
		{
			//string bakBranch=null;
			string bakVeredKey = nilnul.txt_.vered._KeyX._Txt(nilnul.dev.bak.Properties.Settings.Default.branchBak);


			/// todo: exclude any document if the size of it exceeds svrRepoDocument size limit.

			txt_.Vered prevNulable = nilnul.fs.git.module.repo.branch_.vered_.key.delNewIfSame._RetPrevIfDelElseNulX.PrevNulabe_ofModuleAddress(
				_location
				,
				bakVeredKey
				, git
			);

			if (prevNulable != null)
			{
				newBakBranch = prevNulable;
				Trace.TraceWarning($"{typeof(_BranchOfNewContentX).FullName}.{nameof(_Succed)}({_location}): bakBranch changed to {prevNulable}");
			}
			return newBakBranch;
		}

		public static string _Succed(
			fs.FolderI _module
			,
			string bakBranch
			, nilnul.win.prog_.Git git = null
		)
		{
			return _Succeed(_module.ToString(), bakBranch, git);
		}
	}
}
