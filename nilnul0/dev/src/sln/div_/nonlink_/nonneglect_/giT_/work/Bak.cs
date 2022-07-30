using nilnul.fs.folder;
using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.nonneglect_.intent_.giT_.work
{
	/// <summary>
	/// 
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
			_cfg = cfg;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void Exe(
			string folderAddress
		)
		{
			try
			{
				if (nilnul.fs.folder_.git_.work.be_._TopX.__Be_ofAddress(folderAddress))
				{
					new intent_.git_.top.Bak(cfg).Exe(folderAddress);
				}
				else///it cannot be ".git"
				{
					new intent_.git_.plain0Nontop.Bak(cfg).Exe(folderAddress);
				}
			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" + e.Message
				);
				throw;
				return;
			}
		}
	}
}