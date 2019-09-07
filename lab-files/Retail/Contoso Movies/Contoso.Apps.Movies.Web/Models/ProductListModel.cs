﻿using Contoso.Apps.Movies.Data.Models;

namespace Contoso.Apps.Movies.Web.Models
{
    public class ProductListModel : Product
    {
        new public double? UnitPrice { get; set; }

        new public int? CategoryID { get; set; }
    }
}