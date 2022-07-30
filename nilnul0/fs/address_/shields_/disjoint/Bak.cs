using nilnul.fs.address_.shields_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.fs.address_.shields_.disjoint
{
	/// <summary>
	/// for an individual shield.
	/// </summary>
	public  class Bak
	{
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


		public  void _Bak(
			IEnumerable<string> _shieldsDisjoint
			
		)
		{
			var cancel = cfg.cancel;
			string shieldsTxt = nilnul.fs.address.str._PhraseX.Phrase(_shieldsDisjoint);
			Trace.TraceWarning($"begin {shieldsTxt}...");
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelled {shieldsTxt}...");

				return;
			}

			//Trace.Indent();
		
			try
			{
				foreach (string src in _shieldsDisjoint)
				{
					cancel.ThrowIfCancellationRequested();
					new nilnul.fs.address_.shield.dev_.Bak(cfg).void0(src);
				}
			}
			finally
			{
				//Trace.Unindent();

			}

			//throw new NotImplementedException();
		}

		public  void _ShuffleAndBak(
			IEnumerable<string> _shieldsDisjoint
			
		)
		{
			_Bak(
				/*nilnul.obj.str.op_.unary_._ShuffleX.Op*/
				(_shieldsDisjoint)
				
			);

		}

		public  void _Bak( Disjoint disjoint)
		{
			_Bak( disjoint.ee.Select(x => x.ToString()));

			//throw new NotImplementedException();
		}


		

	}
}
