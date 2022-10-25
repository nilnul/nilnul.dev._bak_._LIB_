#define BAK_SERIAL0
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Linq;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.content
{
	/// <summary>
	/// the content of the folder;
	///		including 
	///			".git",
	///			work.
	///				the work may be trivia (nothing but some appSettings such as cfg/ignore files).
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		//	public nilnul.fs.address_.ShieldI module;

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1) : this(cfg, innerModules1, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules1;
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
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

			Trace.TraceInformation($@"bakking {typeof(Bak_srcsInAddresses).FullName}:{folder}...");

			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cfg.cancel.ThrowIfCancellationRequested();
				return;// false;
			}

			Trace.Indent();
			win.prog_.Git git = cfg.git;
			try
			{
				var unlisted = nilnul.fs.folder.dnts_._neglect._cfg_.doc_._DefaultX.Captions_ofAddress(folder);

				foreach (var dir in nilnul.fs.folder.dirs_._ArtisanX.Dirs_ofAddress(folder))
				{
					var dnt = dir.denote.en;

					//if (
					//	unlisted.Contains(
					//		dnt
					//		,
					//		nilnul.txt.eq_.CaseInsensitive.Singleton
					//	)
					//)
					//{
					//	continue;
					//}

					var child = System.IO.Path.Combine(folder, dnt);

					if (cfg.cancel.IsCancellationRequested)
					{
						Trace.TraceWarning($"cancelling {folder} at child:{child}");
						cfg.cancel.ThrowIfCancellationRequested();
						return;
						break;
					}

					new nilnul.dev.src.sln.directory_.giT_.nonplain.Bak_srcsInAddresses(cfg, innerModules, innerModules2reinclude)
					{
						module = nilnul.fs.address_.shield_._AddressX1.Create(folder)
					}._void(
						child
					);

				}
				Trace.TraceInformation($@"baked {typeof(Bak_srcsInAddresses).FullName}:{folder}");

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when enumerating directories (the content) of gitModuleUndone @ {typeof(Bak_srcsInAddresses).FullName}.{nameof(_Exe)}({folder}):{e.Message}:{e.ToString()}");
				throw;
			}
			finally
			{
				Trace.Unindent();

			}


		}
	}
}
