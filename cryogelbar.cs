using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace HavenMod.Items
{
    public class cryogelbar : ModItem
    {
        public override void SetDefaults()
        {
            item.rare = 1;
            item.maxStack = 99;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cryogel Bar");
            Tooltip.SetDefault("'You got frostbite just looking at it.'");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "cryogel", 3);
            recipe.SetResult(this);
            recipe.AddTile(16);
            recipe.AddRecipe();
        }
    }
}