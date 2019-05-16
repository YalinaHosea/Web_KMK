using System;
using Microsoft.AspNetCore.Mvc;
using Web_KMK.DAL;
using Web_KMK.Models;

namespace Web_KMK.Controllers{

    public class RenunganController : Controller{
        
        private IRenungan _renung;
    public RenunganController(IRenungan renung)
    {
        _renung = renung;
    }
            public IActionResult Index(){
                var data = _renung.GetAll();
                return View(data);
            }

            public IActionResult Detail(int id_bacaan){
                var data = _renung.GetById(id_bacaan);
                return View(data);
            }

             public IActionResult Create(){
                 return View();
            }

            [HttpPost]
            public object Create(Renungan ren){
            try{
                _renung.Create(ren);
               
                return RedirectToAction("Index");
            }
            catch(Exception ex){
                ViewData["pesan"] =
                $"<span class='alert alert-danger'>Data Gagal Ditambah, {ex.Message}</span>";
                return View("Index");

            }
        }

        public IActionResult Edit(int id_bacaan){
            var data = _renung.GetById(id_bacaan);
                 return View(data);
            }


            [HttpPost]
        public IActionResult Edit(Renungan ren){
            try{
                _renung.Update(ren);
                  
                return RedirectToAction("Index");
            }catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }
        public IActionResult Delete(int id_bacaan){
            try{
                _renung.Delete(id_bacaan);
                
                return RedirectToAction("Index");
            }catch(Exception ex){
                return Content($"Error: {ex.Message}");
            }
        }
         

    }
}