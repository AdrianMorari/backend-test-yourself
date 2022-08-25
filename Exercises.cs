using System.Collections.Generic;
using System;

class Exercises
{
    // First Exercise
    public static List<B> Map<A, B>(List<A> list, Func<A, B> f)
    {
        var result = new List<B>();
        if (list == null)
            throw new ArgumentNullException("Empty initial list");
        if (f == null)
            throw new ArgumentNullException("Empty function");
        foreach (var item in list)
        {
            result.Add(f(item));
        }
        return result;
    }

    // Second Exercise
    public static B Fold<A, B>(List<A> list, B sum, Func<B, A, B> func)
    {
        B result = sum;
        if (list == null)
            throw new ArgumentNullException("Empty list A");
        if (sum == null)
            throw new ArgumentNullException("Empty sum");
        if (func == null)
            throw new ArgumentNullException("Empty function");
        foreach (var item in list)
        {
            result = func(sum, item);
        }
        return result;
    }

    // Third Exercise
    public static List<B> Map2<A, B>(List<A> list, Func<A, B> f)
    {
        if (list == null)
            throw new ArgumentNullException("Empty list A");
        if (f == null)
            throw new ArgumentNullException("Empty function");
        var result = Fold(list, new List<B>(), (listB, x) =>
        {
            listB.Add(f(x));
            return listB;
        });

        return result;
    }
}