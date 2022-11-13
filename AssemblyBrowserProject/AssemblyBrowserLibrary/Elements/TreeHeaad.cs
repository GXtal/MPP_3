﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyBrowserLibrary.Elements
{
    public class TreeHeaad:Element
    {
        public TreeHeaad()
        {
            Childs = new List<Element>();
            Name = "nyanyanaynaynaynay";
        }
        public TreeHeaad(bool a)
        {
            Childs = new List<Element>();
            Name = "nyanyanaynaynaynay";
            Childs.Add(new NameSpaceElement("uhuhu",true));
            Childs.Add(new NameSpaceElement("uhusaudhau", true));
        }

        public virtual string Info
        {
            get { return "treehead"; }
        }
    }
}
