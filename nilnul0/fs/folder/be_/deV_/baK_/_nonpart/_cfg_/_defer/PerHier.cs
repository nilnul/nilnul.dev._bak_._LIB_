using nilnul.obj.str.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.be_.deV_.baK_._nonpart._cfg_._defer
{
	static public class _PerHierX
	{

		public static bool _BeDeferred_0folder(string folder)
		{

#if DEBUG

			var enumerable = nilnul.fs.folder.cfg.hier.vals_._MaximalX._Vals_0address4folder_1identy(
							folder,
							"bak.aft"
						).ToArray();


			return enumerable.Select(
				v =>
				{
					var parsed = DateTimeOffset.TryParse(v.ToString(), out var benchmark);
					if (parsed)
					{
						return (DateTimeOffset?)benchmark;
					}
					return null;
				}
			).Where(d=> d is not null).Cast<DateTimeOffset>().Any(t=> t>= DateTimeOffset.UtcNow);

#else

			return nilnul.fs.folder.cfg.hier.vals_._MaximalX._Vals_0address4folder_1identy(
				folder,
				"bak.aft"
			).Select(
				v =>
				{
					var parsed = DateTimeOffset.TryParse(v.ToString(), out var benchmark);
					if (parsed)
					{
						return (DateTimeOffset?)benchmark;
					}
					return null;
				}
			).Where(d=> d is not null).Cast<DateTimeOffset>().Any(t=> t>=DateTimeOffset.UtcNow);

#endif
		}
		public static bool? _Deferred0nul_0folder(string folder)
		{
			var vals= nilnul.fs.folder.cfg.hier.vals_._MaximalX._Vals_0address4folder_1identy(
				folder,
				"bak.aft"
			).Select(
				v =>
				{
					var parsed = DateTimeOffset.TryParse(v.ToString(), out var benchmark);
					if (parsed)
					{
						return (DateTimeOffset?)benchmark;
					}
					return null;
				}
			).Where(d => d is not null).Cast<DateTimeOffset>().ToArray();
			if (vals.None())
			{
				return null;
			}

			return vals.Any(t=> t>=DateTimeOffset.UtcNow);
		}


		public static bool _BeImmediate_0folder(string folder)
		{
			return !_BeDeferred_0folder(folder);
		}
		public static bool? _NonDeferred0nul_0folder(string folder)
		{
			///learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/nullable-value-types
			/// The predefined unary and binary operators or any overloaded operators that are supported by a value type T are also supported by the corresponding nullable value type T?. These operators, also known as lifted operators, produce null if one or both operands are null; otherwise, the operator uses the contained values of its operands to calculate the result. 
			return !_Deferred0nul_0folder(folder);
		}


	}
}
