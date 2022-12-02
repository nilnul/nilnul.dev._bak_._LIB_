using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.folder;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top
{
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
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}


		public void _void(
			string folder
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

			Trace.TraceInformation(
				$"{typeof(Bak_srcsInAddresses).FullName}.{nameof(_void)}( {folder}) ... "
			);

			if (cfg.isShieldBaked(folder))
			{
				Trace.TraceInformation(
					$"{folder} is already baked."
				);
				return;
			}

			new top_.incomplete.Bak_srcsInAddresses(cfg)._exe(folder);

			//new sln.div_.module_.nonlink_.nonneglect_.incomplete.Bak(cfg)._exe(folder);



			Trace.TraceInformation(
				$" ... {typeof(Bak_srcsInAddresses).FullName}.{nameof(_void)}( {folder})"
			);




		}
	}
}
