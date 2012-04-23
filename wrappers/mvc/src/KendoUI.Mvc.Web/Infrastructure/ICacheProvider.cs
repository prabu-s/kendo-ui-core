// (c) Copyright 2002-2009 Telerik 
// This source is subject to the GNU General Public License, version 2
// See http://www.gnu.org/licenses/gpl-2.0.html. 
// All other rights reserved.

namespace KendoUI.Mvc.Infrastructure
{
    using System.Web.Caching;
    
    public interface ICacheProvider
    {
        object Get(string key);
        void Insert(string key, object value);
        void Insert(string key, object value, CacheItemRemovedCallback cacheItemRemovedCallback, params string[] fileDependencies);
    }
}
