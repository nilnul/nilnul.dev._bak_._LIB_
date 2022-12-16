using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.sln.directory_.module.name.of_;
using nilnul.dev.srcs._bak;
using nilnul.fs;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.dev.src.div._bak
{
	/// <summary>
	/// for an individual shield, check if the div is cognable
	/// </summary>
	/// <see cref="dev.srcs.each.div_._delvable.ICognable0not"/>
	public class Cognable0not
	{

		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI src { get; internal set; }

		public Cognable0not(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public void vod(
			nilnul.fs.address_.ShieldI _shield
		)
		{
			///time to map back into nonlink
			///


			/// get the div
			///

			var div = nilnul.fs.address_.shield.co_.sup._DifX._ofSupSub(
				nilnul.fs.address_.Shield.FroAddress(
					src
				)
				,
				_shield
			);

			IEnumerable<lang_.cognom._tex.symbol_.Seg> segs;
			IEnumerable<lang_.cognom._tex.symbol_.Seg[]> segsEs;
			try
			{
				segsEs = div.dirs.Select(
					d => nilnul.lang_.cognom._TexX.Parse(
						d.denote.en
					).segs.ToArray()
				);
				segs = div.dirs.SelectMany(
					d => nilnul.lang_.cognom._TexX.Parse(
						d.denote.en
					).segs
				);
				
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"exceptiong when parsing {div} of {_shield} in {src} into segs:{e}"
				);
				return;
				//throw ;
			}

			new cognable.IfFolder(cfg) { src=src,div=div, cognom=segs.Select(s=>s.name), segsEs =segsEs}.vod(
				//_shield
				);

		}

		public void vod(AddressI shield)
		{
			vod(
				nilnul.fs.address_.Shield.FroAddress(shield)
			); ;
			//throw new NotImplementedException();
		}
	}
}
