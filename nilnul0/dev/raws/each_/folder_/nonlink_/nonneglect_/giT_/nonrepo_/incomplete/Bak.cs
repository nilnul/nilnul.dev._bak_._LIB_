using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder_.nonlink_.nonneg_.git_.nonRepo_.incomplete
{
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
			_cfg = cfg;
		}


		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		public  void Exe(
			nilnul.fs.FolderI folder
		)
		{

			Trace.TraceInformation($"baking src:{folder}");
			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				return;
			}



			//Trace.Indent(); //cached by thread


			foreach (fs.FolderI dir in

				nilnul.obj.str.op_.unary_._ShuffleX.Op(
					nilnul.fs.folder.dirs_._NonlinkX.Folders(folder)
				)
				
			)
			{
				if (cfg.cancel.IsCancellationRequested)
				{
					//Trace.Unindent();
					cfg.cancel.ThrowIfCancellationRequested();
				}
				new incomplete.dir_.nonlink.Bak(cfg).Exe(dir);
			}
			//Trace.Unindent();

			_cfg.shieldsNewlyBaked.Add(folder.address.ToString());
			//nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(folder.address.ToString());

		}

		public  void Exe(
			string folder
		)
		{
			Exe(
				nilnul.fs.Folder.FroAddress(folder)
			);
		}
		

	}
}
