using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.folder_.git_;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.sln_.nonlink.directory_.nonlink_.git_.work_.top
{
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}
		private nilnul.fs.address_.ShieldI _moduleAbove;

		public nilnul.fs.address_.ShieldI moduleAbove
		{
			get => _moduleAbove;
			set => _moduleAbove = value;
		}


		/// <summary>
		/// innerDivs
		/// </summary>
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		/// <summary>
		/// innerDivs2reinclude
		/// </summary>

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;
		public Bak(Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}
		private Bak(Io cfg, ConcurrentBag<DivI> innerModules) : this(cfg, innerModules, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules;
		}

		private Bak(
			nilnul.fs.address_.shields.dev_._bak.Io cfg
		):this(cfg,new ConcurrentBag<DivI>())
		{
			_cfg = cfg;
		}

		public void __Exe(string work)
		{
			new nilnul.dev.sln.directory_.nonlink_.git_.work_.top.Bak(
				this.cfg, this.innerModules, this.innerModules2reinclude
			)
			{moduleAbove=this.moduleAbove }.__Exe(work);
			return;
			//if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(work, cfg.git))
			//{
			//	Trace.TraceWarning(
			//		$"{work} is neglected"
			//	);
			//}
			//else
			//{
			//	new nonlink_.nonneglect_.git_.work_.top.Bak(cfg) { }._Exe(work);
			//}
		}

		public void _Exe(Work work)
		{
			__Exe(work.ToString());
		}
	}
}