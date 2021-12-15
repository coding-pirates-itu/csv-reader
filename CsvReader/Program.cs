using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using CsvReaderData;


var fileName = args[0];

//var fileName = "test.csv";
//var csv = @"Month,1958,1959,1960
//JAN,  340,  360,  417
//FEB,  318,  342,  391";
//File.WriteAllText(fileName, csv);

using var f = File.OpenText(fileName);
var header = f.ReadLine().Split(',');

string line;
while ((line = f.ReadLine()) != null && !string.IsNullOrEmpty(line))
{
    var values = line.Split(',');

    for (var i = 0; i < header.Length; i++)
    {
        Console.WriteLine($"{header[i]}: {values[i]}");
    }
}

Console.ReadLine();
Console.WriteLine("--- CsvHelper");

using var reader = File.OpenText(fileName);
var config = new CsvConfiguration(CultureInfo.InvariantCulture);
using var csv = new CsvReader(reader, config);
var records = csv.GetRecords<AirTravelEntry>();
foreach (var r in records)
{
    Console.WriteLine($"1958 {r.Month} - {r.Y1958}");
    Console.WriteLine($"1959 {r.Month} - {r.Y1959}");
    Console.WriteLine($"1960 {r.Month} - {r.Y1960}");
}
