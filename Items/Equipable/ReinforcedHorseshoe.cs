﻿
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace GoldensMisc.Items.Equipable
{
	public class ReinforcedHorseshoe : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return ServerConfig.Instance.ReinforcedVest;
		}
		
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 24;
			item.rare = 4;
			item.defense = 4;
			item.accessory = true;
			item.value = Item.buyPrice(0, 20);
		}
		
		public override void UpdateEquip(Player player)
		{
			player.noFallDmg = true;
			player.fireWalk = true;
			player.GetModPlayer<MiscPlayer>().ExplosionResistant = true;
		}
		
		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ObsidianHorseshoe);
			recipe.AddIngredient(ModContent.ItemType<ReinforcedVest>());
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
