using BusinessLayer.Concrete;
using DataLayer.Abstract;
using DataLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class GetAllUserProperties
    {
        private INameDal _nameDal;
        private IResultDal _resultDal;
        public GetAllUserProperties()
        {
            _nameDal = new NameDal();
            _resultDal = new ResultDal();
        }
        //var Kulupler = KulupleriGetir();

        //        var Ogrenciler = OgrencileriGetir();

        //        var OgrencilerVeKulupSorumlulari =
        //            from Ogrenci in Ogrenciler
        //            join Kulup in Kulupler on Ogrenci.Kulup equals Kulup.KayitNo
        //            select new { OgrenciAdi = Ogrenci.Adi, KulupAdi = Kulup.Adi, KulupSorumlusu = Kulup.Sorumlu };

        //        Console.WriteLine("Öğrenciler ve üye oldukları kulüplerin rehber öğretmenleri :");

        //foreach (var Nesne in OgrencilerVeKulupSorumlulari)
        //{
        //    Console.WriteLine("{0} isimli öğrenci {1} kulübüne üyedir. Kulübün rehber öğretmeni: {2}.",
        //                      Nesne.OgrenciAdi,
        //                      Nesne.KulupAdi,
        //                      Nesne.KulupSorumlusu);
        //}
        //    Console.ReadLine();

        void getAllProperties()
        {
           
                var names = _nameDal.GetAllModel();
                var results = _resultDal.GetAllModel();

                var deneme =
                    from Result in results
                    join Name in names on Result.name.Id equals Name.Id
                    select new { t = Name.title, g = Result.gender };
        }
    }
}
