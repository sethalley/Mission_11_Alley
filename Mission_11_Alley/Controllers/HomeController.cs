using Microsoft.AspNetCore.Mvc;
using Mission_11_Alley.Models;
using Mission_11_Alley.Models.ViewModels;
using System.Diagnostics;

namespace Mission_11_Alley.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;

        public HomeController(IBookRepository temp)
        {
            _repo = temp;
        }
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var Blah = new BookListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip(pageSize * (pageNum - 1))
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };


            return View(Blah);
        }

    }
}
