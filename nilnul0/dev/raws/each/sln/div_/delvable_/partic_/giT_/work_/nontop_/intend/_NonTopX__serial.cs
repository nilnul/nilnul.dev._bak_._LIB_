using nilnul.dev;
using nilnul.dev.srcs._bak;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.addresses_.disjoint.deV_._bak;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.nontop_.intent
{
	/// <summary>
	/// as this is intend, the innerModules(including those reincluded) shall be renewed here;
	/// </summary>
	public class Bak
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

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude
			, nilnul.fs.address_.ShieldI module
		)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Bak(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}


		// void _exe(
		//	string folder
		//)
		//{

		//	var shield = nilnul.fs.address_.Shield.FroAddress(folder);
		//	new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.nontop._bak.Depth1st(
		//		cfg
		//		,
		//		innerModules
		//		,
		//		innerModules2reinclude
		//		,
		//		shield
		//	)._exe(
		//		folder
		//	);

		//	new giT_.plain0nontop_.intent._bak.Container(cfg, innerModules, innerModules2reinclude, shield).Exe(folder);

		//	//new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).Exe(folder);

		//	//else
		//	//{
		//	//	new nonintent_.giT_.work_.nontop.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude,module) ._exe(folder);

		//	//}

		//}

		internal void _exe(
		)
		{

			new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.nontop._bak.Depth1st(
				cfg
				,
				innerModules
				,
				innerModules2reinclude
				,
				this._module
			)._exe(
				this._module.ToString()
			);


			new giT_.plain0nontop_.intent._bak.Container(cfg, innerModules, innerModules2reinclude, this._module)._bak();

			//new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).Exe(folder);

			//else
			//{
			//	new nonintent_.giT_.work_.nontop.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude,module) ._exe(folder);

			//}

		}



		static public void _InvokedFroParentModule(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, fs.address_.ShieldI parentModule, ConcurrentBag<DivI> parentInnerModules,ConcurrentBag<DivI> parentInnerModules2Reinclude, string folder
		) {
				if (parentModule is not null)
				{

					parentInnerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							parentModule
							,
							folder
						)
					);
				}

				new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.nontop_.intent.Bak(
					cfg,
					new ConcurrentBag<DivI>(),
					new ConcurrentBag<DivI>(),
					nilnul.fs.address_.Shield.FroAddress(
						folder
					)
				)._exe();

		}

		
	}
}