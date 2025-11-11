using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tamogoji.Classes;

namespace tamogoji
{
    public class DataPet
    {
        static public bool spritePetRith = false;
        static public Random GodRandom = new Random();
        static public List<petImages> CollectionPet = new List<petImages>();
        static public Size mainScreen = Screen.PrimaryScreen.Bounds.Size;
        static public petImages saoyri = new petImages("Sayori", System.Drawing.Image.FromFile("image\\sayori\\Sayori_Sticker_Excited.png"), System.Drawing.Image.FromFile("image\\sayori\\Sayori_Sticker_Distrait.png"));
        static public petImages Natsuki = new petImages("Natsuki", System.Drawing.Image.FromFile("image\\Natsuki\\N_sticker_Active.png"), System.Drawing.Image.FromFile("image\\Natsuki\\N_sticker_1.png"));
        static public petImages Yuri = new petImages("Yuri", System.Drawing.Image.FromFile("image\\Yuri\\Yuri_sticker_Active.png"), System.Drawing.Image.FromFile("image\\Yuri\\Yuri_sticker_1.png"));
        static public petImages monika = new petImages("Monika", System.Drawing.Image.FromFile("image\\monika\\Monika_Sticker_Excited.png"), System.Drawing.Image.FromFile("image\\monika\\Monika_Sticker_Distrait.png"));
        static public petImages openPet;
        static public int boredomStatus = 0;
        static public bool movePet = false;
        static public string Activity = File.ReadAllLines("settings.txt")[1].Split('=')[1].Trim();
        static public menu Menu;
        static public bool openMenu = false;
        static public menus activeMenu = menus.main;
    }
}
