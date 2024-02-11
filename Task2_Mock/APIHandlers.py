import python_weather
from aiohttp import ClientSession
from pyiqvia import Client
from Task2_Code import forecastdict
import urllib3

async def getweather(location, type):
  async with python_weather.Client(unit=python_weather.METRIC) as client:
    if not location:
      url = 'http://ipinfo.io/json'
      response = urllib3.request("GET", url)
      data = response.json()
      location = data["city"]
      weather = await client.get(location)
    else:
      weather = await client.get(location)
    i=0
    if type == "Daily Forecast":
      for forecast in weather.forecasts:
        forecast.date
        forecast.temperature
        forecast.snowfall
        forecastdict.update({i : {"date" : forecast.date, "temp" : forecast.temperature, "snow" : forecast.snowfall}})
        i=i+1
    else:
      for forecast in weather.forecasts:
        for hours in forecast.hourly:
          forecastdict.update({i : {"date" : hours.time, "temp" : hours.temperature, "snow" : hours.chances_of_rain}})
          i+=1
    print (forecastdict)
    return forecastdict

async def getCurrentWeather(location):
  async with python_weather.Client(unit=python_weather.METRIC) as client:
    weather = await client.get(location)
    list = []    
    for forecast in weather.forecasts:
      list.append(forecast)
    return list[0]
  
async def Pollen() -> None:
  url = 'http://ipinfo.io/json'
  response = urllib3.request("GET", url)
  data = response.json()
  location = data["city"]
  client = Client(data["zip"])

  pollendata=(await client.allergens.current())
  print(pollendata)
  pollendata=pollendata["Location"]
  pollendata=pollendata["periods"]
  pollendata=pollendata[1]
  pollendata=pollendata["Index"]
  return float(pollendata)

async def pollution() -> None:
  client = Client("80012")

  pollutiondata=(await client.asthma.current())
  pollutiondata=pollutiondata["Location"]["periods"][1]["Index"]
  return float(pollutiondata)
