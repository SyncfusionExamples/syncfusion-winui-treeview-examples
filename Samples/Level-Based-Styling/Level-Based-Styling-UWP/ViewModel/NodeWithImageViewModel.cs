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

namespace Level_Based_Styling_UWP
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
            this.Folders = GetFiles();
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or sets the collections for Folders.
        /// </summary>
        public ObservableCollection<Folder> Folders { get; internal set; }

        #endregion

        #region Methods
        /// <summary>
        /// Set the collections for Folders
        /// </summary>
        /// <returns>Returns the collection.</returns>
        private ObservableCollection<Folder> GetFiles()
        {
            var nodeImageInfo = new ObservableCollection<Folder>();

            var doc = new Folder() { FileName = "Documents" };
            var download = new Folder() { FileName = "Downloads" };
            var mp3 = new Folder() { FileName = "Music"};
            var pictures = new Folder() { FileName = "Pictures"};
            var video = new Folder() { FileName = "Videos"};

            var pollution = new Folder() { FileName = "Environmental Pollution.docx"};
            var globalWarming = new Folder() { FileName = "Global Warming.ppt"};
            var sanitation = new Folder() { FileName = "Sanitation.docx"};
            var socialNetwork = new Folder() { FileName = "Social Network.pdf"};
            var youthEmpower = new Folder() { FileName = "Youth Empowerment.pdf"};

            var games = new Folder() { FileName = "Game.exe"};
            var tutorials = new Folder() { FileName = "Tutorials.zip"};
            var typeScript = new Folder() { FileName = "TypeScript.7z"};
            var uiGuide = new Folder() { FileName = "UI-Guide.pdf"};

            var song = new Folder() { FileName = "Gouttes"};

            var camera = new Folder() { FileName = "Camera Roll"};
            var stone = new Folder() { FileName = "Stone.jpg"};
            var wind = new Folder() { FileName = "Wind.jpg"};

            var img0 = new Folder() { FileName = "WIN_20160726_094117.JPG"};
            var img1 = new Folder() { FileName = "WIN_20160726_094118.JPG"};

            var video1 = new Folder() { FileName = "Natural World.mp4"};
            var video2 = new Folder() { FileName = "Wildlife.mpeg"};

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
