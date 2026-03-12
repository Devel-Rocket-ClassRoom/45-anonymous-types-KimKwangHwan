using System;

var weather_info = new[]
{
    new {day = "월요일", max = 12, min = 3, percent = 20},
    new {day = "화요일", max = 8, min = -1, percent = 60},
    new {day = "수요일", max = 5, min = -3, percent = 80},
    new {day = "목요일", max = 10, min = 2, percent = 40},
    new {day = "금요일", max = 15, min = 5, percent = 10},
};

Console.WriteLine("=== 5일간 날씨 예보 ===");
Console.WriteLine("요일     최고기온  최저기온  강수확률");
Console.WriteLine("-------------------------------------");
for (int i = 0; i < weather_info.Length; i++)
{
    Console.WriteLine($"{weather_info[i].day,-6}    {weather_info[i].max,4}  {weather_info[i].min,8}  {weather_info[i].percent,7}%");
}
Console.WriteLine("-------------------------------------");
double max_avg = 0;
int rain_day = 0;

for (int i = 0; i < weather_info.Length; i++)
{
    max_avg += weather_info[i].max;
    if (weather_info[i].percent >= 50)
        rain_day++;
}
Console.WriteLine($"최고기온 평균: {max_avg:F1}도");
Console.WriteLine($"비 올 가능성 높은 날(50% 이상): {rain_day}일");