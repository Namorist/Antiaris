using Terraria;
using Terraria.Localization;
using Terraria.ModLoader;

namespace Antiaris.Items.Miscellaneous
{
    public class IronCoin : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Iron Coin");
            Tooltip.SetDefault("Used for buying items in Adventurer's shop\n'Valar morghulis'");
			DisplayName.AddTranslation(GameCulture.Chinese, "铁币");
			Tooltip.AddTranslation(GameCulture.Chinese, "用于购买城镇NPC“冒险家”售卖的物品\n'Valar morghulis'");
            DisplayName.AddTranslation(GameCulture.Russian, "Железная монета");
            Tooltip.AddTranslation(GameCulture.Russian, "Используется для покупок предметов в магазине Путешественника\n'Валар моргулис'");
        }

        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 28;
            item.rare = -11;
            item.maxStack = 25;
            item.value = Item.sellPrice(0, 0, 15, 45);
        }
    }
}