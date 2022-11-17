using nilnul.fs;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src.sln
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

		//private void __Exe(
		//	string folder
		//)
		//{
		//	new sln_.nonlink.div_.nonlink_.intent.Bak(cfg).__Exe(folder);
		//}

		/// <summary>
		/// the instance of this will bak a shield inside sln in serial. 
		/// we can use this instace to bak a lot of slns. and these slns will run in parallel 
		/// </summary>
		/// <param name="folder"></param>
		public  void _StartTask(string folder)
		{
			///todo: schedule the sln according to last bak successful time;

			if (nilnul.fs.folder.dir.be_._SymlinkX.Be_ofAddress(folder))
			{
				new sln_.link.Bak4unjoint(_cfg).exe_ofAddress(folder);

			}
			else
			{
				new sln_.unjoint.Bak_srcsInAddresses(_cfg)._vod_ofAddress(folder);
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

		public  void _StartTask(FolderI folder)
		{
			_StartTask(folder.ToString());
		}
	}
}