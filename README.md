# SEMicroserviceProject
| Fullname | StudentNumber|
| -------- | ------------ |
| Alireza Eiji | 98101193 |
| Shayan Talaei | 98109548 |

در این آزمایش قرار است که به بررسی معماری میکروسرویس بپردازیم و دو میکروسرویس بالا آورده و با داکر آنها را کانتینتری کنیم.


در کل دو سرویس موجود است یکی سرویس برای بررسی آب و هوا که اسم یک شهر به آن داده میشود و آب و هوا و دما برگردانده میشود.


یکی هم سرویس برای پیشنهاد مسافرت که باز هم اسم شهر داده میشود و اطلاعات شهر از جمله آب و هوا برگردانده میشود.


همان طور که مشخص است سرویس دوم یعنی پیشنهاد مسافرت به سرویس اول وابسته است و این وابستگی از نوع domain coupling میباشد.


پس از آن که جفت سرویس ها را نوشته و داکرفایل آنها را درست کردیم به سراغ build کردن image آن ها میرویم.


![building_weather_image](./Screenshots/Weather_service.png)


![building_trip_image](./Screenshots/trip_suggest_service.png)



![images_without_orch](./Screenshots/containers_without_orchtration.png)




حال تک تک image ها را اجرا کرده و از آن ها container میسازیم.


![run_weather_image](./Screenshots/weather_forecast_run.png)


![run_trip_image](./Screenshots/trip_suggest_service_run.png)




با توجه به آن که سرویس دوم به سرویس اول وابسته است پس باید از فناوری هایی مثل docker-compose و یا docker-swarm استفاده شود تا 
بتوان همه سرویس ها را با هم بالا آورد.


پس یک فایل داکر کامپوز ساخته و سرویس ها را در آن تعریف کرده و بالا می آوریم.



![docker_compose](./Screenshots/docker_compose_services.png)


حال همه api ها را اجرا میکنیم.


![weather_api1](./Screenshots/WeatherForecast_api_run1.png)


![weather_api2](./Screenshots/weather_service_api_run2.png)


![trip_api1](./Screenshots/trip_suggest_api_run1.png)


![trip_api2](./Screenshots/trip_suggest_run_api2.png)


در آخر نتایج دو دستور گفته شده را نشان میدهیم.


![last_commands](./Screenshots/dockerps_dockerimagels.png)
