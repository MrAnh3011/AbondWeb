/*
 * Copyright (c) .NET Foundation and Contributors
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/piranhacms/piranha.core
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.Models;
using Piranha;
using Piranha.AspNetCore.Services;
using Piranha.Models;

namespace MvcWeb.Controllers
{
    public class CmsController : Controller
    {
        private readonly IApi _api;
        private readonly IDb _db;
        private readonly IModelLoader _loader;

        public CmsController(IApi api, IDb db, IModelLoader loader)
        {
            _api = api;
            _db = db;
            _loader = loader;
        }

        [HttpGet]
        [Route("teaserpage")]
        public async Task<IActionResult> TeaserPage(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<Models.TeaserPage>(id, HttpContext.User, draft);

            if (startpage)
            {
                return View("startpage", model);
            }
            return View(model);
        }

        [HttpGet]
        [Route("intropage")]
        public async Task<IActionResult> IntroPage(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<IntroPage>(id, HttpContext.User, draft);

            return View(model);
        }

        [HttpGet]
        [Route("enterprisepage")]
        public async Task<IActionResult> EnterprisePage(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<EnterprisePage>(id, HttpContext.User, draft);

            return View(model);
        }

        [HttpGet]
        [Route("helppage")]
        public async Task<IActionResult> HelpPage(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<HelpPage>(id, HttpContext.User, draft);

            return View(model);
        }

        [HttpGet]
        [Route("documentpage")]
        public async Task<IActionResult> DocumentPage(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<DocumentPage>(id, HttpContext.User, draft);

            return View(model);
        }

        [HttpGet]
        [Route("bondspage")]
        public async Task<IActionResult> BondsPage(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<BondsPage>(id, HttpContext.User, draft);
            return View(model);
        }

        [HttpGet]
        [Route("newspage")]
        public async Task<IActionResult> NewsPage(Guid id, int? year = null, int? month = null, int? page = null,
            Guid? category = null, Guid? tag = null)
        {
            var model = await _api.Pages.GetByIdAsync<NewsPage>(id);
            model.Archive = await _api.Archives.GetByIdAsync(id, page, category, tag, year, month, 6);

            return View(model);
        }

        [Route("post")]
        public async Task<IActionResult> Post(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPostAsync<NewsPost>(id, HttpContext.User, draft);
            ViewBag.Host = $"{this.Request.Scheme}://{this.Request.Host}{this.Request.PathBase}";
            //get next post, previous post
            var BlogId = model.BlogId;
            var pageItem = await _loader.GetPageAsync<NewsPage>(BlogId, HttpContext.User, draft);
            for (int i = 0; i < pageItem.Archive.Posts.Count; i++)
            {
                var post = pageItem.Archive.Posts[i].Id;
                if (post == id)
                {
                    if (i - 1 >= 0)
                    {
                        ViewBag.Prev = pageItem.Archive.Posts[i - 1].Permalink;

                        if (i + 1 < pageItem.Archive.Posts.Count)
                            ViewBag.Next = pageItem.Archive.Posts[i + 1].Permalink;
                    }
                    else
                    {
                        if (i + 1 < pageItem.Archive.Posts.Count)
                            ViewBag.Next = pageItem.Archive.Posts[i + 1].Permalink;
                    }
                }
            }// end next, previous post

            //Get list MuchRead
            ViewBag.lstMuchRead = pageItem.ReadALot;
            return View(model);
        }

        [Route("searchpage/{keyword?}")]
        public async Task<IActionResult> SearchPage(Guid id, string keyword, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<SearchPage>(id, HttpContext.User, draft);
            var listPost = _db.Posts.Where(x => x.Title.Contains(keyword)).ToList();
            var newsPosts = new List<NewsPost>();
            foreach (var item in listPost)
            {
                var itemPosts = await _loader.GetPostAsync<NewsPost>(item.Id, HttpContext.User, draft);
                newsPosts.Add(itemPosts);
            }
            ViewBag.lstPosts = newsPosts;

            return View(model);
        }

        [HttpGet]
        [Route("pagenotfound")]
        public async Task<IActionResult> PageNotFound(Guid id, bool startpage = false, bool draft = false)
        {
            var model = await _loader.GetPageAsync<PageNotFound>(id, HttpContext.User, draft);

            return View(model);
        }
    }
}
