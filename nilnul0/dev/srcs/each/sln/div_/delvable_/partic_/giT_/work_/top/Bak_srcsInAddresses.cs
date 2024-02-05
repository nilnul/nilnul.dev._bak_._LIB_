using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.addresses_.disjoint.deV_._bak;
using nilnul.fs.folder;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top
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


		Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, nilnul.fs.address_.ShieldI module)
		   : this(cfg, new ConcurrentBag<DivI>(), new ConcurrentBag<DivI>(), module)
		{

		}
		public Bak_srcsInAddresses(Io cfg, string folderOfIntent) : this(
				cfg
				,
				nilnul.fs.address_.Shield.FroAddress(folderOfIntent)
			)
		{
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

		public void _vod(
		//string currentModule
		)
		{



			Trace.TraceInformation(
				$"{typeof(Bak_srcsInAddresses).FullName}.{nameof(_vod)}( {this._module}) ... "
			);

			if (cfg.isShieldBaked(this._module.ToString()))
			{
				Trace.TraceInformation(
					$"{this._module} is already baked."
				);
				return;
			}

			new top_.incomplete.Bak_srcsInAddresses(cfg, this.innerModules, this.innerModules2reinclude, this._module)._exe();

			//new sln.div_.module_.nonlink_.nonneglect_.incomplete.Bak(cfg)._exe(folder);



			Trace.TraceInformation(
				$" ... {typeof(Bak_srcsInAddresses).FullName}.{nameof(_vod)}( {this._module})"
			);




		}

		static public void _Vod(
Io cfg, ShieldI parentModule, ConcurrentBag<DivI> innerModules4Parent, ConcurrentBag<DivI> innerModulesReinclude4Parent,
			string currentModule
		)
		{
			if (parentModule is not null)
			{
				innerModules4Parent.Add(
					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
						parentModule
						,
						currentModule
					)
				);
			}

			new Bak_srcsInAddresses(cfg, currentModule)._vod();





		}

	}
}
