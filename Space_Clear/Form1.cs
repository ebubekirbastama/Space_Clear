using System;
using System.Collections;
using System.Windows.Forms;


/// <summary>
/// www.ebubekirbastama.com
/// www.pintimarket.com
/// www.uygunver.com
/// whatshapp:905554128854
/// 05554128854
/// </summary>
namespace Space_Clear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxX1.Text= SapceClear(textBoxX1.Text);
        }
        ArrayList list = new ArrayList();
        public string SapceClear(string veri)
        {
            for (int i = 0; i < veri.ToCharArray().Length; i++)
            {
                if (veri.ToCharArray()[i].ToString() != " ")
                {
                    list.Add(veri.ToCharArray()[i].ToString());
                }
            }
            veri = "";
            for (int i = 0; i < list.Count; i++)
            {
                veri += list[i].ToString();
            }
            list.Clear();
            return veri;
        }
    }
}
