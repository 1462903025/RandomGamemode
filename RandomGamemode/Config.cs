using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RandomGamemode
{
	public sealed class Config : IConfig
	{
		[Description("插件是否已启用。")]
		public bool IsEnabled { get; set; } = true;

		[Description("是否启用躲避球游戏模式。")]
		public bool DodgeBallEnabled { get; private set; } = true;

		[Description("花生危机游戏模式是否启用。")]
		public bool PeanutRaidEnabled { get; private set; } = true;

		[Description("金鱼攻击游戏模式是否启用。")]
		public bool GoldfishEnabled { get; private set; } = false;

		[Description("是否启用沉默的活死人之夜游戏模式。")]
		public bool LivingNerdEnabled { get; private set; } = true;

		[Description("是否启用SCP-682收容失效游戏模式。")]
		public bool SCP682ContainmentEnabled { get; private set; } = true;

		[Description("是否启用混乱游戏模式。")]
		public bool RandomizerEnabled { get; private set; } = true;

		[Description("每轮开始时激活游戏模式的几率。必须是整数。")]
		public int GamemodeChance { get; private set; } = 10;

		[Description("SCP-682收容失效游戏模式中SCP-682开局的血量。")]
		public int SCP682Health { get; private set; } = 5000;

		[Description("SCP-682收容失效游戏模式下MTF单位应获得的弹药量。")]
		public ushort SCP682MTFAmmo { get; private set; } = 1000;

		[Description("在世界上激活的躲避球的最大数量。将此值设置得过高将导致服务器宕机。")]
		public int MaxDodgeballs { get; private set; } = 20;

		[Description("科学家在沉默的活死人之夜游戏模式应获得的弹药量。")]
		public ushort NerdAmmoAmount { get; private set; } = 1000;
	}
}
