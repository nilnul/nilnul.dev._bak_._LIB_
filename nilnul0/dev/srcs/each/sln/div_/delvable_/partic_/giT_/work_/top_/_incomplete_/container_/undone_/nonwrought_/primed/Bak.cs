#define BAK_SERIAL0
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.win.program_;

namespace nilnul.dev.srcs.each.sln.div_.delvable_.partic_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought_.primed
{
	/// <summary>
	/// </summary>
	public class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
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
			if (
				nilnul.fs.git.module.staged.be_.Empty._Be_byDiffCached_ofAddress(
					folder
					,
					git
				)
			)
			{
				return new primed_.stageClean.Bak(cfg)._exe(folder, cancel,git);
			}
			else
			{
				Trace.TraceError(
					$"{folder} stage is not clean."
				);
				return new primed_.stageDirty.Bak_srcsInAddresses(cfg)._exe(folder, cancel,git);
			}
		}
	}
}