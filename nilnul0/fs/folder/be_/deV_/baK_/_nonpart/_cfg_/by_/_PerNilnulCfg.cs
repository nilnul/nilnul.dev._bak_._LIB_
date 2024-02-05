using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.dev_.baK_._nonpart
{
	/// <summary>
	/// </summary>
	///
	[Obsolete(nameof(nilnul.fs.folder.be_.dev_.baK_))]
	static public class _PerNilnulCfgX
	{


		static public bool Be(nilnul.fs.FolderI s, nilnul.win.prog_.Git git = null)
		{

			var spear = new address_.spear_.ParentDoc(s.address.en, ".nilnul");
			var spearAsTxt = spear.ToString();
			string loaded = null;
			if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear))
			{
				loaded = System.IO.File.ReadAllText(spearAsTxt);

			}

			//var spear4legacy = new address_.spear_.ParentDoc(s.address.en, ".nilnulCfg");
			//var spearAsTxt4Legacy = spear4legacy.ToString();
			//string loaded4legacy;
			//if (nilnul.fs.address_.spear.be_.File.Singleton.be(spear4legacy))
			//{
			//	 loaded4legacy = System.IO.File.ReadAllText(spearAsTxt4Legacy);

			//}
			try
			{
				bool? define = null;
				try
				{
					define = _cfg_._DefineX._Be_clobOfNulable(loaded, s, git);
				}
				catch (Exception e)
				{
					Trace.TraceError($"when parseing .nilnul cfg in {s}:{e}");

					//throw;
				}

				bool? defer = null;
				try
				{
					defer = _nonpart._cfg_._DeferX._Be_clobOfNulable(loaded, s, git);

				}
				catch (Exception e)
				{

					Trace.TraceError($"when parseing .nilnul cfg for defer in {s}:{e}");

				}
				return (define
					 ??defer
				) == true;

			}
			catch (Exception e)
			{
				Trace.TraceError($"when determine whether to neglect per cfg in {s}:{e}");
				return false;

				//throw;
			}

		}

		static public bool Be(nilnul.fs.address_.ShieldI s, nilnul.win.prog_.Git git = null)
		{
			return Be(new nilnul.fs.Folder(s), git);
		}


		static public bool Be_ofAddress(string s, nilnul.win.prog_.Git git = null)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s), git);
		}



	}
}
