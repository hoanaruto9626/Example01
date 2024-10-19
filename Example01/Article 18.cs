using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Article_18 : Form
    {
        public Article_18()
        {
            InitializeComponent();
        }

        private void Article_18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();
            lbSong.DataSource = lst;
            lbSong.DisplayMember = "Name";
        }

        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt Pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);
            return lst;
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            Song song = (Song)lbSong.SelectedItem;
            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;
            lbFavorite.Items.Add(id + " - " + name + " - " + author);
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            if(lbFavorite.SelectedItem != null)
            {
                string[] songDetails = lbFavorite.SelectedItem.ToString().Split('-');
                Song song = new Song
                {
                    Id = int.Parse(songDetails[0].Trim()),
                    Name = songDetails[1].Trim(),
                    Author = songDetails[2].Trim()
                };

                lbSong.Items.Add(song);
                lbFavorite.Items.Remove(lbFavorite.SelectedItem);
            }
        }
    }
}
