using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace voiditems.Items.Armours.VoidedChestplate
{
	[AutoloadEquip(EquipType.Body)]
	public class VoidedChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Voided Chestplate");
			Tooltip.SetDefault("A chestplate that has seen the void.");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 18;
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
			recipe.AddIngredient(ItemID.ShadowOrb, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}