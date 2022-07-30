#define BAK_SERIAL0
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.win.program_;
using System.Linq;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought_.primed_.stageDirty
{
	/// <summary>
	/// </summary>
	public  class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) 
		{
			this._cfg = cfg;
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

		public bool _exe(
			string folder
			//,
			//ConcurrentBag<DivI> innerModules
			,
			 CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null
		)
		{
			try
			{
				var size = nilnul.fs.git.module.repo._SizeX.Kb_ofWorkDivAddress(folder);
				var sizeUlong = (ulong)size  * 1024;
				var g = nilnul.num_.radix_.binary_.Giga.ULONG;

				var limit=((ulong) nilnul.dev.bak.Properties.Settings.Default.warnIfOverG  ) *g;
				var limitHalf = limit / 2;

				if (sizeUlong >= limit) //10G
				{
					Trace.TraceError($"repo:{folder}'size ({size} Kb) is  bigger than { nilnul.dev.bak.Properties.Settings.Default.warnIfOverG }G(gitlab limmit)");
				}
				else if (sizeUlong >= limitHalf) {
					Trace.TraceError($"repo:{folder}'size ({size} Kb) is  bigger than half of limit; the limit is {  nilnul.dev.bak.Properties.Settings.Default.warnIfOverG  }G(gitlab limmit)");

				}

			}
			catch (Exception e)
			{
				Trace.TraceError($"exception:{e} when getting the size of {folder}");

			}

			var clients = nilnul.fs.git.Properties.SettingsX.client__noCred_Nameds.Select(c=>c.name);

			bool noErr = _bak_._UploadX._Void(
				folder
				,
				clients
				,
				cancel
				,
				git
			);

			if (noErr)
			{
				_cfg.modulesNewlyBaked.Add(folder);
			}

			return noErr;

		}
	}
}
