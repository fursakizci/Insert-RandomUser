using DataLayer.Abstract;
using DataLayer.Concrete;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UpdateAllTable
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
        public UpdateAllTable()
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
        public void UpdateAll(AllProperties model)
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

            Coordinates coordinate = new Coordinates();
            coordinate = new Coordinates
            {
                Id = model.Id,
                latitude = model.latitude,
                longitude = model.longitude
            };
            _coordinatesDal.Update(coordinate);

            Id id = new Id();
            id = new Id
            {
                UserId = model.Id,
                name = model.name,
                value = model.value
            };
            _idDal.Update(id);

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

            Picture picture = new Picture();
            picture = new Picture
            {
                Id = model.Id,
                large = model.large,
                medium = model.medium,
                thumbnail = model.thumbnail
            };
            _pictureDal.Update(picture);

            Street street = new Street();
            street = new Street
            {
                Id = model.Id,
                number = model.number,
                name = model.streetName
            };
            _streetDal.Update(street);

            Timezone timezone = new Timezone();
            timezone = new Timezone
            {
                Id = model.Id,
                offset = model.offset,
                description = model.description
            };
            _timezoneDal.Update(timezone);
        }

    }
}
