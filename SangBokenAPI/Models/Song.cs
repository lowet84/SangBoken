using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SangBokenAPI.Models
{
    public class Song : ModelBase
    {
        public string Name { get; set; }

        public string Text { get; set; }

        public override void Update(object newObject)
        {
            var newSong = newObject as Song;
            if(newSong==null) return;
            Name = newSong.Name;
            Text = newSong.Text;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(Name);
            if (Text == null) return sb.ToString();
            sb.Append("{");
            sb.Append(new StringReader(Text).ReadLine());
            sb.Append("}");
            return sb.ToString();
        }
    }
}