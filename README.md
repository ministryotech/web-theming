# Introduction
This project allows you to apply themes to a website based on configured values and host URLs. This is achieved by providing simple configuration data.

Sample configuration...

    "AvailableThemes": {
        "Themes": [
            {
                "ValidHosts": [
                    "localhost:44330",
                    "mainweb.com"
                ],
                "Key": "Main",
                "Title": "This is My App"
            },
            {
                "ValidHosts": [
                    "localhost:44334",
                    "otherweb.com"
                ],
                "Key": "Other"
            }
        ],
        "DefaultThemeKey": "Main"
    }
    
Designed for Asp.Net Core, the project is available in discrete versions for Asp.Net Core 1.0 and 2.0 by making use of shared projects to share the core code.

## The Ministry of Technology Open Source Products
Welcome to The Ministry of Technology open source products. All open source Ministry of Technology products are distributed under the MIT License for maximum re-usability. Details on more of our products and services can be found on our website at http://www.minotech.co.uk

Our other open source repositories can be found here...

* [https://github.com/ministryotech](https://github.com/ministryotech)
* [https://github.com/tiefling](https://github.com/tiefling)

### Where can I get it?
You can download the package for this project from any of the following package managers...

- **NUGET** - [https://www.nuget.org/packages/Ministry.Web.Themes/](https://www.nuget.org/packages/Ministry.Web.Themes/)

### Contribution guidelines
If you would like to contribute to the project, please contact me.

### Who do I talk to?
* Keith Jackson - keith@minotech.co.uk
