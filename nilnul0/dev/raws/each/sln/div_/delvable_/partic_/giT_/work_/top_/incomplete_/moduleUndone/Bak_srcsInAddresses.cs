using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_.incomplete_.moduleUndone
{
	/// <summary>
	///  this is called by newly created repo at the folder that is intended to be a git repo.
	/// </summary>
	///
	[Obsolete(nameof(_incomplete_.container_.undone) + " is preferred;",true)]
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
		[Obsolete("as we do depth first traverse, we shall directly call container_Undone.bak",true)]
		public void _exe(
			//string folder
		)
		{
			Trace.TraceInformation($"in {typeof(Bak).FullName} {nameof(_exe)}  for {this._module} ");

			//cfg.cancel.ThrowIfCancellationRequested();
			//ConcurrentBag<nilnul.fs._address.DivI> innerModules = new ConcurrentBag<DivI>();
			//ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude = new ConcurrentBag<DivI>();

			/// for incomplete,
			///		content is not done.
			///			but some module is done , some module is not done.
			/// todo: as we got depth-first traverse, this is not necessary.
			//new _incomplete_.content.Bak_srcsInAddresses(cfg, innerModules,innerModules2reinclude)._Exe(folder);

			cfg.cancel.ThrowIfCancellationRequested();

			 top_._incomplete_.container_.undone.Bak_srcsInAddresses._Exe(cfg ,this._module.ToString(),this.innerModules,this.innerModules2reinclude);

			cfg.shieldsNewlyBaked.Add(this._module.ToString());
		}
	}
}
