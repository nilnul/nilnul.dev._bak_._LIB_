using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.git_.work_.top_.incomplete.bak_
{
	/// <summary>
	/// </summary>
	public class KeepInnerModules
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ConcurrentBag<nilnul.fs._address.DivI2> innerModules=new ConcurrentBag<fs._address.DivI2>();


		public KeepInnerModules(nilnul.fs.address_.shields.dev_._bak.Io cfg)
		{
			_cfg = cfg;
		}

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

		public void _Exe(
			string folder
			
		)
		{
			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_Exe)}  for {folder} ");

			cfg.cancel.ThrowIfCancellationRequested();


			/*When the parent cancels
If a parent cancels itself before its child task is started, the child never starts. If a parent cancels itself after its child task has already started, the child runs to completion unless it has its own cancellation logic. For more information, see Task Cancellation.*/


			new _incomplete_.content.Bak(cfg,innerModules)._Exe(folder);

			cfg.cancel.ThrowIfCancellationRequested();

			new _incomplete_.container.Bak(cfg)._Exe(folder,innerModules);

			cfg.shieldsNewlyBaked.Add(folder);

			Trace.TraceInformation($@"baked {this.GetType().FullName}:{folder}.");

			/*Because the task executes synchronously, there is no need to call a method such as Wait() to ensure that the calling thread waits for the task to complete.
			Note: you don't need to call Wait inside the continueWith; but you still need to Wait for the whole task (the antecedent together with ContinueWith) outside ContinueWith
			 */

			//Trace.Unindent();






		}
	}
}
