namespace _02_Bottles
{
    internal class Song
    {

        public Song()
        {
        }
        internal string CountBottles(int bottles)
        {
            string mySong = "";
            for (int i = bottles; i > -1; i--)
            {
                if (i == 0)
                {
                    mySong = mySong + " No more bottles of beer on the wall.";
                }
                else if (i == 1)
                {
                    mySong = mySong + "1 bottle of beer on the wall." + " 1 bottle of beer." + " Take one down and pass it around.";
                }
                else if (i == 2)
                {
                    mySong = mySong + "2 bottles of beer on the wall." + " 2 bottles of beer." + " Take one down and pass it around." + " 1 bottle of beer on the wall. ";
                }
                else
                {
                    mySong = mySong + i + " bottles of beer on the wall. " + i + " bottles of beer." + " Take one down and pass it around. " + (i - 1) + " bottles of beer on the wall. ";


                }
                

            }
            return mySong;
        }
    }
}
