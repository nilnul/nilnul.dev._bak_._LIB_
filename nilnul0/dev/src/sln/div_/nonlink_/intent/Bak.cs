using nilnul.fs;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.intent
{
	/// <summary>
	/// </summary>
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


		public void __Exe(
			string folder
		)
		{
			if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(folder,cfg.git))
			{
				Trace.TraceWarning( $"{folder} is ignored");
			}
			else
			{
				new intent_.nonneglect.Bak(cfg).__Exe(folder);
			}
		}

		public  void _Exe(FolderI folder)
		{
			__Exe(folder.ToString());
		}
	}
}