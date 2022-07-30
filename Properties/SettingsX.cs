using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.bak.Properties
{
	public class SettingsX
	{
		public const int Fallback = 4;///todo number of cpus
		/// <summary>
		/// 
		/// </summary>
		static public int Semaphore {
			get {
				
				var t=Settings.Default.semaphore;
				if (t<=0)
				{
					try
					{
						t=(int)Settings.Default.Properties[nameof(Settings.semaphore)].DefaultValue;
						if (t<=0)
						{
							t = Environment.ProcessorCount;
						}


					}
					catch (Exception)
					{

						t = Environment.ProcessorCount;
					}

				}
				return t;
				
			}
		}

		static public IEnumerable<string> shieldsBaked
		{
			get
			{
				return (nilnul.dev.bak.Properties.Settings.Default.shieldsBaked ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}

		static public IEnumerable<string> modulesBaked
		{
			get
			{
				return (nilnul.dev.bak.Properties.Settings.Default.modulesBaked ?? new System.Collections.Specialized.StringCollection()).Cast<string>();

			}
		}

	}
}
