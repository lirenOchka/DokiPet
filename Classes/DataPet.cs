using System;
using System.IO;
using System.Windows;
using tamogoji.Classes;

namespace tamogoji
{
    public class DataPet
    {
        static public bool spritePetRith = false;
        static public Random GodRandom = new Random();
        static public petImages saoyri = new petImages("Sayori", "image\\sayori\\Sayori_Sticker_Excited.png", "image\\sayori\\Sayori_Sticker_Distrait.png");
        static public petImages Natsuki = new petImages("Natsuki", "image\\Natsuki\\N_sticker_Active.png", "image\\Natsuki\\N_sticker_1.png");
        static public petImages Yuri = new petImages("Yuri", "image\\Yuri\\Yuri_sticker_Active.png", "image\\Yuri\\Yuri_sticker_1.png");
        static public petImages monika = new petImages("Monika", "image\\monika\\Monika_Sticker_Excited.png", "image\\monika\\Monika_Sticker_Distrait.png");
        static public petImages openPet { get; set; }
        static public int boredomStatus = 0;
        static public bool movePet = false;
        static public string Activity = File.Exists("settings.txt") ? File.ReadAllLines("settings.txt")[1].Split('=')[1].Trim() : "1";
        static public Window Menu;
        static public bool openMenu = false;
    }
}
