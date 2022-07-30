using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_.incomplete_.moduleUndone
{
	/// <summary>
	///  this is called by newly created repo at the folder that is intended to be a git repo.
	/// </summary>
	public  class Bak
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

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
		}
		private Bak(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}


		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
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

			/// for incomplete,
			///		content is not done.
			///			but some module is done , some module is not done.
			new _incomplete_.content.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude)._Exe(folder);

			cfg.cancel.ThrowIfCancellationRequested();

			new top_._incomplete_.container_.undone.Bak_srcsInAddresses(cfg )._exe(folder, innerModules,innerModules2reinclude);

			cfg.shieldsNewlyBaked.Add(folder);
		}
	}
}
