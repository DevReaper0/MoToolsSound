using Terraria;
using Terraria.ModLoader;

namespace MoToolsSound
{
	public class MoToolsSound : Mod
	{
		public static Mod MoTools = ModLoader.GetMod("MoTools");

		public override void Load()
		{
			if (!Main.dedServ)
            {
                // Bosses
                AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Annihilator"), ItemType("AnnihilatorMusicBox"), TileType("AnnihilatorMusicBox"));
    	        AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/PaperCut"), ItemType("PaperCutMusicBox"), TileType("PaperCutMusicBox"));

        	    // Biomes
            	//AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/The404Realm"), ItemType("The404RealmMusicBox"), TileType("The404RealmMusicBox"));

	            // Mounts
    	        //AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DriversTheme"), ItemType("DriversThemeMusicBox"), TileType("DriversThemeMusicBox"));
            }
		}
	}
}