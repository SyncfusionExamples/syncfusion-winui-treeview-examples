#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml.Media.Imaging;
using Syncfusion.UI.Xaml.Core;
using Syncfusion.UI.Xaml.TreeView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_with_Selection_Desktop
{
    /// <summary>
    /// Represents the < see cref="GettingStartedViewModel"/ > class that contains the collection of items used to populate the <see cref="Syncfusion.UI.Xaml.TreeView"/>.
    /// </summary>
    public class SelectionViewModel : NotificationObject
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="DranAndDropViewModel"/> class.
        /// </summary>
        public SelectionViewModel()
        {
            Collections = new ObservableCollection<SelectionModel>();
            PopulateCollections();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the collections for items.
        /// </summary>
        public ObservableCollection<SelectionModel> Collections { get; internal set; }

        /// <summary>
        /// Gets or sets the collection for Selected Nodes.
        /// </summary>
        public ObservableCollection<object> SelectedNodes { get; internal set; }
        #endregion

        #region Methods
        /// <summary>
        /// populate the items in collection.
        /// </summary>
        void PopulateCollections()
        {
            var RootNode1 = new SelectionModel { Header = "Work Documents"};
            var RootNode2 = new SelectionModel { Header = "Personal Folder"};

            var ChildNode1 = new SelectionModel { Header = "Functional Specifications"};
            var ChildNode2 = new SelectionModel { Header = "TreeView spec"};
            var ChildNode3 = new SelectionModel { Header = "Feature Schedule"};
            var ChildNode4 = new SelectionModel { Header = "Overall Project Plan"};
            var ChildNode5 = new SelectionModel { Header = "Feature Resource Allocation"};
            var ChildNode6 = new SelectionModel { Header = "Home Remodel Folder"};
            var ChildNode7 = new SelectionModel { Header = "Contractor Contact Info"};
            var ChildNode8 = new SelectionModel { Header = "Paint Color Scheme"};
            var ChildNode9 = new SelectionModel { Header = "Flooring Woodgrain type"};
            var ChildNode10 = new SelectionModel { Header = "Kitchen Cabinet Style"};

            var ChildNode11 = new SelectionModel { Header = "My Network Places"};
            var ChildNode12 = new SelectionModel { Header = "Server"};
            var ChildNode13 = new SelectionModel { Header = "My Folders"};

            var ChildNode14 = new SelectionModel { Header = "My Computer" };
            var ChildNode15 = new SelectionModel { Header = "Music"};
            var ChildNode16 = new SelectionModel { Header = "Videos"};
            var ChildNode17 = new SelectionModel { Header = "Wallpaper.png"};
            var ChildNode18 = new SelectionModel { Header = "My Banner.png"};

            

            var ChildNode19 = new SelectionModel { Header = "Favourites"};
            var ChildNode20 = new SelectionModel { Header = "Image3.png"};
            var ChildNode21 = new SelectionModel { Header = "Image4.png"};
            var ChildNode22 = new SelectionModel { Header = "Image5.png"};

            var ChildNode23 = new SelectionModel { Header = "Image1.png"};
            var ChildNode24 = new SelectionModel { Header = "Image2.png"};

            RootNode1.Childs.Add(ChildNode1);
            RootNode1.Childs.Add(ChildNode3);
            RootNode1.Childs.Add(ChildNode4);
            RootNode1.Childs.Add(ChildNode5);
            RootNode2.Childs.Add(ChildNode6);

            RootNode2.Childs.Add(ChildNode11);
            RootNode2.Childs.Add(ChildNode14);
            RootNode2.Childs.Add(ChildNode19);

            ChildNode1.Childs.Add(ChildNode2);
            ChildNode6.Childs.Add(ChildNode7);
            ChildNode6.Childs.Add(ChildNode8);
            ChildNode6.Childs.Add(ChildNode9);
            ChildNode6.Childs.Add(ChildNode10);
            ChildNode11.Childs.Add(ChildNode12);
            ChildNode11.Childs.Add(ChildNode13);
            
            ChildNode11.Childs.Add(ChildNode23);
            ChildNode11.Childs.Add(ChildNode24);

            ChildNode14.Childs.Add(ChildNode15);
            ChildNode14.Childs.Add(ChildNode16);
            ChildNode14.Childs.Add(ChildNode17);
            ChildNode14.Childs.Add(ChildNode18);

            ChildNode19.Childs.Add(ChildNode20);
            ChildNode19.Childs.Add(ChildNode21);
            ChildNode19.Childs.Add(ChildNode22);

            SelectedNodes = new ObservableCollection<object>();
            SelectedNodes.Add(ChildNode1);
            SelectedNodes.Add(ChildNode4);
            SelectedNodes.Add(ChildNode8);
            Collections.Add(RootNode1);
            Collections.Add(RootNode2);
        }
        #endregion
    }
}
