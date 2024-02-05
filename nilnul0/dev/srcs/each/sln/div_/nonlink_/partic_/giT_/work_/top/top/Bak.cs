using nilnul.dev;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.partic_.intent_.git_.top
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
				new nilnul.dev.sln.div_.nonlink_.nonneglect_.giT_.work_.top.Bak(cfg)._void(folderAddress);
				//new sln.div_.module_.nonlink_.nonneglect.Bak(cfg)._void(folderAddress);
			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"{this.GetType().FullName}#.{nameof(Exe)}({folderAddress}) :" +e.ToString()
				);
				return ;
			}
		}
	}
}