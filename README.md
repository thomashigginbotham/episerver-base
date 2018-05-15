# Episerver Base

**This is a sample README file and should be modified with your own project details.**

Episerver Base aims to provide a clean starting point without having to pull in a lot of additional code from the Alloy template just to get things up and running. It includes features not available in an empty Episerver project that are common to most websites (e.g. support for page titles and meta keywords and descriptions).

## Getting Started

These instructions will help you set up this Episerver project on your system.

### Prerequisites

The following software is required.

* [Microsoft Visual Studio](http://www.visualstudio.com/)
* [Episerver Visual Studio extensions](https://visualstudiogallery.msdn.microsoft.com/4ad95160-e72f-4355-b53e-0994d2958d3e)
* [Episerver NuGet feed](https://world.episerver.com/documentation/Items/Installation-Instructions/Installing-Episerver-updates/)

To install the Episerver extensions from within Visual Studio:

1. Select **Tools** > **Extensions and Updates**.
1. Select **Online** in the left pane, and enter "episerver" into the search box on the right.
1. Select the **Episerver CMS Visual Studio Extension** and install it.

To add the Episerver NuGet feed to Visual Studio:

1. Select **Tools** > **NuGet Package Manager** > **Package Manager Settings**.
1. In the left pane, select **NuGet Package Manager** > **Package Sources**.
1. Click the green plus icon to add a new source.
1. Change its name to Episerver and set the source to *http://nuget.episerver.com/feed/packages.svc/*.
1. Click the **Update** button.
1. Click **OK**.

### Installing

Clone the repository to an empty folder on your system if you have not already done so, and open the solution (.sln) file in Visual Studio.

To create the database, copy the *EPiServer.Cms.mdf* file from *packages/EPiServer.CMS.11.7.0/tools* to the *EpiserverBase/App_Data* folder. Then, open the package manager console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console) and run the following command: `Initialize-EPiDatabase`

Alternatively, you can create your own database and run the SQL scripts found at *packages/EPiServer.CMS.Core.11.7.0/tools/EPiServer.Cms.Core.sql*. You will need to update the *EpiserverBase/connections.config* file afterward if you choose this method.

Confirm the site works by starting the debugger. After a few seconds, a 404 error should be displayed. This is because a start page has not been created.

### First Steps

Add */episerver* to the end of the URL and verify that you can log in using your Windows account credentials.

You will want to create a Start page from Edit mode. Then switch to Admin mode and configure the website (Admin > Config > Manage Websites). The following settings may be helpful:

**Name**: {Your website's name}

**URL**: {Use the URL in the address bar} (e.g. http://localhost:64473)

**Host Name**: {Grab from the URL} (e.g. localhost:64473)

**Culture**: en

**Type**: Primary

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Thomas Higginbotham** - *Initial work* - [Experis](https://experisspark.com/author/thigginbotham/)
