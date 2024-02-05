using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src_.folder_.nonlink_.git_.nonRepo
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

		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		 public void Exe(
			nilnul.fs.FolderI folder
			)
		{
			Trace.TraceInformation($"baking src:{folder}");
			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				return;
			}
			//Trace.TraceInformation($"{nameof(Cfg.doneContainers)}:{Cfg.doneContainers}");

			if (
					cfg.isShieldBaked
					(folder.ToString())
			)
			{
				Trace.TraceInformation($" {folder} already done ");
			}
			else
			{
				new src_.folder_.nonlink_.git_.nonRepo_.incomplete.Bak(cfg).Exe(
					 folder
				);
			}
		}

		 public void Exe(
			string folder
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder));
		}
	}
}