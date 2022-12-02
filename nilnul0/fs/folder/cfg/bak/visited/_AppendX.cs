using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using nilnul.win.prog_;

namespace nilnul.fs.folder.cfg.bak.visited
{
	/// <summary>
	/// inside:
	///		.nilnul/bak the file
	///			{visited}22y11m19d112211{visited}
	/// </summary>
	/// <remarks>
	///			(traversed time="")
	/// </remarks>
	static public class _AppendX
	{
		/// <summary>
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="time">default as current</param>
		/// <param name="git"></param>
		static public void _Vod(
			nilnul.fs.FolderI folder
			, DateTime time
		)
		{
			/// ensure the latest folder;
			///
			var dotNilnulActive = nilnul.fs.folder.dir_.cfg_.nn_.exted_.active._EnsureX.Ver9exts(folder);

			var cfgAddress = System.IO.Path.Combine(
				folder.ToString()
				,
				nilnul.fs.folder._cfg_._DntX._Dnt_assumeNub_assumeExts(
					".nilnul",
					dotNilnulActive
				)
			);
			const string elName = "bak";
			const string XelContentExt_noDot = "xec";

			var bakActiveEnsured = nilnul.fs.folder._cfg_.div.doc_.active._VwX.__Ver9exts_addressAssumeFolder_assumeNub(
				cfgAddress
				,
				elName
			);

			string doc;

			if (bakActiveEnsured.exists)
			{
				if (bakActiveEnsured.exts.Count() != 1)
				{
					//we need to create one
					doc = $"bak0{bakActiveEnsured.ver}.xec";
					/// todo: doc = $"bak0{bakActiveEnsured.ver}";


				}
				else
				{
					if (bakActiveEnsured.exts.Single().ToLower() != ".xec")
					{
						doc = $"{elName}0{bakActiveEnsured.ver}.xec";
					}
					else
					{
						doc = $"{elName}{bakActiveEnsured.ver}.xec";
					}
				}
			}
			else // 
			{
				doc = nilnul.fs.folder._cfg_._DntX._Dnt_assumeNub_assumeExts(
					"bak"
					,
					(
					bakActiveEnsured.ver
					,
					new[] { ".xec"}
					//bakActiveEnsured.exts
				)
				);
			}

			System.IO.File.AppendAllText(
				System.IO.Path.Combine(
					cfgAddress
					,
					doc
				)
				,
				new XElement(
					"visited"
					,
					nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.phrase(time)
				).ToString() + nilnul.txt_.LineBreakOfWin.CRLF
			);
		}

		static public void Vod(nilnul.fs.FolderI folder, DateTime? time = null)
		{
			_Vod(folder,time??DateTime.UtcNow);
		}

		static public void Vod(nilnul.fs.address_.ShieldI folder, DateTime? time = null)
		{
			Vod(
				new nilnul.fs.Folder(
					folder
				)

				,
				time
			);
		}

		public static void Vod_folderOfAddress(string folder, DateTime? p = null)
		{
			Vod(nilnul.fs.address_.Shield.FroAddress(folder), p);
		}
	}
}
