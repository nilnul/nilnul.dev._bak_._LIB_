using nilnul.dev;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.directory_.delvable_.partic_.giT_.work_.nontop_.intent
{
	/// <summary>
	/// 
	/// </summary>
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
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg,  nilnul.fs.address_.ShieldI module)
			:this(cfg, new ConcurrentBag<DivI>(),new ConcurrentBag<DivI>(),module)
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
		public Bak_srcsInAddresses(fs.addresses_.disjoint.deV_._bak.Io cfg, string folder) : this(cfg, nilnul.fs.address_.Shield.FroAddress(folder))
		{
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void exe( 
			//string folderAddress
		) {
				new sln.div_.delvable_.partic_.giT_.work_.nontop_.intent.Bak(cfg ,innerModules,innerModules2reinclude,module)._exe();

				//new sln.div_.unjoint_.nonneglect_.intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg ,innerModules,innerModules2reinclude,module).Exe(folderAddress);
				
		}

		internal static void Bak(
			fs.addresses_.disjoint.deV_._bak.Io cfg
			, ShieldI module
			, ConcurrentBag<DivI> innerModules
			, ConcurrentBag<DivI> innerModules2reinclude
			, string folder
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

				new Bak_srcsInAddresses(cfg,folder).exe();

		}
	}
}