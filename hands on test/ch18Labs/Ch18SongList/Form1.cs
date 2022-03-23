using System;
using LINQLibary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ch18SongList
{
    public partial class SongList : Form
    {
        //39 mins
        static List<Song> songs = SongManger.LoadData();
        public SongList()
        {
            InitializeComponent();
        }
        private void whichItemSearch()
        {
            switch (cbSearch.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("You must select one of the options!", 
                        "please select one now");
                    cbSearch.Focus();
                    return;
                case 0:
                    showSongListByTitleAscending();
                    break;
                case 1:
                    showSongListByArtistAscending();
                    break;
                case 2:
                    showSongListByGenreAscending();
                    break;
                case 3:
                    showSongListByTitleCriteria();
                    break;
                case 4:
                    showSongListByArtistCriteria();
                    break;
                case 5:
                    showSongListByGenreCriteria();
                    break;
                default:
                    break;
            }
        }
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }
        private void showSongListByTitleAscending()
        {
            lvDisplay.Items.Clear();
            lvDisplay.Items.Clear();
            var titleAsending = 
                from s in songs
                orderby s.SongTitle ascending
                select s;
            foreach(var s in titleAsending)
            {
                ListViewItem item = new ListViewItem(s.SongTitle);
                item.SubItems.Add(s.SongArtist);
                item.SubItems.Add(s.SongGenre);
                lvDisplay.Items.Add(item);

            }
        }
        private void showSongListByArtistAscending()
        {
            
            lvDisplay.Items.Clear();
            var artistAsending =
                from s in songs
                orderby s.SongArtist ascending
                select s;
            foreach (var s in artistAsending)
            {
                ListViewItem item = new ListViewItem(s.SongTitle);
                item.SubItems.Add(s.SongArtist);
                item.SubItems.Add(s.SongGenre);
                lvDisplay.Items.Add(item);

            }
        }
        private void showSongListByGenreAscending()
        {
            
            lvDisplay.Items.Clear();
            var genreAsending =
                from s in songs
                orderby s.SongGenre ascending
                select s;
            foreach (var s in genreAsending)
            {
                ListViewItem item = new ListViewItem(s.SongTitle);
                item.SubItems.Add(s.SongArtist);
                item.SubItems.Add(s.SongGenre);
                lvDisplay.Items.Add(item);

            }
        }
        private void showSongListByTitleCriteria()
        {
            lvDisplay.Items.Clear();
            string title = Interaction.InputBox("Enter a song title to search for");
            if (title.Trim() == "")
            {
                cbSearch.Items.Add("There was no input");
            }
            else
            {
                var songtitle =
                    from s in songs
                    orderby s.SongTitle ascending
                    where s.SongTitle.ToUpper().Contains(title.ToUpper())
                    select s;
                foreach (var s in songtitle)
                {
                    ListViewItem item = new ListViewItem(s.SongTitle);
                    item.SubItems.Add(s.SongArtist);
                    item.SubItems.Add(s.SongGenre);
                    lvDisplay.Items.Add(item);

                }
            }
        }
        private void showSongListByArtistCriteria()
        {
            lvDisplay.Items.Clear();
            string artist = Interaction.InputBox("Enter a song genre to search for");
            if (artist.Trim() == "")
            {
                cbSearch.Items.Add("There was no input");
            }
            else
            {
                var songartist =
                    from s in songs
                    orderby s.SongArtist ascending
                    where s.SongArtist.ToUpper().Contains(artist.ToUpper())
                    select s;
                foreach (var s in songartist)
                {
                    ListViewItem item = new ListViewItem(s.SongTitle);
                    item.SubItems.Add(s.SongArtist);
                    item.SubItems.Add(s.SongGenre);
                    lvDisplay.Items.Add(item);

                }
            }
        }
        private void showSongListByGenreCriteria()
        {
            lvDisplay.Items.Clear();
            string genre = Interaction.InputBox("Enter a song genre to search for");
             if (genre.Trim() == "")
             {
                cbSearch.Items.Add("There was no input");
             }
             else
            {
                var songgenre = 
                    from s in songs
                    orderby s.SongGenre ascending
                    where s.SongGenre.ToUpper().Contains(genre.ToUpper())
                    select s;
                foreach (var s in songgenre)
                {
                    ListViewItem item = new ListViewItem(s.SongTitle);
                    item.SubItems.Add(s.SongArtist);
                    item.SubItems.Add(s.SongGenre);
                    lvDisplay.Items.Add(item);

                }
            }
            
        }

        private void SongList_Load(object sender, EventArgs e)
        {
            cbSearch.Items.Add("Show all songs ascending by Title");
            cbSearch.Items.Add("Show all songs ascending by artist");
            cbSearch.Items.Add("Show all songs ascending by genre");
            cbSearch.Items.Add("Search for songs by title");
            cbSearch.Items.Add("Search for songs by Artist");
            cbSearch.Items.Add("Search for songs by Genre");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            whichItemSearch();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvDisplay.Items.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }
        
        private void Exit()
        {
            DialogResult dialog = MessageBox.Show(
                "Do You Really Want To Exit?",
                "EXIT NOW?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
