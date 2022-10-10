using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.plain0nontop_.intent_.wrought._bak
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

		public Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Container(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Container(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
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
			new nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone.Bak_srcsInAddresses(cfg)._exe(folderAddress, innerModules, innerModules2reinclude);



		}
	}
}