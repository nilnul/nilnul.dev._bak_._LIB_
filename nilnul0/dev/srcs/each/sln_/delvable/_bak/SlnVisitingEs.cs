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
	public class SlnVisitingEs : IProducerConsumerCollection<(string, DateTime)>
	{
		private class _Comparer : IComparer<(string, DateTime)>
		{
			public int Compare((string, DateTime) first, (string, DateTime) second)
			{
				var returnValue = first.Item2.CompareTo(second.Item2);
				if (returnValue == 0)
					returnValue = first.Item1.CompareTo(second.Item1);
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

		SortedSet<(string, DateTime)> _dict = new SortedSet<(string, DateTime)>(
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

		public void CopyTo((string, DateTime)[] array, int index)
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

		public bool TryAdd((string, DateTime) item)
		{
			lock (_lock)
			{
				return _dict.Add(item);
			}
		}

		public bool TryTake(out (string, DateTime) item)
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

		public (string, DateTime)[] ToArray()
		{
			lock (_lock)
			{
				return this._dict.ToArray();

			}
		}

		public IEnumerator<(string, DateTime)> GetEnumerator()
		{
			return ToArray().AsEnumerable().GetEnumerator();
		}

		/// <summary>
		/// </summary>
		/// <returns></returns>
		public BlockingCollection<(string, DateTime)> asBlockingCollection() {
			return new BlockingCollection<(string, DateTime)>(
				this
			);
		}

		//static  void ExampleUse(CancellationToken cancellationToken) {
		//	var s = new SlnVisitingEs().asBlockingCollection();

		//	/// traversal thread:
		//	s.Add(("", DateTime.MinValue));

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
