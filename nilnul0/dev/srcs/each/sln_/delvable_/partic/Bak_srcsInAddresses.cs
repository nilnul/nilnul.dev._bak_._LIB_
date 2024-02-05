using nilnul.fs;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln_.delvable_.partic
{
	/// <summary>
	/// </summary>
	public  class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}


		[Obsolete()]
		private nilnul.fs.address_.ShieldI _module;

		[Obsolete()]
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		[Obsolete()]
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		[Obsolete()]
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
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
			, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		/// <summary>
		/// called by the task
		/// </summary>
		/// <param name="folder"></param>
		internal void _vod_ofAddress(
			string folder
		)
		{


			 dev.srcs.each.sln.div_.delvable_.partic_.intent.Bak_srcsInAddress.Vod(cfg,this._module,this.innerModules,this.innerModules2reinclude,folder);
		}

//		static void _Vod(
//nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
//			,
//			string folder
//			, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module
//			)
//		{
//			new dev.src.sln.div_.unjoint_.partic_.intent.Bak_srcsInAddress(cfg,innerModules,innerModules2reinclude,module).Exe(folder);

//		}

	}
}