using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.deV_.baK_._nonpart
{
	/// <summary>
	/// </summary>
	static public class _PerCfgX
	{

		static public bool _Be_0folder(string s)
		{
			return _cfg_._DefineX._Be_0folder(s) || _cfg_._DeferX._BeDeferred_0folder(s);

		}
		static public bool _Be_0folder(nilnul.fs.address_.ShieldI s)
		{
			return _Be_0folder(s.ToString());
		}

		static public bool Be(nilnul.fs.FolderI s)
		{

			return _Be_0folder(s.ToString());

		}
		static public bool Be(nilnul.fs.address_.ShieldI s)
		{
			return Be(new nilnul.fs.Folder(s));
		}


		static public bool Be_0address(string s)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s));
		}



	}
}
