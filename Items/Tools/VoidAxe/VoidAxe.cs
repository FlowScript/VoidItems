using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace voiditems.Items.Tools.VoidAxe
{
	public class VoidAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void Axe");
			Tooltip.SetDefault("The void in the form of a axe.");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 28;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.UseSound = SoundID.Item1;
			item.knockBack = 50;
			item.damage = 500;
			item.value = Item.buyPrice(platinum: 50);
			item.rare = ItemRarityID.Purple;
			item.autoReuse = true;
			item.useTurn = true;
			item.melee = true;
			item.axe = 10000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 333);
			recipe.AddIngredient(ItemID.SoulofFright, 222);
			recipe.AddIngredient(ItemID.Wood, 111);
			recipe.AddIngredient(ItemID.VoidDye, 50);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}