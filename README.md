# RSS Reader

[![Build Status](https://travis-ci.org/joemccann/dillinger.svg?branch=master)](https://travis-ci.org/joemccann/dillinger)

![](https://github.com/VeselinovStf/ProxyNews/blob/master/repoImg/demo.jpeg)

Demo application of News site based on RSS feeds

# Features
  - API application - provides endpoint for web application
  - Reads Rss feads
  - Optional input of feed
  - Optional display

You can also:
  - Extend existing futures

### Tech

Used technologies

* .NET Core 2.2
* ASP.NET CORE API ( for Demo project )
* ASP.NET CORE MVC ( for Demo project )

### Installation

ProxyNews requires [.NET CORE 2.2] to run.

Clone or Download project.

### Setting Up

Update appsettings.json in ProxyNews.Web where portAddres is api project port addres

```sh
"API_Connection": {
    "HomePage": "https://localhost:{portAddres}/api/news"
  }
```

Add RSS feeds appsettings.json in ProxyNews.API

```sh
 "RSS": [
    "https://www.vesti.bg/rss.php",
    "https://www.24chasa.bg/Rss"
    ]
```

### Starting Up

Solution -> Properties -> Myltiple startup projects -> set ProxyNews.API and ProxyNews.Web as Start and Apply changes


### Todos

- Update Exceptions handling
- In : Utility.RssReading.RssReader.ModelFactory.Implementation.RssFeed - Fix Create method

License
----

MIT