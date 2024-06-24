using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_._define
{
	static public class _PerHierX
	{

		public static bool _IsNeglected_0folder(string folder)
		{
			try
			{
				return nilnul.fs.folder.cfg.hier.vals_._MaximalX._Vals_0address4folder_1identy(
					folder,
					"bak.neglect"
				).Any(
					v =>
					{
						return v?.ToString()?.Trim() == "1";

					}
				);
			}
			catch (System.Xml.XmlException e)
			{

				Trace.TraceError($"when retrieveing 'bak.neglect' value from configuration of {folder}:{e}");
				return false;
				//throw;
			}

		}
	}
}
