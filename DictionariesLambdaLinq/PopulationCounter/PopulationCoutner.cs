using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Task "Population counter"
/// You get raw data for a given city and you need to aggregate it. 
/// On each input line you’ll be given data in format: "city|country|population". There will be no redundant
/// whitespaces anywhere in the input.Aggregate the data by country and by city and print it on the console.
/// For each country, print its total population and on separate lines the data for each of its cities.
/// Countries should be ordered by their total population in descending order and within each country,
/// the cities should be ordered by the same criterion.If two countries/cities have the same population, 
/// keep them in the order in which they were entered. Check out the examples; follow the output format strictly!
///  Input
/// - The input data should be read from the console.
/// - It consists of a variable number of lines and ends when the command "report" is received.
/// - The input data will always be valid and in the format described.There is no need to check it explicitly.
/// Output:
/// - The output should be printed on the console.
/// - Print the aggregated data for each country and city
/// Constraints:
/// - The name of the city, country and the population count will be separated from each other by a pipe ('|').
/// - The number of input lines will be in the range[2 … 50].
/// - A city-country pair will not be repeated.
/// - The population count of each city will be an integer in the range [0 … 2 000 000 000].
/// - Allowed working time for your program: 0.1 seconds.Allowed memory: 16 MB.
/// </summary>
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