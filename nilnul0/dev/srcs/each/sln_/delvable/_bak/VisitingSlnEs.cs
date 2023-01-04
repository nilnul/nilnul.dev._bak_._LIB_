using nilnul.num.integer;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace nilnul.dev.srcs.each.sln_.delvable._bak
{
	/// more understandable when it is (DateTime, string), as we order item1 first;
	/// <summary>
	/// 
	/// </summary>
	public class VisitingSlnEs : IProducerConsumerCollection<( DateTime, string)>
	{
		private class _Comparer : IComparer<(DateTime, string)>
		{
			public int Compare((DateTime, string) first, (DateTime, string) second)
			{
				var returnValue = first.Item1.CompareTo(second.Item1);
				if (returnValue == 0)
					returnValue = first.Item2.CompareTo(second.Item2);
				return returnValue;
			}
			static public _Comparer Singleton
			{
				get
				{
					return nilnul._obj.typ_.nilable_.unprimable_.Singleton<_Comparer>.Instance;
				}
			}
		}

		SortedSet<(DateTime, string)> _dict = new SortedSet<(DateTime, string)>(
			_Comparer.Singleton
		);

		private object _lock=new object();

		public int Count
		{
			get
			{
				lock(_lock){
					return _dict.Count;
				}
			}
		}

		public object SyncRoot => _lock;

		public bool IsSynchronized => true;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}

		public void CopyTo((DateTime, string)[] array, int index)
		{
			lock (_lock)
			{
				foreach (var item in _dict)
				{
					array[index++] = item;
				}
			}

		}
		public void CopyTo(Array array, int index)
		{
			lock (_lock)
			{
				foreach (var item in _dict)
				{
					array.SetValue(item, index++);
				}
			}

		}

		public bool TryAdd((DateTime, string) item)
		{
			lock (_lock)
			{
				return _dict.Add(item);
			}
		}

		public bool TryTake(out (DateTime, string) item)
		{
			lock (_lock)
			{
				item = _dict.Min;
				if (item==default)
				{
					return false;
				}
				return _dict.Remove(item);
			}
		}

		public (DateTime, string)[] ToArray()
		{
			lock (_lock)
			{
				return this._dict.ToArray();

			}
		}

		public IEnumerator<(DateTime, string)> GetEnumerator()
		{
			return ToArray().AsEnumerable().GetEnumerator();
		}

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public BlockingCollection<(DateTime, string)> asBlockingCollection() {
			return new BlockingCollection<(DateTime, string)>(
				this
			);
		}

		//static  void ExampleUse(CancellationToken cancellationToken) {
		//	var s = new VisitingSlnEs().asBlockingCollection();

		//	/// traversal thread:
		//	s.Add(( DateTime.MinValue, ""));

		//	//...
		//	s.CompleteAdding();

		//	/// tackler thread:
		//	///
		//	foreach (var item in s.GetConsumingEnumerable(cancellationToken))
		//	{
		//		/// process the item
		//	}
		//}


	}
}
