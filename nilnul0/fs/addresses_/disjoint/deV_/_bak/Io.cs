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
using nilnul.fs.address_;
using nilnul.fs.folder.be;
using nilnul.obj.str;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace nilnul.fs.addresses_.disjoint.deV_._bak
{
	/// <summary>
	/// </summary>
	public class Io
	{
		private BlockingCollection<(string, DateTime)> _slnVisitingEs = new dev.srcs.each.sln_.delvable._bak.SlnVisitingEs().asBlockingCollection();

		public BlockingCollection<(string, DateTime)> slnVisitingEs
		{
			get
			{
				return _slnVisitingEs;
			}

		}

		private nilnul.dev.SrcsI_addresses _srcs;
		public nilnul.dev.SrcsI_addresses srcs
		{
			get { return _srcs; }
			set { _srcs = value; }
		}

		/// <summary>
		/// 
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

		/// <summary>
		/// including the src top. as the computing of eventual target is time-consuming, and we better compute it in advance.
		/// the key is destiny; the val is the src.
		/// </summary>
		private ConcurrentDictionary<nilnul.fs.AddressI,
			//nilnul.fs.address_.shield_.BaseDiv
			nilnul.fs.address_.ShieldI
			> _destinySrc = new ConcurrentDictionary<AddressI, ShieldI>();

		public ConcurrentDictionary<
			nilnul.fs.AddressI
			,
			//nilnul.fs.address_.shield_.BaseDiv
			nilnul.fs.address_.ShieldI

			> destinySrc
		{
			get { return _destinySrc; }
			set { _destinySrc = value; }
		}

		public event Action<string> notify;

		object _notifyLock = new object();
		public void onNotify(string msg)
		{
			///multiple thread may call this in parallel
			lock (_notifyLock)
			{
				notify?.Invoke(msg);

			}
		}

		object _destinyLock = new object();

		/// <summary>
		///  
		/// </summary>
		/// <param name="destiny">
		/// the tgt of the link
		/// </param>
		/// <param name="src">
		///
		/// </param>
		/// <returns>
		///		old entry with the given key. this old entry is null or valued.
		/// </returns>
		public KeyValuePair<AddressI, address_.ShieldI> addDestiny(
			nilnul.fs.AddressI destiny
			,
			nilnul.fs.address_.ShieldI src
		)
		{
			lock (_destinyLock)
			{
				var joint = _destinySrc.Where(
					k => nilnul.fs.address.re_.Joint.Singleton.re(destiny, k.Key)
				).FirstOrDefault();

				if (
					joint.Key is null
				)
				{
					_destinySrc.TryAdd(destiny, src);
					return joint;
				}
				else
				{
					return joint;  /// it's already coverred.
				}
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="en"></param>
		/// <returns>
		/// the old entry, the key of which is null if there is no old;
		/// </returns>
		internal KeyValuePair<AddressI, address_.ShieldI> _addDestiny_assumeLink(ShieldI en)
		{
			/// todo: xpn when link is invalid;
			///
			/// Let's see whether the tgt is valid
			///
			ShieldI en1 = null;

			try
			{
				en1 = nilnul.fs.folder_.link_.sym._DestinyX.Normal(en).en.address.en;

			}
			catch (Win32Exception ex)       /// System.ComponentModel.Win32Exception (0x80004005): 系统找不到指定的路径。
			{
				string element = $"{en} as symlink may have an invalid tgt: {ex.ToString()}";
				nilnul.app.trace._OfXmlX.TraceError(

					element
				);
				throw new InvalidOperationException(
					element
				);

			}
			catch (Exception x)
			{
				string element = $"unknown exception when parsing the tgt of {en}: {x.ToString()}";
				nilnul.app.trace._OfXmlX.TraceError(

					element
				);

				throw new InvalidOperationException(
					element
				);

			}

			return addDestiny(
				en1
				,

				en

			);



			///throw new nilnul.fs.location_.link_.sym_.

		}
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private KeyValuePair<AddressI, address_.ShieldI> _addDestiny_assumeLink(AddressI f1)
		{

			return _addDestiny_assumeLink(nilnul.fs.address_.shield_._AddressX1.Create(f1));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal KeyValuePair<AddressI, address_.ShieldI> _addDestiny_addressAssumeLink(string en)
		{ 
			return _addDestiny_assumeLink(nilnul.fs.address_.Shield.FroAddress(en));
		}

		public ConcurrentBag<string> modulesNewlyBaked = new ConcurrentBag<string>();

		public ConcurrentBag<string> shieldsNewlyBaked = new ConcurrentBag<string>();
		/*
		/// to align with how git processes symlinks, we here also treat symlink as a pseudo-file, not a directory. Hence there is no problem for loops.
		/// <summary>
		/// as we allow linked folders, we may fall into a loop.
		/// To avoid process the same folder twice, we keep record of the eventual target of each folder being visited. When we are going to visit a folder, we first check whether it has already been visited. If it's not, we insert it here and process it.
		///		note: we may insert the parent folder first. and later each subfolder.
		/// </summary>

		 public ConcurrentBag<string> nonlinkFolderBeingProcessed = new ConcurrentBag<string>();
		*/

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
			nilnul.dev.SrcsI_addresses srcs
			,
			nilnul.fs.address_.shields_.Disjoint shields2neglect
			,
			nilnul.fs.address_.shield.Set modules2neglect
			, int initialAvailable
			,
			int moreThanCores
			,
			CancellationToken cancel
			,
			win.prog_.Git git = null
		)
		{
			var addresses = srcs.addresses;

			/// we treat src_.folder_.nonlink specially due to that:
			///	 it's the topmost. each nontop dir can consider only itself as all the ancesters have been tackled. but for topmost src, it should self-complete its status as a tree.
			addresses.Each(
				f1 =>
				{
					if (nilnul.fs.address.be_.Folder.Singleton.be(f1))
					{
						if (
							nilnul.fs.folder.BeIX.Be(nilnul.fs.folder.be_.link_.Sym.Singleton, f1)
						)
						{
							//var old = this._addDestiny_assumeLink(
							//	f1
							//);
							KeyValuePair<fs.AddressI, ShieldI> old;
							try
							{
								old = _addDestiny_assumeLink(f1);
							}
							catch (InvalidOperationException ex)
							{
								nilnul.app.trace._OfXmlX.TraceError(

									nilnul.txt.op_.scule_._CapitalX.Capital(
										$"{f1}'s tgt might be invalid:{ex}"
									)
								);

								return;
							}



							if (old.Key is null)
							{
							}
							else
							{
								/// it's joint. But it's unknown which one is super.
								/// todo: shall we allow the super one to proceed? if so, will that bury the error that user is not informed and still think the src is disjoint?
								throw new InvalidOperationException($"{f1}'s target is joint with {old.Value}'s target {old.Key}");
							}
						}
						else
						{
							this.addDestiny(
								f1,
								nilnul.fs.address_.shield_._AddressX1.Create(f1)
							);
						}
					}
					else
					{
						Trace.TraceError($"{f1} as a src is not a folder");
					}


				}
			);

			_srcs = srcs;
			_shields2neglect = shields2neglect;
			_modules2neglect = modules2neglect;

			this.semaphore = new SemaphoreSlim(
				initialAvailable
				,
				initialAvailable + moreThanCores
			);


			_cancel = cancel;
			_git = git;

		}

		public Io(
			nilnul.dev.SrcsI_addresses srcs
			,
			nilnul.fs.address_.shields_.Disjoint shields2neglect
			,
			nilnul.fs.address_.shield.Set modules2neglect
			,
			int initialAvailable
			,
			CancellationToken cancel
			,
			win.prog_.Git git = null
		) : this(srcs, shields2neglect, modules2neglect, initialAvailable, 0, cancel)
		{


		}

		public Io(
			nilnul.dev.SrcsI_addresses srcs
			,
			nilnul.fs.address_.shields_.Disjoint shields2neglect
			,
			nilnul.fs.address_.shield.Set modules2neglect
			,
			CancellationToken cancel
			,
			win.prog_.Git git = null
		) : this(
			srcs
			, shields2neglect, modules2neglect
			,
			nilnul.dev.bak.Properties.Settings.Default.semaphore
			, cancel
		)
		{
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
		static public Io OfMoreThanCores(
			nilnul.dev.SrcsI_addresses srcs
			,
			nilnul.fs.address_.shields_.Disjoint shields2neglect
			,
			nilnul.fs.address_.shield.Set modules2neglect
			,
			int moreThanCores
			,
			CancellationToken cancel
			,
			win.prog_.Git git = null
		)
		{
			return new Io(
srcs
,
shields2neglect
,
modules2neglect
,
broughtOutResources
, moreThanCores
,
 cancel,
			 git);

		}

	}
}

