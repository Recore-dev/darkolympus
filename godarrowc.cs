using darkolympus.godarrow;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace darkolympus.godarrow { 
	public class godarrowc : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("If you have this, I fucked up.");
		}

		public override void SetDefaults() {
			item.damage = 200;
			item.ranged = true;
            item.scale = 2f;
			item.width = 40;
			item.height = 40;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
            item.shoot = mod.ProjectileType("godarrow");
            item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
		}

        // Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
        public override void OnConsumeAmmo(Player player)
        {
            if (Main.rand.NextBool(5))
            {
                player.AddBuff(BuffID.Daybreak, 1000);
            }
        }
    }
}
