﻿using StoreDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BackMeow.Controllers
{
    public class ZipCodeController : Controller
    {
        private readonly ZipCodeService _ZipCodeService;

        public ZipCodeController()
        {
            var unitOfWork = new EFUnitOfWork();
            _ZipCodeService = new ZipCodeService(unitOfWork);
        }

        /// <summary>
        /// Gets the city drop downlist.
        /// </summary>
        /// <param name="selectedCity">The selected city.</param>
        /// <returns></returns>
        public ActionResult GetCityDropDownlist(string selectedCity)
        {
            StringBuilder sb = new StringBuilder();

            var cities = _ZipCodeService.GetAllCityDictinoary();

            if (string.IsNullOrWhiteSpace(selectedCity))
            {
                foreach (var item in cities)
                {
                    sb.AppendFormat("<option value=\"{0}\">{1}</option>", item.Key, item.Value);
                }
            }
            else
            {
                foreach (var item in cities)
                {
                    sb.AppendFormat("<option value=\"{0}\" {2}>{1}</option>",
                        item.Key,
                        item.Value,
                        item.Key.Equals(selectedCity) ? "selected=\"selected\"" : "");
                }
            }
            return Content(sb.ToString());
        }

        /// <summary>
        /// Gets the county drop downlist.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        /// <param name="selectedCounty">The selected county.</param>
        /// <returns></returns>
        public ActionResult GetCountyDropDownlist(string cityName, string selectedCounty)
        {
            if (!string.IsNullOrWhiteSpace(cityName))
            {
                StringBuilder sb = new StringBuilder();

                var counties = _ZipCodeService.GetCountyByCityName(cityName);

                if (string.IsNullOrWhiteSpace(selectedCounty))
                {
                    foreach (var item in counties)
                    {
                        sb.AppendFormat("<option value=\"{0}\">{1}</option>",
                            item.Key,
                            string.Concat(item.Key, " ", item.Value)
                        );
                    }
                }
                else
                {
                    foreach (var item in counties)
                    {
                        sb.AppendFormat("<option value=\"{0}\" {2}>{1}</option>",
                            item.Key,
                            string.Concat(item.Key, " ", item.Value),
                            item.Key.Equals(selectedCounty) ? "selected=\"selected\"" : "");
                    }
                }

                return Content(sb.ToString());
            }
            return Content(string.Empty);
        }
    }
}