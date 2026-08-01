using UnityEngine;
using UnityEngine.Rendering;

public class NumberFormatter
{
    public static string Format(double number)
    {
        if (number < 1000)
        {
            return number.ToString("F0");
        }

        if (number < 1000000)
        {
            return (number / 1000d).ToString("0.#") + "K";
        }

        if (number < 1000000000)
        {
            return (number / 1000000d).ToString("0.#") + "M";
        }

        if (number < 1000000000000)
        {
            return (number / 1000000000d).ToString("0.#") + "B";
        }

        if (number < 1000000000000000)
        {
            return (number / 1000000000000d).ToString("0.#") + "T";
        }

        return (number / 1000000000000000d).ToString("0.#") + "Q";
    }
}
