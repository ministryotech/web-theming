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

## Versions to Use
Use v1.x for AspNet Core 1
Use v2.x for AspNet Core 2
Use v6.x for AspNet Core in net 6 and above

## Sample Notes
I don't think the included Sample website actually runs anymore - I've made token adjustments for changes in AspNet Core but getting it to run hasn't been a priority.

## The Ministry of Technology Open Source Products
Welcome to The Ministry of Technology open source products. All open source Ministry of Technology products are distributed under the MIT License for maximum re-usability.
Our other open source repositories can be found here...

* [https://github.com/ministryotech](https://github.com/ministryotech)
* [https://github.com/tiefling](https://github.com/tiefling)

### Where can I get it?
You can download the package for this project from any of the following package managers...

- **NUGET** - [https://www.nuget.org/packages/Ministry.Web.Themes/](https://www.nuget.org/packages/Ministry.Web.Themes/)

### Contribution guidelines
If you would like to contribute to the project, please contact me.

### Who do I talk to?
* Keith Jackson - temporal-net@live.co.uk
