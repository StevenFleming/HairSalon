using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
        _db = db;
    }

    public ActionResult Index()
    {
      List<Client> model = _db.Clients.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
        _db.Clients.Add(client);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Client thisStylist = _db.Clients.FirstOrDefault(clients => clients.Id == id);
        return View(thisStylist);
    }

    public ActionResult Delete(int id)
    {
        var thisStylist = _db.Clients.FirstOrDefault(clients => clients.Id == id);
        return View(thisStylist);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
        var thisStylist = _db.Clients.FirstOrDefault(client => client.Id == id);
        _db.Clients.Remove(thisStylist);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}