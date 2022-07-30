using nilnul.fs.folder_.git_;
using System.Collections.Concurrent;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.top;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_;
using nilnul.fs._address;

namespace nilnul.dev.src.sln.directory_.unjoint_.nonneglect_.giT_.work
{
	public class Bak_srcsInAddresses
	{

		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
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

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
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

		public void __exe_ofAddress(string sln)
		{
			if (
				nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(sln, cfg.git)
			)
			{
				//if (module != null)
				//{
				//	innerModules.Add(
				//		nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
				//			module
				//			,
				//			sln
				//		)
				//	);

				//}
				new work_.top.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module)._exe_ofAddress(sln);
			}
			else
			{
				new work_.nontop.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude,module) ._exe(sln);
			}
		}



		public void _Exe(Work work)
		{
			__exe_ofAddress(work.ToString());
		}


	}

}