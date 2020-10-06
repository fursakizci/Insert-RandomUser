using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataLayer;
using DataLayer.Abstract;
using DataLayer.Concrete;
using Model;
using RandomUserMVC.UI.Models;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace RandomUserMVC.UI.Controllers
{
    public class HomeController : Controller
    {
        private ICoordinatesDal _coordinatesDal;
        private IDobDal _dobDal;
        private IIdDal _idDal;
        private IInfoDal _infoDal;
        private ILocationDal _locationDal;
        private ILoginDal _loginDal;
        private INameDal _nameDal;
        private IPictureDal _pictureDal;
        private IRegisteredDal _registeredDal;
        private IResultDal _resultDal;
        private IRootDal _rootDal;
        private IStreetDal _streetDal;
        private ITimezoneDal _timezoneDal;
        public HomeController()
        {
            _coordinatesDal = new CoordinatesDal();
            _dobDal = new DobDal();
            _idDal = new IdDal();
            _infoDal = new InfoDal();
            _locationDal = new LocationDal();
            _loginDal = new LoginDal();
            _nameDal = new NameDal();
            _pictureDal = new PictureDal();
            _registeredDal = new RegisteredDal();
            _resultDal = new ResultDal();
            _rootDal = new RootDal();
            _streetDal = new StreetDal();
            _timezoneDal = new TimezoneDal();
        }
        public ActionResult Index()
        {
            return View(_nameDal.GetAllModel());
        }
        [HttpGet]
        public ActionResult UpdatePage(int id)
        {
            AllProperties properties = new AllProperties();
            var prop = new GetAllProperties();
            return View(prop.getProperties(id));
           //return View(_nameDal.GetModel(id));
        }
        [HttpPost]
        public ActionResult UpdatePage(AllProperties model)
        {
            UpdateAllTable updateAll = new UpdateAllTable();
            updateAll.UpdateAll(model);
            TempData["allTemp"] = "All Tables Was Update!";

            //return View(model);
            return RedirectToAction("UpdatePage", new { id = model.Id });
            //return View(_nameDal.GetModel(id));
        }
        [HttpPost]
        public ActionResult UpdateName(AllProperties model)
        {
            Name name = new Name();
            name = new Name
            {
                Id = model.Id,
                title = model.title,
                first = model.first,
                last = model.last
            };
            _nameDal.Update(name);
            TempData["nameTemp"] = "Name Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdateResult(AllProperties model)
        {
            Result result = new Result();
            result = new Result
            {
                Id = model.Id,
                gender = model.gender,
                name = _nameDal.GetModel(model.Id),
                location = _locationDal.GetModel(model.Id),
                email = model.email,
                login = _loginDal.GetModel(model.Id),
                dob = _dobDal.GetModel(model.Id),
                registered = _registeredDal.GetModel(model.Id),
                phone = model.phone,
                cell = model.cell,
                id = _idDal.GetModel(model.Id),
                picture = _pictureDal.GetModel(model.Id),
                nat = model.nat

            };
            _resultDal.Update(result);
            TempData["resultTemp"] = "Result Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdateCoordinates(AllProperties model)
        {
            Coordinates coordinate = new Coordinates();
            coordinate = new Coordinates
            {
                Id = model.Id,
                latitude = model.latitude,
                longitude = model.longitude
            };
            _coordinatesDal.Update(coordinate);
            TempData["coordinatesTemp"] = "Coordinates Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdateId(AllProperties model)
        {
            Id id = new Id();
            id = new Id
            {
               UserId = model.Id,
               name = model.name,
               value = model.value
            };
            _idDal.Update(id);
            TempData["idTemp"] = "Id Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdateLocation(AllProperties model)
        {
           Location location = new Location();
            location = new Location
            {
                Id = model.Id,
                street = _streetDal.GetModel(model.Id),
                city = model.city,
                state = model.state,
                country = model.country,
                postcode = model.postcode,
                coordinates = _coordinatesDal.GetModel(model.Id),
                timezone = _timezoneDal.GetModel(model.Id)
            };
            _locationDal.Update(location);
            TempData["locationTemp"] = "Location Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdateLogin(AllProperties model)
        {
            Login login = new Login();
            login = new Login
            {
                Id = model.Id,
                uuid = model.uuid,
                username = model.username,
                password = model.password,
                salt = model.salt,
                md5 = model.md5,
                sha1 = model.sha1,
                sha256 = model.sha256
            };
            _loginDal.Update(login);
            TempData["loginTemp"] = "Login Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdatePicture(AllProperties model)
        {
            Picture picture = new Picture();
            picture = new Picture
            {
                Id = model.Id,
                large = model.large,
                medium = model.medium,
                thumbnail = model.thumbnail
            };
            _pictureDal.Update(picture);
            TempData["pictureTemp"] = "Picture Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdateStreet(AllProperties model)
        {
            
            Street street = new Street();
            street = new Street
            {
                Id = model.Id,
                number = model.number,
                name = model.streetName
            };
            _streetDal.Update(street);
            TempData["streetTemp"] = "Street Table Was Update!";
            return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        [HttpPost]
        public ActionResult UpdateTimezone(AllProperties model)
        {
            Timezone timezone = new Timezone();
            timezone = new Timezone
            {
               Id = model.Id,
               offset = model.offset,
               description = model.description
            };
            _timezoneDal.Update(timezone);
            TempData["timezoneTemp"] = "Timezone Table Was Update!";
            
            return RedirectToAction("UpdatePage", new { id = model.Id});
        }
        [HttpPost]
        public JsonResult UpdateAllTable(AllProperties model)
        {
            UpdateAllTable updateAll = new UpdateAllTable();
            updateAll.UpdateAll(model);
            TempData["allTemp"] = "All Tables Was Update!";
            return Json(model, JsonRequestBehavior.AllowGet);
           // return RedirectToAction("UpdatePage", new { id = model.Id });
        }
        
        public ActionResult AddItem()
        {
            Root root = new Root();
            RandomUser user = new RandomUser();
            root = user.GetRandomUser();
            using (var context = new DbUserContext())
            {
                context.Roots.Add(root);
                context.SaveChanges();
            }
            TempData["message"] = "ok";
            return RedirectToAction("Index");      
        }


      
        
        public ActionResult Deneme()
        {
            return View();
        }

        

    }
}