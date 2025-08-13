#define BAK_SERIAL0
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.win.program_;

namespace nilnul.dev.sln.div_.giT_.module_.nonlink_.nonneglect_._incomplete_.container_.undone_.primed_.cleared
{
	/// <summary>
	/// </summary>
	/// 
	[Obsolete(nameof(sln.div_.module_.nonlink_.nonneglect_.incomplete_.cleared.Bak))]
	public  class Bak
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

		public void _exe(
			string folder
			,
			ConcurrentBag<DivI> innerModules
			,
			 CancellationToken cancel
			,
			nilnul.win.prog_.Git git = null
		)
		{
			new sln.div_.module_.nonlink_.nonneglect_.incomplete_.cleared.Bak(_cfg)._exe(folder, innerModules,cancel,null); ;

			var size = nilnul.fs.git.module.repo._SizeX.Kb_ofWorkDivAddress(folder);

			if (size > 10*1024*1024 /12) //10G
			{
				Trace.TraceError($"repo:{folder} is near or bigger than 10G(gitlab limmit)");
			}

			

		}
	}
}
