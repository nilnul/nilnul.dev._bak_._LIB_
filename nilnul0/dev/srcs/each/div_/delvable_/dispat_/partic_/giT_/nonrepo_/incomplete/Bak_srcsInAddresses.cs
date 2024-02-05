using nilnul.fs._address;
using nilnul.fs.address_;
using nilnul.fs.folder.cfg.hier_.neglect;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.dev.srcs.each.div_.delvable_.dispat_.partic_.giT_.nonrepo_.incomplete
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
		public  void vod(
			//nilnul.fs.FolderI folder
		)
		{

			var shield = new nilnul.fs.address_.shield_.BaseDiv(
				src
				,
				div
			);

			var folder = new nilnul.fs.Folder(shield);
			Trace.TraceInformation($"baking src:{folder}");
			if (cfg.cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelling {folder}");
				return;
			}

			//Trace.Indent(); //cached by thread

			//var regex= _MaximalX.Regexes(folder);


			//var unlisted = nilnul.fs.folder.dsts_.visible_._iterand._DisownX.._DisownX._IsDelisted_0dst().dirs_.._neglect._cfg_.doc_._DefaultX.Captions(folder)			;



			foreach ( //fs.FolderI
				var dir1 in

				nilnul.obj.str.op_.unary_._ShuffleX.Op(
					nilnul.fs.folder.dirs_.unclave_.unnegle_.unvsgen_.baK_._UnSkippedX._Infos_0folder
					//Folders

					(folder)
				)
				
			)
			{

				var dnt = dir1.Name;

				//if (
				//	regex.Any(
				//		r=>r.IsMatch(
				//			dnt
				//		)
				//	)
				//)
				//{
				//	continue;
				//}
				//if (nilnul.fs.folder.dir.be_.deV_.baK_._unchart._PerNameX._Be_0dnt(dnt))
				//{
				//	continue;

				//}


				var child = dir1.FullName;// System.IO.Path.Combine(folder.address.en.ToString(), dnt);

				if (cfg.cancel.IsCancellationRequested)
				{
					//Trace.Unindent();
					cfg.cancel.ThrowIfCancellationRequested();
				}///semaphore here ?
				new nilnul.dev.srcs.each.div_.delvable_.dispat_.partic_.giT_.nonrepo_.incomplete.dir_.unskip.Bak_srcsInAddresses(cfg)
				{
					src = this.src
					,
					div = new nilnul.fs._address.Div( this.div.dirs.Append(
						nilnul.fs._address.Dir.OvDenote(dnt)//dir1
					))
					,
					cognom = this.cognom
				}.exe_ofAddress(child);
			}
			//Trace.Unindent();

			_cfg.shieldsNewlyBaked.Add(folder.address.ToString());
			//nilnul.dev.srcs.bak_._retVoid.SettingX.shieldsNewlyBaked.Add(folder.address.ToString());

		}

		//public  void Exe(
		//	string folder
		//)
		//{
		//	Exe(
		//		nilnul.fs.Folder.FroAddress(folder)
		//	);
		//}
		

	}
}
