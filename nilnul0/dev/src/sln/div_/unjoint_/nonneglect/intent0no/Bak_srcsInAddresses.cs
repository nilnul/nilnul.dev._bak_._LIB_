using nilnul.dev.src.div.dir.cognomen_.commentedSegs._parse.parener._dotter.lex.symbol_;
using nilnul.fs._address;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading;

namespace nilnul.dev.src.sln.div_.unjoint_.nonneglect_.intend0no
{
	//[Obsolete("categorize according to git first; then depth1st; then for the intent.")]

	public class Bak_srcsInAddresses
	{
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}


		private nilnul.fs.address_.ShieldI _module;
		public nilnul.fs.address_.ShieldI module
		{
			get => _module;
			set => _module = value;
		}

		public ConcurrentBag<nilnul.fs._address.DivI> innerModules;
		public ConcurrentBag<nilnul.fs._address.DivI> innerModules2reinclude;

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude, nilnul.fs.address_.ShieldI module)
		{
			this.cfg = cfg;
			this.innerModules = innerModules;
			this.innerModules2reinclude = innerModules2reinclude;
			this._module = module;
		}

		public Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules, ConcurrentBag<DivI> innerModules2reinclude) : this(cfg, innerModules, innerModules2reinclude, null)
		{

		}

		private Bak_srcsInAddresses(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg) : this(cfg, new ConcurrentBag<DivI>())
		{
		}

		private Bak_srcsInAddresses(
			nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg, ConcurrentBag<DivI> innerModules1
		) : this(
			cfg, innerModules1, new ConcurrentBag<DivI>()
		)
		{
		}

		public void _vod(
			string folder
			
		)
		{
			var tip = nilnul.fs.address_.shield_.BaseDir.FroAddress(folder);
			var tip1 = tip.child;

			var parsed = nilnul.dev.src.div.dir.cognomen_.commentedSegs._ParseX.Parse(tip1.denote.en);



			if (
			parsed.HasNotationCaseInsensitiveNonrecur("git")
			&&!string.IsNullOrWhiteSpace( parsed.cognomen)

				//nilnul.fs.git.module._ignore_.rule_.nn_._IntendGitX.IsIntend_ofShieldAddress(folder)

			)
			{

				if (module != null)
				{
					innerModules.Add(
						nilnul.fs.address_.shield.co_.sup._DifX._ofAddresses(
							module
							,
							folder
						)
					);

				}

				new nonneglect_.intent.Bak_srcsInAddress(cfg).Exe(folder);
			}
			else
			{
				new nonneglect_.nonintent.Bak(cfg, innerModules,innerModules2reinclude,module) ._void(folder);
			}
		}

		public void vod(
			nilnul.fs.address_.ShieldI folder
			
		)
		{

			_vod(folder.ToString());
		}

		public  void vod_ofAddress(
			string _shield
		)
		{
			vod(
				nilnul.fs.address_.shield_._AddressX1.Create(_shield)
				
			);
		}
	}
}
