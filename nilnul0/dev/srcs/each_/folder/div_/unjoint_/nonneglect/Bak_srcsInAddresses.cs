using nilnul.fs;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs.addresses_.disjoint;
using System.Linq;
using System;
using nilnul.fs._address;

namespace nilnul.dev.src_.folder.div_.unjoint_.nonneglect
{
	/// <summary>
	/// </summary>
	///
	[Obsolete()]
	public  class Bak_srcsInAddresses
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

		[Obsolete("commented src.dir is not considered",true)]
		public  void exe(
			nilnul.fs.address_.ShieldI _div_inSrc
		)
		{
			

			fs.address_.ShieldI shield = _div_inSrc;

			Trace.TraceInformation($"{this.GetType().FullName}.{nameof(exe)}({_div_inSrc})>>>");

			/// get the parent src

			var parent = nilnul.fs.address_.Shield.FroAddress(
				_cfg.srcs.addresses.Where(
					a => nilnul.fs.address.re_.Sup.Singleton.re(a, _div_inSrc)
				).Single()
			);



			uint distance = nilnul.fs.address_.shield.co_.sup._DistanceX1._ofSupSub(parent, shield);

			switch (distance)
			{
				case 0: //src
					new nilnul.dev.src_.folder_.unjoint_.nonneglect.Bak(cfg).exe(
					   _div_inSrc.ToString()
					);

					break;
				case 1: //sln
					new nilnul.dev.srcs.each.sln_.unjoint_.nonneglect.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).__exe(_div_inSrc.ToString());
					break;

				default:    //inside sln
					new nilnul.dev.srcs.each.sln.directory_.delvable_.partic.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).vod(
						 shield
						);
					break;
			}


		}


		[Obsolete("commented src.dir is not considered", true)]
		public void exe(Exist address)
		{
			exe(address.en);
		}

		[Obsolete("commented src.dir is not considered", true)]
		public void exe(FolderI en)
		{
			exe(en.folder.en.address);
		}

		


	}
}
