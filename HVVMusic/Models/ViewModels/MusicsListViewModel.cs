using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HVVMusic.Models.ViewModels
{
    public class MusicsListViewModel
    {
        public IEnumerable<Music> Musics { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
