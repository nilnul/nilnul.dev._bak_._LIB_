using nilnul.fs;
using nilnul.fs._address;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln_.unjoint_.nonneglect
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public void __exe(
			string folder
		)
		{
			new sln.div_.unjoint_.nonneglect_.intent.Bak_srcsInAddress(cfg,innerModules,innerModules2reinclude,module).Exe(folder);
		}

		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public  void _StartTask(string folder)
		{
			Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- starting task");
			/// due to that:
			///		the semaphore is released after the task started, so the tasks are kept being started
			cfg.semaphore.Wait(cfg.cancel);

			Task.Factory.StartNew(
				() =>
				{
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- in task- waiting semaphore");

					//cfg.semaphore.Wait(cfg.cancel);
					try
					{
						__exe(folder);
						
					}
					finally
					{
						cfg.semaphore.Release();
					}
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- in task - semaphore released");
				}
				,
				cfg.cancel
				,
				TaskCreationOptions.AttachedToParent
				, TaskScheduler.Current //TaskScheduler

			).ContinueWith(
				(t) =>
				{
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- task continueing");

					try
					{
						nilnul.fs.git.module.repo.doc_.cfg_.custom._TimeX.Vod_ifModule(
							
							folder
							
							,null
							,
							_cfg.git
						);
					}
					catch (System.Exception e)
					{
						Trace.TraceError( $"when configing baked.time for {folder} there is exception (see rethrown exception); this may indicate that the folder is not a git module, and no '.git' subfolder is found inside." );
						//throw;
					}
					//cfg.shieldsNewlyBaked.Add(folder); // as is already done in module bak
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- task continued");
				}
				, cfg.cancel //bubbel up
				,
				TaskContinuationOptions.OnlyOnRanToCompletion /*even if it's faulted; as err has been traced*/
				| TaskContinuationOptions.ExecuteSynchronously
				| TaskContinuationOptions.AttachedToParent
				,
				TaskScheduler.Current/*where ExecuteSynchronously continuations won’t run synchronously is when the target scheduler doesn’t allow it.  A TaskScheduler has the ability to say whether tasks are able to run on the current thread or not.  */
			);
			/// release is done in the task
			//cfg.semaphore.Release();

			Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- started task");


		}

		public  void _StartTask(FolderI folder)
		{
			_StartTask(folder.ToString());
		}
	}
}