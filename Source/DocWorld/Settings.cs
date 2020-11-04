using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using UnityEngine;

namespace DocWorld
{
    // Made by Fluffy and ISOREX for Dr_Zhivago's DocWorld
    public class PatchDisablerMod : Mod
    {
        public static DisablePatch_Settings Settings;

        // create a list of all the patches we want to make controllable.
        public static List<PatchDescription> Patches = new List<PatchDescription>
    {
        new PatchDescription("Coolers.xml", "DocWorld Coolers", "Should new coolers be added?"),
        new PatchDescription("Rock_Furniture.xml", "DocWorld Rock Furniture", "Should new rock furniture be added?"),
        new PatchDescription("Table_Lamps.xml", "DocWorld Table Lamps", "Should new table lamps be added?"),
        new PatchDescription("Underground_Conduits.xml", "DocWorld Underground Conduits", "Should underground conduits be added?"),
        new PatchDescription("Vents.xml", "DocWorld Vents", "Should new vents be added?"),
        new PatchDescription("Vitals_Monitors.xml", "DocWorld Vitals Monitors", "Should new vitals monitors be added?"),
        new PatchDescription("Blank.xml", "=============================Mod Features Below this Line===================================", "This is just a line. Stop reading this tooltip."),
        new PatchDescription(".Load1_DesignationCategories.xml", "Custom Categories", "This is the base file for all Architect Menu changes. If disabled, you must disable the other Category options as well."),
        new PatchDescription(".Load2_DesignationCategory_Combined.xml", "Custom Categories Combined", "Should modded architect tabs be combined into DocWorld's custom ones? Note: Depends on 'Custom Categories'"),
        new PatchDescription(".Load3_DesignationCategory_Fences.xml", "Custom Category Fences", "Should fences be given their own architect tab?"),
        new PatchDescription(".Load4_DesignationCategory_Removal.xml", "Modded Category Removals", "Should modded architect tabs be removed now that they're combined? Note: Depends on 'Custom Categories'"),
        new PatchDescription("Biome_Foraging.xml", "Biome Foraging", "Should biomes give different foraged food? Note: Requires 'Vanilla Plants Expanded' or `VGP Vegetable Garden`"),
        new PatchDescription("Cloth_Beds", "Cloth Beds", "Should beds require cloth? Note: Mods like 'Soft Warm Beds' will automatically nullify this content."),
        new PatchDescription("Dropdown_Designator.xml", "Dropdown Menus", "Should custom dropdown menus be enabled?"),
        new PatchDescription("Efficient_Power.xml", "Efficient Power", "Should utilities recieve power consumption changes?"),
        new PatchDescription("Enhanced_Miniaturisation.xml", "Enhanced Miniaturisation", "Should hand selected items become minifiable?"),
        new PatchDescription("Glass_Requisites.xml", "Glass Requisites", "Should modded lights require glass to be built? Note: Must use 'Glass+Lights' mod."),
        new PatchDescription("Linkables.xml", "Linkables", "Should more furniture link to modded linkables?"),
        new PatchDescription("Misc.xml", "Misc", "Should a variety of miscellaneous changes be done? Note: check Wiki for further info"),
        new PatchDescription("Multi_Mod_Support.xml", "Multi Mod Support", "Should changes be applied when certain mods are loaded together?"),
        new PatchDescription("Research_Projects.xml", "Research Projects", "Should research projects be combined or removed where appropriate?"),
        new PatchDescription("Stuffed_Items.xml", "Stuffed Items", "Should more items become stuffable?"),
        new PatchDescription("Textures.xml", "Textures", "Should custom textures be applied?"),
        new PatchDescription("VFE_Usable_Props.xml", "VFE Usable Props", "Should certain props be usable? Note: Requires `VFE-Props and Decor`")

        };


        public PatchDisablerMod(ModContentPack content) : base(content)
        {
            // make the settings available for other code. 
            // Note that GetSettings also loads any previously set settings so that we don't have to.
            Settings = GetSettings<DisablePatch_Settings>();

            // this does several things;
            // 1: getting Patches causes the game to load the files.
            // 2: content.Patches gets passed to us as an IEnumerable<PatchOperation> (which is essentially read-only),
            //  but it is actually a List<PatchOperation> (which we can alter), so we cast it back. Note that this works because
            // List<T> implements IEnumerable<T>, and we know the underlying type. We can't just do this to things that aren't 
            // lists.
            var allPatches = content.Patches as List<PatchOperation>;
            foreach (var patch in Patches)
            {
                if (Settings.PatchDisabled[patch] == false)
                {
                    // find our target patch, null if not found.
                    // note that `sourceFile` is the FULL file path, so we only check that it ends in the correct file name.
                    // make sure that there aren't any false positives here, include some of the folder structure if you need.
                    // and finally, actually remove the patch.
                    allPatches.RemoveAll(p => p.sourceFile.EndsWith(patch.file));
                }
            }
            // profit!
        }

