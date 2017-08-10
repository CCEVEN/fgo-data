# fgo-data
Web service for providing datamined info for Fate/Grand Order

# build
1) Install Microsoft Visual Studio (Community 2017 or better)
2) Open webservice/FGODataWebService.sln
3) Run to deploy locally in your web browser (I will need to figure out how to deploy it on an actual web server later)

# data
The webservice reads data from manually constructed source files in the webservice/src/Models/Data folders.
The original data was gathered from a number of different sources:
* FGO Wikia: http://fategrandorder.wikia.com/wiki (provides the majority of info needed)
* Cirnopedia: http://fate-go.cirnopedia.org/ (provides updated English names)
* Kazemai's FGO-VZ: https://kazemai.github.io/fgo-vz/ (provides Servant stats data)
* FGO @wiki: https://www9.atwiki.jp/f_go/pages/713.html (provides JP names)

~Keripo