﻿namespace ShopUI.Models.Entities;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public List<Order> Orders { get; set; }

}
