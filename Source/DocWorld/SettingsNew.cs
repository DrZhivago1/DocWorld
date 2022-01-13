using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using UnityEngine;
using HugsLib;
using HugsLib.Settings;

namespace DocWorld
{
	public class Settings : ModBase
	{
		private List<Patch> Patches = new List<Patch>
		    {
        new Patch("Coolers.xml", "DocWorld Coolers", "Should new coolers be added?"),
        new Patch("Rock_Furniture.xml", "DocWorld Rock Furniture", "Should new rock furniture be added?"),
        new Patch("Table_Lamps.xml", "DocWorld Table Lamps", "Should new table lamps be added?"),
        new Patch("Underground_Conduits.xml", "DocWorld Underground Conduits", "Should underground conduits be added?"),
        new Patch("Vents.xml", "DocWorld Vents", "Should new vents be added?"),
        new Patch("Vitals_Monitors.xml", "DocWorld Vitals Monitors", "Should new vitals monitors be added?"),
        new Patch(".Load1_DesignationCategories.xml", "Custom Categories", "This is the base file for all Architect Menu changes. If disabled, you must disable the other Category options as well."),
        new Patch(".Load2_DesignationCategory_Combined.xml", "Custom Categories Combined", "Should modded architect tabs be combined into DocWorld's custom ones? Note: Depends on 'Custom Categories'"),
        new Patch(".Load3_DesignationCategory_Fences.xml", "Custom Category Fences", "Should fences be given their own architect tab?"),
        new Patch(".Load4_DesignationCategory_Removal.xml", "Modded Category Removals", "Should modded architect tabs be removed now that they're combined? Note: Depends on 'Custom Categories'"),
        new Patch("Biome_Foraging.xml", "Biome Foraging", "Should biomes give different foraged food? Note: Requires 'Vanilla Plants Expanded' or `VGP Vegetable Garden`"),
        new Patch("Cloth_Beds.xml", "Cloth Beds", "Should beds require cloth? Note: Mods like 'Soft Warm Beds' will automatically nullify this content."),
        new Patch("Dropdown_Designator.xml", "Dropdown Menus", "Should custom dropdown menus be enabled?"),
        new Patch("Efficient_Power.xml", "Efficient Power", "Should utilities recieve power consumption changes?"),
        new Patch("Enhanced_Miniaturisation.xml", "Enhanced Miniaturisation", "Should hand selected items become minifiable?"),
        new Patch("Glass_Requisites.xml", "Glass Requisites", "Should modded lights require glass to be built? Note: Must use 'Glass+Lights' mod."),
        new Patch("Linkables.xml", "Linkables", "Should more furniture link to modded linkables?"),
        new Patch("Misc.xml", "Misc", "Should a variety of miscellaneous changes be done? Note: check Wiki for further info"),
        new Patch("Multi_Mod_Support.xml", "Multi Mod Support", "Should changes be applied when certain mods are loaded together?"),
        new Patch("Research_Projects.xml", "Research Projects", "Should research projects be combined or removed where appropriate?"),
        new Patch("Stuffed_Items.xml", "Stuffed Items", "Should more items become stuffable?"),
        new Patch("Textures.xml", "Textures", "Should custom textures be applied?"),
        new Patch("VFE_Usable_Props.xml", "VFE Usable Props", "Should certain props be usable? Note: Requires `VFE-Props and Decor` and `LWM Deep Storage`")
        };

        // Settings handler; Uses HugsLib to work.
    public override string ModIdentifier
		{
            get => "DocWorld";
		}
        // 
		private SettingHandle<bool> isdisabled;
        public override void DefsLoaded()
		{
            var allPatches = base.ModContentPack.Patches as List<PatchOperation>;
            foreach (Patch p in Patches)
            {
                // Unload patch if it is disabled.
                isdisabled = Settings.GetHandle(p.Name, p.Title, p.Description, false);
                if (isdisabled != null)
                {
                    allPatches.RemoveAll(curp => curp.sourceFile.EndsWith(p.File));
                }
            }
		}
    }
}
