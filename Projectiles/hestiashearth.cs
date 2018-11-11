using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HavenMod.Projectiles
{
    public class hestiashearth : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(106);
            aiType = 106;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hestia's Hearth");
        }

        public override bool TileCollideStyle(ref int width, ref int height, ref bool fallThrough)
		{
			width = 10;
			height = 10;
			return true;
		}

            public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(mod.BuffType("greekfire"), 120);
            target.AddBuff(BuffID.Ichor, 300);
		}
    }
}