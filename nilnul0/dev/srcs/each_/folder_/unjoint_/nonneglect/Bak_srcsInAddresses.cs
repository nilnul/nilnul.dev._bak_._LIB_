using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder_.unjoint_.nonneglect
{
	/// <summary>
	/// concerning link(symlink) destiny:
	///		* srcs are already checked such that the eventual targets are disjoint
	///		* each div, and div.dir, is checked on the fly such as to be unjoint  with any srcs.
	/// </summary>
	/// <remarks>
	/// alias:
	///		unjoint
	///		unjointAlreadyEnsured
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.dev.srcs.each.div_.delvable_.dispat_.partic.Bak))]
	public  class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public void exe(
			nilnul.fs.FolderI folder
		)
		{

			switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category(folder))
			{
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:

					//Trace.TraceWarning($"src {folder} shall not be a git workspace; it shall be a plain folder");
					new nilnul.dev.srcs.each.div_.delvable_.dispat_.partic_.giT_.nonrepo.Bak_srcsInAddresses(cfg) {
						src=folder.address.en
						,
						div= new fs._address.Div()
						,
						cognom= new string[0]
					}.vod(
						//folder
					);

					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
					Trace.TraceError($"src {folder} shall not be a repo (such as .git in name)");
					break;
				default:
					break;
			}

		}


		public  void exe(
			string folder
		)
		{
			exe(nilnul.fs.Folder.FroAddress(folder) );
		}

		

	}

}
