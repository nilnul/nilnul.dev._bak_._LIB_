using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder_.nonlink
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

		public void Exe(
			nilnul.fs.FolderI folder
		)
		{
			if (nilnul.fs.folder.be_.deV_.baK_.nonpart.Anto.Be(folder))
			{
				new folder_.nonlink_.nonneglect.Bak(cfg).exe(folder);
			}
			else
			{
				Trace.TraceWarning($"{folder} is configured to bak later.");
			}

			

		}


		public  void Exe(
			string folder
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder) );
		}

		

	}

}
