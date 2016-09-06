namespace _02_Bottles
{
    internal class Song
    {
        public Song()
        {
        }
        internal string CountBottles (int bottles)
        {
            string mySong = "";
            {
                for (int i = bottles; i > 0; i--)
                { 
                 if (i == 0)
                    {
                        mySong = mySong + " No more bottles of beer on the wall.";
                    }
                  else if (i == 1)
                    {
                        mySong = mySong + "1 bottle of beer on the wall.";
                    }
                    else
                    {

                    }
        }
    }
}