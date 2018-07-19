using BsWebpub.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BsWebpub
{
    public interface iRes_pub_fact
    {
        IEnumerable<pub_fact> GetPub_Facts();
    }
}
