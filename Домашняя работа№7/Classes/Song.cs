using System;

namespace Домашняя_работа_7.Classes
{
    class Song
    {
        private string name;
        private string author;
        public Song prev;

        public void SetName(string songName)
        {
            name = songName;
        }
        public void SetAuthor(string songAuthor)
        {
            author = songAuthor;
        }
        public void SetPrev(Song previousSong)
        {
            prev = previousSong;
        }
        public string Title()
        {
            return $"{name} - {author}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Song otherSong)
            {
                return this.name == otherSong.name && this.author == otherSong.author;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (name, author).GetHashCode();
        }
    }
}
