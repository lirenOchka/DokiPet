using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tamogoji.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace tamogoji
{
    public partial class menu : Form
    {
        List<Label> lables;

        private Form1 PetForm;
        public menu(Form1 mainForm)
        {
            InitializeComponent();
            PetForm = mainForm;
        }

        private void Exit(object sender, EventArgs e)
        {
            DataPet.openMenu = false;
            Close();
        }

        private void rollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void menu_Load(object sender, EventArgs e)
        {
            dialogueButton.Image = Image.FromFile("image\\buttons\\dialogueButtonOff.png");
            dialogueButton.Size = dialogueButton.Image.Size;
            dialogueButton.Location = new Point(12, 40);

            ILoveYouButton.Image = Image.FromFile("image\\buttons\\ILoveYouOff.png");
            ILoveYouButton.Size = ILoveYouButton.Image.Size;
            ILoveYouButton.Location = new Point(12, 40);

            ExitButton.Image = Image.FromFile("image\\buttons\\ButtonExitOff.png");
            ExitButton.Size = ExitButton.Image.Size;
            ExitButton.Location = new Point(this.Width - ExitButton.Image.Size.Width - 12, DialogeWindow.Location.Y - ExitButton.Image.Size.Height - 12);

            DialogeText.Text = DataPet.openPet.name + ":";
        }

        private void changeTextureDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            switch (pictureBox.Name)
            {
                case "dialogueButton":
                    dialogueButton.Image = Image.FromFile("image\\buttons\\dialogueButtonOn.png");
                    break;
                case "ExitButton":
                    ExitButton.Image = Image.FromFile("image\\buttons\\ButtonExitOn.png");
                    break;
                case "ILoveYouButton":
                    ILoveYouButton.Image = Image.FromFile("image\\buttons\\ILoveYouOn.png");
                    break;

            }
        }

        private void changeTextureUp(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            if (e.Button == MouseButtons.Left)
            {
                switch (pictureBox.Name)
                {
                    case "dialogueButton":
                        dialogueButton.Image = Image.FromFile("image\\buttons\\dialogueButtonOff.png");
                        break;
                    case "ExitButton":
                        ExitButton.Image = Image.FromFile("image\\buttons\\ButtonExitOff.png");
                        break;
                    case "ILoveYouButton":
                        ILoveYouButton.Image = Image.FromFile("image\\buttons\\ILoveYouOff.png");
                        break;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            ExitButton.Image = Image.FromFile("image\\buttons\\ButtonExitOff.png");
            if (MessageBox.Show("вы уверены что хотите выйти?", "выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                PetForm.Close();
        }

        private void openMenuPage(menus nextMenu)
        {
            if(DataPet.activeMenu == menus.main)
                backButton.Visible = true;
            else if(nextMenu == menus.main) 
                backButton.Visible = false;

            clearMenu();
            switch (nextMenu)
            {
                case menus.main:
                    DataPet.activeMenu = menus.main;
                    dialogueButton.Visible = true;
                    break;
                case menus.dialog:
                    DataPet.activeMenu = menus.dialog;
                    ILoveYouButton.Visible = true;
                    break;
            }
        }

        private void clearMenu()
        {
            dialogueButton.Visible = false;
            ILoveYouButton.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if(DataPet.activeMenu == menus.dialog)
                openMenuPage(menus.main);
        }

        private void dialogueButton_Click(object sender, EventArgs e)
        {
            openMenuPage(menus.dialog);
        }

        private Font chacheStuleMassengeText(stuleMessangeText stuleMessange)
        {
            switch (stuleMessange)
            {
                case stuleMessangeText.normal:
                    return new Font(DialogeText.Font.FontFamily, 12);
                case stuleMessangeText.whisper:
                    return new Font(DialogeText.Font.FontFamily, 9);
                case stuleMessangeText.scream:
                    return new Font(DialogeText.Font.FontFamily, 16);
                case stuleMessangeText.bigScream:
                    return new Font(DialogeText.Font.FontFamily, 20);
                default:
                    return new Font(DialogeText.Font.FontFamily, 12);

            }
        }

        private bool print = false;

        private async Task PrintMessange(string Messange, int speed)
        {
            print = true;
            DialogeText.Text = DataPet.openPet.name + ": ";
            for (int i = 0; i < Messange.Length; i++)
            {
                await Task.Delay(speed);
                DialogeText.Text += Messange[i];
            }
            print = false;
        }

        private async void ILoveYouButton_Click(object sender, EventArgs e)
        {
            if (!print) { 
                await PrintMessange("лол, это тестовое сообщение", 50);
            }
        }
    }
}