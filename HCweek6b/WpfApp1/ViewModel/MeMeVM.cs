using WpfApp1.Model;

namespace WpfApp1
{
    public class MeMeVM
    {
        private Meme m;

        public MeMeVM()
        {
            m = new Meme();
        }

        public MeMeVM(Meme m)
        {
            this.m = m;
            this.Naam = m.Naam;

            if(m.Ban != null)
                this.BannedBy = m.Ban.Artiest;
        }

        public string Naam { get; set; }
        public string BannedBy { get; }
        public int Upvote { get; set; }

        public int Downvote { get; set; }

        public bool Repost { get; set; }

        public int Score 
        { 
            get { return Upvote - (Downvote / 2); }
        }
    }
}