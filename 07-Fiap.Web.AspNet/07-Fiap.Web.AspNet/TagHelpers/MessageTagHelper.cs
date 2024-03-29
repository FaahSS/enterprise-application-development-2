﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Web.AspNet.TagHelpers
{
    public class MessageTagHelper : TagHelper
{
        public string Mensagem { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if(!string.IsNullOrEmpty(Mensagem))
            output.TagName = "div";
            output.Attributes.SetAttribute("class", "alert alert-success");
            output.Content.SetContent(Mensagem);
        }
    }
}
