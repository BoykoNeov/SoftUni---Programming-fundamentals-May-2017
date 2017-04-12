// Task "Population counter"
// Check the file ../06. Programming-Fundamentals-Dictionaries-Lambda-LINQ-Exercises for task description

using System;
using System.Collections.Generic;
using System.Linq;

public class PopulationCounter
{
    public static void Main()
    {
        // Nested dictionary to hold all country and city input data
        Dictionary<string, Dictionary<string, int>> countryCities = new Dictionary<string, Dictionary<string, int>>();
        // Dictionary to hold total country pop
        var countriesTotalPop = new Dictionary<string, long>();

        while (true)
        {
            List<string> input = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (input[0] == "report")
            {
                break;
            }

            string countryName = input[1];
            string cityName = input[0];
            int cityPopulation = int.Parse(input[2]);

            if (!countryCities.ContainsKey(countryName))
            {
                countryCities[countryName] = new Dictionary<string, int>();
                // create entries in the second dictionary
                countriesTotalPop.Add(countryName, 0);
            }

            countryCities[countryName].Add(cityName, cityPopulation);
            countriesTotalPop[countryName] += cityPopulation;
        }

        foreach (var kvpCountryPop in countriesTotalPop.OrderByDescending(i => i.Value))
        {
            Console.WriteLine($"{kvpCountryPop.Key} (total population: {kvpCountryPop.Value})");
            foreach (var kvpCityPop in countryCities[kvpCountryPop.Key].OrderByDescending(j => j.Value))
            {
                Console.WriteLine($"=>{kvpCityPop.Key}: {kvpCityPop.Value}");
            }
        }
    }
}