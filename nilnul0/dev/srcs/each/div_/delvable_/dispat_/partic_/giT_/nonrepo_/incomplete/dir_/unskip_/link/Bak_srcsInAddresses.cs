using nilnul.dev.srcs._bak;
using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.div_.delvable_.dispat_.partic_.giT_.nonrepo_.incomplete.dir_.unskip_.link
{
	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI src { get; internal set; }
		public Div div { get; internal set; }
		public IEnumerable<string> cognom { get; internal set; }

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public void _exe(
		   nilnul.fs.folder_.ParentDir folder
	   )
		{
			var key = _cfg._addDestiny_assumeLink(folder.address.en).Key;

			if (key is null)
			{
				new dir_.unskip_.unjoint.Bak_srcsInAddresses(_cfg) { src = this.src, div = this.div }.exe(folder);
				return;

			}

			Trace.TraceError(
				$" the src.dir:{folder.ToString()} is link and its destiny is already being bakked by {key}."
			);


		}


		/// <summary>
		/// return newly 
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="cancel"></param>
		/// <param name="git"></param>
		/// <returns>newly baked</returns>
		public void exe(
		   nilnul.fs.FolderI folder
	   )
		{

			_exe(new nilnul.fs.folder_.ParentDir(folder));

			//if (
			//	folder.address.en.stem.div.dirs.Last().denote.en.StartsWith(".")
			//	||
			//	IsSlnNameBlank(folder)
			//)
			//{
			//	Trace.TraceInformation(
			//		$" the src.dir:{folder.ToString()} 's name starts with dot (meanig it's a concealed folder) or is blank (it's notation folder for comment purpose only)."
			//	);
			//}
			//else
			//{
			//	///the parent is nonneglected; but that doesnot mean the dir is nonneglected
			//	new sln_.nonlink.Bak_srcsInAddresses(cfg)._StartTask(folder);

			//}
		}



		public void exe_ofAddress(
		   string folder
	   )
		{
			exe(nilnul.fs.Folder.FroAddress(folder));
		}


	}

}
