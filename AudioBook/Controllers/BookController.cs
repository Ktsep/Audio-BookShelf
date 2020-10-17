using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AudioBook.Core.Domain;
using AudioBook.Core.ViewModels;
using AudioBook.Persistence;
using AudioBook.Persistence.Repositories;
using PagedList;

namespace AudioBook.Controllers
{
    public class BookController : Controller
    {
        UnitOfWork unitOfWork = new UnitOfWork(new ApplicationDbContext());

        // GET: Book
        public ActionResult Index(string searchName, int? page)
        {
            var books = unitOfWork.Books.GetBooksWithAuthors();
            if (!String.IsNullOrEmpty(searchName))
            {
                books = books.Where(x => x.Title.ToUpper().Contains(searchName.ToUpper()));
            }
            int pageSize = 4;
            int pageNumber = page ?? 1;
            return View(books.ToPagedList(pageNumber, pageSize));
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = unitOfWork.Books.Get(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return View(book);
        }

        public ActionResult Player(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Book book = unitOfWork.Books.Get(id);
            if (book == null)
            {
                return HttpNotFound();
            }
            var audio = unitOfWork.Audio.GetAll().Where(a => a.BookId == id);


            List<string> urlList = new List<string>();
            foreach (var aurl in audio)
            {
                urlList.Add(aurl.Url);
            }

            List<string> nameList = new List<string>();
            foreach (var aname in audio)
            {
                nameList.Add(aname.Name);
            }

            var viewModel = new AudioBookViewModel
            {
                Book = book,
                Url = urlList,
                Name = nameList
            };

            return View("Player", viewModel);
        }

    }
}
