using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;
using nilnul.fs.folder;

namespace nilnul.dev.src.div_.folder
{
	/// <summary>
	/// the div is a folder.
	/// this div is the base to bak; that is: all divs in this src that are going to be baked are in this div.
	/// 
	/// </summary>
	/// <remarks>
	///
	/// </remarks>
	public class Bak
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="_shield">
		/// together with the base, this can be the src, the sln, or the directory in sln.
		/// </param>
		/// <remarks>
		///    
		/// </remarks>
		public void exe(
			nilnul.fs.address_.ShieldI _shield
		)
		{
			var src = cfg.srcs.addresses.Where(
				a => nilnul.fs.address.re_.Sup.Singleton.re(a, _shield)
			).Single();

			var div = nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
				nilnul.fs.address_.Shield.FroAddress(
					src
				)
				,
				_shield
			);

			///loop the div, and store each progenitor's eventual target.
			/// also check for errors.
			/// here two directory in different srcs might have the same eventual target. (srcs have different eventual target). This is checked against in runtime. and the first one will succeed, and following ones will fail. In this way, it's efficient as otherwise each div in each src has to be checked in advance, not on the fly.
			/// 
			fs.address_.ShieldI newBase1 = nilnul.fs.address_.shield_._AddressX1.Create( src );

			foreach (var dir in div.dirs)
			{

				var dirAsShield = new nilnul.fs.address_.shield_.BaseDir(
					newBase1
					,
					dir
				);

				if (
					nilnul.fs.folder.dir.be_._SymlinkX.Be(
						newBase1
						,
						dir
					)
				)
				{
					var destiny = nilnul.fs.folder_.link_.sym._DestinyX.Normal(dirAsShield).en.address.en;



					var added = _cfg.addDestiny(
						destiny
						,
						dirAsShield
					);
					if (added.Key is null)  //success
					{

					}
					else
					{
						Trace.TraceError(
		$@"{div} in {src} is a link (such as symbolink). the destiny( eventual target): {destiny} is joint/conflicted with {added.Key}, which is the link by {added.Value} "
						);
						return;
					}

				}
				newBase1 = dirAsShield;
			}

			///de-contextual
			///	we hence look at the inside of the folder, no need to look at its ancesters.
			
			new nilnul.dev.src_.folder.div_.unjoint.Bak4sln(cfg).exe(_shield);

			//new nilnul.fs.addresses_._disjoint.member_.inSrc_.folder.div_.folder_.unjoint.Bak_srcsInAddresses(cfg).exe(_shield);
			

			/// all progenitor's tgt is disjoint.



		}
	}
}
