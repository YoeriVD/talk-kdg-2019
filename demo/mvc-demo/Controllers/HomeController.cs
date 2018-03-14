using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_demo.Models;

namespace mvc_demo.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            var model = new HomeIndexViewModel
            {
                TextCards = new List<TextCard>()
                {
                    new TextCard()
                    {
                        Title = "This is the first text",
                        Preview =
                            "Met video's kunt u uw boodschap krachtig overbrengen. Wanneer u op Onlinevideo klikt, kunt u de ingesloten code plakken voor de video die u wilt toevoegen. U kunt ook een trefwoord typen om online te zoeken naar de video die het meest geschikt is voor het document. Als u het document een professioneler uiterlijk wilt geven, kunt u in Word kiezen uit koptekst-, voettekst-, voorblad- en tekstvakontwerpen die elkaar aanvullen. U kunt bijvoorbeeld een overeenkomend voorblad, koptekst en sidebar toevoegen. Klik op Invoegen en kies vervolgens de elementen uit de verschillende galerieën. Met thema's en stijlen kunt u ook uw document op orde houden. Wanneer u op Ontwerpen klikt en een nieuw thema kiest, worden de afbeeldingen, grafieken en SmartArt-afbeeldingen aan uw nieuwe thema aangepast. Wanneer u stijlen toepast, worden kopteksten aangepast aan het nieuwe thema. ",
                        Sentiments = new[] {"neutral", "motivational"}
                    },
                    new TextCard()
                    {
                        Title = "This is the first text",
                        Preview =
                            "Met video's kunt u uw boodschap krachtig overbrengen. Wanneer u op Onlinevideo klikt, kunt u de ingesloten code plakken voor de video die u wilt toevoegen. U kunt ook een trefwoord typen om online te zoeken naar de video die het meest geschikt is voor het document. Als u het document een professioneler uiterlijk wilt geven, kunt u in Word kiezen uit koptekst-, voettekst-, voorblad- en tekstvakontwerpen die elkaar aanvullen. U kunt bijvoorbeeld een overeenkomend voorblad, koptekst en sidebar toevoegen. Klik op Invoegen en kies vervolgens de elementen uit de verschillende galerieën. Met thema's en stijlen kunt u ook uw document op orde houden. Wanneer u op Ontwerpen klikt en een nieuw thema kiest, worden de afbeeldingen, grafieken en SmartArt-afbeeldingen aan uw nieuwe thema aangepast. Wanneer u stijlen toepast, worden kopteksten aangepast aan het nieuwe thema. ",
                        Sentiments = new[] {"neutral", "motivational"}
                    },
                    new TextCard()
                    {
                        Title = "This is the first text",
                        Preview =
                            "Met video's kunt u uw boodschap krachtig overbrengen. Wanneer u op Onlinevideo klikt, kunt u de ingesloten code plakken voor de video die u wilt toevoegen. U kunt ook een trefwoord typen om online te zoeken naar de video die het meest geschikt is voor het document. Als u het document een professioneler uiterlijk wilt geven, kunt u in Word kiezen uit koptekst-, voettekst-, voorblad- en tekstvakontwerpen die elkaar aanvullen. U kunt bijvoorbeeld een overeenkomend voorblad, koptekst en sidebar toevoegen. Klik op Invoegen en kies vervolgens de elementen uit de verschillende galerieën. Met thema's en stijlen kunt u ook uw document op orde houden. Wanneer u op Ontwerpen klikt en een nieuw thema kiest, worden de afbeeldingen, grafieken en SmartArt-afbeeldingen aan uw nieuwe thema aangepast. Wanneer u stijlen toepast, worden kopteksten aangepast aan het nieuwe thema. ",
                        Sentiments = new[] {"neutral", "motivational"}
                    },
                    new TextCard()
                    {
                        Title = "This is the first text",
                        Preview =
                            "Met video's kunt u uw boodschap krachtig overbrengen. Wanneer u op Onlinevideo klikt, kunt u de ingesloten code plakken voor de video die u wilt toevoegen. U kunt ook een trefwoord typen om online te zoeken naar de video die het meest geschikt is voor het document. Als u het document een professioneler uiterlijk wilt geven, kunt u in Word kiezen uit koptekst-, voettekst-, voorblad- en tekstvakontwerpen die elkaar aanvullen. U kunt bijvoorbeeld een overeenkomend voorblad, koptekst en sidebar toevoegen. Klik op Invoegen en kies vervolgens de elementen uit de verschillende galerieën. Met thema's en stijlen kunt u ook uw document op orde houden. Wanneer u op Ontwerpen klikt en een nieuw thema kiest, worden de afbeeldingen, grafieken en SmartArt-afbeeldingen aan uw nieuwe thema aangepast. Wanneer u stijlen toepast, worden kopteksten aangepast aan het nieuwe thema. ",
                        Sentiments = new[] {"neutral", "motivational"}
                    },
                }
            };
            return View(model);
        }

        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}