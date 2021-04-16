#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.TreeView;
using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Bring_into_View_UWP
{
    /// <summary>
    /// Represents the < see cref="ViewModel"/ > class that contains the collection of items used to populate the <see cref="Syncfusion.UI.Xaml.TreeView"/>.
    /// </summary>
    public class ViewModel : NotificationObject
    {
        #region Fields
        /// <summary>
        /// Represents the the <see cref="DelegateCommand"/> which will be executed when tap on the button. 
        /// </summary>
        private DelegateCommand bringIntoViewCommand;
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the <see cref="DelegateCommand"/> which will be executed when tap on the button. 
        /// </summary>
        public DelegateCommand BringIntoViewCommand
        {
            get { return bringIntoViewCommand; }
            set { bringIntoViewCommand = value; }
        }

        /// <summary>
        /// Gets or Sets the collection for CheckedItems.
        /// </summary>
        public ObservableCollection<object> CheckedItems { get; internal set; }

        /// <summary>
        /// Gets or Sets the collection for Items.
        /// </summary>
        public ObservableCollection<Model> Items { get; internal set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public ViewModel()
        {
            Items = new ObservableCollection<Model>();
            BringIntoViewCommand = new DelegateCommand(OnBringIntoViewClicked);
            var country1 = new Model { State = "Australia" };
            var country2 = new Model { State = "Brazil" };
            var country3 = new Model { State = "China" };
            var country4 = new Model { State = "France" };
            var country5 = new Model { State = "India" };
            var country6 = new Model { State = "USA" };
            var country7 = new Model { State = "UK" };
            var country8 = new Model { State = "Russia" };
            var country9 = new Model { State = "Canada" };
            var country10 = new Model { State = "Germany" };

            var aus_state1 = new Model { State = "New South Wales" };
            var aus_state2 = new Model { State = "Victoria" };
            var aus_state3 = new Model { State = "South Australia" };
            var aus_state4 = new Model { State = "Western Australia" };

            var brazil_state1 = new Model { State = "Parana" };
            var brazil_state2 = new Model { State = "Ceara" };
            var brazil_state3 = new Model { State = "Acre" };

            var china_state1 = new Model { State = "Guangzhou" };
            var china_state2 = new Model { State = "Shanghai" };
            var china_state3 = new Model { State = "Beijing" };
            var china_state4 = new Model { State = "Shantou" };

            var france_state1 = new Model { State = "Pays de la Loire" };
            var france_state2 = new Model { State = "Aquitaine" };
            var france_state3 = new Model { State = "Brittany" };
            var france_state4 = new Model { State = "Lorraine" };

            var ind_State1 = new Model { State = "Assam" };
            var ind_State2 = new Model { State = "Bihar" };
            var ind_State3 = new Model { State = "Tamil Nadu" };
            var ind_State4 = new Model { State = "Punjab" };

            var usa_state1 = new Model { State = "New York" };
            var usa_state2 = new Model { State = "California" };
            var usa_state3 = new Model { State = "Texas" };
            var usa_state4 = new Model { State = "Washington" };
            var usa_state5 = new Model { State = "Florida" };

            var uk_state1 = new Model { State = "England" };
            var uk_state2 = new Model { State = "Wales" };
            var uk_state3 = new Model { State = "Scotland" };
            var uk_state4 = new Model { State = "Northern Ireland" };

            var russia_state1 = new Model { State = "Mordovia" };
            var russia_state2 = new Model { State = "Chechnya" };
            var russia_state3 = new Model { State = "Tatarstan" };
            var russia_state4 = new Model { State = "Dagestan" };

            var canada_state1 = new Model { State = "Alberta" };
            var canada_state2 = new Model { State = "Manitoba" };
            var canada_state3 = new Model { State = "New Brunswick" };
            var canada_state4 = new Model { State = "Quebec" };

            var germany_state1 = new Model { State = "Berlin" };
            var germany_state2 = new Model { State = "Hamburg" };
            var germany_state3 = new Model { State = "Bremen" };
            var germany_state4 = new Model { State = "Lower Saxony" };

            country1.Models.Add(aus_state1);
            country1.Models.Add(aus_state2);
            country1.Models.Add(aus_state3);
            country1.Models.Add(aus_state4);

            country2.Models.Add(brazil_state1);
            country2.Models.Add(brazil_state2);
            country2.Models.Add(brazil_state3);

            country3.Models.Add(china_state1);
            country3.Models.Add(china_state2);
            country3.Models.Add(china_state3);
            country3.Models.Add(china_state4);

            country4.Models.Add(france_state1);
            country4.Models.Add(france_state2);
            country4.Models.Add(france_state3);
            country4.Models.Add(france_state4);

            country5.Models.Add(ind_State1);
            country5.Models.Add(ind_State2);
            country5.Models.Add(ind_State3);
            country5.Models.Add(ind_State4);

            country6.Models.Add(usa_state1);
            country6.Models.Add(usa_state2);
            country6.Models.Add(usa_state3);
            country6.Models.Add(usa_state4);
            country6.Models.Add(usa_state5);

            country7.Models.Add(uk_state1);
            country7.Models.Add(uk_state2);
            country7.Models.Add(uk_state3);
            country7.Models.Add(uk_state4);

            country8.Models.Add(russia_state1);
            country8.Models.Add(russia_state2);
            country8.Models.Add(russia_state3);
            country8.Models.Add(russia_state4);

            country9.Models.Add(canada_state1);
            country9.Models.Add(canada_state2);
            country9.Models.Add(canada_state3);
            country9.Models.Add(canada_state4);

            country10.Models.Add(germany_state1);
            country10.Models.Add(germany_state2);
            country10.Models.Add(germany_state3);
            country10.Models.Add(germany_state4);

            Items.Add(country1);
            Items.Add(country2);
            Items.Add(country3);
            Items.Add(country4);
            Items.Add(country5);
            Items.Add(country6);
            Items.Add(country7);
            Items.Add(country8);
            Items.Add(country9);
            Items.Add(country10);

            CheckedItems = new ObservableCollection<object>();
            CheckedItems.Add(aus_state3);
            CheckedItems.Add(aus_state4);
            CheckedItems.Add(brazil_state2);
            CheckedItems.Add(brazil_state3);
            CheckedItems.Add(china_state3);
        }

        private void OnBringIntoViewClicked(object obj)
        {
            var sfTreeView = obj as SfTreeView;
            var count = this.Items.Count;
            var data = this.Items[count - 1];
            // Scrolls to the data item to make visible in the view.
            sfTreeView.BringIntoView(data, true, true, ScrollToPosition.MakeVisible);
        }
        #endregion
    }
}
