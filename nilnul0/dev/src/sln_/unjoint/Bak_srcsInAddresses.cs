using nilnul.fs;
using nilnul.fs._address;
using nilnul.fs.address_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln_.unjoint
{
	/// <summary>
	/// </summary>
	public  class Bak_srcsInAddresses
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public  void _vod_ofAddress(string folder)
		{

			if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(folder, cfg.git))
			{
				Trace.TraceWarning($"{folder} is ignored");
			}
			else
			{
				new unjoint_.nonneglect.Bak_srcsInAddresses(cfg,innerModules,innerModules2reinclude,module)._StartTask(folder);
			}



			//Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- starting task");

			//Task.Factory.StartNew(
			//	() =>
			//	{
			//		Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- in task- waiting semaphore");


			//		cfg.semaphore.Wait(cfg.cancel);
			//		try
			//		{
			//			__Exe(folder);
						
			//		}
			//		finally
			//		{
			//			cfg.semaphore.Release();
			//		}
			//		Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- in task - semaphore released");
			//	}
			//	,
			//	cfg.cancel
			//	,
			//	TaskCreationOptions.AttachedToParent
			//	, TaskScheduler.Current //TaskScheduler

			//).ContinueWith(
			//	(t) =>
			//	{
			//		Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- task continueing");


			//		cfg.shieldsNewlyBaked.Add(folder);

			//		Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- task continued");


			//	}
			//	, cfg.cancel //bubbel up
			//	,
			//	TaskContinuationOptions.OnlyOnRanToCompletion /*even if it's faulted; as err has been traced*/
			//	| TaskContinuationOptions.ExecuteSynchronously
			//	| TaskContinuationOptions.AttachedToParent
			//	,
			//	TaskScheduler.Current/*where ExecuteSynchronously continuations won’t run synchronously is when the target scheduler doesn’t allow it.  A TaskScheduler has the ability to say whether tasks are able to run on the current thread or not.  */
			//);

			//Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- started task");


		}

		internal void _vod(ShieldI shield)
		{
			_vod_ofAddress(shield.ToString());
		}

		public  void _vod(FolderI folder)
		{
			_vod_ofAddress(folder.ToString());
		}
	}
}