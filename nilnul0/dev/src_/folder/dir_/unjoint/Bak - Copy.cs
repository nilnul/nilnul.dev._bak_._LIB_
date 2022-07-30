using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.src_.folder.dir_.unjoint
{
	public class Bak_srcsInAddresses
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
		 public void Exe(
			nilnul.fs.FolderI folder
		)
		{
			// from the name by convention 
			// or from a config file

			if (
				folder.address.en.stem.div.dirs.Last().denote.en.StartsWith(".")
				||
				IsSlnNameBlank(folder)
			)
			{
				Trace.TraceInformation(
					$" the src.dir:{folder.ToString()} 's name starts with dot (meanig it's a concealed folder) or is blank (it's notation folder for comment purpose only)."
				);
			}
			else
			{
				///the parent is nonneglected; but that doesnot mean the dir is nonneglected
				new src.sln_.unjoint.Bak_srcsInAddresses(cfg)._vod(folder);

			}
		}

		static public bool IsSlnNameBlank(nilnul.fs.FolderI folder) {
			return nilnul.dev.src.sln.name.be_._BlankX._Be_assumeSln(folder);

			
		}

		 public void Exe(
			string folder
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder));
		}


	}

}
