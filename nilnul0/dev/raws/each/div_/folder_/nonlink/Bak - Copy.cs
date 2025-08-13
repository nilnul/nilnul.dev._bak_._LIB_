using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src.div_.folder_.nonlink
{
	/// <summary>
	/// the processed is:
	///		a folder
	///		nonlink: not a link itself; any of the ancestor is nonlink
	/// </summary>
	public  class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)//:this(cfg,new ConcurrentBag<fs._address.DivI>())
		{
			_cfg = cfg;
		}
//		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg,         
//			ConcurrentBag<nilnul.fs._address.DivI> innerModules
//)
//		{
//			_cfg = cfg;
//			this.innerModules = innerModules;
//		}


		public  void exe(
			nilnul.fs.folder_.Normal _div_inSrc
		)
		{
			if (nilnul.fs.folder.be_.deV_.baK_.nonpart.Anto.Be(_div_inSrc))
			{
				new folder_.nonlink_.nonneglect.Bak(cfg).exe(_div_inSrc);
			}
			else
			{
				Trace.TraceWarning($"{_div_inSrc} is configured to neglect (we may bak it later if a date is specified).");
			}

		}

		public  void Exe(
			nilnul.fs.address_.ShieldI _shield
		)
		{
			exe(
						  new nilnul.fs.folder_.Normal(
						   _shield
						   )
			);
		}
	}
}
