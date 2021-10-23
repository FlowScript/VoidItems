using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace voiditems.Items.Armours.VoidedHelmet
{
	[AutoloadEquip(EquipType.Head)]
	public class VoidedHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Voided Helmet");
			Tooltip.SetDefault("A helmet that has seen the void.");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 22;
			item.value = Item.buyPrice(platinum: 50);
			item.rare = ItemRarityID.Purple;
			item.defense = 10000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 333);
			recipe.AddIngredient(ItemID.SoulofFright, 222);
			recipe.AddIngredient(ItemID.VoidDye, 50);
			recipe.AddIngredient(ItemID.ShadowHelmet, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
			return body.type == ItemType<VoidedChestplate.VoidedChestplate>() && legs.type == ItemType<VoidedGreaves.VoidedGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
			player.lifeRegen += 50;
			player.meleeDamage += 50f;
			player.maxRunSpeed += 50f;
			player.moveSpeed += 50f;
        }
    }
}