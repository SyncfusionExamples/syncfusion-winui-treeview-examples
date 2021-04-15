#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Populating_Nodes_with_Bound_mode_UWP
{
    /// <summary>
    /// Reprsents the class <see cref="Folder"/> that contains the data for <see cref="Syncfusion.UI.Xaml.TreeView.TreeViewItem"/>. 
    /// </summary>
    public class Folder : NotificationObject
    {
        #region Fields
        /// <summary>
        /// Maintains the string value for fileName.
        /// </summary>
        private string fileName;

        /// <summary>
        /// Holds the icon template for the TreeViewItem.
        /// </summary>
        private DataTemplate imageTemplate;

        /// <summary>
        /// Represents the ObservableCollection with File.
        /// </summary>
        private ObservableCollection<Folder> files;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Folder"/> class.
        /// </summary>
        public Folder()
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the collection for Files.
        /// </summary>
        public ObservableCollection<Folder> Files
        {
            get { return files; }
            internal set
            {
                files = value;
                RaisePropertyChanged(nameof(Files));
            }
        }

        /// <summary>
        /// Gets or sets the value for File Name.
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisePropertyChanged(nameof(FileName));
            }
        }

        /// <summary>
        /// Gets or sets the icon template for the TreeViewItem.
        /// </summary>
        public DataTemplate ImageTemplate
        {
            get { return imageTemplate; }
            set { imageTemplate = value; }
        }

        #endregion
    }
}
