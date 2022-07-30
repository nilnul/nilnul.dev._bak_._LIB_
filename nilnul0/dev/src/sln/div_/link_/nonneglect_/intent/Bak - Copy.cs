using nilnul.fs._address;
using nilnul.fs.folder;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src.sln.div_.link_.nonneglect_.intent
{
	/// <summary>
	/// gien srcs, bak a disjoint addresses.
	/// </summary>
	public  class Bak_srcsInAddress
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

		public Bak_srcsInAddress(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Bak_srcsInAddress(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Bak_srcsInAddress(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Bak_srcsInAddress(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void Exe(
			string shield
		)
		{
			var old = _cfg._addDestiny_addressAssumeLink(shield);
			if (old.Key is null)
			{
				///unjoint
				///

				new div_.unjoint_.nonneglect_.intent.Bak_srcsInAddress(cfg,innerModules,innerModules2reinclude,module) {  }.Exe(shield);

			}
			else
			{
				Trace.TraceWarning(
					$"{shield} is already processed by {old.Key}, which is linked by {old.Value}"
				);

			}

			

		}
	}
}