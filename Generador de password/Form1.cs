using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Generador_de_password
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string GeneratePassword(
        int length,
        bool upper,
        bool lower,
        bool numbers,
        bool symbols)
        {
            string chars = "";

            if (upper)
                chars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (lower)
                chars += "abcdefghijklmnopqrstuvwxyz";

            if (numbers)
                chars += "0123456789";

            if (symbols)
                chars += "!@#$%^&*()-_=+[]{};:,.?/";

            if (string.IsNullOrEmpty(chars))
                throw new Exception("Selecciona al menos un tipo de carácter.");

            StringBuilder password = new StringBuilder();

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] buffer = new byte[4];

                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buffer);

                    uint randomValue = BitConverter.ToUInt32(buffer, 0);
                    int index = (int)(randomValue % chars.Length);

                    password.Append(chars[index]);
                }
            }

            return password.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int)Length.Value;
            int count = (int)Count.Value;

            string characters = "";

            if (Uppercase1.Checked)
                characters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (Lowercase1.Checked)
                characters += "abcdefghijklmnopqrstuvwxyz";

            if (Numbers1.Checked)
                characters += "0123456789";

            if (Symbols1.Checked)
                characters += "!@#$%^&*()-_=+[]{};:,.?/";

            if (string.IsNullOrEmpty(characters))
            {
                MessageBox.Show(
                    "Selecciona al menos una opción: Mayúsculas, Minúsculas, Números o Símbolos.",
                    "Generador de Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.AppendLine(
                    GeneratePassword(length, characters));
            }

            richTextBox1.Text = result.ToString();
        }
        private string GeneratePassword(int length, string characters)
        {
            StringBuilder password = new StringBuilder();

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] buffer = new byte[4];

                for (int i = 0; i < length; i++)
                {
                    rng.GetBytes(buffer);

                    uint randomNumber = BitConverter.ToUInt32(buffer, 0);

                    int index = (int)(randomNumber % characters.Length);

                    password.Append(characters[index]);
                }
            }

            return password.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(richTextBox1.Text))
            {
                MessageBox.Show(
                    "No hay ninguna contraseña para copiar.",
                    "Generador de Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            Clipboard.SetText(richTextBox1.Text);

            MessageBox.Show(
                "Las contraseñas se han copiado al portapapeles.",
                "Generador de Password",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void Strength_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Strength_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (Strength.SelectedItem.ToString())
            {
                case "Low":

                    Length.Value = 8;

                    Uppercase1.Checked = false;
                    Lowercase1.Checked = true;
                    Numbers1.Checked = true;
                    Symbols1.Checked = false;

                    break;

                case "Medium":

                    Length.Value = 12;

                    Uppercase1.Checked = true;
                    Lowercase1.Checked = true;
                    Numbers1.Checked = true;
                    Symbols1.Checked = false;

                    break;

                case "High":

                    Length.Value = 16;

                    Uppercase1.Checked = true;
                    Lowercase1.Checked = true;
                    Numbers1.Checked = true;
                    Symbols1.Checked = true;

                    break;

            }
        }
    }
}