﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shield_;
using nilnul.fs.folder_;

namespace nilnul.fs.folder.be_.deV_.baK_.nonpart
{
	static public class _AntoX
	{
		public static bool _Be_0folder(string s)
		{
			return !_nonpart._PerCfgX._Be_0folder(s);
		}
		public static bool _Be_0folder(fs.address_.ShieldI folder)
		{
			return _Be_0folder(folder.ToString());
		}
		public static bool Be(nilnul.fs.FolderI s)
		{
			return _Be_0folder(s.ToString());
		}


		public static bool Be(nilnul.fs.address_.ShieldI s)
		{
			return Be(new nilnul.fs.Folder(s));
		}

		public static bool Be_ofAddress(string s)
		{
			return Be(nilnul.fs.address_.shield_._AddressX1.Create(s));
		}

		internal static bool Be(folder_.Normal div_inSrc)
		{
			return Be(div_inSrc.en);
		}

	}
}