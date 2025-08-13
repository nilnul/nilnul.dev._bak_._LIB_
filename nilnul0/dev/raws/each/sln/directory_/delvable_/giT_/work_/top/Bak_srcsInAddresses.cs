using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.addresses_.disjoint.deV_._bak;
using nilnul.fs.folder_.git_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.giT_.work_.top
{
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		private nilnul.fs.address_.ShieldI _module;

		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
			: this(cfg, innerModules, innerModules2reinclude, null)
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules;
			//this.innerModules2reinclude = innerModules2reinclude;
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

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1) : this(cfg, innerModules1, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules1;
		}
		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}

		[Obsolete("partic shall be determined first to allow the inner modules reinclude of parent modules doen.",true)]
		public void __exe()
		{

			/// <see cref="div_.delvable_.partic_"/>

			if (
				nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_._DefineX.Be(
					this._module
				)
			)
			{
				Trace.TraceWarning(
					$"{this._module} is neglected"
				);
				return;
			}

			var deferred = nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_._DeferX._Deferred0nul_0folder(this._module.ToString());


			if (deferred == true)
			{
				Trace.TraceWarning(
					$"{this._module} is deferred"
				);
				return;

			}

			new delvable_.partic_.giT_.work_.top.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) { module = this._module }._exe_ofAddress();
		}

		static public void __Exe(
Io cfg, ShieldI parentModule, ConcurrentBag<DivI> innerModules4Parent, ConcurrentBag<DivI> innerModulesReinclude4Parent,
			string _location__nonrootWork

		)
		{
			div_.delvable_.giT_.work_.top._BakX._Vod(
				cfg, parentModule, innerModules4Parent, innerModulesReinclude4Parent, _location__nonrootWork
			);
			return;

			//if (parentModule is not null)
			//{
			//	innerModules4Parent.Add(
			//			nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
			//				parentModule
			//				,
			//				_location__nonrootWork
			//			)
			//		);
			//}

			//new Bak_srcsInAddresses(cfg, _location__nonrootWork) { }.__exe();




		}

		//public void _exe(Work work)
		//{
		//	__exe(work.ToString());
		//}

		//internal void _exe(ShieldI shield)
		//{
		//	__exe(shield.ToString());
		//}
	}
}