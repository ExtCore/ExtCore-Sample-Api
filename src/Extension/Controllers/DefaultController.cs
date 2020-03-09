// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Extension.Controllers
{
  [Route("api/v1/items")]
  public class DefaultController : Controller
  {
    [HttpGet]
    public IEnumerable<Item> Get()
    {
      return new[] { new Item("Item 1", 1), new Item("Item 2", 2), new Item("Item 3", 3) };
    }
  }
}