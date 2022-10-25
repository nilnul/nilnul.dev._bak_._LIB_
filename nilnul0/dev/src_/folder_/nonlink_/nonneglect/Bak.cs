using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder_.nonlink_.nonneglect
{
	public  class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
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
					new nonlink_.nonneg_.git_.nonRepo.Bak(cfg).Exe(folder);

					break;
				case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
					//Trace.TraceWarning($"src {folder} shall not be a git workspace; it shall be a plain folder");
					new nonlink_.nonneg_.git_.nonRepo.Bak(cfg).Exe(folder);

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
