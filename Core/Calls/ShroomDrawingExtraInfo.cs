using CalamityMod.DataStructures;
using CalamityMod.Particles;
using Terraria;
using static ToastyQoLCalamity.ToastyQoLCalamity;

namespace ToastyQoLCalamity.Core.Calls
{
    /// <summary>
    /// An example of adding custom drawcode that would otherwise not run to the custom shrooms drawing, thus preventing some things from being invisible.
    /// </summary>
    public static class ShroomDrawingExtraInfo
    {
        public static void LoadExtraShroomDrawFuncs()
        {
            AddShroomDrawMethod((spriteBatch) =>
            { 
                for (int i = 0; i < Main.maxProjectiles; i++)
                {
                    if (Main.projectile[i].ModProjectile is not IAdditiveDrawer additiveDrawer)
                        continue;

                    additiveDrawer.AdditiveDraw(spriteBatch);
                }

                GeneralParticleHandler.DrawAllParticles(spriteBatch);
            });
        }
    }
}
