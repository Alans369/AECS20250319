using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AECS20250319.AppWebMVC.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    [Display(Name = "Categoria")]
    public int? CategoryId { get; set; }

    [Display(Name = "Marca")]
    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; } = null!;

    public virtual Category? Category { get; set; } = null!;
}
