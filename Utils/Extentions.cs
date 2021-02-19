using System;
using Gladiator.Model.Gladiators;

namespace Gladiator.Utils
{
    public static class Extentions
    {
        public static Random Random = new Random();
        public static double Value(this StatisticMultiplier statisticMultiplier)
        {
            return statisticMultiplier switch
            {
                StatisticMultiplier.Easy => 0.75,
                StatisticMultiplier.Medium => 1.0,
                StatisticMultiplier.High => 1.25,
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public static string Rand(this string[] strings)
        {
            return strings[Random.Next(0, strings.Length)];
        }
    }
}