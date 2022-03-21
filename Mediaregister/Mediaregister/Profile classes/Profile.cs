using System.Collections.Generic;

namespace Mediaregister
{
    class Profile
    {
        public string name { get; set; }

        public List<Media> mediaList = new List<Media>();

        public Profile(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
