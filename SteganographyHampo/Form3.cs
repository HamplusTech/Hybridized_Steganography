using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace SteganographyHampo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            opnfd.Title = "Upload Image || Hampo_Odii Steg Sys";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbxIn.Image = new Bitmap(opnfd.FileName);
            }
            txtInMessage.Enabled = true; btnEncryptMessage.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void extractOpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gbxOut.Enabled = true;
            this.gbxIn.Enabled = false;
        }

        private void hideOpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gbxIn.Enabled = true;
            this.gbxOut.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveStegImage_Click(object sender, EventArgs e)
        {
            SaveStegImage(pbxOut.Image);
        }

        public static void SaveStegImage(System.Drawing.Image image)
        {
            string hampo = System.DateTime.Now.ToLongDateString() + "_" + System.DateTime.Now.ToLongTimeString().Replace(':','-');
            SaveFileDialog s = new SaveFileDialog();
            s.Title = "Save Steg Image || Hampo_Odii Steg Sys";
            s.FileName = "StegImage" + "_" + hampo;// Default file name
            s.DefaultExt = ".jpg";// Default file extension
            s.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif"; // Filter files by extension
            s.InitialDirectory = @"C:\Users\";//Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            s.RestoreDirectory = true;
            if (s.ShowDialog() == DialogResult.OK)
            {
                string filename = s.FileName;
                using (System.IO.FileStream fstream = new System.IO.FileStream(filename, System.IO.FileMode.Create))
                {
                    image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    fstream.Close();
                }
            }
        }

        private void btnEncryptMessage_Click(object sender, EventArgs e)
        {
            if (txtInMessage.Text == "")
            { MessageBox.Show("You must type a message to hide.", "Hampo_Odii Steg Sys", MessageBoxButtons.OK); }
            else
            {
                txtInEncrypt.Text = crypto.EnryptString(txtInMessage.Text);
                btnHideMessage.Enabled = true;
            }
        }


        public class crypto
        {
            public static string DecryptString(string encrString)
            {
                byte[] b;
                string decrypted;
                try
                {
                    b = Convert.FromBase64String(encrString);
                    decrypted = System.Text.ASCIIEncoding.ASCII.GetString(b);
                }
                catch (FormatException fe)
                {
                    decrypted = "Error in Decryption";
                }
                return decrypted;
            }

            public static string EnryptString(string strEncrypted)
            {
                byte[] b = System.Text.ASCIIEncoding.ASCII.GetBytes(strEncrypted);
                string encrypted = Convert.ToBase64String(b);
                return encrypted;
            }
        }

        private void btnDecryptMessage_Click(object sender, EventArgs e)
        {
            txtOutMessage.Text = crypto.DecryptString(txtOutEncrypt.Text);
        }

        private void btnHideMessage_Click(object sender, EventArgs e)
        {
            Bitmap a;
            a = new Bitmap(pbxIn.Image);
            pbxOut.Image = SteganographyHelper.embedText(txtInEncrypt.Text, a);
            btnSaveStegImage.Enabled = true;
        }

        private void btnExtractMessage_Click(object sender, EventArgs e)
        {
            Bitmap a;
            a = new Bitmap(pbxOut.Image);
            txtOutEncrypt.Text = SteganographyHelper.extractText(a);
            btnDecryptMessage.Enabled = true;
        }

        class SteganographyHelper
        {
            public enum State
            {
                Hiding,
                Filling_With_Zeros
            }
            public static Bitmap embedText(string text, Bitmap bmp)
            {
                // initially, we'll be hiding characters in the image
                State state = State.Hiding;

                // holds the index of the character that is being hidden
                int charIndex = 0;

                // holds the value of the character converted to integer
                int charValue = 0;

                // holds the index of the color element (R or G or B) that is currently being processed
                long pixelElementIndex = 0;

                // holds the number of trailing zeros that have been added when finishing the process
                int zeros = 0;

                // hold pixel elements
                int R = 0, G = 0, B = 0;

                // pass through the rows
                for (int i = 0; i < bmp.Height; i++)
                {
                    // pass through each row
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        // holds the pixel that is currently being processed
                        Color pixel = bmp.GetPixel(j, i);

                        // now, clear the least significant bit (LSB) from each pixel element
                        R = pixel.R - pixel.R % 2;
                        G = pixel.G - pixel.G % 2;
                        B = pixel.B - pixel.B % 2;

                        // for each pixel, pass through its elements (RGB)
                        for (int n = 0; n < 3; n++)
                        {
                            // check if new 8 bits has been processed
                            if (pixelElementIndex % 8 == 0)
                            {
                                // check if the whole process has finished
                                // we can say that it's finished when 8 zeros are added
                                if (state == State.Filling_With_Zeros && zeros == 8)
                                {
                                    // apply the last pixel on the image
                                    // even if only a part of its elements have been affected
                                    if ((pixelElementIndex - 1) % 3 < 2)
                                    {
                                        bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                    }

                                    // return the bitmap with the text hidden in
                                    return bmp;
                                }

                                // check if all characters has been hidden
                                if (charIndex >= text.Length)
                                {
                                    // start adding zeros to mark the end of the text
                                    state = State.Filling_With_Zeros;
                                }
                                else
                                {
                                    // move to the next character and process again
                                    charValue = text[charIndex++];
                                }
                            }

                            // check which pixel element has the turn to hide a bit in its LSB
                            switch (pixelElementIndex % 3)
                            {
                                case 0:
                                    {
                                        if (state == State.Hiding)
                                        {
                                            // the rightmost bit in the character will be (charValue % 2)
                                            // to put this value instead of the LSB of the pixel element
                                            // just add it to it
                                            // recall that the LSB of the pixel element had been cleared
                                            // before this operation
                                            R += charValue % 2;

                                            // removes the added rightmost bit of the character
                                            // such that next time we can reach the next one
                                            charValue /= 2;
                                        }
                                    } break;
                                case 1:
                                    {
                                        if (state == State.Hiding)
                                        {
                                            G += charValue % 2;

                                            charValue /= 2;
                                        }
                                    } break;
                                case 2:
                                    {
                                        if (state == State.Hiding)
                                        {
                                            B += charValue % 2;

                                            charValue /= 2;
                                        }

                                        bmp.SetPixel(j, i, Color.FromArgb(R, G, B));
                                    } break;
                            }

                            pixelElementIndex++;

                            if (state == State.Filling_With_Zeros)
                            {
                                // increment the value of zeros until it is 8
                                zeros++;
                            }
                        }
                    }
                }

                return bmp;
            }
            public static string extractText(Bitmap bmp)
            {
                int colorUnitIndex = 0;
                int charValue = 0;

                // holds the text that will be extracted from the image
                string extractedText = String.Empty;

                // pass through the rows
                for (int i = 0; i < bmp.Height; i++)
                {
                    // pass through each row
                    for (int j = 0; j < bmp.Width; j++)
                    {
                        Color pixel = bmp.GetPixel(j, i);

                        // for each pixel, pass through its elements (RGB)
                        for (int n = 0; n < 3; n++)
                        {
                            switch (colorUnitIndex % 3)
                            {
                                case 0:
                                    {
                                        // get the LSB from the pixel element (will be pixel.R % 2)
                                        // then add one bit to the right of the current character
                                        // this can be done by (charValue = charValue * 2)
                                        // replace the added bit (which value is by default 0) with
                                        // the LSB of the pixel element, simply by addition
                                        charValue = charValue * 2 + pixel.R % 2;
                                    } break;
                                case 1:
                                    {
                                        charValue = charValue * 2 + pixel.G % 2;
                                    } break;
                                case 2:
                                    {
                                        charValue = charValue * 2 + pixel.B % 2;
                                    } break;
                            }

                            colorUnitIndex++;

                            // if 8 bits has been added,
                            // then add the current character to the result text
                            if (colorUnitIndex % 8 == 0)
                            {
                                // reverse? of course, since each time the process occurs
                                // on the right (for simplicity)
                                charValue = reverseBits(charValue);

                                // can only be 0 if it is the stop character (the 8 zeros)
                                if (charValue == 0)
                                {
                                    return extractedText;
                                }

                                // convert the character value from int to char
                                char c = (char)charValue;

                                // add the current character to the result text
                                extractedText += c.ToString();
                            }
                        }
                    }
                }

                return extractedText;
            }
            public static int reverseBits(int n)
            {
                int result = 0;

                for (int i = 0; i < 8; i++)
                {
                    result = result * 2 + n % 2;

                    n /= 2;
                }

                return result;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtInMessage.Clear();
            txtInEncrypt.Clear();
            btnHideMessage.Enabled = false;
            btnEncryptMessage.Enabled = false;
            txtInMessage.Enabled = false;
            pbxIn.Image = null;
            btnSaveStegImage.Enabled = true;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            opnfd.Title = "Upload Steg Image || Hampo_Odii Steg Sys";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pbxOutIn.Image = new Bitmap(opnfd.FileName);
            }
            //txtOutEncrypt.Enabled = true;
            btnExtractMessage.Enabled = true;
        }
    }
}
