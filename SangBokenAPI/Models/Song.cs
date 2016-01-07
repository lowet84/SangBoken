using System.Collections.Generic;

namespace SangBokenAPI.Models
{
    public class Song : ModelBase
    {
        public string Name { get; set; }

        public override void Update(object newObject)
        {
            var newSong = newObject as Song;
            if(newSong==null) return;
            Name = newSong.Name;
        }
    }
}