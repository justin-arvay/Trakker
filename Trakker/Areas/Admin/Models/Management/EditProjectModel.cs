﻿namespace Trakker.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;
    using Trakker.Properties;
    using System.ComponentModel;
    using Trakker.Data;
    using Trakker.Models;
    using Trakker.Core;

    public class EditProjectModel : MasterModel
    {
        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [StringLength(100, ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "StringLength_100")]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        [StringLength(100, ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "StringLength_100")]
        [Uri(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "InvalidUri")]
        public string Url { get; set; }

        [DisplayName("Due Date")]
        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        public DateTime? Due { get; set; }

        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        public int Lead { get; set; }

        [DisplayName("Color Palette")]
        [Required(ErrorMessageResourceType = typeof(Validation), ErrorMessageResourceName = "Required")]
        public int ColorPaletteId { get; set; }

        public IList<User> Users { get; set; }
        public IList<ColorPalette> ColorPalettes { get; set; }

    }
}