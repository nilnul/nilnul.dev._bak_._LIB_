using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using nilnul.fs.address_.shield;


namespace nilnul.fs.address_.shields.dev_._bak
{
	/// <summary>
	/// </summary>
	public class Io
	{
		private nilnul.dev.SrcsI3 _srcs;
		public nilnul.dev.SrcsI3 srcs
		{
			get { return _srcs; }
			set { _srcs = value; }
		}

		/// <summary>
		/// </summary>
		private nilnul.fs.address_.shields_.Disjoint _shields2neglect;
		public nilnul.fs.address_.shields_.Disjoint shields2neglect
		{
			get { return _shields2neglect; }
			set { _shields2neglect = value; }
		}

		/// <summary>
		/// when bak is run last time, it might be incomplete. some modules are baked last time, and need to be neglected.
		/// These modules are initiated before the start of this run of baking.
		/// </summary>
		private nilnul.fs.address_.shield.Set _modules2neglect;
		public nilnul.fs.address_.shield.Set modules2neglect
		{
			get { return _modules2neglect; }
			set { _modules2neglect = value; }
		}


		private CancellationToken _cancel;
		public CancellationToken cancel
		{
			get { return _cancel; }
			set { _cancel = value; }
		}

		private nilnul.win.prog_.Git _git;

		public nilnul.win.prog_.Git git
		{
			get { return _git; }
			set { _git = value; }
		}

		 public ConcurrentBag<string> modulesNewlyBaked = new ConcurrentBag<string>();

		 public ConcurrentBag<string> shieldsNewlyBaked = new ConcurrentBag<string>();

		/// <summary>
		/// the available resources
		/// </summary>
		private static int broughtOutResources = nilnul.dev.bak.Properties.SettingsX.Semaphore;

		/// <summary>
		/// for error margin
		/// </summary>
		private const int preserved_resources = 0;

		/// <summary>
		/// total resources = available resources + occupiedResources
		/// </summary>
		//private  int maxResources = initialResources + preoccupied_resources;

		internal SemaphoreSlim semaphore;// = new SemaphoreSlim(initialResources, maxResources);


		public Io(
			nilnul.dev.SrcsI3 srcs
			,
			nilnul.fs.address_.shields_.Disjoint shields2neglect
			,
			nilnul.fs.address_.shield.Set modules2neglect
			,
			int semaphore
			,
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			_srcs = srcs;
			_shields2neglect = shields2neglect;
			_modules2neglect = modules2neglect;

			this.semaphore=new SemaphoreSlim(broughtOutResources, broughtOutResources+semaphore);
			_cancel = cancel;
			_git = git;

		}

		

		/// <summary>
		/// is shield baked last time?
		/// </summary>
		/// <param name="shieldAddress"></param>
		/// <returns></returns>
		 public bool isShieldBaked(string shieldAddress)
		{
			

			return 
				new nilnul.fs.address_.shield.collection_.Cover(shields2neglect.ee).Contain_ofAddress(shieldAddress);
		}


		/// <summary>
		/// is module baked last time?
		/// </summary>
		/// <param name="shieldAddress"></param>
		/// <returns></returns>
		 public bool isModuleBaked(string shieldAddress)
		{
			//return nilnul.fs.address_.shield.set._HasX.Bit_ofAddresses(
			//		modulesBaked
			//		,
			//		(shieldAddress)
			//);

			return 
				modules2neglect.contain_ofAddress(
				shieldAddress
			);
		}
	}
}

