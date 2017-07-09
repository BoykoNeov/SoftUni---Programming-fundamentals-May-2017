using System;
using System.Collections.Generic;
using System.Linq;

public class PokoemonDontGo
{
   public static void Main()
    {
        List<long> pokemons = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions
            .RemoveEmptyEntries)
            .Select(long.Parse)
            .ToList();

        long pokemonSum = 0;

        while (pokemons.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());
            long actedOnPokemon = 0;

            if (index >= pokemons.Count)
            {
                actedOnPokemon = pokemons[pokemons.Count -1];
                pokemons[pokemons.Count-1] = pokemons[0];
                pokemonSum += actedOnPokemon;

                ChangeValues(actedOnPokemon, pokemons);
            }
            else if (index < 0)
            {
                actedOnPokemon = pokemons[0];
                pokemons[0] = pokemons[pokemons.Count - 1];
                pokemonSum += actedOnPokemon;

                ChangeValues(actedOnPokemon, pokemons);
            }
            else
            {
                actedOnPokemon = pokemons[index];
                pokemons.RemoveAt(index);
                pokemonSum += actedOnPokemon;

                ChangeValues(actedOnPokemon, pokemons);
            }
        }

        Console.WriteLine(pokemonSum);
    }

    private static void ChangeValues(long actedOnPokemon, List<long> pokemons)
    {
        for (int i = 0; i < pokemons.Count; i++)
        {
            if (pokemons[i] <= actedOnPokemon)
            {
                pokemons[i] += actedOnPokemon;
            }
            else
            {
                pokemons[i] -= actedOnPokemon;
            }
        }
    }
}