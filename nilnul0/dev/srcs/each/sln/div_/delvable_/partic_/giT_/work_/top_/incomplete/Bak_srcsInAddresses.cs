using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.addresses_.disjoint.deV_._bak;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_.incomplete
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


		[Obsolete()]
		private nilnul.fs.address_.ShieldI _module;

		[Obsolete()]
		private nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		/// <summary>
		/// for parent module
		/// </summary>
		[Obsolete()]
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		[Obsolete()]
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		[Obsolete()]
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg,  nilnul.fs.address_.ShieldI module)
			:this(cfg,new ConcurrentBag<DivI>(),new ConcurrentBag<DivI>(),module)
		{
			
		}
	public Bak_srcsInAddresses(Io cfg, string folderOfIntent) : this(
			cfg
			,
			nilnul.fs.address_.Shield.FroAddress(folderOfIntent)
		)
		{
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

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg):this(cfg,new ConcurrentBag<DivI>())
		{
			
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
			//string folder

		)
		{
			var folder = this._module.ToString();
			//new nilnul.dev.sln.div_.module_.nonlink_.nonneglect_.incomplete.Bak(_cfg)._exe(folder);
			//return;
			//var folderOnDisk = nilnul.fs.Folder.FroAddress(folder);

			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");

			cfg.cancel.ThrowIfCancellationRequested();


			/*When the parent cancels
If a parent cancels itself before its child task is started, the child never starts. If a parent cancels itself after its child task has already started, the child runs to completion unless it has its own cancellation logic. For more information, see Task Cancellation.*/
			//ConcurrentBag<nilnul.fs._address.DivI> innerModules = new ConcurrentBag<DivI>();
			//ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude = new ConcurrentBag<DivI>();

			var noErr = true;
			try
			{

				//this._cfg.onNotify($"{DateTime.Now.ToString()}: bakking the content of {folder}...");

				new _incomplete_.content.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude) { module=this._module}._exe();
				//this._cfg.onNotify($"{DateTime.Now.ToString()}: bakked the content of {folder}...");

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
				this.cfg.onNotify($"{DateTime.Now.ToString()}: bakking the container of {folder}...");

				new _incomplete_.container.Bak_srcsInAddresses(cfg)._exe(folder, innerModules, innerModules2reinclude);

				this.cfg.onNotify($"{DateTime.Now.ToString()}: bakked the container of {folder}...");


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

		static public void _Exe(
fs.addresses_.disjoint.deV_._bak.Io cfg, ShieldI parentModule, ConcurrentBag<DivI> innerModules4Parent,ConcurrentBag<DivI> innerModulesReinclude4Parent,

			string folder

		)
		{


			if (parentModule is not null)
			{
				innerModules4Parent.Add(
					nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
						parentModule
						,
						folder
					)
				);
			}

			new Bak_srcsInAddresses(cfg,folder)._exe();



		}

	}
}