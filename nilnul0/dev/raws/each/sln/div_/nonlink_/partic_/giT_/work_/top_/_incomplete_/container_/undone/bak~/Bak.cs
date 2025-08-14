using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder;
using nilnul.fs.git.module;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.container_.undone
{
	/// <summary>
	/// </summary>
	public class Bak
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
		/// newly processed
		/// </returns>
		//[Obsolete(nameof(nilnul.dev.sln.div_.module_.nonlink_.nonneglect_.incomplete_._noncleared_.container_.undone.Bak), true)]
		[Obsolete("",true)]

		public void _exe(
			string folder
			,
			ConcurrentBag<DivI> innerModules
			,
			ConcurrentBag<DivI> innerModules2reinclude

		)
		{

			///todo: nothingButNilnulcfg
			if (nilnul.fs.git.module.BeX.Be_ofAddress(
				nilnul.fs.git.module.be_.dev_.NothingButSetting.Singleton
				, 
				(folder)
			))
			{
				new dev.sln.div_.module_.nonlink_.nonneglect_.incomplete_.cleared.Bak(_cfg)._exe(folder);
				return;
			}
			else
			{
				new nilnul.dev.sln.div_.module_.nonlink_.nonneglect_.incomplete_._noncleared_.container_.undone.Bak(_cfg)._exe(folder, innerModules, innerModules2reinclude);

				return;

			}

			var cancel = cfg.cancel;
			var git = cfg.git;

			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");

			_bak_._PrimeX._Exe(folder, innerModules, innerModules2reinclude, cancel, git);

			new undone_.primed.Bak(_cfg)._exe(folder, innerModules, cancel, git);


		}
	}
}
