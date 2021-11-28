# Casus_SoialBrothers
SocialBrothers

C# ASP.NET Web API Create, Read, Update and Delete addresses. Calculate distance between Dutch addresses in kilometers.

A free anonymous key is used for the geolocation api.

CRUD Addresses:

-GET /api/Adresses/

It is possible to query the addresses by adding query parameters in the url.
Example:
/api/addresses?city=Den%20Bosch this will list only the addresses with city den bosch
Filter options are:
-city
-country
-zip
-street
-pageSize
-pageNumber
-id

-GET /api/Adresses/{id} Body - > none

-DELETE /api/Adresses/{id} Body - > none

-POST /api/Adresses

Calculate distance between addresses:

GET: api/distance/{id_location1}/{id_location2} Body - > none
