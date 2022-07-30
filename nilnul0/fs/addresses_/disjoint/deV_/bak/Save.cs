using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.addresses_.disjoint.deV_.bak
{
	public  class Save
	{

		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Save(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public Save(CancellationToken cancel, nilnul.win.prog_.Git git=null)
			: this(
	nilnul.fs.addresses_.disjoint.deV_._bak.io_._CfgX.Create(cancel, git)
)
		{

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_shieldsInAddresses_assumeDisjointAddresses">
		///
		/// </param>
		/// <param name="git"></param>
		public void exe(
			IEnumerable<string> _shieldsInAddresses_assumeDisjointAddresses
			//,
			//CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null)
		{
			var bak = new nilnul.fs.addresses_.disjoint.deV_.Bak(cfg);

			string shieldsTxt = nilnul.fs.address.str._PhraseX.Phrase(_shieldsInAddresses_assumeDisjointAddresses);

			Trace.TraceInformation($"begin baking :{shieldsTxt}...");

			try
			{

				/*Its CreationOptions property value is TaskCreationOptions.DenyChildAttach.*/
				System.Threading.Tasks.Task.Factory.StartNew(
					() => {
						bak._ShuffleAndBak(_shieldsInAddresses_assumeDisjointAddresses);
					}
					,
					cfg.cancel
					,
					TaskCreationOptions.AttachedToParent// don't use: | TaskCreationOptions.DenyChildAttach
					,
					TaskScheduler.Current //https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskfactory.scheduler?view=netframework-4.7.2 If this property value is null, the value of the Current property is used..
				).Wait(
					/*cancel*/
				);


				//WaitAll(cancel);
			}
			catch (AggregateException e)//the exceptions, including custom ones, of tasks, are all wrapped here.
			{
				//e.Flatten().Handle(x => {

				//}

				//);
				#region not necessary as errors are already logged one by one in place

				#endregion
				//foreach (Exception v in e.Flatten().InnerExceptions)
				//{
				//	if (v is TaskCanceledException)
				//	{
				//		Trace.TraceInformation("   TaskCanceledException: Task {0}",
				//						  ((TaskCanceledException)v).Task.Id);
				//	}
				//	else
				//	{
				//		Trace.TraceError($"exception when processing srcs: {shieldsTxt}: {e}");
				//	}
				//}
				Trace.TraceError($"exception when processing srcs: {shieldsTxt}: {e}");


			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing shields: {shieldsTxt}: {e}");
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when processing srcs: {shieldsTxt}: {e}");
			}
			Trace.TraceInformation($"end baking shields:{shieldsTxt}");

			Trace.TraceInformation($"saving settings:{shieldsTxt}");

			deV_._bak.io._SaveX.Save( cfg);

			Trace.TraceInformation($"saved settings:{shieldsTxt}");

		}

	
		//public  void exe(IEnumerable<string> shieldsInAddresses)
		//{
		//	exe(shieldsInAddresses);

		//}



	}
}
