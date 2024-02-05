using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder_.nonlink_.nonneglect
{
	/// <summary>
	/// concerning link(symlink) destiny:
	///		* srcs are already checked that the eventual targets are disjoint
	///		* each div, and div.dir, is checked on the fly such as to be unjoint  with any srcs.
	/// </summary>
	///
	[Obsolete(nameof(dev.src.div_.folder_.unjoint_.nonneglect_.giT_.nonrepo.IBak))]
	public  class Bak_srcsAsAddresses
		:
		dev.src.div_.folder_.unjoint_.nonneglect_.giT_.nonrepo.IBak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak_srcsAsAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
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
					new nilnul.dev.src_.folder_.nonlink_.nonneglect_.giT_.nonrepo.Bak_srcsInAddresses(cfg).Exe(folder);

					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					//Trace.TraceWarning($"src {folder} shall not be a git workspace; it shall be a plain folder");
					new nilnul.dev.src_.folder_.nonlink_.nonneglect_.giT_.nonrepo.Bak_srcsInAddresses(cfg).Exe(folder);

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
