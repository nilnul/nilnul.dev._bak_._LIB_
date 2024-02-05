using nilnul.fs._address;
using System.Collections.Concurrent;
using System.Diagnostics;
using nilnul.fs.folder;

namespace nilnul.dev.sln.div_.module_.nonlink_.nonneglect_.incomplete
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

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)//:this(cfg,new ConcurrentBag<DivI>())
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
			if (nilnul.fs.git.module.be_.Clear.Singleton.Be_ofAddress(folder))
			{
				new incomplete_.cleared.Bak(_cfg)._exe(folder);
			}
			else
			{
				new incomplete_.noncleared.Bak(_cfg)._exe(folder);
			}
		}
	}
}
