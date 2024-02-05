﻿#define BAK_SERIAL0
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.win.program_;

namespace nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought_.primed
{
	/// <summary>
	/// </summary>
	public class Bak
	{
		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}
		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
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

				if (size > nilnul._dev_._bak_._LIB_.Properties.Settings.Default.warnIfOverG * 1024 * 1024) //10G
				{
					Trace.TraceError($"repo:{folder}'size ({size} Kb) is near or bigger than 10G(gitlab limmit)");
				}
			}
			catch (Exception e)
			{
				Trace.TraceError($"exception:{e} when getting the size of {folder}");

			}


			bool noErr = _bak_._UploadX._Void(folder, /*innerModules,*/ cancel, git);

			if (noErr)
			{
				_cfg.modulesNewlyBaked.Add(folder);
			}

			return noErr;

		}
	}
}
