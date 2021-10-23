using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace voiditems.Items.Accessories.VoidCharm
{
	public class VoidCharm : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void Charm");
			Tooltip.SetDefault("The void in the form of a charm.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 20;
			item.accessory = true;
			item.value = Item.buyPrice(platinum: 50);
			item.rare = ItemRarityID.Purple;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
			player.lifeRegenTime += 50;
			player.meleeDamageMult += 50f;
			player.meleeDamage += 50f;
			player.meleeSpeed += 50f;
        }

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 333);
			recipe.AddIngredient(ItemID.SoulofFright, 222);
			recipe.AddIngredient(ItemID.VoidDye, 50);
			recipe.AddIngredient(ItemID.ObsidianShield, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}