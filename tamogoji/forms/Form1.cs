using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using tamogoji.Classes;
using static System.Net.Mime.MediaTypeNames;

namespace tamogoji
{
    public partial class Form1 : Form
    {
        bool spritePetRith = false;
        Random GodRandom = new Random();
        List<petImages> CollectionPet = new List<petImages>();
        petImages saoyri = new petImages("Sayori", System.Drawing.Image.FromFile("image\\sayori\\Sayori_Sticker_Excited.png") , System.Drawing.Image.FromFile("image\\sayori\\Sayori_Sticker_Distrait.png"));
        petImages Natsuki = new petImages("Natsuki", System.Drawing.Image.FromFile("image\\Natsuki\\N_sticker_Active.png"), System.Drawing.Image.FromFile("image\\Natsuki\\N_sticker_1.png"));
        petImages Yuri = new petImages("Yuri", System.Drawing.Image.FromFile("image\\Yuri\\Yuri_sticker_Active.png"), System.Drawing.Image.FromFile("image\\Yuri\\Yuri_sticker_1.png"));
        petImages monika = new petImages("Monika", System.Drawing.Image.FromFile("image\\monika\\Monika_Sticker_Excited.png"),System.Drawing.Image.FromFile("image\\monika\\Monika_Sticker_Distrait.png"));
        petImages openPet;
        int boredomStatus = 0;
        bool movePet = false;
        string Activity = File.ReadAllLines("settings.txt")[1].Split('=')[1].Trim();


        public Form1()
        {
            InitializeComponent();
            CollectionPet.Add(Natsuki);
            CollectionPet.Add(saoyri);
            openPet = choicePet();
            this.Icon = Icon.ExtractAssociatedIcon("image\\Doki_Doki_Literature_Club_Logo.ico");
            Jump();
            pet.Image = openPet.calmness;
        }

        private petImages choicePet()
        {
            string[] str = File.ReadAllLines("settings.txt");
            switch (str[0].Split('=')[1].Trim())
            {
                case "sayori":
                    return saoyri;
                case "yuri":
                    return Yuri;
                case "natsuki":
                    return Natsuki;
                case "monika":
                    return monika;
                default:
                    return saoyri;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            pet.Size = pet.Image.Size;
            boredom();
        }

        private bool activity()
        {
            bool result;
            switch (Activity)
            {
                case "1":
                    result = GodRandom.Next(3, 7) == boredomStatus || boredomStatus == 8;
                    if (boredomStatus == 8)
                        boredomStatus = 0;
                    break;
                case "2":
                    result = GodRandom.Next(10, 14) == boredomStatus || boredomStatus == 15;
                    if (boredomStatus == 15)
                        boredomStatus = 0;
                    break;
                case "3":
                    result = GodRandom.Next(25, 29) == boredomStatus || boredomStatus == 30;
                    if (boredomStatus == 30)
                        boredomStatus = 0;
                    break;
                case "4":
                    result = GodRandom.Next(55, 59) == boredomStatus || boredomStatus == 60;
                    if (boredomStatus == 60)
                        boredomStatus = 0;
                    break;
                default:
                    result = GodRandom.Next(5, 9) == boredomStatus || boredomStatus == 10;
                    if (boredomStatus == 8)
                        boredomStatus = 0;
                    break;
            }
            return result;
        }

        private async Task boredom()
        {
            while (true)
            {
                await Task.Delay(1000);
                boredomStatus++;

                int fff = 0;

                if (activity() && !movePet)
                {
                    fff = GodRandom.Next(1, 6);
                    if (!movePet)
                        if (fff <= 2)
                        {
                            for (int i = 0; i < GodRandom.Next(1, 3); i++)
                            {
                                await jumpLeft();
                                await Task.Delay(GodRandom.Next(100, 1000));
                            }
                        }
                        else if (fff == 3)
                        {

                            for (int i = 0; i < GodRandom.Next(1, 3); i++)
                            {
                                await turn();
                                await Task.Delay(GodRandom.Next(100, 1000));
                            }
                        }
                        else
                        {
                            for (int i = 0; i < GodRandom.Next(1, 3); i++)
                            {
                                await jumpRigth();
                                await Task.Delay(GodRandom.Next(100, 1000));
                            }
                            await Drive(pet.Location.X, pet.Location.Y);
                        }
                }
            }
        }

        private async Task jumpLeft()
        {
            pet.Image = openPet.calmness;
            if (spritePetRith)
            {
                pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pet.Refresh();
                spritePetRith = false;
            }
            if (!movePet)
            {
                int posisionY = pet.Location.Y;
                pet.Image = openPet.calmness;
                for (int j = 4; j < 10; j++)
                {
                    pet.Location = new Point(pet.Location.X - 2, pet.Location.Y - j);
                    await Task.Delay(1);
                }

                for (int j = 10; j > 5; j--)
                {
                    pet.Location = new Point(pet.Location.X - 2, pet.Location.Y + j);
                    await Task.Delay(1);
                }
                await Drive(pet.Location.X, posisionY);
            }
        }

        private async Task jumpRigth()
        {
            if (!movePet)
            {
                int posisionY = pet.Location.Y;
                pet.Image = openPet.calmness;
                if (!spritePetRith)
                {
                    pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pet.Refresh();
                    spritePetRith = true;
                }
                for (int j = 4; j < 10; j++)
                {
                    pet.Location = new Point(pet.Location.X + 2, pet.Location.Y - j);
                    await Task.Delay(1);
                }

                for (int j = 10; j > 5; j--)
                {
                    pet.Location = new Point(pet.Location.X + 2, pet.Location.Y + j);
                    await Task.Delay(1);
                }
                await Drive(pet.Location.X, posisionY);
            }
        }

        private async void mouseLeave(object sender, EventArgs e)
        {
                pet.Image = openPet.calmness;
                await Drive(pet.Location.X, pet.Location.Y);
                movePet = false;
                
        }

        private async Task turn()
        {
            if (spritePetRith)
            {
                pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pet.Refresh();
                spritePetRith = false;
            }
            else
            {
                pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pet.Refresh();
                spritePetRith = true;
            }
        }

        private async Task Jump()
        {
                pet.Image = openPet.active;
            int speed = 5;
            pet.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height);
            while (true)
            {
                pet.Location = new Point(pet.Location.X, pet.Location.Y - speed);
                speed++;
                await Task.Delay(1);
                if (pet.Location.Y < Screen.PrimaryScreen.Bounds.Height / 1.4)
                {
                    break;
                }
            }
            await Drive(pet.Location.X, pet.Location.Y);
            pet.Image = openPet.calmness;
        }

