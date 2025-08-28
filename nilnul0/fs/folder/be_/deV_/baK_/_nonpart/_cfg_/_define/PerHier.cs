using nilnul.obj.seq;
using nilnul.obj.seq_.str.be_;
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
		/// <summary>
		/// <see cref="nilnul.fs.folder.be_._PartakeX._IsParticipant_0folder(string)"/>
		/// </summary>
		private const string NOMINA = "bak.neglect";

		public static bool _IsNeglected_0folder(string folder)
		{
			try
			{
				if (nilnul.fs.folder.cfg.hier.vals_._MaximalX._Vals_0address4folder_1identy(
					folder,
					NOMINA
				).Any(
					v =>
					{
						return v?.ToString()?.Trim() == "1";

					}
				))
				{
					return true;
				}

				var vals = nilnul.fs.folder.cfg.hier.vals_._MaximalX._Vals_0address4folder_1identy(
						folder,
						"bak" + "." + "abstain" // nilnul.fs.folder.cfg.hier_.partake._MaximalX.NOM
					).ToArray();
				if (vals.Any() )
				{
					return vals.Any(
						v =>
						{
							return v?.ToString()?.Trim() == "1";

						}
					);

				}


				return 					//nilnul.fs.folder.be_._PartakeX._IsParticipant_0folder(folder)
					nilnul.fs.folder.cfg.hier.vals_._MaximalX._Vals_0address4folder_1identy(
						folder,
						 "abstain" // nilnul.fs.folder.cfg.hier_.partake._MaximalX.NOM
					).Any(
						v =>
						{
							return v?.ToString()?.Trim() == "1";

						}
					)

				;
			}
			catch (System.Xml.XmlException e)
			{

				Trace.TraceError($"when retrieveing '{NOMINA}' value from configuration of {folder}:{e}");
				return false;
				//throw;
			}
			catch(System.Exception e) { /// for configuration, exception shall not be fatal.
				
				Trace.TraceError($"when retrieveing '{NOMINA}' value from configuration of {folder}:{e}");
				return false;
			}
			

		}
	}
}
