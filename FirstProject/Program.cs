using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

// ReSharper disable UseFormatSpecifierInInterpolation

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string csvPath = @"D:\vs projects\c-sharp_fundamentals_051222\FirstProject\googleplaystore1.csv";
            var googleApps = LoadGoogleAps(csvPath);

            //Display(googleApps);
            GetData(googleApps);


        }

        static void GetData(IEnumerable<GoogleApp> googleApps)
        {
            //bool IsHighRatedApp(GoogleApp app)
            //{
            //    return app.Rating > 4.6;
            //}

            //var highRatedApps = googleApps.Where(IsHighRatedApp);

            var highRatedApps = googleApps.Where(x => x.Rating > 4.6 && x.Category == Category.BEAUTY);
        }

        static void Display(IEnumerable<GoogleApp> googleApps)
        {
            foreach (var googleApp in googleApps)
            {
                Console.WriteLine(googleApp);
            }

        }
        static void Display(GoogleApp googleApp)
        {
            Console.WriteLine(googleApp);
        }

        static List<GoogleApp> LoadGoogleAps(string csvPath)
        {
            using (var reader = new StreamReader(csvPath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<GoogleAppMap>();
                var records = csv.GetRecords<GoogleApp>().ToList();
                return records;
            }

        }

    }

    
}


