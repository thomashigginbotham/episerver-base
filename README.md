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

Confirm the site works by starting the debugger. It should open a new browser window with a short message about Visual Studio debugging. After a few seconds, the home page (or a 404 error) should be displayed.

Add */episerver* to the end of the URL and verify that you can log in using your Windows account credentials.

Note that when you stop debugging or close the browser window, the site will not be accessible anymore. To keep the site running while not debugging, press `ctrl+F5` in Visual Studio.

## Versioning

We use [SemVer](http://semver.org/) for versioning. For the versions available, see the [tags on this repository](https://github.com/your/project/tags). 

## Authors

* **Thomas Higginbotham** - *Initial work* - [Experis](http://experisspark.com/)
