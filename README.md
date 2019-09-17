# DocWorld
A mod of combined patches for Vanilla RimWorld, and my RimWorld mod collection [The Doctor's World](https://steamcommunity.com/sharedfiles/filedetails/?id=1568763074).

The basics are: mod moves items to new tabs and organizes layout, balances some recipes for various items, enhances miniaturisation abilities, adds underground power conduits, improves inter-mod compatibility. There are a lot of patches done to the various mods outlined in the [Changelog](https://github.com/DrZhivago1/DocWorld/blob/master/README.md#changelog). I suggest you read there for detailed information.

_[Link to Steam](https://steamcommunity.com/sharedfiles/filedetails/?id=1568744597)_

_[Link to Ludeon](https://ludeon.com/forums/index.php?topic=47165.msg447416#msg447416)_


## [License](https://creativecommons.org/licenses/by-nc-sa/4.0/)

# Save-Friendliness and Compatibility
__*Mod Compatibility*__
- Requires loading below ["Extended Storage Extended"](https://github.com/Terragg/Extended-Storage-Extended) if mod is used.
- Requires loading below ["Gloomy Vanilla"](https://steamcommunity.com/sharedfiles/filedetails/?id=1697864590) if mod is used.
- Requires loading below ["Industrialisation"](https://steamcommunity.com/sharedfiles/filedetails/?id=1463579055) if mod is used.

__*Save Compatibility*__

There is only one patch that causes larger incompatibility. This incompatibility only exists IF you are using the mod "Dubs Bad Hygiene" AND "RF Fertile Fields". This is due to the fact that I remove biosolids and fertilizing from "Dubs Bad Hygiene". So it may break your current save-game, but more than likely there will only be a lot of errors generated upon first loading into an existing game. These errors occur due to any existing biosolids being deleted, as well as any soil previously fertilized with them. I've tested on-going saves with this patch, and my save was not broken by the changes made. New games will not suffer any issues other than 2 error logs generated at game start-up from the missing defs, but it is harmless. The errors look like: "Failed to find Verse.ThingDef named Biosolids. There are XXXX defs of this type loaded." **To remove that patch and allow this mod to be save-friendlier, navigate to "DocWorld/Patches" and find "DubsBadHygiene_RFFertileFields.xml" and then either hide it or delete it.**

The only other thing to note is that there may be some issues with floors/items going missing if you use various other mods. This *should* not be save-breaking, it means you need to redo your floors or may lose some redundant items from stockpiles. The more mods you use, the more likely it is to have complications on current saves. Use with caution.

# Changelog
Date Format: DD/MM/YYYY

**v1.0.13 (00/00/0000):**

	Updated "LWM Deep Storage" designation category patches.
	Updated "Glass+Lights" patches. Glass is a common ingredient in lights. Supported mods: Additional Joy Objects (classic/lite), Industrial Age - Objects and Furniture, RIMkea, Vanilla Furniture Expanded, Vanilla Furniture Expanded - Spacer Module
	Vanilla butcher table and vent are 'stuffed'.
	Vanilla lights are now more efficient, this replaces the need for "Chickens Effecient Light".
	
	IF "Dubs Bad Hygiene" is installed:
		'Stuff' the SewageOutlet.
		
	IF "Expanded Woodworking" AND "Survivalist's Additions" are installed:
		Enables building with the wood types from "Expanded Woodworking". Applies masks.
		
	IF "FishIndustry" is installed:
		Rotatable AquacultureBasin, changed designation category, and new art assets applied (FishingPier, FishingPierSpawner, MenuIcon_FishingPierSpawner, MicroFungus).
		
	IF "Floored" is installed:
		Group floor types into dropdown designators and match textures if using "Simply More Bridges".
		
	IF "Industrialisation" is installed:
		Patch Vanilla paved tile flooring to use concrete.
		
	IF "More Furniture [1.0]" is installed:
		Groups the "More Furniture" carpet with the vanilla carpet.
		
	IF "[1.0] RimCuisine 2 Core" is installed:
		Change biome foraged foods.
		
	IF "[1.0] RimCuisine 2 Core" AND "[RF] Realistic Planets [1.0]" are installed:
		Change biome foraged foods, and include agriculture patch to RF biomes.
		
	IF "Simple Concrete" AND "Simply More Bridges" are installed:
		Replace the cost of concrete bridges with concrete.
		
	IF "Simply More Bridges" AND "Industrialisation"/"Simple Concrete" AND "Roads of the Rim" are installed:
		Replace/add texture and recipe for Concrete bridges.
	
	IF "Vanilla Armour Expanded" AND "NightVision" are installed:
		Remove NightVision goggles from NV, VAE has a pair(check the NV settings for allowing nightvision goggles).

	IF "VGP Fabrics" AND "RimCuisine 2" are installed:
		Replace flax plant harvest with raw flax.
	
	IF "VGP Fabrics" AND "RimCuisine 2" AND "SeedsPlease" are installed:
		Add rot to flax plant.
		
	IF "VGP Garden Gourmet" is installed:
		'Stuffs' the VGP-GG worktables. Applies masks.

**v1.0.12 (21/08/2019):**

	Now requires being loaded below "Gloomy Vanilla" if the mod is used. This is due to patching patches.
	Changed all designation category def names to be unique and better support adapting mods into new categories.
	Rewrote the "ClothBeds" modification so it is friendlier and nullified if using with other similar mods. Support for: Vanilla, Gloomy Furniture, RimJobWorld, RIMkea, Vanilla Furniture Expanded, Vanilla Furniture Expanded - Spacer Module.
	Removes "Fences" designation category if not using any Fence mods.
	Add dropdown designator for Vanilla standing lamps.
	Updated AJO-Lite mod name in patches.
	Updated "DubsBadHygiene_RFFertileFields" (irrigation sprinklers and composter now in "Farming" tab).
	Updated "Glass+Lights_Lighting" (outdoor ground lamp in proper category and cieling lamps combined in one dropdown menu).
	Updated "DubsSkyLights_Lighting" (updated lighting designation category name).
	Updated "LWM Deep Storage" (patches better reflect storage categories and recent update, though this will likely need to be updated again very soon).
	
	IF "Additional Joy Objects" lite/classic is/are installed:
		Move painting easel to "joy" category.
	
	IF "Centralized Climate Control" is installed:
		Move all items to "Temperature" category.
		
	IF "Complete Tech Solutions" is installed:
		Move bed to "Beds" category.
		
	IF "Dubs Bad Hygiene" is installed:
		Put Ceiling fans into dropdown designator.
		
	IF "Fast Regen" is installed:
		Move beds to "Beds" category.
	
	IF "Glitter Tech"/"Glitter Tech (No Surgery)" is installed:
		Move beds and lights to respective categories.
	
	IF "Gloomy Vanilla" is installed:
		Move lights to "Lighting" and fences to "Fences" category.
	
	IF "Glowstone" is installed:
		Move lights into their respective category, and remove designation category from mod.
	
	IF "RimJobWorld" is installed:
		Move beds to "Beds" category.
		
	IF "Sparkling Worlds" is installed:
		Move bed to "Beds" category.
	
	IF "Steam Light" is installed:
		Move lights into their respective category.
		
	IF "Vanilla Fences" is installed:
		Moves fences to "Fences" tab.
		
	IF "Vanilla Furniture Expanded - Spacer Module" is installed:
		Remove VFE category and put all furniture into their respective categories.
	
	IF "VGP Fabrics" AND "MendandRecycle" are installed:
		Remove salvaging from Loom.
		
	IF "VGP Fabrics" AND "SeedsPlease" are installed:
		Clean up storage categories.
		
	IF "RF Fertile Fields" AND "SeedsPlease" are installed:
		Move seeds production bench to "farming" category.	
		
	IF "[1.0] RimCuisine 2 Core" and/or the sub-mods are installed:
		Create new category called "Culinary" and move all cooking/brewing items into it. Remove RC2 designation category.
	
	IF "RIMkea" is installed:
		Put Shainbrait and Kageshain lights into dropdown designators.
		
	IF "Wall Sun Lamp" is installed:
		Move lights into their respective category, if "Fertile Fields" is installed the Sun Lamp goes into farming category.
		
	IF "ZARS Production Spots" AND "RimCuisine 2" are installed:
		Move production spots into drop down designator from ZARS, move brewing/butcher spots to "Culinary" category, and remove excess brewing spot from RC2.	

**v1.0.11 (08/08/2019):**

	Now requires being loaded below "Extended Storage Extended" and/or "Industrialisation" if the mod/s are used. This is due to patching patches.
	Updated patch for "Glass+Lights" to reflect mod updates.
	Removed "Colony Leadership" patch for sound errors, fixed by mod author.
	Removed "VGPGardenFabrics_ThrumboExtension", author of VGP used my patch.
	Removed "VGPGardenFabrics_AnimalCollabProj", author of VGP used my patch.
	Added new "Beds" tab for all beds. Supported Mods: RIMKea, LoTR, [sd] goodnight, Vanilla Furniture Expanded/Medical Module
	Added new "Storage" tab for all shelving furniture. Supported mods: LWM's Deep Storage, RimWriter, Vanilla Furniture Expanded, Extended Storage, Extended Storage Extended
	
	IF "Ceiling Lights" is installed:
		Moves all lights to the Lighting tab.
	
	IF "Combat Extended" AND "[SYR] Individuality" are installed:
		Patch 'Expert Shooter' accuracy bonus to be in line with Combat Extended. -Thanks to XeoNovaDan
	
	IF "Expanded Woodworking" AND "Simple Chains: Leather" are installed:
		Tanning liquor made from logs.

	IF "Floor Lights" is installed:
		Moves all lights to the Lighting tab.
		
	IF "LWM's Deep Storage" is installed:
		Adds categories and items to storage furniture for change to Vanilla as well as "VGP Garden Fabrics".
		
	IF "Medical Training" AND "Thanks For All The Fish" are installed:
		Removes fish from training recipe on medical training table.
		
	IF "Outdoor Lighting" is installed:
		Moves all lights to the Lighting tab.

	IF "RIMkea" is installed:
		Nerf values for work to build/comfort/beauty on furniture items.
		
	IF "Soft Warm Beds" is installed:
		Move beds to Beds tab.
		
	IF "Un-Colony" AND "Glass+Lights" are installed:
		Remove and replace all UN-Colony glass.
		
	IF "Un-Colony" AND "Industrialisation" are installed:
		Remove and replace all Industrialisation concrete.
		
	IF "Vanilla Furniture Expanded" is installed:
		Remove VFE category and put all furniture into their respective tabs.
		Add recipes to stone campfire from mods: "Fertile Fields", "RazzleDazzle!", "Simple Chains: Leather".
		
	IF "Vanilla Furniture Expanded" AND "Additional Joy Objects/Classic" are installed:
		Remove VFE dartboard and arcade.
		
	IF "Vanilla Furniture Expanded" AND "Industrial Age - Objects and Furniture" are installed:
		Remove Industrial Age radio.
		
	IF "Vanilla Furniture Expanded" AND "Misc. Training"/"Combat Training" are installed:
		Remove VFE punching bag.
		
	IF "VGP Garden Fabrics" AND "MendAndRecycle" are installed:
		Remove salvage recipe from loom, as it is on tailoring bench, which seems more appropriate.
		
	IF "ZARS Production Spots" AND "Thanks For All The Fish" OR "RimCuisine" are installed:
		Move production spots into drop down designator from ZARS.

**v1.0.10 (04/03/2019):**

	Moved the Changelog into the README.md
	Fixed RoM-Bones_StuffedFloors patch
	Changed underground conduit defName, this will delete conduits from ongoing saves (so replace them).
	Buffed the mass of various minifiable Vanilla items (only items from 1.0.0 release of DocWorld).
	Removed "Weapon Tech" error fixing patch, no longer needed.
	
	IF "DDA Security and More" AND "Doors Expanded" are installed:
		Remove DDA blastdoor research and replace research with Doors Expanded version.
	
	IF "DDA Security and More" AND "Fences and No Floors"/"Fences and Floors" are installed:
		Remove fence research and move fences to Fences tab.
		
	IF "Dubs Hygiene" is installed:
		Moves "CeilingFanS" to Hygiene designation category.
		
	IF "Dubs Hygiene" AND "RF Fertile Fields" are installed:
		The composter is usable and produces RF Fertile Field compost. May cause minor issues with ongoing saves.
		Returns previously removed JobDef "LoadComposter" and "UnloadComposter".
		Returns previously replaced "WaterFiltration" research prerequisites to "SepticTanks".
		Returns previously removed "SewageSludgeComposting" research.
		Returns previously removed "BiosolidsComposter".
		Returns previously removed WorkGiver "UnloadComposter".
		Returns previously removed WorkGiver "FillComposter".
		Continues to remove "BiosolidFertilizer".
		Continues to remove "Biosolids".
		
	IF "LED Lights" is installed:
		Move all lights to Lighting tab.
		
	IF "Repair Workbench" AND "Survival Tools" are installed:
		Add tools to weapon repair recipe.

**v1.0.9 (06/01/2018):**

	IF "Architect Icons" is installed:
		Added more mod support for pictures.
		
	IF "Change Dresser" is installed:
		Added compatibility to [sd] Goodnight, RIMkea, LOTRE, Gloomy Furniture, Medeival Times, Polyamory Beds.
	
	IF "Dubs Bad Hygiene" is installed:
		"Ceiling Fan" requires electricity research.

	IF "Extended Storage" is installed:
		Adds some categories to various storage furniture for better compatibility with "RimCuisine" and "Rim of Madness - Bones".
	
	IF "VGP Xtra Trees and Flowers" AND "Realistic Planets" AND "Expanded Woodworking" are installed:
		Add wood logs and lumber to VGP Trees.

**v1.0.8 (18/12/2018):**
	
	Updated Vanilla and modded miniaturisation Defs.
	Removed "Expanded Woodworking"/experimental patches, as they are now integrated into the main mod/not useful.
	
	IF "High Tech Labratory Facilities" is installed:
		Moves countertop behind complex furniture research.
	
	IF "RimCuisine" AND "SeedsPlease" are installed:
		Removes extra cocoa recipes and items.
		
	IF "RIMkea" AND "CuprosStones" are installed:
		Allows all chunks to be used for BULDRESTStool.
		
	IF "VGP Garden Fabrics" AND "Vanilla Animals Overhaul Reloaded" are installed:
		Allows new wools to be used on blended wool recipe.
	
	IF "VGP Garden Fabrics" AND "RimCuisine" are installed:
		Wild flax drops raw flax instead of cloth.
		
**v1.0.7 (07/12/2018):**
	
	IF "Glass+Lights" is installed:
		Make lights require "Electricity" as research prerequisite and make outdoor ground lamp require electricity.
		
	IF "Industrial Age - Objects and Furniture" AND "VGP Garden Gourmet" are installed:
		Allow basic gourmet recipes to be cooked at the wood burning stove.
		
	IF "Nature's Pretty Sweet" is installed:
		Alter forageability of biomes.
	
	IF "LoTR Elves" AND/OR "LoTR Dwarves" is installed:
		Move all lighting to "Lighting" designation category.
	
	IF "LoTR Elves" AND "Fences and No Floors" are installed:
		Moves fences to "Fences" category.
		
	IF "LoTR Elves" AND "[sd] goodnight" are installed:
		Moves beds to "sd_beds" designation category.
		
	IF "LoTR Elves" AND/OR "LoTR Dwarves" AND "Industrial Age - Objects and Furniture" are installed:
		Make chandeliers and candelabras require wax for fuel.
	
	IF "RIMkea" is installed:
		Move fireplace to "Temperature" designation category.
	
	IF "Smoked Meat" is installed:
		Hides ability to smoke meat behind pemmican research, the smoke house also requires complex furniture.

**v1.0.6 (01/12/2018):**

	Optimized this mods patch coding for faster game load times.
	Fixed error logs produced from redundant or missing code with PhiClient, Weapon Tech, and Colony Leadership.
	Added underground power conduits, invisible, cost 2 steel, neutral beauty.
	
	IF "Architect Icons" is installed:
		Adds a "Lighting" icon for the "Lighting" designation category.
		Adds a "Bomb" icon for "Remote Tech" designation category.
		Adds a "Sketch" icon for "More Planning" designation category.
		Adds a "Saloon" icon for "Gloomy Furniture" designation category.

	IF "Dubs Bad Hygiene" is installed:
		Moves "Cieling Fan" to "Lighting" designation category.
		
	IF "Glass+Lights" AND "Dubs Skylights" are installed:
		Removes "Dubs Skylights" glass and recipes in favor of "Glass+Lights".
	
	IF "Gloomy Furniture" is installed:
		Adds cloth to bed recipes.
		
	IF "Harvest Organs" AND "VGP Garden Medicine" are installed:
		Removes most VGP medicine from harvesting recipes where overpowered.

	IF "Harvest Organs" AND "Alpha Animals" are installed:
		Removes "Cactipine Quill" from harvesting recipes where overpowered.

	IF "Industrial Age - Objects and Furniture" is installed:
		Moves light sources to "Lighting" tab.
		Makes gas lamps actually require and use chemfuel.
		Moves telescope to "Joy"(aka Recreation) tab.
		Makes "Complex Furniture" required research for "Telescope".
	
	IF "Rim of Madness - Bones" is installed:
		Nerfs bone wall by 50 hitpoints.
	
	IF "Rim of Madness - Bones" AND "Expanded Woodworking" are installed:
		Allows bones to be used in wood recipes where it makes sense. (Minor bug allows "WoodLog Walls" to be made of bone).
	
	IF "Rim of Madness - Bones" AND "Stuffed Floors" are installed:
		Moves all floors into a single drop-down menu on the "Foors" designation category.

	IF "RIMkea" is installed:
		Moves light sources to "Lighting" tab.
		Moves furniture to "Furniture" tab.
		Adds cloth requirement to colonist beds.
		Moves floors to "Floors" tab.
		Removes designation category "RIMkea" as all items are moved out and to Vanilla tabs.

	IF "RIMkea" AND "Stuffed Floors" are installed:
		Removes "RIMkea" stone floors as they are redundant.

	IF "[sd] goodnight" AND "RIMkea" are installed:
		Moves "RIMkea" beds to "Beds" tab.

**v1.0.4 (29/11/2018):**

	Alphabetize designation categories for Vanilla, More Planning, RF Fertile Fields, Fences and No Floors, Colony Leadership, sd Goodnight, Dubs Bad Hygiene, Remote Tech.
	Vanilla colonist beds require cloth to build.
	
	IF "[sd] goodnight" is installed:
		Moves all Vanilla beds to "Beds" designation category.
		
	IF "Extended Storage" is installed:
		Most storage containers now require "Complex Furniture" research. (Not food basket or wooden pallet).
		
	IF "Replace Stuff" is installed:
		Adds "Replace Stuff" function to Furniture and Production designation category.
		
	IF "Wall Light" is installed:
		Moves lights to "Lighting" designation category.

**v1.0.2 (26/11/2018):**

	IF "Dubs SkyLights" is installed:
		Moves skylights to "Lighting" designation category.
		
	IF "BetterCoolers" is installed:
		Changes cooler texture to new RedistHeat texture. Prettifying.
		
	IF "Nature's Pretty Sweet" is installed:
		Adds forageability to biomes.
		
	IF "VGP Garden Fabrics" AND "Animal Collab Project are installed:
		Adds wools from animals in "Animal Collab Project" to VGP loom "Blended Wool" recipe.
		
	IF "VGP Garden Fabrics" AND "Thrumbo Extension" are installed:
		Adds "Thrumbo Wool" to VGP loom "Blended Wool" recipe.

**v1.0.0 (18/11/2018):**

	Creates a "Lighting" tab(Designation Category) and moves all vanilla, and supported mod lights, under the tab.
	Allows Hopper, Orbital Trade Beacon, Moisture Pump, Comms Console, MultiAnalyzer, Ground Penetrating Scanner, Hi-Tech Research Bench, Pod Launcher, Sarcophagus, Power Switch, Wood Fired Generator, Chemfuel Powered Generator, Wind Turbine, and Solar Generator to be minified with mass.

	IF "Additional Joy Objects" is installed:
		Replaces chandelier "Furniture" designation category to "Lighting".
		Allows miniaturisation of Arcade Construction Table.

	IF "Advanced Power Generation" is installed:
		Alters miniaturisation of Advanced Wind Turbine.
		Alters miniaturisation of Advaned Solar Generator.
		Removes miniaturisation of Advanced Geothermal Generator.
		Alters miniaturisation of Advanced Nuclear Powerplant.

	IF "Dead Goat's Weapon Pack" AND "Expanded Woodworking" are installed:
		Replaces stuff categories, changes "Woody" to "RawWoody" for making Blowgun.
		Replaces stuff categories, changes "Woody" to "RawWoody" for making Solanine Blowgun.
		Replaces stuff categories, changes "Woody" to "RawWoody" for making Neurotoxin Blowgun.
		Replaces stuff categories, changes "Woody" to "RawWoody" for making Knuckles.
		Replaces stuff categories, changes "Woody" to "RawWoody" for making Staff.
		Replaces stuff categories, changes "Woody" to "RawWoody" for making Skullclub.
		Replaces stuff categories, changes "Woody" to "RawWoody" for making Macuahuitl.

	IF "Dubs Hygiene" is installed:
		Removes "HygieneMisc" designation category.
		Replaces "airPipe" designation category to "Temperature".
		Replaces "ToiletStallDoor" designation category to "Structure".
		Removes "LitterBox" designation category.
		Removes "KitchenSink" designation category.
		Removes "WashingMachine" designation category.
		Adds designation category "Temperature" to "BasedHeating" Abstract.
		Adds designation category "Temperature" to "SolarHeater".
		Adds designation category "Temperature" to "BaseRadiator" Abstract.
		Removes "AirConOutdoorUnit" designation category.
		Replaces "BaseAircon" designation category to "Temperature".
		Removes "IrrigationSprinkler" designation category.
		Replaces "FireSprinkler" designation category to "Misc".
		Removes "plumbingValve" designation category.
		Removes "BiosolidsComposter" designation category.
		Removes "BiosolidFertilizer" designation category.
		Allows miniaturisation of Wind Pump.

	IF "Dubs Hygiene" AND "RF Fertile Fields" are installed:
		Removes JobDef "LoadComposter" and "UnloadComposter".
		Replaces "WaterFiltration" research prerequisites to "SepticTanks".
		Removes "SewageSludgeComposting" research.
		Removes "BiosolidsComposter".
		Removes "BiosolidFertilizer".
		Removes "Biosolids".
		Removes WorkGiver "UnloadComposter".
		Removes WorkGiver "FillComposter".
		Adds designation category "RFF_Farm" to "IrrigationSprinkler".

	IF "ED-Shields Basic" is installed:
		Allows miniaturisation of Standard Shield.
		Allows miniaturisation of Small Shield.
		Allows miniaturisation of Fortress Shield.
		Allows miniaturisation of SIF Shield.

	IF "Glass+Lights" is installed:
		Replaces "CeilingLampBase" Abstract designation category to "Lighting".
		Replaces "StandingLampBase" Abstract designation category to "Lighting".

	IF "High Tech Laboratory Facilities" is installed:
		Allows miniaturisation of Modular Conter Top.
		Allows miniaturisation of Lab Station.
		Allows miniaturisation of Lab Terminal.

	IF "Medical Training" is installed:
		Allows miniaturisation of MT Training Bed.

	IF "More Furniture" is installed:
		Removes Designation Category "ANON2MF".
		Replaces "Anon2SquarePlantPot" designation category to "Furniture".
		Replaces "Anon2PlantSpot" designation category to "Furniture".
		Replaces "Anon2Dresser" designation category to "Furniture".
		Replaces "Anon2EndTable" designation category to "Furniture".
		Replaces "Anon2RoyalEndTable" designation category to "Furniture".
		Replaces "Anon2EndTableLight" designation category to "Lighting".
		Replaces "Anon2RoyalEndTableLight" designation category to "Lighting".
		Replaces "ANON2StandingLampBase" Abstract designation category to "Lighting".
		Replaces "Anon2FileCabinet" designation category to "Furniture".
		Replaces "Anon2SquareDiningChair" designation category to "Furniture".
		Replaces "Anon2CushionedChair" designation category to "Furniture".
		Replaces "Anon2CouchRight" designation category to "Furniture".
		Replaces "Anon2CouchCenter" designation category to "Furniture".
		Replaces "Anon2CouchLeft" designation category to "Furniture".
		Replaces "Anon2CouchCorner" designation category to "Furniture".
		Replaces "Anon2CouchCornerInv" designation category to "Furniture".
		Replaces "Anon2TableTiny" designation category to "Furniture".
		Replaces "Anon2CounterA" designation category to "Furniture".
		Replaces "Anon2CounterAFull" designation category to "Furniture".

	IF "More Linkables" is installed:
		Allows miniaturisation of Surgical Lamp.
		Allows miniaturisation of Surgical Instruments.
		Allows miniaturisation of Advanced MultiAnalyzer.

	IF "Neutrainer and AI Persona Core Crafting" is installed:
		Allows miniaturisation of Neurotrainer Work Table.

	IF "Repair Workbench" is installed:
		Allows miniaturisation of Electric Repair Table.

	IF "RT's Weapon Pack Reloaded" AND "Expanded Woodworking" are installed:
		Replaces RecipeDef "ingredients" for crafting "Slingshot" weapon.
		Replaces RecipeDef "fixedIngredientFilter" for crafting "Slingshot" weapon.
		Replaces RecipeDef "recipeUsers" for crafting "Slingshot" weapon.

	IF "Seeds Please" is installed:
		Allows miniaturisation of Plant Processing Table.

	IF "Nature's Pretty Sweet" AND "Stuffed Floors" are installed:
		Removes TerrainDef "TKKN_FlagstoneBasalt" floors.
		Removes TerrainDef "TKKN_TileBasalt" floors.
		Removes TerrainDef "TKKN_FloorRedWood" floors.
		Removes TerrainDef "TKKN_FloorPertrifiedWood" floors.

	IF "Smoked meat" AND "Expanded Woodworking" are installed:
		Replaces "Smokepit" costlist to "RawWoody" category with cost of "20 stuff".
    	Removes "Smokepit" constructEffect.
