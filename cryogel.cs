using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
// If you are using c# 6, you can use: "using static Terraria.Localization.GameCulture;" which would mean you could just write "DisplayName.AddTranslation(German, "");"
using Terraria.Localization;

namespace HavenMod.Items
{
    public class cryogel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cryogel");
            Tooltip.SetDefault("'Solid only due to its frigid temperature'");
        }

        public override void SetDefaults()
        {
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("cryogelore");
            item.value = 100;
            item.rare = 1;
            
        }
    }
}
