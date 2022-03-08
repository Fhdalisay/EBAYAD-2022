using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Web.Mvc;

namespace ebayad.Models
{
    public class customModel
    {
    }
    public partial class user_table
    {
        public string LoginErrorMessage { get; set; }
    }
}