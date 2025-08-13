using nilnul.fs.folder_.git_;
using System.Collections.Concurrent;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_.top;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_.work_;
using nilnul.dev.sln_.nonlink.directory_.nonlink_.nonneglect_.git_;


namespace nilnul.dev.srcs.each.sln.directory_.delvable_.partic_.giT_.work
{
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;


		private nilnul.fs.address_.ShieldI _module;

		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}


		public Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
			,
			ConcurrentBag<nilnul.fs._address.DivI> innerModules
,
			ConcurrentBag<fs._address.DivI> innerModules2reinclude

		)
		{
			_cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}

		public void __exe_ofAddress(string sln)
		{
			if (
				nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(sln, cfg.git)
			)
			{
				if (module is not null)
				{
					innerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							module
							,
							sln
						)
					);
				}


				new nilnul.dev.srcs.each.sln.directory_.delvable_.partic_.giT_.work_.top.Bak_srcsInAddresses(cfg)._exe_ofAddress(sln);
			}
			else
			{
				new nilnul.dev.srcs.each.sln.directory_.delvable_.partic_.giT_.work_.nontop.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) { module = this.module }._exe(sln);
			}
		}



		public void _Exe(Work work)
		{
			__exe_ofAddress(work.ToString());
		}


	}
}