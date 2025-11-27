using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public Form1()
        {
            InitializeComponent();
            if (File.ReadAllLines("settings.txt")[0].Split('=')[1].Trim().ToLower() == "all".ToLower()) { 
                Form1 form1;
                DataPet.createCollection();
                for (int i = 1; i < DataPet.CollectionPet.Count; i++)
                {
                    form1 = new Form1(DataPet.CollectionPet[i]);
                    form1.Show();
                    Thread.Sleep(1000);
                }

                DataPet.openPet = DataPet.CollectionPet[0];
            }
            else {
                DataPet.openPet = choicePet();
            }
                this.Icon = Icon.ExtractAssociatedIcon("image\\Doki_Doki_Literature_Club_Logo.ico");
                Jump();
                pet.Image = DataPet.openPet.calmness; 
        }
        public Form1(petImages OpenPet)
        {
            InitializeComponent();
            DataPet.openPet = OpenPet;
            this.Icon = Icon.ExtractAssociatedIcon("image\\Doki_Doki_Literature_Club_Logo.ico");
            Jump();
            pet.Image = DataPet.openPet.calmness;
        }

        private petImages choicePet()
        {
            string[] str = File.ReadAllLines("settings.txt");
            switch (str[0].Split('=')[1].Trim())
            {
                case "sayori":
                    return DataPet.saoyri;
                case "yuri":
                    return DataPet.Yuri;
                case "natsuki":
                    return DataPet.Natsuki;
                case "monika":
                    return DataPet.monika;
                default:
                    return DataPet.saoyri;
            }
        }

        private bool activity()
        {
            bool result;
            switch (DataPet.Activity)
            {
                case "1":
                    result = DataPet.GodRandom.Next(3, 7) == DataPet.boredomStatus || DataPet.boredomStatus == 8;
                    if (DataPet.boredomStatus == 8)
                        DataPet.boredomStatus = 0;
                    break;
                case "2":
                    result = DataPet.GodRandom.Next(10, 14) == DataPet.boredomStatus || DataPet.boredomStatus == 15;
                    if (DataPet.boredomStatus == 15)
                        DataPet.boredomStatus = 0;
                    break;
                case "3":
                    result = DataPet.GodRandom.Next(25, 29) == DataPet.boredomStatus || DataPet.boredomStatus == 30;
                    if (DataPet.boredomStatus == 30)
                        DataPet.boredomStatus = 0;
                    break;
                case "4":
                    result = DataPet.GodRandom.Next(55, 59) == DataPet.boredomStatus || DataPet.boredomStatus == 60;
                    if (DataPet.boredomStatus == 60)
                        DataPet.boredomStatus = 0;
                    break;
                default:
                    result = DataPet.GodRandom.Next(5, 9) == DataPet.boredomStatus || DataPet.boredomStatus == 10;
                    if (DataPet.boredomStatus == 8)
                        DataPet.boredomStatus = 0;
                    break;
            }
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.Bounds.Size;
            pet.Size = pet.Image.Size;
            boredom();
        }

        private async Task boredom()
        {
            while (true)
            {
                await Task.Delay(1000);
                DataPet.boredomStatus++;

                int fff = 0;

                if (activity() && !DataPet.movePet)
                {
                    fff = DataPet.GodRandom.Next(1, 6);
                    if (!DataPet.movePet)
                        if (fff <= 2)
                        {
                            for (int i = 0; i < DataPet.GodRandom.Next(1, 3); i++)
                            {
                                await jumpLeft();
                                await Task.Delay(DataPet.GodRandom.Next(100, 1000));
                            }
                        }
                        else if (fff == 3)
                        {

                            for (int i = 0; i < DataPet.GodRandom.Next(1, 3); i++)
                            {
                                await turn();
                                await Task.Delay(DataPet.GodRandom.Next(100, 1000));
                            }
                        }
                        else
                        {
                            for (int i = 0; i < DataPet.GodRandom.Next(1, 3); i++)
                            {
                                await jumpRigth();
                                await Task.Delay(DataPet.GodRandom.Next(100, 1000));
                            }
                            await Drive(pet.Location.X, pet.Location.Y);
                        }
                }
            }
        }

        private async Task jumpLeft()
        {
            pet.Image = DataPet.openPet.calmness;
            if (DataPet.spritePetRith)
            {
                pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pet.Refresh();
                DataPet.spritePetRith = false;
            }
            if (!DataPet.movePet)
            {
                int posisionY = pet.Location.Y;
                pet.Image = DataPet.openPet.calmness;
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
            if (!DataPet.movePet)
            {
                int posisionY = pet.Location.Y;
                pet.Image = DataPet.openPet.calmness;
                if (!DataPet.spritePetRith)
                {
                    pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pet.Refresh();
                    DataPet.spritePetRith = true;
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

        private async Task turn()
        {
            if (DataPet.spritePetRith)
            {
                pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pet.Refresh();
                DataPet.spritePetRith = false;
            }
            else
            {
                pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                pet.Refresh();
                DataPet.spritePetRith = true;
            }
        }

        private async void mouseLeave(object sender, EventArgs e)
        {
            pet.Image = DataPet.openPet.calmness;
            DataPet.movePet = false;
            await Drive(pet.Location.X, pet.Location.Y);
        }

        private async Task Jump()
        {
            pet.Image = DataPet.openPet.active;
            int speed = 0;
            pet.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2, Screen.PrimaryScreen.Bounds.Height);
            for (int i = pet.Location.Y; i > Screen.PrimaryScreen.Bounds.Height / 1.4;)
            {
                speed++;
                i -= speed;
            }
            while (true)
            {
                pet.Location = new Point(pet.Location.X, pet.Location.Y - speed);
                speed--;
                await Task.Delay(1);
                if (pet.Location.Y < Screen.PrimaryScreen.Bounds.Height / 1.4)
                {
                    break;
                }
            }
            await Drive(pet.Location.X, pet.Location.Y);
            pet.Image = DataPet.openPet.calmness;
        }

        private async Task Drive(int X, int Y)
        {
            int speed = 1;
            pet.Location = new Point(X, Y);
            if (pet.Location.X > DataPet.mainScreen.Width - pet.Width)
            {
                pet.Location = new Point(DataPet.mainScreen.Width - pet.Size.Width, pet.Location.Y);
            }
            else if (pet.Location.X < 0)
            {
                pet.Location = new Point(0, pet.Location.Y);
            }
            if (pet.Location.Y > DataPet.mainScreen.Height - pet.Size.Height)
            {
                pet.Location = new Point(pet.Location.X, DataPet.mainScreen.Height - pet.Size.Height);
            }
            else if (pet.Location.Y < 0)
            {
                pet.Location = new Point(pet.Location.X, 0);
            }
            if (!DataPet.movePet)
                while (pet.Location.Y < DataPet.mainScreen.Height - pet.Size.Height - 1)
                {
                    pet.Location = new Point(pet.Location.X, pet.Location.Y + speed);
                    await Task.Delay(1);
                    speed++;
                    if (pet.Location.Y >= DataPet.mainScreen.Height - pet.Size.Height)
                    {
                        pet.Location = new Point(pet.Location.X, DataPet.mainScreen.Height - pet.Height);
                    }
                }
        }

        bool pastConditionSpritePetRith = false;
        private async Task Danse()
        {
            if (!DataPet.movePet)
            {
                Task.WaitAny();
                int posisionY = pet.Location.Y;
                int posisionX = pet.Location.X;
                pet.Image = DataPet.openPet.active;
                if (DataPet.spritePetRith != pastConditionSpritePetRith)
                {
                    pet.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pet.Refresh();
                    pastConditionSpritePetRith = DataPet.spritePetRith;
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
                if (!DataPet.movePet)
                {
                    pet.Image = DataPet.openPet.calmness;
                    await Drive(pet.Location.X, pet.Location.Y);
                }
                DataPet.boredomStatus = 0;
            }
        }

        private async void MovePet(object sender, MouseEventArgs e)
        {if (e.Button == MouseButtons.Left)
            {
                DataPet.movePet = ((DataPet.movePet) ? false : true);
                if (!DataPet.movePet)
                {
                    pet.Image = DataPet.openPet.calmness;
                }
                await Drive(pet.Location.X, pet.Location.Y);
                DataPet.boredomStatus = 0;
            }
        }

        private void DravePet(object sender, MouseEventArgs e)
        {
            if (DataPet.movePet)
            {
                pet.Location = new Point(MousePosition.X - (pet.Image.Size.Height / 3), MousePosition.Y - (int)(pet.Image.Size.Height / 3));
                pet.Image = DataPet.openPet.active;
            }
        }
            
        private async void Danse(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                await Danse();
            else if (e.Button == MouseButtons.Right)
            {
                if (!DataPet.openMenu)
                {
                    DataPet.Menu = new menu(this);
                    DataPet.Menu.Show();
                    DataPet.openMenu = true;
                }
                else
                {
                    DataPet.Menu.WindowState = FormWindowState.Normal;
                }
            }
        }
    }
}
