﻿using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_._incomplete_.container
{
	/// <summary>
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}



		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		/// <summary>
		/// </summary>
		/// <param name="git"></param>
		/// <param name="_location"></param>
		/// <param name="log"></param>
		/// <param name="err"></param>
		/// <remarks>
		/// </remarks>
		/// <returns>
		/// newly processed
		/// </returns>

		public void _exe(
			string folder
			,
			ConcurrentBag<nilnul.fs._address.DivI> innerModules

			,
			ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude

		)
		{
			//nilnul.fs.git.module._ignore_.exclude.put._IfLinesNonemptyX.Void_ofModuleAddress(folder, innerModules);
			//nilnul.fs.git.module._ignore_.exclude.unput._IfLinesNonemptyX._OfModuleAddress(folder, innerModules2reinclude.Select(x => x.ToString()));


			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");
			if (cfg.isModuleBaked(folder))
			{
				Trace.TraceInformation($"module {folder} is already baked previously");
				//incomplete_._ModuleDoneX._Exe(folder, cancel);
				return;
			}

			_incomplete_.container_.undone.Bak_srcsInAddresses._Exe(cfg, folder, innerModules, innerModules2reinclude);

			//new dev.sln.div_.module_.nonlink_.nonneglect_._incomplete_.container_.undone.Bak(cfg)._exe(folder, innerModules,innerModules2reinclude);


		}
	}
}