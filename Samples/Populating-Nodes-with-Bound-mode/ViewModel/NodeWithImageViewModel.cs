#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Imaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Populating_Nodes_with_Bound_mode
{
    /// <summary>
    /// Represents the < see cref="NodeWithImageViewModel"/ > class that contains the collection of items used to populate the <see cref="Syncfusion.UI.Xaml.TreeView"/>.
    /// </summary>
    public class NodeWithImageViewModel
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeWithImageViewModel"/> class.
        /// </summary>
        public NodeWithImageViewModel()
        {
            CommonResourceDictionary = new ResourceDictionary() { Source = new Uri("ms-appx:///Icons/PathIcon.xaml", UriKind.RelativeOrAbsolute) };
            this.Folders = GetFiles();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the collections for Folders.
        /// </summary>
        public ObservableCollection<Folder> Folders { get; internal set; }

        /// <summary>
        /// Holds the required resouces for IconTemplate.
        /// </summary>
        private ResourceDictionary CommonResourceDictionary { get; set; }

        #endregion

        #region Methods
        /// <summary>
        /// Set the collections for Folders
        /// </summary>
        /// <returns>Returns the collection.</returns>\
        private ObservableCollection<Folder> GetFiles()
        {
            var nodeImageInfo = new ObservableCollection<Folder>();

            var doc = new Folder() { FileName = "Documents", ImageTemplate = CommonResourceDictionary["Folder"] as DataTemplate };
            var download = new Folder() { FileName = "Downloads", ImageTemplate = CommonResourceDictionary["Folder"] as DataTemplate };
            var mp3 = new Folder() { FileName = "Music", ImageTemplate = CommonResourceDictionary["Folder"] as DataTemplate };
            var pictures = new Folder() { FileName = "Pictures", ImageTemplate = CommonResourceDictionary["Folder"] as DataTemplate };
            var video = new Folder() { FileName = "Videos", ImageTemplate = CommonResourceDictionary["Folder"] as DataTemplate };

            var pollution = new Folder() { FileName = "Environmental Pollution.docx", ImageTemplate = CommonResourceDictionary["Word"] as DataTemplate };
            var globalWarming = new Folder() { FileName = "Global Warming.ppt", ImageTemplate = CommonResourceDictionary["PowerPoint"] as DataTemplate };
            var sanitation = new Folder() { FileName = "Sanitation.docx", ImageTemplate = CommonResourceDictionary["Word"] as DataTemplate };
            var socialNetwork = new Folder() { FileName = "Social Network.pdf", ImageTemplate = CommonResourceDictionary["Pdf"] as DataTemplate };
            var youthEmpower = new Folder() { FileName = "Youth Empowerment.pdf", ImageTemplate = CommonResourceDictionary["Pdf"] as DataTemplate };

            var games = new Folder() { FileName = "Game.exe", ImageTemplate = CommonResourceDictionary["EXE"] as DataTemplate };
            var tutorials = new Folder() { FileName = "Tutorials.zip", ImageTemplate = CommonResourceDictionary["Zip"] as DataTemplate };
            var typeScript = new Folder() { FileName = "TypeScript.7z", ImageTemplate = CommonResourceDictionary["Zip"] as DataTemplate };
            var uiGuide = new Folder() { FileName = "UI-Guide.pdf", ImageTemplate = CommonResourceDictionary["Pdf"] as DataTemplate };

            var song = new Folder() { FileName = "Gouttes", ImageTemplate = CommonResourceDictionary["Audio"] as DataTemplate };

            var camera = new Folder() { FileName = "Camera Roll", ImageTemplate = CommonResourceDictionary["Folder"] as DataTemplate };
            var stone = new Folder() { FileName = "Stone.jpg", ImageTemplate = CommonResourceDictionary["Png"] as DataTemplate };
            var wind = new Folder() { FileName = "Wind.jpg", ImageTemplate = CommonResourceDictionary["Png"] as DataTemplate };

            var img0 = new Folder() { FileName = "WIN_20160726_094117.JPG", ImageTemplate = CommonResourceDictionary["Png"] as DataTemplate };
            var img1 = new Folder() { FileName = "WIN_20160726_094118.JPG", ImageTemplate = CommonResourceDictionary["Png"] as DataTemplate };

            var video1 = new Folder() { FileName = "Natural World.mp4", ImageTemplate = CommonResourceDictionary["Video"] as DataTemplate };
            var video2 = new Folder() { FileName = "Wildlife.mpeg", ImageTemplate = CommonResourceDictionary["Video"] as DataTemplate };

            doc.Files = new ObservableCollection<Folder>
            {
                pollution,
                globalWarming,
                sanitation,
                socialNetwork,
                youthEmpower
            };

            download.Files = new ObservableCollection<Folder>
            {
                games,
                tutorials,
                typeScript,
                uiGuide
            };

            mp3.Files = new ObservableCollection<Folder>
            {
                song
            };

            pictures.Files = new ObservableCollection<Folder>
            {
                camera,
                stone,
                wind
            };
            camera.Files = new ObservableCollection<Folder>
            {
                img0,
                img1
            };

            video.Files = new ObservableCollection<Folder>
            {
                video1,
                video2
            };

            nodeImageInfo.Add(doc);
            nodeImageInfo.Add(download);
            nodeImageInfo.Add(mp3);
            nodeImageInfo.Add(pictures);
            nodeImageInfo.Add(video);

            return nodeImageInfo;
        }
        #endregion
    }
}
