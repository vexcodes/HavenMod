using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using HavenMod.NPCs;

namespace HavenMod.Buffs
{
    public class greekfire : ModBuff
    {
        public override void SetDefaults()
        {
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
            longerExpertDebuff = true;
        }

        public override void Update(NPC npc, ref int buffIndex)
        {
            npc.GetGlobalNPC<NPCGlobal>(mod).greekfire = true;
            int num1 = Dust.NewDust(npc.position, npc.width, npc.height, 228);
            Main.dust[num1].scale = 2.9f;
            Main.dust[num1].velocity *= 3f;
            Main.dust[num1].noGravity = true;
        }
    }
}