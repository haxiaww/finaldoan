using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SpeechLib;

namespace dictionary_winform
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            loaddata();
            BackUp();
            btnql.Enabled = false;
            LoadListData();
        }
        public Dictionary<string, string> myDict = new Dictionary<string, string>();
        public void loaddata()
        {
            StreamReader sr = new StreamReader(@"tuvung.txt");
            string line = null;
            string[] words = null;
            try
            {
                do
                {
                    line = sr.ReadLine();
                    if (line != null)
                    {
                        words = line.Split(':');
                        myDict.Add(words[0].ToLower(), words[1].Trim());
                    }
                }
                while (line != null);
            }
            catch
            {
            }
            sr.Close();
        }
        private void bttn_search_Click(object sender, EventArgs e)
        {
            string eng = txteng.Text.ToLower();
            if (eng == "")
                MessageBox.Show("Vui lòng nhập từ cần tra cứu!");
            else if (myDict.ContainsKey(eng))
            {
                string bientam;
                myDict.TryGetValue(eng, out bientam);
                txtviet.Text = bientam;
            }
            else
                txtviet.Text = "Không có thông tin.";
        }

        private void btnspeech_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txteng.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void main_Load(object sender, EventArgs e)
        {
            foreach(KeyValuePair<string,string> kvp in myDict)
            {
                txteng.Items.Add(kvp.Key);
            }
        }
        public void BackUp()
        {
            StreamWriter sw = new StreamWriter(@"tuvung.txt");
            for (int i = 0; i < myDict.Count(); i++)
            {
                foreach(KeyValuePair<string,string> kvp in myDict)
                {
                    if (kvp.Key != null)
                    {
                        sw.WriteLine(kvp.Key + ":" + kvp.Value);
                    }
                }
            }
            sw.Close();
        }
        private void btnescape_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                BackUp();
                Close();
            }
        }

        private void btnql_Click(object sender, EventArgs e)
        {
            login frmlog = new login();
            frmlog.Owner = this;
            frmlog.Show();
        }

        private void btnql_Click_1(object sender, EventArgs e)
        {
            if (btnql.Enabled == true)
            {
                grbox.Show();
            }
        }

        private void btnxoatrang_Click(object sender, EventArgs e)
        {
            txteng.ResetText();
            txtviet.Clear();
        }

        private void btnclosegr_Click(object sender, EventArgs e)
        {
            grbox.Hide();
            btnql.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string eng = txteng.Text.Trim();
            string vn = txtviet.Text.Trim();
            try
            {
                if (txteng.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập từ cần thêm");
                    return;
                }
                if (txtviet.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập nghĩa của từ!");
                    return;
                }
                if (!myDict.ContainsKey(eng))
                {
                    myDict.Add(eng, vn);
                    MessageBox.Show("Thêm từ thành công!");
                    LoadListData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                string eng = txteng.Text.Trim().ToLower();
                if (myDict.ContainsKey(eng))
                {
                    myDict.Remove(eng);
                    MessageBox.Show("Xóa thành công!");
                    LoadListData();
                }
                else
                {
                    MessageBox.Show("Từ cần xóa không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                string eng = txteng.Text.Trim();
                string vn = txtviet.Text.Trim();
                if (myDict.ContainsKey(eng))
                {
                    myDict[eng] = vn;
                    MessageBox.Show("Cập nhật thành công!");
                    LoadListData();
                }
                else
                {
                    MessageBox.Show("Từ cần cập nhật không tồn tại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadListData()
        {
            listbox.DataSource = new BindingSource(myDict, null);
            listbox.DisplayMember = "Key";
            listbox.ValueMember = "Value";
            
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListData();
        }

        private void listbox_Click(object sender, EventArgs e)
        {
            string temp = listbox.Text;
            foreach(KeyValuePair<string,string> kvp in myDict)
            {
                if (temp == kvp.Key)
                {
                    txteng.Text = temp;
                    txtviet.Text = myDict[temp];
                }    
            }    
        }

        private void txteng_Click(object sender, EventArgs e)
        {
            btnxoatrang.PerformClick();
        }
    }
}
