using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RandomGamemode
{
	public sealed class Config : IConfig
	{
		[Description("����Ƿ������á�")]
		public bool IsEnabled { get; set; } = true;

		[Description("�Ƿ����ö������Ϸģʽ��")]
		public bool DodgeBallEnabled { get; private set; } = true;

		[Description("����Σ����Ϸģʽ�Ƿ����á�")]
		public bool PeanutRaidEnabled { get; private set; } = true;

		[Description("���㹥����Ϸģʽ�Ƿ����á�")]
		public bool GoldfishEnabled { get; private set; } = false;

		[Description("�Ƿ����ó�Ĭ�Ļ�����֮ҹ��Ϸģʽ��")]
		public bool LivingNerdEnabled { get; private set; } = true;

		[Description("�Ƿ�����SCP-682����ʧЧ��Ϸģʽ��")]
		public bool SCP682ContainmentEnabled { get; private set; } = true;

		[Description("�Ƿ����û�����Ϸģʽ��")]
		public bool RandomizerEnabled { get; private set; } = true;

		[Description("ÿ�ֿ�ʼʱ������Ϸģʽ�ļ��ʡ�������������")]
		public int GamemodeChance { get; private set; } = 10;

		[Description("SCP-682����ʧЧ��Ϸģʽ��SCP-682���ֵ�Ѫ����")]
		public int SCP682Health { get; private set; } = 5000;

		[Description("SCP-682����ʧЧ��Ϸģʽ��MTF��λӦ��õĵ�ҩ����")]
		public ushort SCP682MTFAmmo { get; private set; } = 1000;

		[Description("�������ϼ���Ķ������������������ֵ���õù��߽����·�����崻���")]
		public int MaxDodgeballs { get; private set; } = 20;

		[Description("��ѧ���ڳ�Ĭ�Ļ�����֮ҹ��ϷģʽӦ��õĵ�ҩ����")]
		public ushort NerdAmmoAmount { get; private set; } = 1000;
	}
}
