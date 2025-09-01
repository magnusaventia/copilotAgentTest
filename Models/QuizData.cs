using System;
using System.Collections.Generic;

namespace MunicipalQuizGame.Models
{
    public class QuizQuestion
    {
        public string Question { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new();
        public int CorrectAnswerIndex { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Explanation { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
    }

    public class QuizData
    {
        public static List<QuizQuestion> GetQuestions()
        {
            return new List<QuizQuestion>
            {
                new QuizQuestion
                {
                    Question = "Hvilken kommune er Norges st�rste m�lt i areal?",
                    Options = new List<string> { "Kautokeino", "Alta", "Karasjok", "Troms�" },
                    CorrectAnswerIndex = 0,
                    Category = "Geografi",
                    Explanation = "Kautokeino kommune i Finnmark er Norges st�rste kommune med et areal p� 9 707 km�.",
                    ImagePath = "/Images/kautokeino_landscape.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvor mange kommuner er det i Norge i 2024?",
                    Options = new List<string> { "356", "422", "365", "391" },
                    CorrectAnswerIndex = 0,
                    Category = "Fakta",
                    Explanation = "Etter kommunereformen er det 356 kommuner i Norge per 2024.",
                    ImagePath = "/Images/norway_map.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest innbyggere?",
                    Options = new List<string> { "Bergen", "Trondheim", "Oslo", "Stavanger" },
                    CorrectAnswerIndex = 2,
                    Category = "Befolkning",
                    Explanation = "Oslo kommune har over 700 000 innbyggere og er Norges mest folkerike kommune.",
                    ImagePath = "/Images/oslo_city.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune ligger lengst nord i Norge?",
                    Options = new List<string> { "Vard�", "B�tsfjord", "Berlev�g", "Nordkapp" },
                    CorrectAnswerIndex = 3,
                    Category = "Geografi",
                    Explanation = "Nordkapp kommune ligger lengst nord p� fastlandet, men Longyearbyen p� Svalbard er teknisk sett lengst nord.",
                    ImagePath = "/Images/nordkapp_cliff.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hva heter den minste kommunen i Norge m�lt i areal?",
                    Options = new List<string> { "Kvits�y", "Utsira", "V�r�y", "R�st" },
                    CorrectAnswerIndex = 1,
                    Category = "Geografi",
                    Explanation = "Utsira kommune er Norges minste med bare 6,2 km� areal.",
                    ImagePath = "/Images/utsira_island.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune ble etablert som Norges f�rste kommune?",
                    Options = new List<string> { "Oslo", "Bergen", "Trondheim", "Ladested" },
                    CorrectAnswerIndex = 1,
                    Category = "Historie",
                    Explanation = "Bergen fikk byrettigheter i 1070 og regnes som en av Norges eldste kommuner.",
                    ImagePath = "/Images/bergen_harbor.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvor mange fylker (regioner) er det i Norge?",
                    Options = new List<string> { "11", "15", "18", "19" },
                    CorrectAnswerIndex = 0,
                    Category = "Fakta",
                    Explanation = "Norge har 11 fylker etter fylkesreformen.",
                    ImagePath = "/Images/norway_regions.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har h�yest gjennomsnittsinntekt?",
                    Options = new List<string> { "B�rum", "Asker", "Oslo", "Stavanger" },
                    CorrectAnswerIndex = 0,
                    Category = "�konomi",
                    Explanation = "B�rum kommune har tradisjonelt hatt h�yest gjennomsnittsinntekt i Norge.",
                    ImagePath = "/Images/baerum_houses.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hva er det norske navnet for en kommune?",
                    Options = new List<string> { "Borough", "Municipality", "Kommune", "District" },
                    CorrectAnswerIndex = 2,
                    Category = "Spr�k",
                    Explanation = "P� norsk bruker vi ordet 'kommune' for lokale administrative enheter.",
                    ImagePath = "/Images/municipal_building.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest �yer?",
                    Options = new List<string> { "Lofoten", "V�gan", "Flakstad", "Bod�" },
                    CorrectAnswerIndex = 1,
                    Category = "Geografi",
                    Explanation = "V�gan kommune i Lofoten har over 1000 �yer og holmer.",
                    ImagePath = "/Images/lofoten_islands.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hva kalles lederen av en kommune?",
                    Options = new List<string> { "Ordf�rer", "Borgermester", "R�dmann", "Fylkesmann" },
                    CorrectAnswerIndex = 0,
                    Category = "Politikk",
                    Explanation = "Lederen av en kommune kalles ordf�rer i Norge.",
                    ImagePath = "/Images/mayor_office.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har mest regnfall per �r?",
                    Options = new List<string> { "Bergen", "Odda", "Brekke", "�lesund" },
                    CorrectAnswerIndex = 2,
                    Category = "Klima",
                    Explanation = "Brekke kommune p� Vestlandet har mest nedb�r med over 3000mm �rlig.",
                    ImagePath = "/Images/rainy_western_norway.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune ligger lengst s�r i Norge?",
                    Options = new List<string> { "Mandal", "Lindesnes", "Lyngdal", "Farsund" },
                    CorrectAnswerIndex = 1,
                    Category = "Geografi",
                    Explanation = "Lindesnes kommune ligger lengst s�r p� det norske fastlandet.",
                    ImagePath = "/Images/lindesnes_lighthouse.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har f�rrest innbyggere?",
                    Options = new List<string> { "Utsira", "R�st", "Modalen", "Fedje" },
                    CorrectAnswerIndex = 0,
                    Category = "Befolkning",
                    Explanation = "Utsira kommune har bare rundt 200 innbyggere og er Norges minst folkerike kommune.",
                    ImagePath = "/Images/small_village.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken by var Norges hovedstad f�r Oslo?",
                    Options = new List<string> { "Bergen", "Trondheim", "Stavanger", "Hamar" },
                    CorrectAnswerIndex = 1,
                    Category = "Historie",
                    Explanation = "Trondheim (Nidaros) var Norges hovedstad i middelalderen f�r Oslo tok over.",
                    ImagePath = "/Images/trondheim_cathedral.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest tunneler?",
                    Options = new List<string> { "Rogaland", "Bergen", "Troms�", "�lesund" },
                    CorrectAnswerIndex = 1,
                    Category = "Infrastruktur",
                    Explanation = "Bergen kommune har flest tunneler p� grunn av den krevende topografien.",
                    ImagePath = "/Images/bergen_tunnel.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune er kjent for � ha midnattssol?",
                    Options = new List<string> { "Alta", "Bod�", "Harstad", "Alle over" },
                    CorrectAnswerIndex = 3,
                    Category = "Natur",
                    Explanation = "Alle kommuner nord for polarsirkelen opplever midnattssol om sommeren.",
                    ImagePath = "/Images/midnight_sun.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvor mange kommuner ble det etter kommunereformen i 2020?",
                    Options = new List<string> { "356", "370", "422", "428" },
                    CorrectAnswerIndex = 0,
                    Category = "Politikk",
                    Explanation = "Kommunereformen reduserte antall kommuner fra 422 til 356.",
                    ImagePath = "/Images/municipal_reform.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har h�yest beliggenhet?",
                    Options = new List<string> { "Lillehammer", "R�ros", "Tynset", "Oppdal" },
                    CorrectAnswerIndex = 1,
                    Category = "Geografi",
                    Explanation = "R�ros ligger h�yest over havet av norske kommunesentre, p� 628 moh.",
                    ImagePath = "/Images/roros_mountains.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest museer per innbygger?",
                    Options = new List<string> { "Oslo", "Bergen", "R�ros", "Troms�" },
                    CorrectAnswerIndex = 2,
                    Category = "Kultur",
                    Explanation = "R�ros har en h�y tetthet av museer relatert til gruvehistorien og UNESCO-statusen.",
                    ImagePath = "/Images/roros_museum.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har landets nordligste jernbanestasjon?",
                    Options = new List<string> { "Fauske", "Bod�", "Narvik", "Mo i Rana" },
                    CorrectAnswerIndex = 1,
                    Category = "Transport",
                    Explanation = "Bod� er endestasjon for Nordlandsbanen og Norges nordligste jernbanestasjon.",
                    ImagePath = "/Images/bodo_train_station.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest vindm�ller?",
                    Options = new List<string> { "Fosen", "Havsul", "Rogaland", "M�re og Romsdal" },
                    CorrectAnswerIndex = 0,
                    Category = "Energi",
                    Explanation = "Fosen vindpark er verdens st�rste vindpark p� land og ligger i Tr�ndelag.",
                    ImagePath = "/Images/wind_turbines.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har landets lengste kystlinje?",
                    Options = new List<string> { "Bergen", "Troms�", "Nordkapp", "V�gan" },
                    CorrectAnswerIndex = 1,
                    Category = "Geografi",
                    Explanation = "Troms� kommune har en sv�rt lang og kompleks kystlinje med mange �yer.",
                    ImagePath = "/Images/tromso_coastline.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune ble f�rst elektrisk belyst i Norge?",
                    Options = new List<string> { "Hammerfest", "Oslo", "Bergen", "Trondheim" },
                    CorrectAnswerIndex = 0,
                    Category = "Historie",
                    Explanation = "Hammerfest var verdens nordligste by med elektrisk gatebelysning i 1891.",
                    ImagePath = "/Images/hammerfest_lights.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har det mildeste klimaet?",
                    Options = new List<string> { "Bergen", "Stavanger", "Mandal", "Kristiansand" },
                    CorrectAnswerIndex = 1,
                    Category = "Klima",
                    Explanation = "Stavanger har et mildt kystklima med relativt stabile temperaturer �ret rundt.",
                    ImagePath = "/Images/stavanger_climate.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest samiske innbyggere?",
                    Options = new List<string> { "Kautokeino", "Karasjok", "Tana", "Nesseby" },
                    CorrectAnswerIndex = 0,
                    Category = "Kultur",
                    Explanation = "Kautokeino har den st�rste samiske befolkningen og er et viktig samisk kultursentrum.",
                    ImagePath = "/Images/sami_culture.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har landets st�rste fiskefl�te?",
                    Options = new List<string> { "Bergen", "Troms�", "�lesund", "Bod�" },
                    CorrectAnswerIndex = 1,
                    Category = "N�ring",
                    Explanation = "Troms� har Norges st�rste fiskefl�te og er et viktig fiskerisentrum.",
                    ImagePath = "/Images/fishing_fleet.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest hoteller per innbygger?",
                    Options = new List<string> { "Lillehammer", "Geiranger", "Fl�m", "Lofoten" },
                    CorrectAnswerIndex = 1,
                    Category = "Turisme",
                    Explanation = "Geiranger har en ekstremt h�y tetthet av hoteller p� grunn av turisttrafikken.",
                    ImagePath = "/Images/geiranger_hotels.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har landets st�rste universitetsomr�de?",
                    Options = new List<string> { "Oslo", "Bergen", "Trondheim", "Troms�" },
                    CorrectAnswerIndex = 2,
                    Category = "Utdanning",
                    Explanation = "NTNU i Trondheim har det st�rste campus-omr�det m�lt i areal.",
                    ImagePath = "/Images/ntnu_campus.jpg"
                },
                new QuizQuestion
                {
                    Question = "Hvilken kommune har flest skil�yper?",
                    Options = new List<string> { "Lillehammer", "Trysil", "Oslo", "Drammen" },
                    CorrectAnswerIndex = 2,
                    Category = "Sport",
                    Explanation = "Oslo har det mest omfattende l�ypenettet med over 2600 km preparerte skil�yper.",
                    ImagePath = "/Images/ski_trails.jpg"
                }
            };
        }
    }
}