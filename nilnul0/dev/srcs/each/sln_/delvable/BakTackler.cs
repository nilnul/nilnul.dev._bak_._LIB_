using nilnul.fs;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.address_.shield_;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln_.delvable
{
	/// <summary>
	/// not a traverser;
	/// but tackle the bak;
	/// </summary>
	public class BakTackler
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

		public BakTackler(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		private BakTackler(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}


		private BakTackler(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public BakTackler(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		private void _vod_ofAddress(string folder)
		{
			if (nilnul.fs.folder.be_.deV_.src_.bak_._NeglectX.Be_ofAddress(folder, cfg.git))
			{
				Trace.TraceWarning($"{folder} is ignored");
			}
			else
			{
				new dev.srcs.each.sln_.delvable_.nonneglect.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude, module)._vod_ofAddress(folder);
			}
		}

		private void _vod(ShieldI shield)
		{
			_vod_ofAddress(shield.ToString());
		}

		private void _vod(FolderI folder)
		{
			_vod_ofAddress(folder.ToString());
		}


		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public void _startTask_ofAddress(string folder)
		{
			Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- starting task");
			/// due to that:
			///		the semaphore is released after the task started, so the tasks are kept being started
			cfg.semaphore.Wait(cfg.cancel);

			/// todo: schedule task according to the last succeeded bak time

			Task.Factory.StartNew(
				() =>
				{
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- in task- waiting semaphore");

					//cfg.semaphore.Wait(cfg.cancel);
					try
					{
						_vod_ofAddress(folder);

					}
					finally
					{
						cfg.semaphore.Release();
					}
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- in task - semaphore released");
				}
				,
				cfg.cancel
				,
				TaskCreationOptions.AttachedToParent
				, TaskScheduler.Current //TaskScheduler

			).ContinueWith(
				(t) =>
				{
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- task continueing");

					try
					{
						//nilnul.fs.git.module.repo.doc_.cfg_.custom._TimeX.Vod_ifModule(

						//	folder

						//	,null
						//	,
						//	_cfg.git
						//);
						nilnul.fs.folder.cfg.bak.visited._AppendX.Vod_folderOfAddress(folder);
					}
					catch (System.Exception e)
					{
						Trace.TraceError($"when configing baked.time for {folder} there is exception:{e}; (see rethrown exception); this may indicate that the folder is not a git module, and no '.git' subfolder is found inside.");
						//throw;
					}
					//cfg.shieldsNewlyBaked.Add(folder); // as is already done in module bak
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- task continued");
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

			Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- started task");


		}

		public void _startTask(FolderI folder)
		{
			_startTask_ofAddress(folder.ToString());
		}

		public void _startTask(nilnul.fs.address_.ShieldI folder)
		{
			_startTask_ofAddress(folder.ToString());

		}
	}
}