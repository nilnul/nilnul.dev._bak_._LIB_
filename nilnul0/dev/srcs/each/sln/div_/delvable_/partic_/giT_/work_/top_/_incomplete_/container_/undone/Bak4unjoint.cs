using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.git.module;
//using nilnul.fs.folder;
namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_._incomplete_.container_.undone

{
	/// <summary>
	/// use this when you want to bak this module only (not to bak any modules in below)
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		//public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI>())
		{
			this.cfg = cfg;
		}

		//public Bak(Io cfg, ConcurrentBag<DivI> innerModules)
		//{
		//	this.cfg = cfg;
		//	this.innerModules = innerModules;
		//}

		//[Obsolete("",true)]
		internal void _exe(
			string folder
		)
		{
			///whether to touch ".gitignore"
			///

			if (
				nilnul.fs.git.module.be_.Nonwrought.Singleton._Be_assumeWorkbaseAddress(folder)
			)
			{
				new container_.undone_.nonwrought.Bak_srcsInAddresses(_cfg)._exe(folder); //no need to pass in the parameters: innerModules and innerModules2reinclude, as have already been done by caller.
				return;
			}

			new undone_.wrought.Bak_srcsInAddresses(_cfg)._exe(folder);
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
		/// </returns>
		/// 
		static public void _Exe(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg,
			string folder
						,
			ConcurrentBag<DivI> innerModules
			,
			ConcurrentBag<DivI> innerModules2reinclude
		)
		{
			//bool isUnlocked = false;
			//var waitInbetween = 5000;
			//var tryingTimes = 10;
			var duration = 7 * 60 * 1000;

			try
			{
				nilnul.fs.git.depo.repo.vow_.unlocked_.watch_.due._ForceX._AsTask_0depo(folder, duration).GetAwaiter().GetResult();

			}
			catch (Exception)
			{
				Trace.TraceError(

					$"after waiting for {duration} milliseconds,  {folder} is all the way locked. backup will not be done on this repo."
				);
				return;

			}


			//for (int i = 0; i < tryingTimes; i++)
			//{
			//	if (
			//		isUnlocked = nilnul.fs.git.module.be_.locked.Anto.Singleton._Be_assumeWorkbaseAddress(folder))
			//	{
			//		break;
			//	}
			//	else
			//	{
			//		Thread.Slep(waitInbetween);
			//	}
			//}

			//if (!isUnlocked)
			//{
			//	Trace.TraceError(

			//		$"after checking {tryingTimes} time at a time interval of {waitInbetween} milliseconds,  {folder} is all the way locked. backup will not be done on this repo."
			//	);
			//	nilnul.fs.git.module.repo._UnlockX._ByRename_moduleAssumeAddress(folder);

			//	//return;
			//}

			/// ensure (only touch it if not done)
			nilnul.fs.git.module.repo.cfg.section_.core.Longpaths.EnsureTrue_ofAddress(folder);

			nilnul.fs.git.module._ignore_.exclude.put._IfLinesNonemptyX.Void_ofModuleAddress(folder, innerModules);

			nilnul.fs.git.module._ignore_.exclude.unput._IfLinesNonemptyX._OfModuleAddress(folder, innerModules2reinclude.Select(x => x.ToString()));

			new Bak_srcsInAddresses(cfg)._exe(
				folder
			);
		}
	}
}