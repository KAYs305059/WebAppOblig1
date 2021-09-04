using System;
using System.Collections.Generic;
using KundeApp1.Model;
using Microsoft.AspNetCore.Mvc;

namespace KundeApp1.Controllers
{
    [Route("[controller]/[action]")]
    public class KundeController : ControllerBase
    {
        public List<Kunde> HentAlle()
        {
            var kundene = new List<Kunde>();

            var kunde1 = new Kunde();
            kunde1.navn = "Kristian Bakke";
            kunde1.adresse = "Bjornveien 12";

            var kunde2 = new Kunde
            {
                navn = "Seline Hansen",
                adresse = "Nyjordet 31"
            };

            kundene.Add(kunde1);
            kundene.Add(kunde2);

            return kundene;
        }
    }
}
