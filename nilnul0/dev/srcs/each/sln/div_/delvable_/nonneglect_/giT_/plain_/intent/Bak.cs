﻿using nilnul.dev;
using nilnul.dev.srcs._bak;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.plain_.intent
{
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

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		public Bak(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}
		public void _Exe(
		string folder
	)
		{
			new nonneglect_.giT_._plain.Depth1st(cfg, innerModules, innerModules) { module = this.module }._vod(folder);

			try
			{

			

					new plain0nontop_.intent._bak.Container(cfg,innerModules,innerModules2reinclude,module).Exe(folder);
					//new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module).Exe(folder);
				
				//else
				//{
				//	new nonneglect_.nonintent_.giT_.plain.Bak(cfg,innerModules,innerModules2reinclude,module)._vod(folder);

				//}



			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing {this.GetType().FullName}: {folder}: {e}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError($"exception when baking {folder}:{e}");
			}

		}
	}
}
