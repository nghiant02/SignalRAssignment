﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

public partial class Customer
{
    [Key]
    public int CustomerID { get; set; }

    [StringLength(255)]
    public string Password { get; set; }

    [StringLength(255)]
    public string ContactName { get; set; }

    [StringLength(255)]
    public string Address { get; set; }

    [StringLength(255)]
    public string Phone { get; set; }

    [InverseProperty("Customer")]
    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}