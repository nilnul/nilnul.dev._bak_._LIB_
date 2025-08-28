using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using nilnul.win.program_;

namespace nilnul.dev.raws_.cfged
{
	/// <summary>
	/// </summary>
	static public class _ShieldInSrcX
	{
		public static bool Exe(
			nilnul.fs.address_.shields_.Disjoint srcs,
			nilnul.fs.address_.ShieldI _shield
			
		)
		{
			

			var parent = srcs.supOf(_shield);
			if (parent == null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public static bool Exe(
			nilnul.fs.address_.ShieldI _shield
			
		)
		{
			 return Exe(
				 nilnul.fs.address_.shields_.disjoint_._AddressesX.ToDisjoint(
					//nilnul.dev.bak.nilnul0.dev.raws.bak_._retVoid.Settings1
					nilnul.dev.Properties.Settings
					
					.Default.srcs.Cast<string>()
				),
				_shield
				
			);
		}

		public static bool Exe(
			string _shield
			
		)
		{
			return  Exe(
				nilnul.fs.address_.Shield.FroAddress(_shield)
				
			);
		}
	}
}