        private async Task Drive(int X, int Y)
        {
            int speed = 1;
            pet.Location = new Point(X, Y);
            if (pet.Location.X > Screen.PrimaryScreen.Bounds.Size.Width - pet.Width)
            {
                pet.Location = new Point(Screen.PrimaryScreen.Bounds.Size.Width - pet.Size.Height, pet.Location.Y);
            }
            else if (pet.Location.X < 0)
            {
                pet.Location = new Point(0, pet.Location.Y);
            }
            if (pet.Location.Y > Screen.PrimaryScreen.Bounds.Height - pet.Size.Height)
            {
                pet.Location = new Point(pet.Location.X, Screen.PrimaryScreen.Bounds.Size.Height - pet.Size.Height);
            }
            else if (pet.Location.Y < 0)
            {
                pet.Location = new Point(pet.Location.X, 0);
            }
            if (!movePet)
            while (pet.Location.Y < Screen.PrimaryScreen.Bounds.Height - pet.Size.Height - 1)
            {
                pet.Location = new Point(pet.Location.X, pet.Location.Y + speed);
                await Task.Delay(1);
                speed++;
                if (pet.Location.Y >= Screen.PrimaryScreen.Bounds.Height - pet.Size.Height)
                {
                    pet.Location = new Point(pet.Location.X, Screen.PrimaryScreen.Bounds.Size.Height - pet.Height);
                }
            }
        }

        bool pastConditionSpritePetRith = false;
        private async Task Danse()
        {
            if (!movePet)
            {
                Task.WaitAny();
                int posisionY = pet.Location.Y;
                int posisionX = pet.Location.X;
                pet.Image = openPet.active;
                if (spritePetRith != pastConditionSpritePetRith)
                {
                    pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pet.Refresh();
                    pastConditionSpritePetRith = spritePetRith;
                }

                for (int j = 4; j < 10; j++)
                {
                    pet.Location = new Point(pet.Location.X, pet.Location.Y - j);
                    await Task.Delay(1);
                }
                await Task.Delay(15);

                for (int j = 10; j > 5; j--)
                {
                    pet.Location = new Point(pet.Location.X, pet.Location.Y + j);
                    await Task.Delay(1);
                }
                pet.Location = new Point(posisionX, posisionY);
                await Task.Delay(250);
                if (!movePet)
                {
                    pet.Image = openPet.calmness;
                    await Drive(pet.Location.X, pet.Location.Y);
                }
                boredomStatus = 0;
            }
        }

        private async void MovePet(object sender, EventArgs e)
        {
            movePet = ((movePet) ? false : true);
            if (!movePet)
            {
                pet.Image = openPet.calmness;
            }
                await Drive(pet.Location.X, pet.Location.Y);
            boredomStatus = 0;
        }

        private void Danse(object sender, EventArgs e)
        {
        }

        private void MovePet(object sender, MouseEventArgs e)
        {
            if (movePet)
            {
                pet.Location = new Point(MousePosition.X - (pet.Image.Size.Height / 3), MousePosition.Y - (int)(pet.Image.Size.Height / 3));
                pet.Image = openPet.active;
            }
        }

        private async void Danse(object sender, MouseEventArgs e)
        {
            await Danse();
        }
    }
}
