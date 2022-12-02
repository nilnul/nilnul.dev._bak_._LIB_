using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using nilnul.fs.address_.shield;


namespace nilnul.fs.addresses_.disjoint.deV_._bak.io_
{
	/// <summary>
	/// </summary>
	static public class _CfgX
	{

		static public Io Create(
			nilnul.fs.address_.shields_.Disjoint shields2neglect
			,
			nilnul.fs.address_.shield.Set modules2neglect
			,
			CancellationToken cancel
			,
			win.prog_.Git git = null
		)
		{
			return new Io(
                //nilnul.dev.Properties.SettingsX.Srcs
				nilnul.dev.Srcs_addresses.OvCfg() //.Srcs
				,
				shields2neglect
				,
				modules2neglect
				,
				nilnul.dev.bak.Properties.Settings.Default.semaphore
				,
				cancel
				,
				git
			);
		}


		static public Io Create(
		
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			return Create(
				nilnul.fs.address_.shields_.disjoint_._AddressNulableSX.ToDisjoint(
					nilnul.dev.bak.Properties.SettingsX.shieldsBaked
				)
				,

				 Set.FroAddresses(
					nilnul.dev.bak.Properties.SettingsX.modulesBaked
				)
				,
				cancel
				,
				git
			);
		}

		static public Io Create_bakedNone(
		
			CancellationToken cancel,
			win.prog_.Git git = null
		)
		{
			return Create(
				
				new address_.shields_.Disjoint()
				,
				new Set()
				,
				cancel
				,
				git
			);
		}



		

	}
}

