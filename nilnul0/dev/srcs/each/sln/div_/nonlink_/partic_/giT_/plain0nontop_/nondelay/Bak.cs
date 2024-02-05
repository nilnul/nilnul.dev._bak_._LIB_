using nilnul.dev;
using nilnul.dev.srcs._bak;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.partic_.git_.plain0Nontop_.nondelay
{
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
		public void _Exe(
			string folder
		)
		{
			try	{

				if (
					nilnul.dev.sln.div.be_._IntendGitX.Be_ofAddress(folder,cfg.git)
			)
				{
					new plain0Nontop_.intent.Bak(cfg).Exe(folder);
				}
				else
				{
					new plain0Nontop_.nonIntent.Bak(cfg)._Exe(folder);

				}

				

			}
			catch (OperationCanceledException e)
			{
				Trace.TraceWarning($"operation cancelled when processing {this.GetType().FullName}: {folder}: {e}");
				throw;
			}

			catch (Exception e)
			{
				Trace.TraceError($"exception when baking {folder}:{e}");
			}

		}



	}
}
