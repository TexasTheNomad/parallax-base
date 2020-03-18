using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace CosmicParallax.Items.Blocks
{
	public class Astrite_Ore : ModItem

	{
		public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Astrite Ore");
        }
		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.rare = ItemRarityID.Blue;
			item.value = Item.buyPrice(silver: 4);
			item.maxStack = 999;
		}
	}
}