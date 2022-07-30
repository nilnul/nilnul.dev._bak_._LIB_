using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;
using nilnul.fs._address;
using nilnul.fs.address_.shields.dev_._bak;
using nilnul.fs.git.module;
using static nilnul.fs.git.module.BeX;

namespace nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought
{
	/// <summary>
	/// for nonwroung:
	///		no need to add current to index.
	///		we check whether any in index is not added.
	///			if something is added but not commited., a warning is issued.
	///			if all commited, a warning is not issued.
	/// </summary>
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI>())
		{
			this.cfg = cfg;
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


		)
		{
			var cancel = cfg.cancel;
			var git = cfg.git;

			Trace.TraceInformation($"in {this.GetType().FullName} {nameof(_exe)}  for {folder} ");




			nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.nonwrought._bak_._PrimeX._Exe(folder, cancel, git);



			if (
				new nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top_._incomplete_.container_.undone_.primed.Bak_srcsInAddresses(_cfg)._exe(folder, /*innerModules,*/ cancel, git)
			)
			{
				Trace.TraceError(
					$"{folder} is clearable as all pushed to at least {nilnul.dev.bak.Properties.Settings.Default.pushErrsAsWarningIfSuccessesGe} or all remotes"
				);
				///todo: delete
			}



		}
	}
}
