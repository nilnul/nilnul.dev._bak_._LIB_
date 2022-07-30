using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.folder_.git_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.src.sln.directory_.unjoint_.giT_.work_.top
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
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

		public void __exe(string _location__nonrootWork)
		{

			if (nilnul.fs.folder.be_.deV_.src_.bak_._neglect._PerNameX.Be_ofAddress(_location__nonrootWork, cfg.git))
			{
				Trace.TraceWarning(
					$"{_location__nonrootWork} is neglected"
				);
				if (module != null)
				{
					innerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							module
							,
							_location__nonrootWork
						)
					);
				}
				///todo: no child is enumerated here. so inner modules are commited into parent module
			}
			else  //not to neglect
			{
				bool? aft = nilnul.fs.folder.sign_.dev_.src_.bak_._AftX.Be_ofAddress(_location__nonrootWork, cfg.git);
				if (aft == false)
				{
					if (module != null)
					{
						innerModules.Add(
							nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
								module
								,
								_location__nonrootWork
							)
						);
					}
				}

				else
				{
					if (aft == true)
					{
						if (module != null)
						{
							innerModules2reinclude.Add(
								nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
									module
									,
									_location__nonrootWork
								)
							);
						}

					}
					new unjoint_.nonneglect_.giT_.work_.top.Bak_srcsInAddresses(cfg) { }._exe_ofAddress(_location__nonrootWork);
					//new nonintent_.nonneglect.Bak(cfg, innerModules, innerModules2reinclude) { module = this.module }.Exe(_location__nonrootWork);
				}
			}

			return;
			//if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(work, cfg.git))
			//{
			//	Trace.TraceWarning(
			//		$"{work} is neglected"
			//	);
			//}
			//else
			//{
			//	new unjoint_.nonneglect_.giT_.work_.top.Bak_srcsInAddresses(cfg) { }._exe_ofAddress(work);
			//}
		}

		public void _exe(Work work)
		{
			__exe(work.ToString());
		}

		internal void _exe(ShieldI shield)
		{
			__exe(shield.ToString());
		}
	}
}