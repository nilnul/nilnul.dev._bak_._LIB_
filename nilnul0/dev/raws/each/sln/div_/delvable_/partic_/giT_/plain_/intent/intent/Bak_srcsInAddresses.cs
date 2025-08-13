using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.src.sln.div_.unjoint_.partic_.giT_.plain_.intent
{
	[Obsolete(nameof(Bak),true)]
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}


		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		internal Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}
		public void _vod_0folder(
				string folder
			)
		{
			new div_.unjoint_.partic_.giT_._plain.Depth1st(cfg, innerModules, innerModules) { module = this.module }._vod(folder);

			cfg.cancel.ThrowIfCancellationRequested();

			new div_.unjoint_.partic_.giT_.plain0nontop_.intent._bak.Container(cfg, innerModules, innerModules2reinclude, module).Exe(folder);
			//new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).Exe(folder);

			//new div_.unjoint_.partic_.giT_.plain.BakByIntent(
			//	cfg,innerModules,innerModules2reinclude
			//){module=this.module  }._Exe(folder);
			//return;

			//if (
			//	nilnul.fs.git.module._ignore_.rule_.nn_._IntendGitX.IsIntend_ofShieldAddress(folder)
			//)
			//{

			//	new div_.unjoint_.nonneglect_.intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude){module=this.module  }.Exe(folder);
			//}
			//else
			//{
			//	new div_.unjoint_.nonneglect_.nonintent_.giT_.plain.Bak(cfg,innerModules,innerModules2reinclude) {module=this.module  }._vod(folder);
			//}

		}
	}
}