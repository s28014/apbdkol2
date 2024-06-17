﻿namespace kol2.Models;

public class Subscription
{
    public int IdSubscription { get; set; }
    public string Name { get; set; }
    public DateOnly EndTime { get; set; }
    public decimal Price { get; set; }

    public ICollection<Sale> Sales { get; set; }
    public ICollection<Payment> Payments { get; set; }
}