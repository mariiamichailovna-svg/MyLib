using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib;

///
/// Для работы со строками.
///
public static class StringTools
{
    /// Разворачивает строку задом наперёд
    /// <exception cref="ArgumentNullException">Если строка равна null.</exception>
    public static string Reverse(string s)
    {
        if (s is null) throw new ArgumentNullException(nameof(s));
        return new string(s.Reverse().ToArray());
    }

    /// Считает количество слов (разделители: пробелы/таб/переносы)
    /// <exception cref="ArgumentNullException">Если строка равна null.</exception>
    public static int WordCount(string s)
    {
        if (s is null) throw new ArgumentNullException(nameof(s));
        return s.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}

