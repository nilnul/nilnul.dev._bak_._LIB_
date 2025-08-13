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

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.plain_.intent
{
	/// <summary>
	/// 
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

		//[Obsolete()]
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		//[Obsolete()]
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		//[Obsolete()]
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		//[Obsolete()]
		internal Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, nilnul.fs.address_.ShieldI module)
		   : this(cfg, new ConcurrentBag<DivI>(), new ConcurrentBag<DivI>(), module)
		{

		}
		public Bak(Io cfg, string folderOfIntent) : this(
				cfg
				,
				nilnul.fs.address_.Shield.FroAddress(folderOfIntent)
			)
		{
		}
		private Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{
		}

		private Bak(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}



		//[Obsolete(nameof(_exe), true)]
		//private void _exe(
		//	string folder
		//)
		//{
		//	var innerModules = new ConcurrentBag<DivI>();
		//	var innerModules2reinclude = new ConcurrentBag<DivI>();
		//	fs.address_.Shield module = nilnul.fs.address_.Shield.FroAddress(folder);

		//	new partic_.giT_._plain.Depth1st(cfg, innerModules, innerModules2reinclude)
		//	{
		//		module = module // this.superModule
		//	}._vod(folder);

		//	try
		//	{

		//		new plain0nontop_.intent._bak.Container(cfg, innerModules, innerModules2reinclude, module)._bak();
		//		//new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).Exe(folder);

		//		//else
		//		//{
		//		//	new nonneglect_.nonintent_.giT_.plain.Bak(cfg,innerModules,innerModules2reinclude,module)._vod(folder);
		//		//}
		//	}
		//	catch (OperationCanceledException e)
		//	{
		//		Trace.TraceWarning($"operation cancelled when processing {this.GetType().FullName}: {folder}: {e}");
		//		throw;
		//	}

		//	catch (Exception e)
		//	{
		//		Trace.TraceError($"exception when baking {folder}:{e}");
		//	}

		//}

		public void _exe(

		)
		{
			//var innerModules = new ConcurrentBag<DivI>();
			//var innerModules2reinclude = new ConcurrentBag<DivI>();
			//fs.address_.Shield module = nilnul.fs.address_.Shield.FroAddress(folder);

			new partic_.giT_._plain.Depth1st(cfg, innerModules, innerModules2reinclude)
			{
				module = _module // this.superModule
			}._vod(this._module.ToString());

			try
			{

				new plain0nontop_.intent._bak.Container(cfg, innerModules, innerModules2reinclude, module)._bak();
				//new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).Exe(folder);

				//else
				//{
				//	new nonneglect_.nonintent_.giT_.plain.Bak(cfg,innerModules,innerModules2reinclude,module)._vod(folder);
				//}
			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing {this.GetType().FullName}: {this._module}: {e}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError($"exception when baking {this._module}:{e}");
			}

		}

		internal static void Vod(Io cfg, ShieldI parentModule, ConcurrentBag<DivI> innerModules4Parent, ConcurrentBag<DivI> innerModulesReinclude4Parent, string folderOfIntent)
		{
			if (parentModule is not null)
			{
				innerModules4Parent.Add(
					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
						parentModule
						,
						folderOfIntent
					)
				);
			}

			//new div_.unjoint_.partic_.giT_. plain0nontop_.intent._bak.Container(cfg, innerModules, innerModules2reinclude, module).Exe(folder);

			new div_.delvable_.partic_.giT_.plain_.intent.Bak(cfg, folderOfIntent) { }._exe();
		}
	}
}
