#define BAK_SERIAL0
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.plain_._intent_.dir
{
	/// <summary>
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

		private nilnul.fs.address_.ShieldI _module;
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

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

		public void _void(
			string folder
		)
		{

			//Trace.TraceInformation($@"baking {typeof(Bak).FullName}:{folder}...");

			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				cfg.cancel.ThrowIfCancellationRequested();
				return;// false;
			}

			win.prog_.Git git = cfg.git;


			if (nilnul.fs.folder.be_.git_.Work.Singleton.be_ofAddress(folder))
			{
				if (_module!=null)
				{
					innerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							_module
							,
							folder
						)
					);
				}
				try
				{
					new sln.div_.nonlink_.nonneglect_.giT_.work_.top.Bak(cfg) {}._void(folder);

				}
				catch (System.Exception e)
				{
					Trace.TraceError($"when processing module{folder}:{e}");
					
				}
			}
			else  //plain
			{
				if (nilnul.dev.sln.div.be_._IntendGitX.Be_ofAddress(folder, cfg.git)
)
				{
					if (_module!=null)
					{
						innerModules.Add(
							nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
								_module
								,
								folder
							)
						);
					}
					try
					{
						new sln.div_.nonlink_.nonneglect_.giT_..work_.top.Bak(cfg) {}._void(folder);

					}
					catch (System.Exception e)
					{
						Trace.TraceError($"when processing module{folder}:{e}");
					
					}

				}
				new sln.div_.nonlink_.nonneglect_.giT_.plain0Nontop_._intent_._content_.dir_.plain.Bak(cfg, innerModules, innerModules2reinclude).__Exe(folder);
			}

			//Trace.TraceInformation($@"baked {typeof(Bak).FullName}:{folder}");




		}
	}
}
