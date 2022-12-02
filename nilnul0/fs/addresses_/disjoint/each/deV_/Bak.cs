using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;


namespace nilnul.fs.addresses_._disjoint.item.deV_
{
	/// <summary>
	/// processing each member of the disjoint addresses.
	/// 
	/// </summary>
	public class Bak
	{

		//private nilnul.dev.SrcsI3 _srcs;

		//public nilnul.dev.SrcsI3 srcs
		//{
		//	get { return _srcs; }
		//	set { _srcs = value; }
		//}

		//private nilnul.fs.address_.shields_.Disjoint _shields2neglect;

		//public nilnul.fs.address_.shields_.Disjoint shields2neglect
		//{
		//	get { return _shields2neglect; }
		//	set { _shields2neglect = value; }
		//}

		//private nilnul.fs.address_.shields_.Disjoint _modules2neglect;

		//public nilnul.fs.address_.shields_.Disjoint modules2neglect
		//{
		//	get { return _modules2neglect; }
		//	set { _modules2neglect = value; }
		//}

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


		public void vod(
			nilnul.fs.AddressI address

		)
		{
			this._cfg.onNotify($"baking the {address} you specified...");
			Trace.TraceInformation($"{this.GetType().FullName}.{nameof(vod)}({address})>>>");
			/// get the parent src

			var sup = cfg.srcs.addresses.Where(
				a => nilnul.fs.address.re_.Sup.Singleton.re(a, address)
			).SingleOrDefault();

			var src = nilnul.fs.address_.shield_._AddressX1.Create(sup);

			if (sup is null)
			{

				Trace.TraceInformation($"{address} in not in srcs:{cfg.srcs}");
				return;
			}

			/// in src
			if (
				nilnul.fs.address.re_.sup_.EndMatters.Singleton.re(
					sup, address
				)
			)
			{
				new dev.src.div._bak.Cognable0not(
						cfg
					)
				{
					src = src,
				}.vod(address);
				return;
			}

			if (
				nilnul.fs.address.eq_.AsShield.Singleton.Equals(
					address
					,
					sup
				)
			)
			{
				Trace.TraceWarning($"{address} is appended a dirSep, before being taken as the sub of {sup}; or else {address} is the proper sup of {sup}. ");

				new dev.src.div._bak.Cognable0not(
						cfg
					)
				{
					src = src,
				}.vod(
					(address)
				);
				return;

			}

			Trace.TraceError($" unexpected. {address}, when converted to shield, shall be in {sup}.");
		}



		public void vod_ofAddress(
			string _shield

		)
		{
			vod(
				nilnul.fs.AddressA.Parse(_shield)

		   );
		}
	}
}

