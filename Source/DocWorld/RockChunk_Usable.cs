using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace DocWorld
{   // Designed by XeoNovaDan
    [DefOf]
    public static class StuffCategoryDefOf
    {

        public static StuffCategoryDef DZ_StoneChunks;

    }

    [StaticConstructorOnStartup]
    public static class StaticConstructorClass
    {

        static StaticConstructorClass()
        {
            var thingDefs = DefDatabase<ThingDef>.AllDefsListForReading;
            for (int i = 0; i < thingDefs.Count; i++)
            {
                var tDef = thingDefs[i];
                // Implied stuffProps for stone chunks
                if (tDef.IsWithinCategory(ThingCategoryDefOf.StoneChunks) && !tDef.butcherProducts.NullOrEmpty() && tDef.butcherProducts.FirstOrDefault(t => t.thingDef.IsStuff)?.thingDef is ThingDef firstStuffProduct)
                    ResolveImpliedStoneChunkStuffProperties(tDef, firstStuffProduct.stuffProps);
            }
            ResourceCounter.ResetDefs();
        }

        private static void ResolveImpliedStoneChunkStuffProperties(ThingDef stoneChunk, StuffProperties referenceProps)
        {
            // For compatibility with other mods that make stone chunks a material
            var stuffCategories = new List<StuffCategoryDef>() { StuffCategoryDefOf.DZ_StoneChunks };
            if (stoneChunk.stuffProps?.categories is List<StuffCategoryDef> oldCats)
            {
                for (int i = 0; i < oldCats.Count; i++)
                {
                    var cat = oldCats[i];
                    if (!stuffCategories.Contains(cat))
                        stuffCategories.Add(cat);
                }
            }

            stoneChunk.resourceReadoutPriority = ResourceCountPriority.Middle;
            stoneChunk.smeltable = false;
            stoneChunk.stuffProps = new StuffProperties()
            {
                stuffAdjective = referenceProps.stuffAdjective,
                commonality = referenceProps.commonality,
                categories = stuffCategories,
                statOffsets = new List<StatModifier>(),
                statFactors = new List<StatModifier>(),
                color = referenceProps.color,
                constructEffect = referenceProps.constructEffect,
                appearance = referenceProps.appearance,
                soundImpactStuff = referenceProps.soundImpactStuff,
                soundMeleeHitSharp = referenceProps.soundMeleeHitSharp,
                soundMeleeHitBlunt = referenceProps.soundMeleeHitBlunt
            };

            var chunkProps = stoneChunk.stuffProps;

            if (referenceProps.statOffsets != null)
            {
                for (int i = 0; i < referenceProps.statOffsets.Count; i++)
                {
                    var statOffset = referenceProps.statOffsets[i];
                    chunkProps.statOffsets.Add(new StatModifier() { stat = statOffset.stat, value = statOffset.value });
                }
            }

            if (referenceProps.statFactors != null)
            {
                for (int i = 0; i < referenceProps.statFactors.Count; i++)
                {
                    var statFactor = referenceProps.statFactors[i];
                    chunkProps.statFactors.Add(new StatModifier() { stat = statFactor.stat, value = statFactor.value });
                }
            }

            ModifyStatModifier(ref chunkProps.statFactors, StatDefOf.WorkToMake, ToStringNumberSense.Factor, factor: 1.5f);
            ModifyStatModifier(ref chunkProps.statFactors, StatDefOf.WorkToBuild, ToStringNumberSense.Factor, factor: 1.5f);
        }

        private static void ModifyStatModifier(ref List<StatModifier> modifierList, StatDef stat, ToStringNumberSense mode, float offset = 0, float factor = 1)
        {
            if (modifierList.FirstOrDefault(s => s.stat == stat) is StatModifier meleeCooldownFactor)
                meleeCooldownFactor.value = (meleeCooldownFactor.value + offset) * factor;
            else
                modifierList.Add(new StatModifier() { stat = stat, value = ((mode == ToStringNumberSense.Factor ? 1 : 0) + offset) * factor });
        }

    }

}
