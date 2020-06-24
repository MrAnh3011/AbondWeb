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
    /// Simple region for a teaser.
    /// </summary>
    public class Teaser
    {

        [Field(Options = FieldOption.HalfWidth)]
        public StringField HeaderTitle { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Title { get; set; }

        [Field]
        public HtmlField Body { get; set; }

        [Field]
        public ImageField Image { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField TitleLink1 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Link1 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField TitleLink2 { get; set; }

        [Field(Options = FieldOption.HalfWidth)]
        public StringField Link2 { get; set; }
    }
}
