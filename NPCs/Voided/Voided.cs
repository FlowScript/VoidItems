using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace voiditems.NPCs.Voided
{
	[AutoloadHead]
	public class Voided : ModNPC
	{
        public override string Texture
        {
            get { return "voiditems/NPCs/Voided/Voided";  }
        }

        public override bool Autoload(ref string name)
        {
            name = "Voided";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            Main.npcFrameCount[npc.type] = 26;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 5;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 100;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 20;
            npc.defense = 2;
            npc.lifeMax = 15;
            npc.HitSound = SoundID.NPCHit36;
            npc.DeathSound = SoundID.NPCDeath36;
            npc.knockBackResist = 0.4f;
            animationType = NPCID.Guide;
        }

        public override bool CanTownNPCSpawn(int numTownNPCs, int money)
        {
            for (int k = 0; k < 255; k++)
            {
                Player player = Main.player[k];
                if(!player.active)
                {
                    continue;
                }

                if(Main.hardMode)
                {
                    foreach (Item item in player.inventory)
                    {
                        if (item.type == ItemID.SoulofFlight || item.type == ItemID.SoulofNight)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public override string TownNPCName()
        {
            switch(WorldGen.genRand.Next(10))
            {
                case 2:
                    return "Mike";
                default:
                    return "Void";
            }
        }

        public override string GetChat()
        {
            if(npc.GivenName == "Mike")
            {
                switch (Main.rand.Next(20))
                {
                    case 4:
                        return "I'm no criminal!";
                    default:
                        return "What can I do for you today young one?";
                }
            }
            return "What can I do for you today young one?";
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Language.GetTextValue("LegacyInterface.28");
            button2 = "Teach me how to craft the items.";
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if(firstButton)
            {
                shop = true;
            }
            else
            {
                Main.npcChatText = "Use the guide to teach you how to craft them.\n\nHere are some hints:\n\nThey all need Souls of Night and Souls of Fright to be crafted.\nThey are all crafted on a Demon Altar.\n\nGood luck.";
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidSword"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidGun"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidGunUzi"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidPick"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidAxe"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidHammer"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidedHelmet"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidedChestplate"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidedGreaves"));
            nextSlot++;
            shop.item[nextSlot].SetDefaults(mod.ItemType("VoidCharm"));
            nextSlot++;
        }

        public override void NPCLoot()
        {
            Item.NewItem(npc.getRect(), ItemID.VoidDye, 2);
        }

        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 2f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 100;
            randExtraCooldown = 25;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = ProjectileID.DemonScythe;
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 5f;
            randomOffset = 2f;
        }
    }
}