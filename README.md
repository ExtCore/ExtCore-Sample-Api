# ExtCore Framework 1.2.0 Sample API Web Application

[![Join the chat at https://gitter.im/ExtCore/ExtCore](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/ExtCore/ExtCore?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)

## Introduction

[ExtCore](https://github.com/ExtCore/ExtCore) is free, open source and cross-platform framework for creating
modular and extendable web applications based on ASP.NET Core. It is built using the best and the most modern
tools and languages (Visual Studio 2017, C# etc). Join our team!

This is the ExtCore framework sample API web application.

## Getting Started

* rebuild the solution;
* copy the extension DLL file into the Extensions folder of the main web application (this folder doesn’t exist by default,
so you need to create it in the web application root or specify another location in the config.json file; also you may just
add direct dependency to the main web application project instead, but it is not so interesting);
* run the main web application and navigate to /api/v1/items.

## More Information

### Other Samples

* [Full-featured ExtCore 1.2.0 framework sample web application](https://github.com/ExtCore/ExtCore-Sample);
* [ExtCore framework 1.2.0 sample simplest web application](https://github.com/ExtCore/ExtCore-Sample-Simplest);
* [ExtCore framework 1.2.0 sample MVC web application](https://github.com/ExtCore/ExtCore-Sample-Mvc);
* [ExtCore framework 1.2.0 sample web application that uses a database](https://github.com/ExtCore/ExtCore-Sample-Data);
* [ExtCore framework 1.2.0 sample web application with modular UI](https://github.com/ExtCore/ExtCore-Sample-Modular-Ui);
* [ExtCore framework 1.2.0 advanced sample web application with modular UI](https://github.com/ExtCore/ExtCore-Sample-Modular-Ui-Adv);
* [ExtCore framework 1.2.0 sample web application that registers a service inside the extension](https://github.com/ExtCore/ExtCore-Sample-Service);
* [ExtCore framework 1.2.0 sample web application that uses the events](https://github.com/ExtCore/ExtCore-Sample-Events).

You can also download our [ready to use full-featured sample](http://extcore.net/files/ExtCore-Sample-1.2.0.zip).
It contains everything you need to run ExtCore-based web application from Visual Studio 2017, including SQLite
database with the test data.

### Tutorials

We have written [several tutorials](http://docs.extcore.net/en/latest/getting_started/index.html)
to help you start developing your ExtCore-based web applications.

### Real Projects

Please take a look at [Platformus](https://github.com/Platformus/Platformus) on GitHub. It is CMS
built on ExtCore framework with 10 extensions and 70 projects.

## Links

Sources on GitHub: https://github.com/ExtCore/ExtCore

Website: http://extcore.net/

Docs: http://docs.extcore.net/

Author: http://sikorsky.pro/