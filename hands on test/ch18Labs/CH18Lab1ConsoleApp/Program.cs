using LINQLibary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CH18Lab1ConsoleApp
{
    internal class Program
    {
        // global consts
        const string NOTHINGINPUTTED = "No vaule was Inputted for the search Criteria";
        const string NOSONGTITLEFOUND = "No song title matching search criteria";
        const string NOSONGSRTISTFOUND = "No song Artist matching search criteria";
        const string NOSONGGENREFOUND = "No song Genre matching search criteria";
        //global variables
        static List<Song> songs = SongManger.LoadData();
        static void Main(string[] args)
        {
            int option;
            bool runAgain = true;

            while (runAgain)
            {
                option = showMenu();
                callCorrectFunction(option);
                runAgain = anotherTime();
            }
        }
        static int showMenu()
        {
            Clear();
            string option = "";
            int optionChosen = 0;
            bool results;
            string menuStr = "please choose one of the following options\n"; 
            menuStr += "Enter a 1 to show all songs by title ascending order\n"; ;
            menuStr += "Enter a 2 to show all songs by artist ascending order\n";
                menuStr += "Enter a 3 to show all songs by genre ascending order\n";
            menuStr += "Enter a 4 to show songs(s) that meet title cirteria\n";
                menuStr += "Enter a 5 to show songs(s) that meet artist cirteria\n";
                menuStr += "Enter a 6 to show songs(s) that meet genre cirteria\n";
                menuStr += "Enter a 7 to exit the program now\n";
                menuStr += "Please enter a 1,2,3,4,5,6 or 7 now\n";
            Write(menuStr);
            option = ReadLine();
            results = int.TryParse(option, out optionChosen);
            if (!results)
            {
                Write("you must enter a number! hit any key to continue");
            }
            else if ((optionChosen < 1) || (optionChosen > 7 ))
            {
                Write("you must enter a nuber between 1 and 7");
                ReadLine();
                showMenu();
            }
            return optionChosen;
        }
        static void callCorrectFunction(int option)
        {
             switch (option)
            {
                case 1:
                    showSongListByTitleAscending();
                    break;
                case 2:
                    showSongListByArtistAscending();
                    break;
                case 3:
                    showSongListByGenreAscending();
                    break;
                case 4:
                    showSongListByTitleCriteria();
                    break;
                case 5:
                    showSongListByArtistCriteria();
                    break;
                case 6:
                    showSongListByGenreCriteria();
                    break;
                case 7:
                    exitProgramOrNot();
                    break;
                    default:
                    break;

            }
        }
        static void showSongListByGenreCriteria()
        {
            Clear();
            string genre;
            Write("Enter a genre to search for now (full or partial title):");
            genre = ReadLine();
            if (genre.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
            }
            else
            {
                var songGenre =
                    from s in songs
                    orderby s.SongGenre ascending
                    where s.SongGenre.ToUpper().Contains(genre.ToUpper())
                    select s;
                WriteLine("Song titles Matching Inputted search criteria:");
                foreach (var st in songGenre)
                {
                    WriteLine(st);
                }

            }
        }
        static void showSongListByArtistCriteria()
        {
            Clear();
            string artist;
            Write("Enter a artist to search for now (full or partial title):");
            artist = ReadLine();
            if (artist.Trim() == "")
            {
                WriteLine(NOTHINGINPUTTED);
            }
            else
            {
                var songArtist =
                    from s in songs
                    orderby s.SongArtist ascending
                    where s.SongArtist.ToUpper().Contains(artist.ToUpper())
                    select s;
                WriteLine("Song titles Matching Inputted search criteria:");
                foreach (var st in songArtist)
                {
                    WriteLine(st);
                }

            }
        }
        static void showSongListByTitleCriteria()
        {
            Clear();
            string title;
            Write("Enter a song title to search for now (full or partial title):");
            title = ReadLine();
            if (title.Trim() =="")
            {
                WriteLine(NOTHINGINPUTTED);
            }
            else
            {
                var songTitles = 
                    from s in songs 
                    orderby s.SongTitle ascending
                    where s.SongTitle.ToUpper().Contains(title.ToUpper())
                    select s;
                WriteLine("Song titles Matching Inputted search criteria:");
                foreach (var st in songTitles)
                {
                    WriteLine(st);
                }
                    
            }
        }
        static void showSongListByTitleAscending()
        {
            Clear();
            var titleAsending = 
                from s in songs 
                orderby s.SongTitle ascending
                select s;
            WriteLine("Song list in ascending order by song title ");
            foreach (var s in titleAsending)
            {
                WriteLine(s);
            }
        }
        static void showSongListByArtistAscending()
        {
            Clear();
            var artistAsending =
                from s in songs
                orderby s.SongArtist ascending
                select s;
            WriteLine("Song list in ascending order by song title ");
            foreach (var s in artistAsending)
            {
                WriteLine(s);
            }
        }
        static void showSongListByGenreAscending()
        {
            Clear();
            var genreAsending =
                from s in songs
                orderby s.SongGenre ascending
                select s;
            WriteLine("Song list in ascending order by song title ");
            foreach (var s in genreAsending)
            {
                WriteLine(s);
            }
        }

        static bool anotherTime()
        {
            bool retVal    = true;
            string again   = "";
            char firstChar = ' ';

            Write("Run Program Again?!? (Y/N):");
            again = ReadLine().ToUpper();
            firstChar = again[0];

            if(firstChar != 'Y')
            {
                retVal = false;
            }
            return retVal;
        }
        static void exitProgramOrNot()
        {
            Clear();
            WriteLine("Program Terminating Normally.Good Bye!");
            ReadLine();
        }
    }
}
