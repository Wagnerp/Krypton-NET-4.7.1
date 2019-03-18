# <img src="https://github.com/Wagnerp/Krypton-NET-5.471/blob/master/Assets/PNG/Square%20Design/Main%20Icon/64%20x%2064/Square%20Design%2064%20x%2064%20New%20Green.png"> .NET 5.471

=======

# ["Toolkit help index"](https://rawgit.com/Wagnerp/Krypton-NET-4.7/master/Help/Output/index.html)

=======

## NOTE: With the advent of Windows 10 1803 being released to the general public, I am pleased to announce the availability of a 5.472 release that will support the .NET 4.7.2 framework. You can follow the project [here](https://github.com/Wagnerp/Krypton-NET-5.472).

=======

## 2019-03-18 Build 794
* Build 794 (build date Monday 18th March, 2019) is now available on NuGet

=======

## 2019-03-11 Build 791
* Fix for [#39](https://github.com/Wagnerp/Krypton-NET-5.470/issues/39)
* Fix for [#74](https://github.com/Wagnerp/Krypton-NET-5.470/issues/74)
* Fix for [#93](https://github.com/Wagnerp/Krypton-NET-5.470/issues/93)
* Fix for [#97](https://github.com/Wagnerp/Krypton-NET-5.470/issues/97)
* Now you are required to accept the license agreement when downloading new NuGet package versions
* Build 791 (build date Monday 11th March, 2019) is now available on NuGet

=======

## 2019-03-04 Build 770
* You can now use `Krypton Tooltips` on listboxes and treeviews [#90](https://github.com/Wagnerp/Krypton-NET-5.470/issues/90)
* You can now use `Krypton Tooltips` on every Krypton control [#85](https://github.com/Wagnerp/Krypton-NET-5.470/issues/85)
* `ThemeManager.cs` now makes it easier for developers to access the true theme names, without relying on nonsensical enumerations.
* Build 770 (build date Monday 4th March, 2019) is now available on NuGet

=======

## 2019-02-16 Build 720 - Fix for drop shadow while using the ribbon component
* Fix for [#56](https://github.com/Wagnerp/Krypton-NET-5.470/issues/56) courtesy of [richterAI](https://github.com/richterAl)
* Build 720 (build date Saturday 16th February, 2019) is now available on NuGet

=======

## 2019-01-29 **`AccurateText.cs`** - Issue #75
* Bugfix for [#75](https://github.com/Wagnerp/Krypton-NET-5.471/issues/75) courtesy of [nickfinch71](https://github.com/nickfinch71)
* For more information about this issue on NT 6.0 systems, please read thread [#75](https://github.com/Wagnerp/Krypton-NET-5.471/issues/75)
* NuGet package build 717 (build date Tuesday 29th January, 2019) will be made available

=======

## 2019-01-03 Year Change
* Changed `2018` to `2019` in code
* Code parity with version `5.471`

=======

## 2018-09-28 Version **`4`** now becomes version **`5`**
* Major version number changed from `4` to `5` after experimenting successfuly with NuGet packages
- Known bug if installing via NuGet, ToolBox images will not be displayed properly
* A new NuGet package can be obtained [here](https://www.nuget.org/packages/KryptonToolkitSuite5471/5.471.700) or by typing `KryptonToolkitSuite5471` in the package manager
* Build 700 (build date Saturday 29th September, 2018) is now available through the **releases** tab
* Repository name change to reflect version changes

=======

## 2018-09-25 Build 643
* Build 643 (build date Tuesday 25th September, 2018) is now available through the **releases** tab
* Allow the developer to override the `Ctrl+c to copy` text in the Caption
* The `Import()` and `Export()` methods will now use the native `KryptonMessageBox` instead of a system one
* Removed the phantom `KryptonPalette` component
* Now you can access the full `FilePath` of the loaded palette XML file
* New icon (not propagated through all the example applications yet)
* General bugfixes

=======

## 2018-07-16 Build 633
* Build 633 (released Monday 16th July, 2018) is now available through the **releases** tab
* Fix KryptonForm does not respect Minimum Size set in designer #57
  * And sort out some spelling mistakes in the `VisualForm.cs`
* `SeparatorController.cs` & `DragObject` bug fix, #79
  * Fix for bug Issue, #79, courtesy of [James Simms](https://github.com/jwsimms)

=======

## 2018-06-15 Palette Example Application
* Now you can export your custom palette creation in the `Krypton Palette Example` application.

=======

## 2018-06-11 Version 620
* Build 620 (build date Monday 11th June 2018) is now obtainable through the `releases` tab.
* Fixed references that blocked demo applications from launching.
* Start work on getting the system themes to display the extras. 
  * Not perfect but at least the "Chrome" displays the intended buttons and text(s).
* Removal of "not needed" casts.

=======

## 2018-05-25 Version 593
* Build 593 (build date Friday 25th May 2018) is now available through the `releases` tab.
* Remove the Designer dll (Project / code moved in Git)
* Place designers into actual dlls (Small size increase)
* Fix fallout from Designer dll removal from other projects
  * Fix build path output, and Demo Apps Ref path import and Output

=======

## 2018-05-01 Version 573
* Build 573 (build date Tuesday 1st May 2018) is now available through the `releases` tab. A installable version will be made available shortly, once testing has been completed.
* Fixed `4.70` references as noted by Smurf-IV in [#3](https://github.com/Wagnerp/Krypton-NET-4.71/issues/3)

=======

## 2018-04-29 Build 572
* Build 572 (build date Sunday 29th April 2018) is now obtainable through the `releases` tab.
* Remove hard-coded directory offsets for Component outputs
* Use offset location for components in Demo Apps 
* Remove Release GAC'ing
* Fix explorer for the copied target names
* DLL assembly names have been renamed to `Krypton Design`, `Krypton Docking`, `Krypton Navigator`, `Krypton Ribbon`, `Krypton Toolkit` and `Krypton Workspace`, these changes do also apply to other binaries in this repo. However these changes does **NOT** affect the namespace names of `ComponentFactory.Krypton.xx`.
* Build output paths have been changed for easier installer authouring and syncronisation.
* Renamed repo title to `Krypton-NET-4.71` to better reflect versioning.
* Removed different architectures folder for easier navigation.
* All binaries, applications, tools etc in this project will now be installed by one installer, powered by Advanced Installer. This is to allow easier distribution, and easier end-user updating.
* New folder `Updates` to contain files needed for the new update distribution.
* Don't forget to add the TextExtra into the title width calculation
* Only Display "Ctrl+C..." for Error and Exclamation icon's
* Change the projects to at least recognise C#7.2 features and enhancements - _to be applied in the future_
* Some tinkering with spelling corrections - _to be applied in the future_

=======

## 2018-03-26 Version 561
* Build 561 (build date Monday 26th March, 2018) is now available from the **releases** tab.
* Make the Help relevant to the Actual Code #17
* Change `bmp`'s to `png`'s
* Fix location of source for Help
* Change output to be clearer
* Remove previous output *leftovers*
* Add instructions on how to generate
* MessageBox taking a Null window owner (via default API's / null start / No KryptonManager loaded)
* Sort out the Toolkit examples to use the new dll locations
* Remove `BootstrapperPackage` .Net 3.5 nonsense from projects
* Remove hard coded build `Output Paths`
* The palette upgrade tool is now back! Enhancements over previous commercial version 4.4.0 include:
- Ability to export upgraded palette XML files
- Check to see if the output palette file is not saved before closing
* Exploration into a console version is in the works
* Changed some classes from `internal` to `public` for easier accessibility for the **Extended Toolkit**
* All AMD64/x64 solutions should now build into correct directories
* TODO: Rework Krypton Explorer (x64 and Any CPU) code to launch correct binaries
* Renamed everything labeled `2015` to `2018`
* Each solution now has its own binary folder
* Groundwork for supporting AMD64/x64, x86 and 'Any CPU' architectures

=======
## 2018-02-16 New Nuget package release
* Build 554 (build date 16th February, 2018) has been released.
* Palette designer has been included with this release and future releases.

=======

## 2018-01-25 KryptonTextBox.cs descriptions
* Added descriptions to 'OnTrackMouseEnter' and 'OnTrackMouseLeave' events to make more sense
* Added raw '.cab' and '.mshc' help files

=======

## 2018-01-24 Designer bug fix
* Fixed bug with ComponentFactory.Krypton.Design.dll to version 4.71.0.0 due to hard coded values in toolkit code. Thanks to Smurf-IV for pointing this out to me.
* New Nuget package, version 4.71.524, relating to the version of ComponentFactory.Krypton.Designer.dll (build date January 24th, 2018) will be uploaded to incorporate this fix.

=======

## 2018-01-21 Nuget package update
* Fixed Nuget package specification to show the true file assembly number, i.e 4.71.533.0 (build date January 21st, 2018) 
* All new releases of packages will no longer have a dedicated changelog. Instead, it will point users back to [this repository](https://github.com/Wagnerp/Krypton-NET-4.7.1) for more information.
* All new releases of packages will no longer ship with the '.chm' help file. This is to reduce file size from 70+ MB to 5 - 6 MB. If the help file is needed, then please refer to [this link](https://github.com/Wagnerp/Krypton-NET-4.7.1/raw/master/Help/KryptonHelp.chm) to download it.
* New versions of Nuget packages can be obtained via [this link](https://www.nuget.org/packages/KryptonToolkitSuite471/) or via your package manager with the following command 'Install-Package KryptonToolkitSuite471 -Version 4.71.xxx' (replace the x's with version number) or by searching KryptonToolkitSuite471 in your package manager.

=======

## 2018-01-15 Minor changes
* Renamed 'GetCreateParams()' method to 'DrawDropShadow()' in 'KryptonForm.cs' to avoid confusion
* Added/update documentation/comments for drop shadow methods in 'KryptonForm.cs' to make functions clearer

=======

## 2018-01-14 Toolkit Solution changes
* Convert to `'?:` expression
  * `null-coalescing` if applicable
  * Then to `Expression body` if simplified enough
* Fix some spelling mistakes along the way
* Add Ctrl+c text to `KryptonCommand`

=======

## 2018-01-13 Minor changes in 'SeparatorController.cs'
* Fixed bug [Screen artifact, #79](https://github.com/ComponentFactory/Krypton/issues/79) courtesy of Cocotteseb

=======

## 2018-01-12 Master branch changes
* Removed binaries due to merge issues
* Attempt at including drop shadow around the form
* Begin work on fixing bug [Screen artifact, #79](https://github.com/ComponentFactory/Krypton/issues/79)
* Groundwork for Visual Studio project & item templates

=======

## 2018-01-11a Fix the KryptonMessageBox clipping
* Fix `AssemblyCopyright` information date ranges
* Create a Test project demonstrating MessageBox usage
  * Fix Mangled Caption that may contain carriage returns
  * Fix Box clipping on long and short text combinations
  * Add Extra text showing that Ctrl+C works in a `KryptonMessageBox`

=======
  
## 2018-01-11 Fix the Code Header and __nameof__ in Exceptions
* Code Headers changed:
  * Add correct license term and date range for ComponentFactory
  * Moved Wagnerp and Smurf-IV to later
* Use `nameof` for exception parameter references
* Add /// comments (on some public API's) stating that an exception can be returned if it explicitly __throws new__

=======

## 2018-10-10 Assembly values modifications
* Updated values 
* Refreshed Nuget package data to reflect changes

=======

## 2018-01-09 Incremental versioning
* To reflect the .Net version move to Major.Minor of 4.71
* Build will increment, with the final useless installable number left at zero
* Use "[Automatic Versions](https://marketplace.visualstudio.com/items?itemName=PrecisionInfinity.AutomaticVersions)" to perform the update build number action

=======

## 2018-01-08 Repository changes
* Nuget package upload
* Chocolatey package is in the works

=======

## 2018-01-07 pm Toolkit Solution changes
* Reupload of fresh binaries after a good fight!
* Changed year of all classes, controls etc from 2017 to 2018
* Mass rebuild of solution
* Eradicated all references of 4.5.0.0 to 4.7.1.0

=======

## 2018-01-07 Toolkit Solution
* Message content size adjustment in KryptonTaskDialog; ComponentFactory commit [5463f83](https://github.com/ComponentFactory/Krypton/commit/5463f835bcdbfffbafc9002923e0bea831bed211)
* Remove "Assignment is not used"
* Initialise orientation in mementos correctly
* CherryPick Merges from Cocotteseb 
  * Docking : Get the KryptonWorkspaceCell from a page; commit [ea42f5f](https://github.com/Cocotteseb/Krypton/commit/fe2e778d49216215b8fb51c03c9ac3170f5a67c3)
  * Improvements to Krypton Workspace; commit [fe2e778](https://github.com/Cocotteseb/Krypton/commit/fe2e778d49216215b8fb51c03c9ac3170f5a67c3)
  * Draw text without a glowing background, for use on a composition element; commit [0286bd1](https://github.com/Cocotteseb/Krypton/commit/d3876704ad0ec24f5379a7febc1e3c3a1844e8af)
  * Modifications required for Krypton OutlookGrid; commit [d387670](https://github.com/Cocotteseb/Krypton/commit/7adde64817cfaa3967da1773774949a37d4b4a84)
  * Fixed an exception crash in KryptonTreeView; commit [7adde64](https://github.com/Cocotteseb/Krypton/commit/8d529d7a624c71c3ce22a7205f9116f0d443bb64)
  * Improvements Office2010 Black and first try Render Office 2013; commit [8d529d7](https://github.com/Cocotteseb/Krypton/commit/f85b69403a2e4359c546fb7d959dfd2c737491f1)
  * Windows 10 1511 enhancements + maximized windows bug fix trying; commit [71e5f32](https://github.com/Cocotteseb/Krypton/commit/621ab7c5ca1d7cd47f2c527ae1c18731b622b846)
  * Added KryptonMenuImageSelect click event; commit [621ab7c](https://github.com/Cocotteseb/Krypton/commit/ef4a415b84ac4ce9b145db9d723701a0099ce0f1)
  * Trying to fixed rare crashed in KryptonRibbon Composition; commit [ef4a415](https://github.com/Cocotteseb/Krypton/commit/c55aeadc2224ed68a7446bf3986eb02bf0415751)
  * Add DPI Awareness for Tab images (Mixture of commits)
* Update a few test to use Office 2013 palettes
* Remove Binaries from Git

=======

## 2018-01-06 Toolkit solution and Examples II changes:
* Remove "redundant delegate constructors" for callbacks
* Fix "OnClick" routing for 
  - ListBox
  - CheckedListBox
  - TextBox
  - TreeView
* Update the test project to see if click on TextBox's work as expected 
* Set some private fields to "readonly"
* Fix AddToWorkspace in KryptonDockingManager

=======

## 2017-11-12 Toolkit Examples II solution changes:
* Work out why clipping is the default for "DrawText" 
  - Applies to buttons, lLabels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove 'Severity Code Description Project File Line Suppression State' Warning CS0618 'SecurityAction.RequestMinimum' is obsolete: 'Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.' Basic Events 2015 [Source Path]\Krypton-NET-4.7.1\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs 35 Active

=======

## 2017-10-17 Commits are:
* An update to Component factory's KryptonToolkit to support the .NET 4.7.1 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7.1 Target framework
* Add designer dll to test apps to allow visual design and testing without GAC'ing

=======

## 2017-11-12 Toolkit solution changes:
* Change Get Set functions to be inlined
* Merge Sequential Checks
* Clarify precedence with brackets

=======

## 2017-11-05 Commits:
* Pre-compiled binaries for use in projects

=======

## 2017-11-04 Toolkit solution only:
* Add braces to if statements
* Use explicit types instead of "vars"
* Object initialization can be simplified
* Delegate invocation can be simplified.
* Use pattern matching 
  - Adjust some logic to test bool before cast
  - Use of switch if necessary
* Variable declaration can be inlined
* Null check can be simplified
  - null-propagating code
* Local Variable can be const (And rename to upper case to follow the rest of the codebase.)
* ﻿Join declaration and assignment

=======

## 2017-10-17 Commits are:
* An update to Component factory's KryptonToolkit to support the .NET 4.7.1 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7.1 Target framework
* Add designer Dll to test apps to allow visual design and testing without GAC'ing

=======

## 2017-11-05 Commits:
* Pre-compiled binaries for use in projects

=======

## 2017-11-12 am Toolkit solution changes:
* Change Get Set functions to be inlined
* Merge Sequential Checks
* Clarify precedence with brackets

=======

## 2017-11-12 pm Toolkit solution changes:
* Work out why clipping is the default for "DrawText" 
  - Applies to buttons, lLabels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove Severity Code Description Project File Line Suppression State Warning CS0618 'SecurityAction.RequestMinimum' is obsolete: 'Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.' Basic Events 2015 [Source Path]\Krypton-NET-4.7.1\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs 35 Active

## NOTE: This is a mirror of the Krypton-NET-4.70 repository, therefore it may take a day or two to update this repository with the .NET 4.7.1 framework. Thank you for your patience. 
