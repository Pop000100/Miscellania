﻿
using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace GoldensMisc.Items.Equipable.Vanity
{
	public class MythrilDye : ModItem
	{
		public override bool Autoload(ref string name)
		{
			return Config.ExtraDyes;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reflective Mythril Dye");

			DisplayName.AddTranslation(GameCulture.Russian, "Светоотражающий мифриловый краситель");
			DisplayName.AddTranslation(GameCulture.Chinese, "反光秘银染料");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50);
			item.rare = 3;
		}
	}
}