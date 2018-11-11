using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace HavenMod.NPCs
{
    public class NPCGlobal : GlobalNPC
    {
        public bool greekfire = false;

        public override void ResetEffects(NPC npc)
        {
            greekfire = false;
        }

        public override void UpdateLifeRegen(NPC npc, ref int damage)
        {
            if (greekfire)
            {
                npc.lifeRegen -= 35;
                if (damage < 2);
            }
        }

                public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}
    }
}