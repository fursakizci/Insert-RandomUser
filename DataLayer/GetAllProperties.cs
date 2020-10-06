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
    public class GetAllProperties
    {
        
        public GetAllProperties()
        {
            
        }
        public List<AllProperties> getAllUserProperties()
        {
            List<AllProperties> allProperties = new List<AllProperties>();
            using (var context = new DbUserContext())
            {
                allProperties = (from r in context.Results
                                 join n in context.Names on r.name.Id equals n.Id
                                 join l in context.Logins on r.login.Id equals l.Id
                                 join d in context.Dobs on r.dob.Id equals d.Id
                                 join p in context.Pictures on r.picture.Id equals p.Id
                                 join re in context.Registereds on r.registered.Id equals re.Id
                                 join lo in context.Locations on r.location.Id equals lo.Id
                                 join t in context.Timezones on lo.timezone.Id equals t.Id
                                 join s in context.Streets on lo.street.Id equals s.Id
                                 join c in context.Coordinates on lo.coordinates.Id equals c.Id
                                 join i in context.Ids on r.id.UserId equals i.UserId
                                 select new AllProperties
                                 {
                                     Id = r.Id,
                                     latitude = c.latitude,
                                     longitude = c.longitude,
                                     age = d.age,
                                     name = i.name,
                                     value = i.value,
                                     city = lo.city,
                                     state = lo.state,
                                     country = lo.country,
                                     postcode = lo.postcode,
                                     uuid = l.uuid,
                                     username = l.username,
                                     password = l.password,
                                     salt = l.salt,
                                     md5 = l.md5,
                                     sha1 = l.sha1,
                                     sha256 = l.sha256,
                                     title = n.title,
                                     first = n.first,
                                     last = n.last,
                                     large = p.large,
                                     medium = p.medium,
                                     thumbnail = p.thumbnail,
                                     registeredAge = re.age,
                                     gender = r.gender,
                                     email = r.email,
                                     phone = r.phone,
                                     cell = r.cell,
                                     nat = r.nat,
                                     number = s.number,
                                     streetName = s.name,
                                     offset = t.offset,
                                     description = t.description
                                 }).ToList();

            }
            return allProperties;
        }

        public AllProperties getProperties(int id)
        {
            AllProperties properties = new AllProperties();
            using (var context = new DbUserContext())
            {
                properties = (from r in context.Results
                              join n in context.Names on r.name.Id equals n.Id
                              join l in context.Logins on r.login.Id equals l.Id
                              join d in context.Dobs on r.dob.Id equals d.Id
                              join p in context.Pictures on r.picture.Id equals p.Id
                              join re in context.Registereds on r.registered.Id equals re.Id
                              join lo in context.Locations on r.location.Id equals lo.Id
                              join t in context.Timezones on lo.timezone.Id equals t.Id
                              join s in context.Streets on lo.street.Id equals s.Id
                              join c in context.Coordinates on lo.coordinates.Id equals c.Id
                              join i in context.Ids on r.id.UserId equals i.UserId
                              where r.Id == id
                              select new AllProperties
                              {
                                  Id = r.Id,
                                  latitude = c.latitude,
                                  longitude = c.longitude,
                                  age = d.age,
                                  name = i.name,
                                  value = i.value,
                                  city = lo.city,
                                  state = lo.state,
                                  country = lo.country,
                                  postcode = lo.postcode,
                                  uuid = l.uuid,
                                  username = l.username,
                                  password = l.password,
                                  salt = l.salt,
                                  md5 = l.md5,
                                  sha1 = l.sha1,
                                  sha256 = l.sha256,
                                  title = n.title,
                                  first = n.first,
                                  last = n.last,
                                  large = p.large,
                                  medium = p.medium,
                                  thumbnail = p.thumbnail,
                                  registeredAge = re.age,
                                  gender = r.gender,
                                  email = r.email,
                                  phone = r.phone,
                                  cell = r.cell,
                                  nat = r.nat,
                                  number = s.number,
                                  streetName = s.name,
                                  offset = t.offset,
                                  description = t.description
                              }).FirstOrDefault();
            }
            return properties;
        }
    }
}
