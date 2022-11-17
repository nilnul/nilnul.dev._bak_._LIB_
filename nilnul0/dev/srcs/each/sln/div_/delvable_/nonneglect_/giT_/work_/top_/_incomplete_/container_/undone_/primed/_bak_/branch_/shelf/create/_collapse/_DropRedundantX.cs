using System.Diagnostics;

namespace nilnul.srcs.each.sln.div_.delvable_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed._bak_.branch_.shelf.create._collapse
{
	/// <summary>
	/// if the last two bakBranches are same in contents, delete the last one, 
	/// </summary>
	public static class _DropRedundantX
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


			

			txt_.Vered prevNulable = nilnul.fs.git.module.repo.branch_.vered_.key.delNewIfSame._RetPrevIfDelElseNulX.PrevNulabe_ofModuleAddress(
				_location
				,
				bakVeredKey
				, git
			);

			if (prevNulable != null)
			{
				newBakBranch = prevNulable;
				Trace.TraceWarning($"{typeof(_DropRedundantX).FullName}.{nameof(_Succed)}({_location}): bakBranch changed to {prevNulable}");
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
