using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace voiditems.Items.Weapons.VoidGunUzi
{
	public class VoidGunUzi : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fast Void Gun");
			Tooltip.SetDefault("The void in the form of a gun. (Faster)");
		}

		public override void SetDefaults()
		{
			item.damage = 10000;
			item.ranged = true;
			item.width = 42;
			item.height = 30;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 50;
			item.value = Item.buyPrice(platinum: 50);
			item.rare = ItemRarityID.Purple;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 64f;
			item.useAmmo = AmmoID.Bullet;
			item.useTurn = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 333);
			recipe.AddIngredient(ItemID.SoulofFright, 222);
			recipe.AddIngredient(ItemID.IllegalGunParts, 111);
			recipe.AddIngredient(ItemID.VoidDye, 50);
			recipe.AddIngredient(ItemID.FastClock, 5);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}