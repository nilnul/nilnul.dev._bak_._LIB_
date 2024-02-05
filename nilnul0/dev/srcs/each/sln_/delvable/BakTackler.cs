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


		//private nilnul.fs.address_.ShieldI _module;
		//public nilnul.fs.address_.ShieldI module
		//{
		//	get => _module;
		//	set => _module = value;
		//}

		[Obsolete()]
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		[Obsolete()]
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		[Obsolete()]
		private BakTackler(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			//this._module = module;
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
		private void _vod_0folderPartic(string folder)
		{
			
				new dev.srcs.each.sln_.delvable_.partic.Bak_srcsInAddresses(cfg)._vod_ofAddress(folder);
			
		}

		private void _vod_0folderPartic(ShieldI shield)
		{
			_vod_0folderPartic(shield.ToString());
		}

		private void _vod_0folderPartic(FolderI folder)
		{
			_vod_0folderPartic(folder.ToString());
		}


		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public void _startTask_ofAddress(string folder)
		{
			if (nilnul.fs.folder.be_.deV_.baK_._NonparticipantX.Be_ofAddress(folder))
			{
				/// todo: move this out of task.
				Trace.TraceWarning($"{folder} is not participating;");
				return;
			}

			new delvable_.partic.BakTackler(_cfg)._startChildTask_0partic(folder);
			return;

			Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- starting task");
			/// due to that:
			///		the semaphore is released after the task started, so the tasks are kept being started
			var waited = cfg.semaphore.Wait(
				10 * 60 * 1000/* when this time duration is set too short, the popped up windows would be too many;and when we handle them manually, new window would be popped out, increasing the total number of windows; So when we mannually handle a window, the new window shall not be popped out before we finish one; thus, supposing we need 10minuts to handle one window, the time here shall be set 10m
				               * we generally run the program at night and artificially monitor it the next day; soe the total number of popup windows shall be not too much; We shall control the number of popups per hour in a trivia number, eg: 10minutes would make 6per hour; 
				               And the next day we can cancel the running process  (or set a flag or new timespan for nonsephamore process ), and the popups are grouped in os taskbar; if the number is too much, they are forming a menu; if the number is not too much, they are forming a row of miniature windows, and this would make it easy to be monitored whether it's waiting4input;
				               */

							 // or use the avg time of each task; the initial time can be 0, memicing the avg 0/0=0;
				// make this half the avg time; but don't start too many programs at a time as that would crash the os;
				, cfg.cancel
			); 

			if (!waited)
			{
				Task.Factory.StartNew(
					() =>
					{
						Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- in task- outside semaphore");
						_vod_0folderPartic(folder);
						Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- in task - outside semaphore done;");
					}
					,
					cfg.cancel
					,
					TaskCreationOptions.AttachedToParent
					,
					TaskScheduler.Current //TaskScheduler

				).ContinueWith(
					(t) =>
					{
						Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- task continueing outside semaphore");

						try
						{
							nilnul.fs.folder.cfg.bak.visited._AppendX.Vod_folderOfAddress(folder);
						}
						catch (System.Exception e)
						{
							Trace.TraceError($"when configing baked.time for {folder} there is exception:{e}; (see rethrown exception); this may indicate that the folder is not a git module, and no '.git' subfolder is found inside.");
							//throw;
						}
						//cfg.shieldsNewlyBaked.Add(folder); // as is already done in module bak
						Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- task continued outside semaphore");
					}
					, cfg.cancel //bubbel up
					,
					TaskContinuationOptions.NotOnCanceled /*even if it's faulted; as err has been traced*/
					| TaskContinuationOptions.ExecuteSynchronously
					| TaskContinuationOptions.AttachedToParent
					,
					TaskScheduler.Current/*where ExecuteSynchronously continuations won’t run synchronously is when the target scheduler doesn’t allow it.  A TaskScheduler has the ability to say whether tasks are able to run on the current thread or not.  */
				);

				Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- started task outside semaphore");

				return;
			}

			Task.Factory.StartNew(
				() =>
				{
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_startTask)}({folder})  --- in task- waiting semaphore");

					//cfg.semaphore.Wait(cfg.cancel);
					try
					{
						_vod_0folderPartic(folder);
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
				TaskContinuationOptions.NotOnCanceled /*even if it's faulted; as err has been traced*/
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