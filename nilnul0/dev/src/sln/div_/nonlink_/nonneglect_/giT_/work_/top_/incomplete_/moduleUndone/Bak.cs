using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_.incomplete_.moduleUndone
{
	/// <summary>
	/// </summary>
	public  class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules ;


		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)//:this(cfg, new ConcurrentBag<DivI>())
		{
			this.cfg = cfg;
			
		}

		//private Bak(Io cfg, ConcurrentBag<DivI> innerModules1)
		//{
		//	this.cfg = cfg;
		//	this.innerModules = innerModules1;

		//}

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
		[Obsolete("",false)]
		public void _Exe(
			string folder
		)
		{
			Trace.TraceInformation($"in {typeof(Bak).FullName} {nameof(_Exe)}  for {folder} ");

			cfg.cancel.ThrowIfCancellationRequested();
			ConcurrentBag<nilnul.fs._address.DivI> innerModules = new ConcurrentBag<DivI>();
			ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude = new ConcurrentBag<DivI>();

			new _incomplete_.content.Bak(cfg, innerModules,innerModules2reinclude)._Exe(folder);

			cfg.cancel.ThrowIfCancellationRequested();

			new nilnul.dev.sln.div_.module_.nonlink_.nonneglect_._incomplete_.container_.undone.Bak(cfg )._exe(folder, innerModules,innerModules2reinclude);

			cfg.shieldsNewlyBaked.Add(folder);
		}
	}
}
