using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.addresses_.disjoint.deV_._bak;
using nilnul.fs.folder_.git_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.srcs.each.sln.directory_.giT_.work_.top
{
	[Obsolete()]
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude,nilnul.fs.address_.ShieldI module )
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
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude):this(cfg,innerModules,innerModules2reinclude,null)
		{
			
		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public void __exe(
			//string work
		)
		{
			

			///shuffle the namespace segment.
			///

			if (nilnul.fs.folder.dir.be_._SymlinkX.Be_ofAddress(this._module.ToString()))
			{
				new directory_.link_.giT_.work_.top.Bak4unjoint(_cfg, innerModules, innerModules2reinclude) { module = this.module }.exe(); // ..exe_ofAddress(work);


			}

			else
			{
				new directory_.delvable_.giT_.work_.top.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude) {module=this.module }.__exe();
			}
		}

		static public void Exe(
Io cfg, ShieldI parentModule, ConcurrentBag<DivI> innerModules4Parent, ConcurrentBag<DivI> innerModulesReinclude4Parent,
			string folderAddress
		)
		{

			if (parentModule is not null)
			{
				innerModules4Parent.Add(
					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
						parentModule
						,
						folderAddress
					)
				);
			}

			new Bak_srcsInAddresses(cfg, folderAddress).__exe();

		}

		//public void _exe(Work work)
		//{
		//	__exe(work.ToString());
		//}
	}
}