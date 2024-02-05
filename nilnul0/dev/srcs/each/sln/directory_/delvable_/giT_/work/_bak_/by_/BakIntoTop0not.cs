using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder_.git_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.giT_.work
{
	[Obsolete(nameof(Bak4unjoint))]
	public class Bak2Top0not
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


		public Bak2Top0not(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1) : this(cfg, innerModules1, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules1;
		}

		public Bak2Top0not(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}

		public void __exe(string work)
		{

			if (
				nilnul.fs.folder_.git_.work.be_.Top.Singleton.be_ofAddress(work, cfg.git)
			)
			{
				//if (module != null)
				//{
				//	innerModules.Add(
				//		nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
				//			module
				//			,
				//			work
				//		)
				//	);

				//}
				
				/// todo: determine isNeglect first?  
				/// no! as we need to settle the collection of direct inner modules for parent module

				//if (nilnul.fs.folder.be_.dev_.src_.bak_._NeglectX.Be_ofAddress(work, cfg.git))
				//{
				//	Trace.TraceWarning(
				//		$"{work} is neglected"
				//	);
				//}
				//else { 
					
				//}

				 work_.top.Bak_srcsInAddresses.__Exe(
					 cfg,this._module, innerModules, innerModules2reinclude,work
					);
			}
			else
			{
				new work_.nontop.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude) {module=this.module }._exe(work);
			}
		}

		internal void __exe(ShieldI shield)
		{
			__exe(shield.ToString());
			//throw new NotImplementedException();
		}

		public void _exe(Work work)
		{
			__exe(work.ToString());
		}


	}
}