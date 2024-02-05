using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.src.sln.div_.nonneglect_.unjoint_.giT_.work_.top_.incomplete
{
	/// <summary>
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI>())
		{
			this.cfg = cfg;
		}


		//	private ConcurrentBag<nilnul.fs._address.DivI> innerModules ;


		//private Bak(Io cfg, ConcurrentBag<DivI> innerModules)
		//{
		//	this.cfg = cfg;
		//	this.innerModules = innerModules;
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

		public void _exe(
			string folder

		)
		{
			//new nilnul.dev.sln.div_.module_.nonlink_.nonneglect_.incomplete.Bak(_cfg)._exe(folder);
			//return;
			//var folderOnDisk = nilnul.fs.Folder.FroAddress(folder);

			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");

			cfg.cancel.ThrowIfCancellationRequested();


			/*When the parent cancels
If a parent cancels itself before its child task is started, the child never starts. If a parent cancels itself after its child task has already started, the child runs to completion unless it has its own cancellation logic. For more information, see Task Cancellation.*/
			ConcurrentBag<nilnul.fs._address.DivI> innerModules = new ConcurrentBag<DivI>();
			ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude = new ConcurrentBag<DivI>();

			var noErr = true;
			try
			{
				new _incomplete_.content.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) {/* module=nilnul.fs.address_.shield_._AddressX1.Create(folder) */}._Exe(folder);

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (System.Exception)
			{
				noErr = false;

			}

			cfg.cancel.ThrowIfCancellationRequested();
			try
			{
				new _incomplete_.container.Bak_srcsInAddresses(cfg)._Exe(folder, innerModules, innerModules2reinclude);

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (System.Exception)
			{

				noErr = false;
			}

			if (noErr)
			{
				cfg.shieldsNewlyBaked.Add(folder);

			}


			Trace.TraceInformation($@"baked {this.GetType().FullName}:{folder}.");

			/*Because the task executes synchronously, there is no need to call a method such as Wait() to ensure that the calling thread waits for the task to complete.
			Note: you don't need to call Wait inside the continueWith; but you still need to Wait for the whole task (the antecedent together with ContinueWith) outside ContinueWith
			 */

			//Trace.Unindent();






		}
	}
}
