using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Entities;

namespace AspNetCoreVideo.Services
{
    public class MockVideoData : IVideoData
    {
        private List<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, Title = "Pulp Fiction", Genre = ViewModels.Genres.Comedy},
                new Video { Id = 2, Title = "Fight Club", Genre = ViewModels.Genres.Horror},
                new Video { Id = 3, Title = "Dark Knight", Genre = ViewModels.Genres.Action },
                new Video { Id = 4, Title = "Princess Bride", Genre = ViewModels.Genres.Romance}
            };
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(v => v.Id.Equals(id));
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
  
        public void Add(Video newVideo)
        {
            newVideo.Id = _videos.Max(x => x.Id) + 1;
            _videos.Add(newVideo);
        }
    }
}
