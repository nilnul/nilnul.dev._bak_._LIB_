using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.sln.directory_.module.name.of_;
using nilnul.dev.srcs._bak;
using nilnul.fs.address_;
using nilnul.win.program_;

namespace nilnul.fs.addresses_._disjoint.member_.inSrc_.folder
{
	/// <summary>
	/// for an individual shield
	/// </summary>
	public class Bak
	{

		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public ShieldI src { get; internal set; }

		public Bak(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}

		public void Exe(
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
			try
			{
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

			new nilnul.dev.src.div._bak.cognable_.folder.EnsureUnjoint(cfg) { src=src, div=div, cognom=segs.Select(s=>s.name)}.exe(
				//_shield
			);

		}

		public void Exe(AddressI shield)
		{
			Exe(
				nilnul.fs.address_.Shield.FroAddress(shield)
			); ;
			//throw new NotImplementedException();
		}
	}
}
