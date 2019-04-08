# Dotnet Selenium Template

## Table of Contents
* [Purpose](#)
* [Features](#features)
* [Required Nuget Packages](#required-nuget-packages)
* [Project Layout](#project-layout)
* [How to Use the Template](#how-to-use-the-template)


## Purpose
Many online resources for Selenium have unorganized code and don't adhere to Object-Oriented Programming (OOP). The template is a guide to getting started and how to potentially organize a Selenium Project to make it accessible, not only in readability, but to also see how Selenium can be used to perform a variety of actions. 

## Features
  - Adheres to OOP
  - Page Object Model (POM)
  - Pre-populated code
  - NUnit attributes set for test cases


## Required NuGet Packages
The following NuGet Packages will need to be installed for a successful build. 

* [Selenium.WebDriver](https://www.nuget.org/packages/Selenium.WebDriver/)
* [Selenium.Support](https://www.nuget.org/packages/Selenium.Support/3.141.0/)
* [Selenium.Chrome.WebDriver](https://www.nuget.org/packages/Selenium.Chrome.WebDriver/2.45.0/)
* [NUnit.Console](https://www.nuget.org/packages/NUnit.Console/3.10.0/)
* [NUnit3TestAdapter](https://www.nuget.org/packages/NUnit3TestAdapter/3.13.0/)


## Project Layout
The project is organized according to the POM but with has some changes. Organizing the project in this way reduces repetetitive code and makes the tests readable. 

| Folder         | Description   
| -------------  |-------------
| Actions        | Contains actions to be performed in the web. Tied to the classes in the Pages folder.
| Data           | Contains data relevant to tests. Examples: Element XPaths, names, dates, addresses, etc.     
| Helper Classes | Re-usable classes that help with data access.
| Pages          | Cointains classes that return elements. Works in conjuntion with classes in the Actions folder.
| Tests          | Contains all test classes. These will reference the above to keep the tests simple and concise. 
|Verification    | Classes that are used to verify if tests pass or fail. 

## How to Use the Template

1. Download OR clone the repository 

      ``git clone <url>``
    
2. Open DotnetSeleniumTemplate.sln 


