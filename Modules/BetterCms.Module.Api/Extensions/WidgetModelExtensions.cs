﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WidgetModelExtensions.cs" company="Devbridge Group LLC">
// 
// Copyright (C) 2015,2016 Devbridge Group LLC
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see http://www.gnu.org/licenses/. 
// </copyright>
// 
// <summary>
// Better CMS is a publishing focused and developer friendly .NET open source CMS.
// 
// Website: https://www.bettercms.com 
// GitHub: https://github.com/devbridge/bettercms
// Email: info@bettercms.com
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.Collections.Generic;
using System.Linq;

using BetterCms.Core.DataContracts.Enums;

using BetterCms.Module.Api.Operations.Pages.Widgets.Widget.HtmlContentWidget;
using BetterCms.Module.Api.Operations.Pages.Widgets.Widget.ServerControlWidget;

using BetterCms.Module.Pages.ViewModels.Widgets;
using BetterCms.Module.Root.Models;

namespace BetterCms.Module.Api.Extensions
{
    public static class WidgetModelExtensions
    {
        public static EditHtmlContentWidgetViewModel ToServiceModel(this SaveHtmlContentWidgetModel model)
        {
            var serviceModel = new EditHtmlContentWidgetViewModel();

            serviceModel.Version = model.Version;
            serviceModel.Name = model.Name;
            serviceModel.DesirableStatus = model.IsPublished ? ContentStatus.Published : ContentStatus.Draft;
            serviceModel.PublishedOn = model.PublishedOn;
            serviceModel.PublishedByUser = model.PublishedByUser;
            serviceModel.Categories = model.Categories != null ? model.Categories.Select(c => new LookupKeyValue()
            {
                Key = c.ToString(),
            }).ToList() : new List<LookupKeyValue>();

            serviceModel.CustomCSS = model.CustomCss;
            serviceModel.EnableCustomCSS = model.UseCustomCss;
            serviceModel.PageContent = model.Html;
            serviceModel.EnableCustomHtml = model.UseHtml;
            serviceModel.CustomJS = model.CustomJavaScript;
            serviceModel.EnableCustomJS = model.UseCustomJavaScript;

            if (model.Options != null)
            {
                serviceModel.Options = model.Options.ToServiceModel();
            }

            return serviceModel;
        }
        
        public static EditServerControlWidgetViewModel ToServiceModel(this SaveServerControlWidgetModel model)
        {
            var serviceModel = new EditServerControlWidgetViewModel();

            serviceModel.Version = model.Version;
            serviceModel.Name = model.Name;
            serviceModel.DesirableStatus = model.IsPublished ? ContentStatus.Published : ContentStatus.Draft;
            serviceModel.PublishedOn = model.PublishedOn;
            serviceModel.PublishedByUser = model.PublishedByUser;
            serviceModel.Categories = model.Categories != null ? model.Categories.Select(c => new LookupKeyValue()
            {
                Key = c.ToString(),                
            }).ToList() : new List<LookupKeyValue>();
            serviceModel.Url = model.WidgetUrl;
            serviceModel.PreviewImageUrl = model.PreviewUrl;

            if (model.Options != null)
            {
                serviceModel.Options = model.Options.ToServiceModel();
            }

            return serviceModel;
        }
    }
}