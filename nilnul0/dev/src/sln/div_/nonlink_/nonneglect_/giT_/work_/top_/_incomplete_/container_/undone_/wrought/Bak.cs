using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.git.module;
using nilnul.fs.folder;
namespace nilnul.dev.sln.div_.module_.nonlink_.nonneglect_._incomplete_.container_.undone_.noncleared

{
	/// <summary>
	/// if there are significant work in the repo. only ".gitignore" or ".nilnulCfg" are considered not work.
	/// </summary>
	public  class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI>())
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
		public void _exe(
			string folder

			//,
			//ConcurrentBag<DivI> innerModules
			//,
			//ConcurrentBag<DivI> innerModules2reinclude
		)
		{
			var cancel = cfg.cancel;
			var git = cfg.git;

			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");

			//var innerModules = new ConcurrentBag<DivI>( nilnul.fs.git.module._DirectInnerModulesX.DivsAsArray_ofAddress(folder)
			//	);
			//var innerModules2reinclude = new ConcurrentBag<DivI>(

			//);

			incomplete_._noncleared_.container_.undone._bak_._PrimeX._Exe(folder,/*innerModules, innerModules2reinclude, */cancel, git);

			new nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.container_.undone_.primed.Bak(_cfg)._exe(folder, /*innerModules,*/ cancel, git);

			//new incomplete_._noncleared_.container_.undone_.primed.Bak(;
		}
	}
}
