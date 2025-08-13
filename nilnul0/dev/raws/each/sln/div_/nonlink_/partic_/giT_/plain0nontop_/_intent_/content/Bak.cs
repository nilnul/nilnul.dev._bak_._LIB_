#define BAK_SERIAL0
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.plain0Nontop_._intent_.content
{
	/// <summary>
	/// the content of the folder;
	///		including 
	///			".git",
	///			work.
	///				the work may be trivia (nothing but some appSettings such as cfg/ignore files).
	/// </summary>
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get => _cfg;
			set => _cfg = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;

		//	public nilnul.fs.address_.ShieldI module;

		private Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
			//_cfg = cfg;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Bak(Io cfg, ConcurrentBag<DivI> innerModules1) : this(cfg, innerModules1, new ConcurrentBag<DivI>())
		{
			//this.cfg = cfg;
			//this.innerModules = innerModules1;
		}

		public Bak(Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude)
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

			Trace.TraceInformation($@"baking {typeof(Bak).FullName}:{folder}...");

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
				foreach (string child in nilnul.fs.folder.dirs_.excludeVs_._NormalX.EnumerateAsAddresses(folder))
				{
					if (cfg.cancel.IsCancellationRequested)
					{
						Trace.TraceWarning($"cancelling {folder}");
						cfg.cancel.ThrowIfCancellationRequested();
						return;
						break;
					}
					new nilnul.dev.sln_.nonlink.directory_.nonlink_.git_.nonplain.Bak(cfg, innerModules, innerModules2reinclude)
					{
						module = nilnul.fs.address_.shield_._AddressX1.Create(folder)
					}._void(child);
				
				}
				Trace.TraceInformation($@"baked {typeof(Bak).FullName}:{folder}");

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception when enumerating directories (the content) of gitModuleUndone @ {typeof(Bak).FullName}.{nameof(_Exe)}({folder}):{e.Message}:{e.ToString()}");
				throw;
			}
			finally
			{
				Trace.Unindent();

			}


		}
	}
}
