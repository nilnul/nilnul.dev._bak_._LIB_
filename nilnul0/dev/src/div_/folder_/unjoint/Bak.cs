using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.fs.addresses_._disjoint.member_.inSrc_.folder.div_.folder_.unjoint
{
	/// <summary>
	/// called by <see cref="nameof(nilnul.dev.src.div_.folder.Bak)"/>.
	///		from this on, we no longer need to look about the progenitors, thus we can look about the child only
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)//:this(cfg,new ConcurrentBag<fs._address.DivI>())
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
			nilnul.fs.address_.ShieldI _div_inSrc
		)
		{

			if (nilnul.fs.folder.be_.deV_.src_.bak_.neglect.Anto.Be(_div_inSrc))
			{
				new folder_.unjoint_.nonneglect.Bak_srcsInAddresses(cfg).exe(_div_inSrc);
			}
			else
			{
				Trace.TraceWarning($"{_div_inSrc} is configured to neglect (we may bak it later if a date is specified).");
			}

			
		}
	}
}
