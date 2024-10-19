using System;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        // Nút chuyển bài hát từ lbSong sang lbFavorite
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                string song = lbSong.SelectedItem.ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        // Double-click vào bài hát trong lbSong để chuyển sang lbFavorite
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSong.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

        // Nút chuyển tất cả bài hát từ lbSong sang lbFavorite
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                string song = lbSong.Items[i].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(i);
            }
        }

        // Nút chuyển lại bài hát từ lbFavorite về lbSong
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                string favorite = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(favorite);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // Nút chuyển tất cả bài hát từ lbFavorite về lbSong
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                string favorite = lbFavorite.Items[i].ToString();
                lbSong.Items.Add(favorite);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        // Double-click vào bài hát trong lbFavorite để chuyển lại về lbSong
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbFavorite.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                string favorite = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(favorite);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}
