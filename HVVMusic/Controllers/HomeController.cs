using HVVMusic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using HVVMusic.Models.ViewModels;
using System.Net.NetworkInformation;

namespace HVVMusic.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        //public IActionResult Index() => View(repository.Musics);

        public ViewResult Index(int musicPage = 1)
            => View(new MusicsListViewModel
            {
                Musics = repository.Musics
             .OrderBy(p => p.MusicID)
            .Skip((musicPage - 1) * PageSize)
            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = musicPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Musics.Count()
                }
            });

                

        //localhost:5000/?musicPage=2
    }
}
