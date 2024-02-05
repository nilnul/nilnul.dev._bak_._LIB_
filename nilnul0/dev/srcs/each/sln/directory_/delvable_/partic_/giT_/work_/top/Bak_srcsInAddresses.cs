using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.addresses_.disjoint.deV_._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.partic_.giT_.work_.top
{
	//[Obsolete(nameof(sln.div_.nonlink_.nonneglect_.giT_.work_.top.Bak))]
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

		 Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg,  nilnul.fs.address_.ShieldI module)
			:this(cfg,new ConcurrentBag<DivI>(),new ConcurrentBag<DivI>(),module)
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
		public void _exe_ofAddress(
			//string folder
		)
		{

			//new div_.nonlink_.nonneglect_.git_.work_.top.Bak(cfg)._void(folder);

			new sln.div_.delvable_.partic_.giT_.work_.top.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module)._vod();

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

			new Bak_srcsInAddresses(cfg, currentModule)._exe_ofAddress();





		}
	}
}
