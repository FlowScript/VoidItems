using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace voiditems.Items.Weapons.VoidSword
{
	public class VoidSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Void Sword");
			Tooltip.SetDefault("The void in the form of a sword.");
		}

		public override void SetDefaults() 
		{
			item.damage = 10000;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 50;
			item.value = Item.buyPrice(platinum: 50);
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.useTurn = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 333);
			recipe.AddIngredient(ItemID.SoulofFright, 222);
			recipe.AddIngredient(ItemID.IronBar, 111);
			recipe.AddIngredient(ItemID.VoidDye, 50);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}