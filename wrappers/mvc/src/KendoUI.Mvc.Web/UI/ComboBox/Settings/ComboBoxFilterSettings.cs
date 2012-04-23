﻿// (c) Copyright 2002-2010 Telerik 
// This source is subject to the GNU General Public License, version 2
// See http://www.gnu.org/licenses/gpl-2.0.html. 
// All other rights reserved.

namespace KendoUI.Mvc.UI
{
    public class ComboBoxFilterSettings
    {
        public ComboBoxFilterSettings()
        {
            MinimumChars = 0;
        }

        public bool Enabled
        {
            get;
            set;
        }

        public AutoCompleteFilterMode FilterMode
        {
            get;
            set;
        }

        public int MinimumChars
        {
            get;
            set;
        }
    }
}
