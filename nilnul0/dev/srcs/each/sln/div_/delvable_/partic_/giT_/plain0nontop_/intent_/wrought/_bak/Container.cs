using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.plain0nontop_.intent_.wrought._bak
{
	/// <summary>
	/// 
	/// </summary>
	public class Container
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

		internal Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		 Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}
		private Container(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		private Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		///
		[Obsolete()]
		public void Exe(
			string folderAddress
		)
		{


			CancellationToken cancel = cfg.cancel;
			win.prog_.Git git = cfg.git;




			try
			{




				//cancel.ThrowIfCancellationRequested();

				//new nonneglect_.giT_.work_.top_.incomplete_.moduleUndone.Bak(cfg, innerModules, innerModules) {module=this.module }._Exe(folderAddress);


				cancel.ThrowIfCancellationRequested();
				_container._IniX.Setup(folderAddress, git);
				cancel.ThrowIfCancellationRequested();



			}


			//catch (OperationCanceledException ex)
			//{
			//	throw;
			//}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} by init as a git repo :" + e.Message
				);
				throw;
			}


			nilnul.fs.git.module._ignore_.exclude.put._IfLinesNonemptyX.Void_ofModuleAddress(folderAddress, innerModules);

			nilnul.fs.git.module._ignore_.exclude.unput._IfLinesNonemptyX._OfModuleAddress(folderAddress, innerModules2reinclude.Select(x => x.ToString()));


			///// todo: reset the innerModules

			//this.innerModules = new ConcurrentBag<DivI>();
			//this.innerModules2reinclude = new ConcurrentBag<DivI>();

			new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_._incomplete_.container_.undone_.wrought.Bak_srcsInAddresses(cfg)._exe(
				folderAddress
			);



		}

		public void _bak(
		)
		{


			CancellationToken cancel = cfg.cancel;
			win.prog_.Git git = cfg.git;


			string folderAddress = this.module.ToString();


			try
			{




				//cancel.ThrowIfCancellationRequested();

				//new nonneglect_.giT_.work_.top_.incomplete_.moduleUndone.Bak(cfg, innerModules, innerModules) {module=this.module }._Exe(folderAddress);


				cancel.ThrowIfCancellationRequested();

				_container._IniX.Setup(folderAddress, git);
				cancel.ThrowIfCancellationRequested();



			}


			//catch (OperationCanceledException ex)
			//{
			//	throw;
			//}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {this.module} by init as a git repo :" + e.Message
				);
				throw;
			}


			nilnul.fs.git.module._ignore_.exclude.put._IfLinesNonemptyX.Void_ofModuleAddress(folderAddress, innerModules);

			nilnul.fs.git.module._ignore_.exclude.unput._IfLinesNonemptyX._OfModuleAddress(folderAddress, innerModules2reinclude.Select(x => x.ToString()));


			///// todo: reset the innerModules

			//this.innerModules = new ConcurrentBag<DivI>();
			//this.innerModules2reinclude = new ConcurrentBag<DivI>();

			new nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_._incomplete_.container_.undone_.wrought.Bak_srcsInAddresses(cfg)._exe(
				folderAddress
			);



		}
	}
}