using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src_.folder_.unjoint
{
	public  class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public void Exe(
			nilnul.fs.FolderI folder
		)
		{
			if (nilnul.fs.folder.be_.deV_.src_.bak_.neglect.Anto.Be(folder))
			{
				new folder_.unjoint_.nonneglect.Bak(cfg).exe(folder);
			}
			else
			{
				Trace.TraceWarning($"{folder} is configured to bak later.");
			}

			

		}


		public  void Exe(
			string folder
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder) );
		}

		

	}

}
