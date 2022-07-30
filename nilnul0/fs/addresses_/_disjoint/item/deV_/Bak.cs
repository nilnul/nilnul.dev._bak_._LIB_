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

			var parent = cfg.srcs.addresses.Where(
				a => nilnul.fs.address.re_.Sup.Singleton.re(a, address)
			).SingleOrDefault();


			if (parent is null)
			{

				Trace.TraceInformation($"{address} in not in srcs:{cfg.srcs}");
				//return ;
			}
			else  //parent.Count() is 1
			{

				if (
					nilnul.fs.address.re_.sup_.EndMatters.Singleton.re(
						parent, address
					)
				)
				{
					new address_.deV_.inSrc.Bak(
							cfg
						).exe(address);
				}
				else if (
					nilnul.fs.address.eq_.AsShield.Singleton.Equals(
						address
						,
						parent
					)
				)
				{
					Trace.TraceWarning($"{address} is appended a dirSep, before being taken as the sub of {parent}; or else {address} is the proper sup of {parent}. ");

					new address_.deV_.inSrc.Bak(
						cfg
					).exe(
						nilnul.fs.address_.Shield.Ov(address)
					);

				}
				else
				{
					Trace.TraceError($" unexpected. {address}, when converted to shield, shall be in {parent}.");

				}


			}
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

