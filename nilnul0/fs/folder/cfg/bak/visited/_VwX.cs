using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using nilnul.fs.file.blob;
using nilnul.fs.git.depo.repo._setting;
using nilnul.num.quotient.stream_;
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
	static public class _VwX
	{
		public const string VISITED_EL_NAME = "visited";
		/// <summary>
		/// </summary>
		/// <param name="folder"></param>
		/// <param name="time">default as current</param>
		/// <param name="git"></param>
		static public DateTime? _Time0nul_addressAssumeFolder(
			string folder
		)
		{
			/// ensure the latest folder;
			///
			var dotNilnulActive = nilnul.fs.folder._cfg_.div.dst_._ExtedsX._Active0defaultDir_addressAssumeFolder_assumeNub(
				folder, ".nilnul"
			);

			if (dotNilnulActive.ver is null)
			{
				return null;
			}


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
				if (bakActiveEnsured.exts.Count() > 1)
				{
					return null;


				}
				else
				{
					if (bakActiveEnsured.exts.Count() == 1)
					{
						if (bakActiveEnsured.exts.Single().ToLower() != ".xec")
						{
							return null;

						}
						else
						{
							doc = $"{elName}{bakActiveEnsured.ver}.xec";

						}

					}
					else
					{
						doc = $"{elName}{bakActiveEnsured.ver}";

					}
				}

			}
			else
			{
				return null;
			}

			XNode[] content = default;

				string path = System.IO.Path.Combine(
										cfgAddress
										,
										doc
									);
			

			try
			{
				content = nilnul._xml._el.content._ParseX.Load(
					path
				).ToArray();

				


			}
			catch (Exception e)
			{
				Trace.TraceError(
					new XElement("xecParse",
					$"error when parsing {path} as .xec: {e.ToString()}"
					).ToString()
				);
				return null;
				//throw;
			}

			var maxTime =
				nilnul.obj.str.to_.scalar_._MaxOrDefaultX.Max(

				content.Where(
					n => n.NodeType == System.Xml.XmlNodeType.Element
				).Cast<XElement>().Where(e => e.Name.LocalName == "visited").Select(
					v =>
					{
						try
						{
							return (DateTime?)nilnul.time_.datetime.lex_.alnum_.NonyearCollapse.Singleton.parse(
													v.Value
												);

						}
						catch (Exception x)
						{
							Trace.TraceError(
								new XElement("time5alnum",
									$"error when parsing alnum {v.Value} from {path} as time: {x.ToString()}"
								).ToString()
							);
							return null;
						}
					})
				,
				nilnul.obj.nulable.comp_.NulMaxOvStruc<DateTime>.Singleton

			);


			return maxTime;


		}
		static public DateTime? Time0nul(
			nilnul.fs.FolderI folder
		)
		{
			return _Time0nul_addressAssumeFolder(folder.ToString());


		}
		static public DateTime? Time0nul(nilnul.fs.FolderI1 folder)
		{
			return _Time0nul_addressAssumeFolder(folder.ToString());
		}

		static public DateTime? Time0nul(nilnul.fs.address_.ShieldI folder)
		{
			return Time0nul(
				new nilnul.fs.Folder(
					folder
				)

			);
		}

		public static DateTime? Time0nul_folderOfAddress(string folder)
		{
			return Time0nul(nilnul.fs.address_.Shield.FroAddress(folder));
		}
	}
}
