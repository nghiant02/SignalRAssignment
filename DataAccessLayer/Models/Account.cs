﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models;

[Table("Account")]
public partial class Account
{
    [Key]
    public int AccountID { get; set; }

    [StringLength(255)]
    public string UserName { get; set; }

    [StringLength(255)]
    public string Password { get; set; }

    [StringLength(255)]
    public string FullName { get; set; }

    [StringLength(50)]
    public string Type { get; set; }
}