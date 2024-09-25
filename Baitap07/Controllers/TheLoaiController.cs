﻿using Baitap07.Data;
using Baitap07.Models;
using Microsoft.AspNetCore.Mvc;

namespace Baitap07.Controllers
{
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TheLoaiController(ApplicationDbContext db)
        {
               _db = db;
        }
        public IActionResult Index()
        {
            var theloai = _db.TheLoai.ToList();
			ViewBag.theloai = theloai;
            return View();
        }

        [HttpGet]
		public IActionResult Create()
		{
			
			return View();
		}
        [HttpPost]
		public IActionResult Create(TheLoai theloai)
		{
            if (ModelState.IsValid)
            {
				_db.TheLoai.Add(theloai);
				_db.SaveChanges();
				return RedirectToAction("index");
			}
			return View();
		}
        [HttpGet]
		public IActionResult Edit(int id)
		{
			if( id == 0)
			{
				return NotFound();
			}
			var theloai = _db.TheLoai.Find(id);
			return View();
		}
		[HttpPost]
		public IActionResult Edit(TheLoai theloai)
		{
		
			if (ModelState.IsValid)
			{
				_db.TheLoai.Update(theloai);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
			
		}
		[HttpGet]
		public IActionResult Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var theloai = _db.TheLoai.Find(id);
			return View();
		}
		[HttpPost]
		public IActionResult DeleteConfirm (int id)
		{
			var theloai = _db.TheLoai.Find(id);
			if (theloai == null)
			{
				return NotFound();
			}
			_db.TheLoai.Remove(theloai);
			_db.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Detail(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var theloai = _db.TheLoai.Find(id);
			return View(theloai);
		}

	}
}
