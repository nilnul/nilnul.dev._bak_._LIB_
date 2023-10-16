using nilnul.fs.address_.shields_;
using nilnul.obj.str;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.fs.addresses_.disjoint.deV_
{
	/// <summary>
	/// given srcs that is disjoint addresses(including both spears and shields), bak disjoint addresses
	/// </summary>
	public class Bak
	{
		/// <summary>
		/// we extract nondisjoint folders, which is destinyDisjoint (with regards to their destiny that is nonlink, the collection is disjoint).
		/// </summary>
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
		/// <param name="_shieldsDisjoint">
		/// disjoint
		/// </param>
		public void _Bak(
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

			/// the collection is initially empty, we would process items once the collection is added.
			var t = Task.Factory.StartNew(
				() => cfg.slnVisitingEs.GetConsumingEnumerable(cancel).Each(
					s =>
					new nilnul.dev.srcs.each.sln_.delvable.BakTackler(cfg)._startTask_ofAddress(s.Item1) ///here wouldnot return for next if semophore stalls;
				)
				,
				cancel
								,
				TaskCreationOptions.AttachedToParent
				, TaskScheduler.Current //TaskScheduler


			);

			try
			{

				foreach (string src in _shieldsDisjoint)
				{
					cancel.ThrowIfCancellationRequested();

					new nilnul.fs.addresses_._disjoint.item.deV_.Bak(cfg).vod_ofAddress(src);
				}

			}
			finally
			{
				cfg.slnVisitingEs.CompleteAdding(

				);
				//Trace.Unindent();

			}
			try
			{
				t.Wait();
			}
			catch (AggregateException ex)
			{
				ex.Handle(
					c => {
						/// if it's intentionally cancelled, ignore them
						return c is OperationCanceledException oc && oc.CancellationToken == cfg.cancel;
					}
				);
			}
			

			//throw new NotImplementedException();
		}

		public void _bak_assumeDisjoint(List<AddressI> addressIs)
		{
			_Bak(
				addressIs.Select(a => a.ToString())
			);
		}

		public void _ShuffleAndBak(
			IEnumerable<string> _shieldsDisjoint

		)


		{
			//shall be shuffled and shown in UI lest the UI is inconsisitent with the order in action.
			_Bak(
				/*nilnul.obj.str.op_.unary_._ShuffleX.Op*/
				(_shieldsDisjoint)

			);

		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="disjoint">
		/// it's disjoint so there would be no two that is <see cref="nilnul.fs.address.co_.spearShield_.SameLocation"/>
		/// </param>
		public void _Bak(Disjoint disjoint)
		{
			_Bak(disjoint.toOriginal().Select(x => x.ToString()));

			//throw new NotImplementedException();
		}




	}
}
