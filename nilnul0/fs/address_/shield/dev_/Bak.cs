using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using nilnul.dev.srcs._bak;
using nilnul.win.program_;


namespace nilnul.fs.address_.shield.dev_
{
	/// <summary>
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

		private nilnul.fs.address_.shields.dev_._bak.Io _cfg;
		public nilnul.fs.address_.shields.dev_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak(nilnul.fs.address_.shields.dev_._bak.Io cfg)
		{
			_cfg = cfg;
		}


		public void void0(
			nilnul.fs.address_.ShieldI _shield
			
		)
		{
			Trace.TraceInformation($"{this.GetType().FullName}.{nameof(void0)}({_shield})>>>");
			/// get the parent src

			var parent = cfg.srcs.shields.supOf(_shield);
			if (parent == null)
			{
				Trace.TraceInformation($"{_shield} in not in srcs:{cfg.srcs}");
				//return ;
			}
			else
			{
				new shield_.dev_.insideSrc.Bak(
					cfg
				).exe( _shield);

			}
		}

		

		public  void void0(
			string _shield
			
		)
		{
			 void0(
				nilnul.fs.address_.Shield.FroAddress(_shield)
				
			);
		}
	}
}

