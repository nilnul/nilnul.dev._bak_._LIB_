using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System.Collections.Concurrent;

namespace nilnul.dev.src.sln.directory_.unjoint_.nonneglect_.giT_.work_.nontop
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


		public void _exe(
			string folder
		)
		{

			if (
				nilnul.fs.git.module._ignore_.rule_.nn_._IntendGitX.IsIntend_ofShieldAddress(folder)
			)
			{
				if (module != null)
				{
					innerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							module
							,
							folder
						)
					);

				}

				new nontop_.intent.Bak_srcsInAddresses(cfg).Exe(folder);
			}
			else
			{
				new nontop_.nonintent.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude,module) ._Exe(folder);
			}

		}
	}
}