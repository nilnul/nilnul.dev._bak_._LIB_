using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.git.module;
//using nilnul.fs.folder;
namespace	nilnul.dev.		sln.div_.nonlink_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone

{
	/// <summary>
	/// use this when you want to bak this module only (not to bak any modules in below)
	/// </summary>
	///
	[Obsolete(
		nameof(
			nilnul.dev.src.	sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone.Bak_srcsInAddresses)
		,true

	)]
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
		public void _exe(
			string folder
						,
			ConcurrentBag<DivI> innerModules
			,
			ConcurrentBag<DivI> innerModules2reinclude

		)
		{

			bool isUnlocked = false;
			var waitInbetween = 5000;
			var tryingTimes = 10;
			try
			{
				nilnul.fs.git.module.repo.unlock_.wait._TimeoutX._TimeoutAsTask_addressAssumeModule(folder).Wait();

			}
			catch (Exception)
			{
				Trace.TraceError(

					$"after checking {tryingTimes} time at a time interval of {waitInbetween} milliseconds,  {folder} is all the way locked. backup will not be done on this repo."
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
			//	return;

			//}


			/// ensure (only touch it if not done)
			nilnul.fs.git.module.repo.cfg.section_.core.Longpaths.SetTrue_ofAddress(folder);

			nilnul.fs.git.module._ignore_.exclude.put._IfLinesNonemptyX.Void_ofModuleAddress(folder, innerModules);

			nilnul.fs.git.module._ignore_.exclude.unput._IfLinesNonemptyX._OfModuleAddress(folder, innerModules2reinclude.Select(x => x.ToString()));


			_exe(folder


				);


		}

		public void _exe(
			string folder




		)
		{
			///whether to touch ".gitignore"
			///


			if (nilnul.fs.git.module.be_.dev_.NothingButSetting.Singleton.Be_ofAddress(folder))
			{
				new nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought.Bak_srcsInAddresses(_cfg)._exe(folder); //no need to pass in the parameters: innerModules and innerModules2reinclude, as have already been done by caller.
			}
			else
			{
				new undone_.wrought.Bak_srcsInAddresses(_cfg)._exe(folder);
			}


		}

	}
}
