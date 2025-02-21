﻿namespace ShopUI.Models.Entities;

public class Order
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public DateTime Date { get; set; }

    public int UserId { get; set; }
    public User User { get; set; }

    public int ProductId { get; set; }
    public Product Product { get; set; }

}

