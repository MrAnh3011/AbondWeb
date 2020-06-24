/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using Piranha.Extend;
using Piranha.Extend.Fields;
using Piranha.Models;

namespace MvcWeb.Models.Regions
{
    /// <summary>
    /// Simple hero region.
    /// </summary>
    public class Hero
    {
        [Field(Options = FieldOption.HalfWidth)]
        public StringField Name { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        [Field]
        public ImageField Avatar { get; set; }

    }
}