        // the game expects a render function for the settings here, forwarding it to settings (this is personal preference)
        public override void DoSettingsWindowContents(Rect canvas)
        {
            Settings.DoWindowContents(canvas);
        }

        // title of the settings tab for our mod
        public override string SettingsCategory()
        {
            return "DocWorld";
        }
    }

    // define a simple struct as a data container for our patches.
    public struct PatchDescription
    {
        public string file;
        public string label;
        public string tooltip;

        public PatchDescription(string file, string label, string tooltip = null)
        {
            this.file = file;
            this.label = label;
            this.tooltip = tooltip;
        }
    }

    public class DisablePatch_Settings : ModSettings
    {
        // expose data is the games way of saving/loading data.
        private Dictionary<string, bool> _scribeHelper;

        // keep a dictionary of patches and a enabled/disabled bool
        // we initialize all patches as not disabled, we'll load their
        // values in ExposeData.
        public Dictionary<PatchDescription, bool> PatchDisabled = PatchDisablerMod.Patches.ToDictionary(p => p, p => true);
        private Vector2 scrollPosition;
        private Rect viewRect;

        // I like putting the 'render function' for settings in the settings class, vanilla would put it in the mod class. 
        public void DoWindowContents(Rect canvas)
        {
            // listing_standard is the simplest way to make an interface. It's not pretty, but it works.
            // I use it for most of my settings, as people shouldn't be spending much time there anyway.
            var options = new Listing_Standard();

            // tells the listing where it can render
            options.Begin(canvas);
            options.Label("Game has to be restarted in order for the changes to be applied!");
            options.Label("Check the github for an exact list of what each setting changes.");
            options.Label("");
            options.Label("Choose what should be enabled:");
            options.BeginScrollView(options.GetRect(400), ref scrollPosition, ref viewRect);

            // for each patch in the list of patches, render a checkbox.
            // this is one of the things that is super easy to do in options.
            // NOTE: if you have a lot of patches, you may want to try out 
            // options.BeginScrollView
            foreach (var patch in PatchDisablerMod.Patches) 
            {
                // we can't use ref on a dictionary value, so pull it out for a sec.
                var status = PatchDisabled[patch];
                options.CheckboxLabeled(patch.label, ref status, patch.tooltip);

                PatchDisabled[patch] = status;
            }
            options.EndScrollView(ref viewRect);
            
            // see also other functions on `options`, for textboxes, radio buttons, etc.
            options.End();
        }

        public override void ExposeData()
        {
            // store any values in the base ModSettings class (there aren't any, but still good practice).
            base.ExposeData();

            // save/load now becomes a bit more complicated, as we need to associate each of the patches with 
            // a specific value, while dealing with updates and such.
            // the 'proper' way to do this would be to use ILoadReferencable, but that is WAY overkill for this 
            // scenario.

            // we're going to store the filename, because that's a relatively unique identifier.
            if (Scribe.mode == LoadSaveMode.Saving)
            {
                // create the data structure we're going to save.
                _scribeHelper = PatchDisabled.ToDictionary(
                    // delegate to transform a dict item into a key, we want the file property of the old key. ( PatchDescription => string )
                    k => k.Key.file,

                    // same for the value, which is just the value. ( bool => bool )
                    v => v.Value);
            }

            // and store it. Notice that both the keys and values of our collection are strings, so simple values.
            // Note that we want this step to take place in all scribe stages, so it's not in a Scribe.mode == xxx block.
            Scribe_Collections.Look(ref _scribeHelper, "patches", LookMode.Value, LookMode.Value);

            // finally, when the scribe finishes, we need to transform this back to a data structure we understand.
            if (Scribe.mode == LoadSaveMode.PostLoadInit)
            {
                // for each stored patch, update the value in our dictionary.
                foreach (var storedPatch in _scribeHelper)
                {
                    var index = PatchDisablerMod.Patches.FindIndex(p => p.file == storedPatch.Key);
                    if (index >= 0) // match found
                    {
                        var patch = PatchDisablerMod.Patches[index];
                        PatchDisabled[patch] = storedPatch.Value;
                    }
                }
            }
        }
    }

}
