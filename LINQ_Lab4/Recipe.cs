﻿namespace LINQ_Lab4;

public class Recipe : IRecipe
{
    public string _doctorName;
    public DateTime _expirationDate;
    public Recipe(string doctorName, DateTime expirationDate)
    {
        _doctorName = doctorName;
        _expirationDate = expirationDate;
    }

    public void Extend(int days)
    {
        var tmp = _expirationDate;
        _expirationDate = _expirationDate.AddDays(days);
        Console.WriteLine($"Expiration date extended by {days} days. Old expiration date: {tmp}. New expiration date: {_expirationDate}");
    }
    
    public override string ToString()
    {
        return $"Doctor: {_doctorName}, Expiration Date: {_expirationDate}";
    }

}