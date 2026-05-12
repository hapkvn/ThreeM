using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiemtragiuaki.DTO
{
    internal class Song
    {
        public string SongID { get; set; }     // quy ước là :MS_01
        public string Title { get; set; }
        public string Artist { get; set; }
        public string FilePath { get; set; }
        public string CategoryID { get; set; }
    }   
}
