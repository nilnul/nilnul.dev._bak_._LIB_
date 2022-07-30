using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.fs.address_.shield;

namespace nilnul.fs.address_.shields.dev_._bak.io
{
	static public class _SaveX
	{



		static public void _SaveNewlyBaked(Io io)
		{
			var absorbed = nilnul.fs.address_.shields_.Disjoint._Absorb_addresses(
				nilnul.dev.bak.Properties.SettingsX.shieldsBaked//.dev.srcs.bak_._retVoid.SettingX. shieldsBaked
				,
				io.shieldsNewlyBaked);

			//var newlyBaked = shieldsNewlyBaked;

			//var merged = shieldsBaked.Concat(newlyBaked);

			//var newDoneFolders = nilnul.fs.address_.shields_.Disjoint.Fro(merged);

			if (
				nilnul.fs.address_.shield.set.Eq.Singleton.eq_ofAddresses(
					nilnul.dev.Properties.SettingsX.Srcs	//._dev_._bak_._LIB_.Properties.SettingsX.shields2bak
					,
					absorbed.Select(
						s => s.ToString()
					)
				)
			)
			{
				//newDoneFolders = new nilnul.fs.address_.shields_.Disjoint();
				nilnul.dev.bak.Properties.Settings.Default.modulesBaked = new StringCollection();
				nilnul.dev.bak.Properties.Settings.Default.shieldsBaked= new StringCollection();

			}

			//var stringconn = new StringCollection();

			//stringconn.AddRange(newDoneFolders.en.Select(container => container.ToString()).ToArray());
			else
			{
			nilnul.dev.bak.Properties.Settings.Default.shieldsBaked = nilnul.txts_.StrCollectionX.FroEnumable( absorbed.Select(x=>x.ToString()));

			}


		}
		static public void _SaveNewlyBakedModule(Io io)
		{
			var absorbed = new nilnul.fs.address_.shield.Set(
				nilnul.dev.srcs.bak_._retVoid.SettingX.modulesBaked.Concat( io.modulesNewlyBaked).Select(x=>nilnul.fs.address_.shield_._AddressX1.Create(x))
			);

			//var merged = modulesBaked.Concat(modulesNewlyBaked);
			//var newDoneModules = nilnul.fs.address_.shields_.Disjoint.Fro(merged);

			//var modulesBakedNow = new StringCollection();
			//modulesBakedNow.AddRange(newDoneModules.en.Select(container => container.ToString()).ToArray());

			nilnul.dev.bak.Properties.Settings.Default.modulesBaked = nilnul.txts_.StrCollectionX.FroEnumable( absorbed.Select(x=>x.ToString()) );

			//nilnul.dev.srcs.bak_._retVoid.Settings1.Default.Save();

		}

		static public void Save(Io io)
		{
			_SaveNewlyBakedModule(io);
			//_SaveNewlyBakedSlns();
			_SaveNewlyBaked(io);
			nilnul.dev.bak.Properties.Settings.Default.Save();

		}


	

	}
}
