using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder.div_.unjoint
{
	/// <summary>
	/// called by <see cref="nameof(nilnul.dev.src.div_.folder.Bak)"/>.
	///		from this on, we no longer need to look about the progenitors, thus we can look about the child only
	/// </summary>
	///
	[Obsolete("commented src.dir is not considered", true)]
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		private nilnul.fs.address_.ShieldI _module;
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		/// <summary>
		/// <see cref="nameof( nilnul.fs.addresses_._disjoint.member_.inSrc_.folder.div_.folder_.unjoint.Bak_srcsInAddresses)"/>
		/// </summary>
		/// <param name="_div_inSrc"></param>
		public void exe(
			nilnul.fs.address_.ShieldI _div_inSrc
		)
		{

			if (nilnul.fs.folder.be_.deV_.baK_.nonpart.Anto.Be(_div_inSrc))
			{
				new unjoint_.nonneglect.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).exe(_div_inSrc);
			}
			else
			{
				Trace.TraceWarning($"{_div_inSrc} is configured to neglect (we may bak it later if a date is specified).");
			}

			
		}
	}
}
