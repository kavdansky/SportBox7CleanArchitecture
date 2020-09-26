namespace SportBox7.Domain.Models.Editors
{
    using System.Collections.Generic;
    using System.Linq;
    using Bogus;
    using Common;
    //using static CarAds.CarAdFakes.Data;
   

    public class DealerFakes
    {
        public static class Data
        {
           // public static IEnumerable<Editor> GetEditors(int count = 10)
           //     => (IEnumerable<Editor>)Enumerable
           //         .Range(1, count)
           //         .Select(GetEditor)
           //         .ToList();
           //
           // public static Editor GetEditor(int id = 1, int totalCarAds = 10)
           // {
           //     var dealer = new Faker<Editor>()
           //         .CustomInstantiator(f => new Editor(
           //             $"Editor{id}",
           //             f.Phone.PhoneNumber("+########")))
           //         .Generate()
           //         .SetId(id);
           //
           //     foreach (var carAd in GetCarAd().Take(totalCarAds))
           //     {
           //         dealer.AddCarAd(carAd);
           //     }
           //
           //     return dealer;
           // }
        }
    }
}
