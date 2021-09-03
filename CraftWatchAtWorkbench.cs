using Terraria.ModLoader;
using Terraria;
using Terraria.ID;

namespace CraftWatchAtWorkbench
{
	public class CraftWatchAtWorkbench : Mod
	{
		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(this);

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.CopperBar, 10);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.CopperWatch);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TinBar, 10);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.TinWatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.SilverBar, 10);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.SilverWatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.TungstenBar, 10);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.TungstenWatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.GoldWatch);
			recipe.AddRecipe();

			recipe = new ModRecipe(this);
			recipe.AddIngredient(ItemID.PlatinumBar, 10);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.PlatinumWatch);
			recipe.AddRecipe();
		}
	}
}