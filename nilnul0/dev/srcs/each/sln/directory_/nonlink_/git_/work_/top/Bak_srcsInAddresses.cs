using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder_.git_;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.giT_.work_.top
{
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		private nilnul.fs.address_.ShieldI _moduleAbove;
		public nilnul.fs.address_.ShieldI moduleAbove
		{
			get => _moduleAbove;
			set => _moduleAbove = value;
		}

		/// <summary>
		/// innerDivs
		/// </summary>
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		/// <summary>
		/// innerDivs2reinclude
		/// </summary>

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}
		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules) : this(cfg, innerModules, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules;
		}

		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		public void __Exe(string _location__nonrootWork)
		{

			if (nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_._DefineX._Be_0folder(_location__nonrootWork))
			{
				Trace.TraceWarning(
					$"{_location__nonrootWork} is neglected"
				);
				if (moduleAbove != null)
				{
					innerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							moduleAbove
							,
							_location__nonrootWork
						)
					);
				}
				///todo: no child is enumerated here. so inner modules are commited into parent module
			}
			else  //not to neglect per name
			{
				bool? aft = nilnul.fs.folder.sign_.dev_.src_.bak_._AftX.Be_ofAddress(_location__nonrootWork, cfg.git);
				if (aft == false)
				{
					if (moduleAbove != null)
					{
						innerModules.Add(
							nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
								moduleAbove
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
						if (moduleAbove != null)
						{
							innerModules2reinclude.Add(
								nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
									moduleAbove
									,
									_location__nonrootWork
								)
							);
						}

					}
					new nonlink_.nonneglect_.giT_.work_.top.Bak_srcsInAddresses(cfg) { }._Exe(_location__nonrootWork);

				}
			}


			//if (nilnul.fs.folder.be_.dev_.baK_._NeglectX.Be_ofAddress(work, cfg.git))
			//{
			//	Trace.TraceWarning(
			//		$"{work} is neglected"
			//	);
			//}
			//else
			//{
			//	new nonlink_.nonneglect_.giT_.work_.top.Bak_srcsInAddresses(cfg) { }._Exe(work);
			//}
		}

		public void _Exe(Work work)
		{
			__Exe(work.ToString());
		}
	}
}