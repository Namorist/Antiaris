using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace Antiaris.Items.Equipables.Armor.Developers
{
    [AutoloadEquip(new EquipType[] { EquipType.Body })]
    public class ZerokkChestguard : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 34;
            item.height = 22;
            item.rare = 9;
            item.vanity = true;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Zerokk's Chestguard");
            Tooltip.SetDefault("'Great for impersonating former developers!'");
            DisplayName.AddTranslation(GameCulture.Russian, "��������� Zerokk'a");
            Tooltip.AddTranslation(GameCulture.Russian, "'������� ��� ������ ���� �� ������� ������������!'");
			DisplayName.AddTranslation(GameCulture.Chinese, "Zerokk???");
            Tooltip.AddTranslation(GameCulture.Chinese, "�???????????!�");
        }
    }
}