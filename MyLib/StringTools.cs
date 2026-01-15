using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib;

/// <summary>
/// Утилиты для работы со строками.
/// </summary>
public static class StringTools
{
    /// <summary>Разворачивает строку задом наперёд.</summary>
    /// <exception cref="ArgumentNullException">Если строка равна null.</exception>
    public static string Reverse(string s)
    {
        if (s is null) throw new ArgumentNullException(nameof(s));
        return new string(s.Reverse().ToArray());
    }

    /// <summary>Считает количество слов (разделители: пробелы/таб/переносы).</summary>
    /// <exception cref="ArgumentNullException">Если строка равна null.</exception>
    public static int WordCount(string s)
    {
        if (s is null) throw new ArgumentNullException(nameof(s));
        return s.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

