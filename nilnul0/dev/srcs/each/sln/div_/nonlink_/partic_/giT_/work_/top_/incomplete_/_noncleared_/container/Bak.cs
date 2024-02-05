using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln.div_.module_.nonlink_.nonneglect_.incomplete_._noncleared_.container
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete("",true)]
	public  class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
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

		public void _Exe(
			string folder
			,
			ConcurrentBag<nilnul.fs._address.DivI> innerModules

			,
			ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude

		)
		{
			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_Exe)}  for {folder} ");
			if (cfg.isModuleBaked(folder))
			{
				Trace.TraceInformation($"module {folder} is already baked previously");
				//incomplete_._ModuleDoneX._Exe(folder, cancel);
			}
			else
			{
				new container_.undone.Bak(cfg)._exe(folder, innerModules,innerModules2reinclude);
			}
		}
	}
}
