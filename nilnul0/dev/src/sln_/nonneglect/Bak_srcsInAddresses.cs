﻿using nilnul.fs;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonneglect
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		 public void __Exe(
			string folder
		)
		{
			new sln_.nonlink.div_.nonlink_.nonneglect_.intent.Bak_srcsInAddress(cfg).Exe(folder);
		}

		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public  void _StartTask(string folder)
		{
			Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- starting task");

			Task.Factory.StartNew(
				() =>
				{
					Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- in task- waiting semaphore");


					cfg.semaphore.Wait(cfg.cancel);
					try
					{
						__Exe(folder);
						
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

			Trace.TraceInformation($"{(this.GetType().FullName)}.{nameof(_StartTask)}({folder})  --- started task");


		}

		public  void _StartTask(FolderI folder)
		{
			_StartTask(folder.ToString());
		}
	}
}