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

namespace nilnul.dev.src_.folder_.unjoint_.nonneglect_.giT_.nonrepo_.incomplete.dir_.unjoint
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

			//if (
			//	folder.address.en.stem.div.dirs.Last().denote.en.StartsWith(".")

			//)
			//{
			//	Trace.TraceInformation(
			//		$" the src.dir:{folder.ToString()} 's name starts with dot (meanig it's a concealed folder) or is blank (it's notation folder for comment purpose only)."
			//	);
			//	return;
			//}
			fs._address.DirI dir = folder.address.en.stem.div.dirs.Last();
			lang_.cognom._tex.symbol_.MainI segs;
			try
			{

				 segs = nilnul.lang_.cognom._TexX.Parse(dir.denote.en);
			}
			catch (System.Exception e)
			{
				Trace.TraceError(
					$"{dir} in {folder} cannot be parsed as cognomen: {e}"
				);
				return;
				//throw;
			}

			if (!segs.segs.Any())
			{
				new nilnul.dev.src.div_.cognable_.empty.Bak(this._cfg) {
					src=this.src
					,
					div=this.div
					,
					cognom=this.cognom
				}.vod(
					//folder
				);
				return;
			}
				///the parent is nonneglected; but that doesnot mean the dir is nonneglected
			new src.sln_.unjoint.Bak_srcsInAddresses(cfg){
					
				}._vod(folder);

			
		}

		static public bool IsSlnNameBlank(nilnul.fs.FolderI folder) {

			return nilnul.txt.be_.White.Singleton.be(
				nilnul.fs.folder._repoName.dir.name_.idioms0Comments._ParseX.Parse(
					folder.address.en.stem.div.dirs.Last().denote.ToString()
				).name
			);
		}

		 public void Exe(
			string folder
		)
		{
			Exe(nilnul.fs.Folder.FroAddress(folder));
		}


	}

}
