using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_._incomplete_.container_.undone.bak_;

namespace nilnul.dev.sln.div_.module_.nonlink_.nonneglect_.incomplete_._noncleared_.container_.undone
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete("", true)]

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
		/// </returns>
		/// 
		public void _exe(
			string folder
						,
			ConcurrentBag<DivI> innerModules
			,
			ConcurrentBag<DivI> innerModules2reinclude


		)
		{
			var cancel = cfg.cancel;
			var git = cfg.git;

			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");
			try
			{
				var size = nilnul.fs.git.module.repo._SizeX.Kb_ofWorkDivAddress(folder);	//if exception errCode is -1, it's maybe because that the process of git is timeout.
				if (size > (double)new nilnul.num_.radix_.binary_.Giga().toNum().toBigint().en * 10) //10G
				{
					Trace.TraceError($"repo:{folder}'s size({size}) is bigger than 10G(gitlab limmit)");
				}
				else
				{
					if (size > (double)new nilnul.num_.radix_.binary_.Giga().toNum().toBigint().en * 10 * 0.8) //10G
					{
						Trace.TraceError($"repo:{folder}'s size(size) is sized at (0.8,1]*10G(gitlab limmit)");
					}
				}
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception:{e} when getting the size of {folder}. App will ingore this exception and continue.");
			}


			_bak_._PrimeX._Exe(folder,innerModules, innerModules2reinclude, cancel, git);

			new undone_.primed.Bak(_cfg)._exe(folder, innerModules, cancel, git);
		}
	}
}
