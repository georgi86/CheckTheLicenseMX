﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace CheckLicense
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the CheckLicenseRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    [RepositoryFolder("03e70104-3417-4012-847c-93e93bb03329")]
    public partial class CheckLicenseRepository : RepoGenBaseFolder
    {
        static CheckLicenseRepository instance = new CheckLicenseRepository();
        CheckLicenseRepositoryFolders.MeasureXUntitledAppFolder _measurexuntitled;
        CheckLicenseRepositoryFolders.AboutMeasureXAppFolder _aboutmeasurex;

        /// <summary>
        /// Gets the singleton class instance representing the CheckLicenseRepository element repository.
        /// </summary>
        [RepositoryFolder("03e70104-3417-4012-847c-93e93bb03329")]
        public static CheckLicenseRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public CheckLicenseRepository() 
            : base("CheckLicenseRepository", "/", null, 0, false, "03e70104-3417-4012-847c-93e93bb03329", ".\\RepositoryImages\\CheckLicenseRepository03e70104.rximgres")
        {
            _measurexuntitled = new CheckLicenseRepositoryFolders.MeasureXUntitledAppFolder(this);
            _aboutmeasurex = new CheckLicenseRepositoryFolders.AboutMeasureXAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("03e70104-3417-4012-847c-93e93bb03329")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The MeasureXUntitled folder.
        /// </summary>
        [RepositoryFolder("db90b56b-bf45-4141-a2ff-d902a68d8d56")]
        public virtual CheckLicenseRepositoryFolders.MeasureXUntitledAppFolder MeasureXUntitled
        {
            get { return _measurexuntitled; }
        }

        /// <summary>
        /// The AboutMeasureX folder.
        /// </summary>
        [RepositoryFolder("07f7d290-5dd2-4b20-89a5-a26f422dad06")]
        public virtual CheckLicenseRepositoryFolders.AboutMeasureXAppFolder AboutMeasureX
        {
            get { return _aboutmeasurex; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
    public partial class CheckLicenseRepositoryFolders
    {
        /// <summary>
        /// The MeasureXUntitledAppFolder folder.
        /// </summary>
        [RepositoryFolder("db90b56b-bf45-4141-a2ff-d902a68d8d56")]
        public partial class MeasureXUntitledAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _measurexuntitledInfo;

            /// <summary>
            /// Creates a new MeasureXUntitled  folder.
            /// </summary>
            public MeasureXUntitledAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MeasureXUntitled", "/form[@title='Measure-X - [Untitled]']", parentFolder, 30000, null, true, "db90b56b-bf45-4141-a2ff-d902a68d8d56", "")
            {
                _measurexuntitledInfo = new RepoItemInfo(this, "MeasureXUntitled", "titlebar[@accessiblerole='TitleBar']", 60000, null, "e9562f9a-aed6-4ff9-b32a-f47be9166421");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("db90b56b-bf45-4141-a2ff-d902a68d8d56")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("db90b56b-bf45-4141-a2ff-d902a68d8d56")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MeasureXUntitled item.
            /// </summary>
            [RepositoryItem("e9562f9a-aed6-4ff9-b32a-f47be9166421")]
            public virtual Ranorex.TitleBar MeasureXUntitled
            {
                get
                {
                    return _measurexuntitledInfo.CreateAdapter<Ranorex.TitleBar>(true);
                }
            }

            /// <summary>
            /// The MeasureXUntitled item info.
            /// </summary>
            [RepositoryItemInfo("e9562f9a-aed6-4ff9-b32a-f47be9166421")]
            public virtual RepoItemInfo MeasureXUntitledInfo
            {
                get
                {
                    return _measurexuntitledInfo;
                }
            }
        }

        /// <summary>
        /// The AboutMeasureXAppFolder folder.
        /// </summary>
        [RepositoryFolder("07f7d290-5dd2-4b20-89a5-a26f422dad06")]
        public partial class AboutMeasureXAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _helpaboutInfo;

            /// <summary>
            /// Creates a new AboutMeasureX  folder.
            /// </summary>
            public AboutMeasureXAppFolder(RepoGenBaseFolder parentFolder) :
                    base("AboutMeasureX", "/form[@title='About Measure-X']", parentFolder, 30000, null, true, "07f7d290-5dd2-4b20-89a5-a26f422dad06", "")
            {
                _helpaboutInfo = new RepoItemInfo(this, "HelpAbout", "text[@controlid='1928']", 30000, null, "696e9997-cc81-4d26-b330-7d0e18acd08f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("07f7d290-5dd2-4b20-89a5-a26f422dad06")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("07f7d290-5dd2-4b20-89a5-a26f422dad06")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HelpAbout item.
            /// </summary>
            [RepositoryItem("696e9997-cc81-4d26-b330-7d0e18acd08f")]
            public virtual Ranorex.Text HelpAbout
            {
                get
                {
                    return _helpaboutInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The HelpAbout item info.
            /// </summary>
            [RepositoryItemInfo("696e9997-cc81-4d26-b330-7d0e18acd08f")]
            public virtual RepoItemInfo HelpAboutInfo
            {
                get
                {
                    return _helpaboutInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}