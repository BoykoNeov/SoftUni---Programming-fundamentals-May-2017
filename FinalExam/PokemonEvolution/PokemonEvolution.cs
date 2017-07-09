using System;
using System.Collections.Generic;
using System.Linq;

public class PokemonEvolution
{
    public static void Main()
    {
        string input = string.Empty;
        Dictionary<string, List<Evolution>> pokemonsEvolutions = new Dictionary<string, List<Evolution>>();

        while ((input = Console.ReadLine()) != "wubbalubbadubdub")
        {
            string[] parameters = input.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

            if (parameters.Length == 1)
            {
                if (pokemonsEvolutions.ContainsKey(parameters[0]))
                {
                    Console.WriteLine($"# {parameters[0]}");

                    foreach (Evolution evol in pokemonsEvolutions[parameters[0]])
                    {
                        Console.WriteLine($"{evol.Name} <-> {evol.Index}");
                    }
                }
            }
            else
            {
                string pokemonName = parameters[0];
                string evolutionType = parameters[1];
                int evolutionIndex = int.Parse(parameters[2]);

                if (!pokemonsEvolutions.ContainsKey(pokemonName))
                {
                    pokemonsEvolutions.Add(pokemonName, new List<Evolution>());
                }

                Evolution currentEvolution = new Evolution(evolutionType, evolutionIndex);
                pokemonsEvolutions[pokemonName].Add(currentEvolution);
            }
        }

        foreach (KeyValuePair<string, List<Evolution>> pokemons in pokemonsEvolutions)
        {
            Console.WriteLine($"# {pokemons.Key}");

            foreach (Evolution evol in pokemons.Value.OrderByDescending(ev => ev.Index))
            {
                Console.WriteLine($"{evol.Name} <-> {evol.Index}");
            }
        }
    }
}

public class Evolution
{
    string name;
    int index;

    public string Name { get => name; set => name = value; }
    public int Index { get => index; set => index = value; }

    public Evolution(string inputName, int inputIndex)
    {
        this.Name = inputName;
        this.Index = inputIndex;
    }
}