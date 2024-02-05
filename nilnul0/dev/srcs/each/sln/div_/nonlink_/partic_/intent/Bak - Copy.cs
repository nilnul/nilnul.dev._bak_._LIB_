using nilnul.fs.folder;
using System;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.sln_.nonlink.div_.nonlink_.partic_.intent
{
	/// <summary>
	/// gien srcs, bak a disjoint addresses.
	/// </summary>
	public  class Bak_srcsInAddress
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Bak_srcsInAddress(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="folderAddress"></param>
		/// <param name="cancellationToken"></param>
		/// <param name="git"></param>
		public void Exe(
			string folderAddress
		)
		{

			try
			{
				switch (nilnul.fs.folder.categorize_.git_.PlainWorkRepo.Category_ofAddress(folderAddress))
				{
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Plain:
						new intent_.giT_.plain0nontop.Bak_srcsInAddresses(cfg).Exe(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Work:
						new nilnul.dev.sln_.nonlink.div_.nonlink_.partic_.intent_.giT_.work.Bak_srcsInAddresses(cfg).Exe(folderAddress);

						break;
					case fs.folder.categorize_.git_._plainWorkRepo.Ret.Repo:
						break;
					default:
						Trace.TraceError(
							$"{folderAddress} is triaged into an unknown category other than Plain|Work|Repo"
						);
						break;
				}

			}
			catch (OperationCanceledException ex)
			{
				throw;
			}
			catch (Exception e)
			{
				Trace.TraceError(
					$"when processing {folderAddress} :" + e.Message
				);
				throw;
				return;
			}
		}
	}
}