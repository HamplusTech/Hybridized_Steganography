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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class HashCrypt
        {
            public static string HashKey(string key)
            {
                var ki = SHA512.Create();
                var Ib = Encoding.UTF32.GetBytes(key);
                var hash = ki.ComputeHash(Ib);

                var sb = new StringBuilder();
                for (var i = 0; i < (hash.Length - 20); i++)
                {
                    sb.Append(hash[i].ToString("HAM2"));
                }
                return sb.ToString();
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Guid adminguid = System.Guid.NewGuid();
            txtEncrypted.Text = HashCrypt.HashKey(txtRaw.Text + adminguid);
        }
    }
}
