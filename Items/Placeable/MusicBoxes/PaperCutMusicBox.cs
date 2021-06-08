using MoToolsSound.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace MoToolsSound.Items.Placeable.MusicBoxes
{
    public class PaperCutMusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Paper Cut)");
            Tooltip.SetDefault("");
        }

        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.maxStack = 1;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = TileType<Tiles.MusicBoxes.PaperCutMusicBox>();
            item.accessory = true;
        }

        /*public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MusicBox, 1);
            recipe.AddIngredient(MoToolsSound.MoTools.GetItem("SoulOfThought"), 5);
            recipe.AddIngredient(MoToolsSound.MoTools.GetItem("Paper"), 30);
            recipe.AddTile(MoToolsSound.MoTools.GetTile("ExtremeForge"));
            recipe.SetResult(this);
            recipe.AddRecipe();
        }*/
    }
}