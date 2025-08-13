using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.container_.undone.bak_
{
	/// <summary>
	/// </summary>
	public  class Module
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public Module(nilnul.fs.address_.shields.dev_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI>())
		{
			this.cfg = cfg;
		}

		//public Bak(Io cfg, ConcurrentBag<DivI> innerModules)
		//{
		//	this.cfg = cfg;
		//	this.innerModules = innerModules;
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
		/// </returns>
		/// 
		[Obsolete("",true)]
		public void _exe(
			string folder
	
		)
		{

			
			var cancel = cfg.cancel;
			var git = cfg.git;

			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");

			var innerModules = new ConcurrentBag<DivI>( nilnul.fs.git.module._DirectInnerModulesX.DivsAsArray_ofAddress(folder)
				);
			var innerModules2reinclude = new ConcurrentBag<DivI>(

			);

			///todo: 

			_bak_._PrimeX._Exe(folder,innerModules, innerModules2reinclude, cancel, git);

			new undone_.primed.Bak(_cfg)._exe(folder, innerModules, cancel, git);
		}
	}
}
