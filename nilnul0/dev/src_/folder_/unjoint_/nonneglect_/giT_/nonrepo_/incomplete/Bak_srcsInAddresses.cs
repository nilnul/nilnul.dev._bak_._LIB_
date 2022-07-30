using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder_.unjoint_.nonneglect_.giT_.nonrepo_.incomplete
{
	/// <summary>
	/// the src is nonrepo. If it's inside gitManaged, then the top of the src is still not regarded as a module, but as a plain folder, and only directories in src is dealt with.
	/// </summary>
	public  class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
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
					nilnul.fs.folder._DirsX.Folders(folder)
				)
				
			)
			{
				if (cfg.cancel.IsCancellationRequested)
				{
					//Trace.Unindent();
					cfg.cancel.ThrowIfCancellationRequested();
				}///semaphore here ?
				new nilnul.dev.src_.folder_.unjoint_.nonneglect_.giT_.nonrepo_.incomplete.dir.Bak_srcsInAddresses(cfg).exe(dir);
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
