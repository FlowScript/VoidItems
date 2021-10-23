using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace voiditems.Items.Tools.VoidHammer
{
	public class VoidHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void Hammer");
			Tooltip.SetDefault("The void in the form of a hammer.");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 32;
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
			item.hammer = 10000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 333);
			recipe.AddIngredient(ItemID.SoulofFright, 222);
			recipe.AddIngredient(ItemID.WoodWall, 111);
			recipe.AddIngredient(ItemID.VoidDye, 50);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}